Imports System.Collections
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Web.Helpers
Imports System.Data.SqlClient
Imports System.Runtime.Serialization.Json
Imports System.Net
Imports System.Xml
Imports System.Xml.Serialization
Partial Class ReceiveINS
    Inherits System.Web.UI.Page

    
    Public Shared Function ComputeHash(ByVal input As String, ByVal algorithm As HashAlgorithm) As String

        Dim inputBytes As [Byte]() = Encoding.UTF8.GetBytes(input)
        Dim hashedBytes As [Byte]() = algorithm.ComputeHash(inputBytes)

        Dim sb As New StringBuilder()

        For i As Integer = 0 To hashedBytes.Length - 1
            sb.Append([String].Format("{0:x2}", hashedBytes(i)))
        Next

        Return sb.ToString()
    End Function
    Public Shared Function base64Decode(ByVal encodedString As String) As String
        Dim data As Byte() = Convert.FromBase64String(encodedString)
        Dim decodedString As String = Encoding.UTF8.GetString(data)
        Return decodedString
    End Function
    ' Decrypt a string into a string using a key and an IV 

    ' Decrypt a string into a string using a key and an IV 
    Public Shared Function Decrypt(ByVal cipherData As String, ByVal keyString As String, ByVal ivString As String) As String
        Dim key As Byte() = Encoding.UTF8.GetBytes(keyString)
        Dim iv As Byte() = Encoding.UTF8.GetBytes(ivString)

        Try
            Using rijndaelManaged = New RijndaelManaged()
                rijndaelManaged.Key = key
                rijndaelManaged.IV = iv
                rijndaelManaged.Mode = CipherMode.CBC

                    Using memoryStream = New MemoryStream(Convert.FromBase64String(cipherData))
                        Using cryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(key, iv), CryptoStreamMode.Read)
                            Return New StreamReader(cryptoStream).ReadToEnd()
                        End Using
                    End Using
            End Using
        Catch e As CryptographicException
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message)
            Return Nothing
        End Try
        ' You may want to catch more exceptions here...
    End Function
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim ipnIsValid As [Boolean] = False

        Dim ipnInput As String = ""

        Try
            'Getting the response posted from clickbank

            Using reader = New StreamReader(Request.InputStream)
                ipnInput = reader.ReadToEnd()
            End Using
        Catch ex As Exception
            Exit Sub
        End Try


        If String.IsNullOrEmpty(ipnInput) Then

            Exit Sub
        Else
            inserteventlog(ipnInput, "ReceivedInput")


            'Parsing the input string to a json object

            Dim inputjson As ClickHandler.Encrypted = Json.Decode(Of ClickHandler.Encrypted)(ipnInput)
            Dim initializationVector As String = inputjson.iv
            Dim encryptedNotification As String = inputjson.notification

            'Decryting the input notification using AES algorithm

            'Hash the secret key,Convert to byte array,take substring(0,32) from hex encoded string

            Dim secretKey As String = ConfigurationManager.AppSettings("SecretKey").ToString()




            Dim algorithm As HashAlgorithm = HashAlgorithm.Create("SHA1")
            Dim hashedKey As String = ComputeHash(secretKey, algorithm)
            Dim keystr As String = hashedKey.Substring(0, 32)

            'Decode Initialization vector

            Dim ivstr As String = base64Decode(initializationVector)

            'Decrypting the input using AES

            Dim decrypted As String = Decrypt(encryptedNotification, keystr, ivstr)
            inserteventlog(decrypted, "DecryptedJson")

            ' txtResponse.Text = decrypted

            'Parsing the decrypted json response into object

            Dim serializer As New DataContractJsonSerializer(GetType(ClickHandler.Decrypted))
            Dim objdecrypted As ClickHandler.Decrypted
            Using ms = New MemoryStream(Encoding.Unicode.GetBytes(decrypted))
                objdecrypted = DirectCast(serializer.ReadObject(ms), ClickHandler.Decrypted)
            End Using

            'Converting to XML
            Dim xmlNotification As String = ClickHandler.CreateXML(objdecrypted)
            inserteventlog(xmlNotification, "XML")

            ' WriteFile(xmlNotification)

        End If







    End Sub
    Public Shared Sub WriteFile(ByVal text As String)
        Dim provider As New CultureInfo("en-us")
        Dim writer As New StreamWriter(HttpContext.Current.Server.MapPath("Log.txt"), True, System.Text.Encoding.ASCII)
        writer.Write(DateTime.Now.ToString(provider))
        writer.Write(": ")
        writer.Write(text)
        writer.Write(Environment.NewLine)
        writer.Close()
    End Sub
    Public Function inserteventlog(ByVal message As String, ByVal eventName As String) As Integer
        Dim conn As SqlConnection
        Dim retval As Integer
        Dim now As DateTime = DateTime.Now
        Dim connString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ToString()
        Try
            conn = New SqlConnection(connString)
            conn.Open()

            Dim sqlString As String = "INSERT INTO eventhistory(eventDesc,eventDate,eventName) VALUES (" & "'" & message & "'," & "'" & now & "'," & "'" & eventName & "')"
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = sqlString
            cmd.ExecuteNonQuery()
            conn.Close()
            retval = 1
        Catch ex As Exception
            retval = -1
        End Try
        Return retval
    End Function

    
End Class
