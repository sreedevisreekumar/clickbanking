Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Globalization
Imports System.Text
Imports System.Security.Cryptography
''' <summary>
''' Summary description for ClickHandler
''' </summary>
Public NotInheritable Class ClickHandler
    Private Sub New()
    End Sub
    Public Class Encrypted

        Public Property notification() As String
            Get
                Return m_notification
            End Get
            Set(ByVal value As String)
                m_notification = Value
            End Set
        End Property
        Private m_notification As String
        Public Property iv() As String
            Get
                Return m_iv
            End Get
            Set(ByVal value As String)
                m_iv = Value
            End Set
        End Property
        Private m_iv As String
    End Class
    Public Class Decrypted
        Public Property transactionTime() As String
            Get
                Return m_transactionTime
            End Get
            Set(ByVal value As String)
                m_transactionTime = Value
            End Set
        End Property
        Private m_transactionTime As String
        Public Property receipt() As String
            Get
                Return m_receipt
            End Get
            Set(ByVal value As String)
                m_receipt = Value
            End Set
        End Property
        Private m_receipt As String
        Public Property transactionType() As String
            Get
                Return m_transactionType
            End Get
            Set(ByVal value As String)
                m_transactionType = Value
            End Set
        End Property
        Private m_transactionType As String
        Public Property vendor() As String
            Get
                Return m_vendor
            End Get
            Set(ByVal value As String)
                m_vendor = Value
            End Set
        End Property
        Private m_vendor As String
        Public Property affiliate() As String
            Get
                Return m_affiliate
            End Get
            Set(ByVal value As String)
                m_affiliate = Value
            End Set
        End Property
        Private m_affiliate As String
        Public Property role() As String
            Get
                Return m_role
            End Get
            Set(ByVal value As String)
                m_role = Value
            End Set
        End Property
        Private m_role As String
        Public Property totalAccountAmount() As Double
            Get
                Return m_totalAccountAmount
            End Get
            Set(ByVal value As Double)
                m_totalAccountAmount = value
            End Set
        End Property
        Private m_totalAccountAmount As Double
        Public Property paymentMethod() As String
            Get
                Return m_paymentMethod
            End Get
            Set(ByVal value As String)
                m_paymentMethod = Value
            End Set
        End Property
        Private m_paymentMethod As String
        Public Property totalOrderAmount() As Double
            Get
                Return m_totalOrderAmount
            End Get
            Set(ByVal value As Double)
                m_totalOrderAmount = value
            End Set
        End Property
        Private m_totalOrderAmount As Double
        Public Property totalTaxAmount() As Double
            Get
                Return m_totalTaxAmount
            End Get
            Set(ByVal value As Double)
                m_totalTaxAmount = value
            End Set
        End Property
        Private m_totalTaxAmount As Double
        Public Property totalShippingAmount() As Double
            Get
                Return m_totalShippingAmount
            End Get
            Set(ByVal value As Double)
                m_totalShippingAmount = value
            End Set
        End Property
        Private m_totalShippingAmount As Double
        Public Property currency() As String
            Get
                Return m_currency
            End Get
            Set(ByVal value As String)
                m_currency = Value
            End Set
        End Property
        Private m_currency As String
        Public Property orderLanguage() As String
            Get
                Return m_orderLanguage
            End Get
            Set(ByVal value As String)
                m_orderLanguage = Value
            End Set
        End Property
        Private m_orderLanguage As String
        Public Property trackingCodes() As List(Of String)
            Get
                Return m_trackingCodes
            End Get
            Set(ByVal value As List(Of String))
                m_trackingCodes = Value
            End Set
        End Property
        Private m_trackingCodes As List(Of String)
        Public Property lineItems() As List(Of LineItem)
            Get
                Return m_lineItems
            End Get
            Set(ByVal value As List(Of LineItem))
                m_lineItems = Value
            End Set
        End Property
        Private m_lineItems As List(Of LineItem)
        Public Property customer() As Customer
            Get
                Return m_customer
            End Get
            Set(ByVal value As Customer)
                m_customer = Value
            End Set
        End Property
        Private m_customer As Customer
        Public Property upsell() As Upsell
            Get
                Return m_upsell
            End Get
            Set(ByVal value As Upsell)
                m_upsell = Value
            End Set
        End Property
        Private m_upsell As Upsell
        Public Property hopfeed() As Hopfeed
            Get
                Return m_hopfeed
            End Get
            Set(ByVal value As Hopfeed)
                m_hopfeed = Value
            End Set
        End Property
        Private m_hopfeed As Hopfeed
        Public Property attemptCount() As Integer
            Get
                Return m_attemptCount
            End Get
            Set(ByVal value As Integer)
                m_attemptCount = Value
            End Set
        End Property
        Private m_attemptCount As Integer


    End Class
    Public Class LineItem
        Public Property itemNo() As String
            Get
                Return m_itemNo
            End Get
            Set(ByVal value As String)
                m_itemNo = Value
            End Set
        End Property
        Private m_itemNo As String
        Public Property productTitle() As String
            Get
                Return m_productTitle
            End Get
            Set(ByVal value As String)
                m_productTitle = Value
            End Set
        End Property
        Private m_productTitle As String
        Public Property shippable() As Boolean
            Get
                Return m_shippable
            End Get
            Set(ByVal value As Boolean)
                m_shippable = Value
            End Set
        End Property
        Private m_shippable As Boolean
        Public Property recurring() As Boolean
            Get
                Return m_recurring
            End Get
            Set(ByVal value As Boolean)
                m_recurring = Value
            End Set
        End Property
        Private m_recurring As Boolean
        Public Property accountAmount() As Double
            Get
                Return m_accountAmount
            End Get
            Set(ByVal value As Double)
                m_accountAmount = value
            End Set
        End Property
        Private m_accountAmount As Double
        Public Property downloadUrl() As String
            Get
                Return m_downloadUrl
            End Get
            Set(ByVal value As String)
                m_downloadUrl = Value
            End Set
        End Property
        Private m_downloadUrl As String
    End Class

    Public Class Address
        Public Property address1() As String
            Get
                Return m_address1
            End Get
            Set(ByVal value As String)
                m_address1 = Value
            End Set
        End Property
        Private m_address1 As String
        Public Property address2() As String
            Get
                Return m_address2
            End Get
            Set(ByVal value As String)
                m_address2 = Value
            End Set
        End Property
        Private m_address2 As String
        Public Property city() As String
            Get
                Return m_city
            End Get
            Set(ByVal value As String)
                m_city = Value
            End Set
        End Property
        Private m_city As String
        Public Property county() As String
            Get
                Return m_county
            End Get
            Set(ByVal value As String)
                m_county = Value
            End Set
        End Property
        Private m_county As String
        Public Property state() As String
            Get
                Return m_state
            End Get
            Set(ByVal value As String)
                m_state = Value
            End Set
        End Property
        Private m_state As String
        Public Property postalCode() As String
            Get
                Return m_postalCode
            End Get
            Set(ByVal value As String)
                m_postalCode = Value
            End Set
        End Property
        Private m_postalCode As String
        Public Property country() As String
            Get
                Return m_country
            End Get
            Set(ByVal value As String)
                m_country = Value
            End Set
        End Property
        Private m_country As String
    End Class

    Public Class Shipping
        Public Property firstName() As String
            Get
                Return m_firstName
            End Get
            Set(ByVal value As String)
                m_firstName = Value
            End Set
        End Property
        Private m_firstName As String
        Public Property lastName() As String
            Get
                Return m_lastName
            End Get
            Set(ByVal value As String)
                m_lastName = Value
            End Set
        End Property
        Private m_lastName As String
        Public Property fullName() As String
            Get
                Return m_fullName
            End Get
            Set(ByVal value As String)
                m_fullName = Value
            End Set
        End Property
        Private m_fullName As String
        Public Property phoneNumber() As String
            Get
                Return m_phoneNumber
            End Get
            Set(ByVal value As String)
                m_phoneNumber = Value
            End Set
        End Property
        Private m_phoneNumber As String
        Public Property email() As String
            Get
                Return m_email
            End Get
            Set(ByVal value As String)
                m_email = Value
            End Set
        End Property
        Private m_email As String
        Public Property address() As Address
            Get
                Return m_address
            End Get
            Set(ByVal value As Address)
                m_address = Value
            End Set
        End Property
        Private m_address As Address
    End Class

    Public Class Address2
        Public Property state() As String
            Get
                Return m_state
            End Get
            Set(ByVal value As String)
                m_state = Value
            End Set
        End Property
        Private m_state As String
        Public Property postalCode() As String
            Get
                Return m_postalCode
            End Get
            Set(ByVal value As String)
                m_postalCode = Value
            End Set
        End Property
        Private m_postalCode As String
        Public Property country() As String
            Get
                Return m_country
            End Get
            Set(ByVal value As String)
                m_country = Value
            End Set
        End Property
        Private m_country As String
    End Class

    Public Class Billing
        Public Property firstName() As String
            Get
                Return m_firstName
            End Get
            Set(ByVal value As String)
                m_firstName = Value
            End Set
        End Property
        Private m_firstName As String
        Public Property lastName() As String
            Get
                Return m_lastName
            End Get
            Set(ByVal value As String)
                m_lastName = Value
            End Set
        End Property
        Private m_lastName As String
        Public Property fullName() As String
            Get
                Return m_fullName
            End Get
            Set(ByVal value As String)
                m_fullName = Value
            End Set
        End Property
        Private m_fullName As String
        Public Property phoneNumber() As String
            Get
                Return m_phoneNumber
            End Get
            Set(ByVal value As String)
                m_phoneNumber = Value
            End Set
        End Property
        Private m_phoneNumber As String
        Public Property email() As String
            Get
                Return m_email
            End Get
            Set(ByVal value As String)
                m_email = Value
            End Set
        End Property
        Private m_email As String
        Public Property address() As Address2
            Get
                Return m_address
            End Get
            Set(ByVal value As Address2)
                m_address = Value
            End Set
        End Property
        Private m_address As Address2
    End Class

    Public Class Customer
        Public Property shipping() As Shipping
            Get
                Return m_shipping
            End Get
            Set(ByVal value As Shipping)
                m_shipping = Value
            End Set
        End Property
        Private m_shipping As Shipping
        Public Property billing() As Billing
            Get
                Return m_billing
            End Get
            Set(ByVal value As Billing)
                m_billing = Value
            End Set
        End Property
        Private m_billing As Billing
    End Class

    Public Class Upsell
        Public Property upsellOriginalReceipt() As String
            Get
                Return m_upsellOriginalReceipt
            End Get
            Set(ByVal value As String)
                m_upsellOriginalReceipt = Value
            End Set
        End Property
        Private m_upsellOriginalReceipt As String
        Public Property upsellFlowId() As Integer
            Get
                Return m_upsellFlowId
            End Get
            Set(ByVal value As Integer)
                m_upsellFlowId = Value
            End Set
        End Property
        Private m_upsellFlowId As Integer
        Public Property upsellSession() As String
            Get
                Return m_upsellSession
            End Get
            Set(ByVal value As String)
                m_upsellSession = Value
            End Set
        End Property
        Private m_upsellSession As String
        Public Property upsellPath() As String
            Get
                Return m_upsellPath
            End Get
            Set(ByVal value As String)
                m_upsellPath = Value
            End Set
        End Property
        Private m_upsellPath As String
    End Class

    Public Class Hopfeed
        Public Property hopfeedClickId() As String
            Get
                Return m_hopfeedClickId
            End Get
            Set(ByVal value As String)
                m_hopfeedClickId = Value
            End Set
        End Property
        Private m_hopfeedClickId As String
        Public Property hopfeedApplicationId() As String
            Get
                Return m_hopfeedApplicationId
            End Get
            Set(ByVal value As String)
                m_hopfeedApplicationId = Value
            End Set
        End Property
        Private m_hopfeedApplicationId As String
        Public Property hopfeedCreativeId() As String
            Get
                Return m_hopfeedCreativeId
            End Get
            Set(ByVal value As String)
                m_hopfeedCreativeId = Value
            End Set
        End Property
        Private m_hopfeedCreativeId As String
        Public Property hopfeedApplicationPayout() As Integer
            Get
                Return m_hopfeedApplicationPayout
            End Get
            Set(ByVal value As Integer)
                m_hopfeedApplicationPayout = Value
            End Set
        End Property
        Private m_hopfeedApplicationPayout As Integer
        Public Property hopfeedVendorPayout() As Integer
            Get
                Return m_hopfeedVendorPayout
            End Get
            Set(ByVal value As Integer)
                m_hopfeedVendorPayout = Value
            End Set
        End Property
        Private m_hopfeedVendorPayout As Integer
    End Class

    Public Shared Function GetEncrypted(ByVal response As String) As Encrypted
        Dim objEncrypted As New Encrypted()
        Dim serializer As New DataContractJsonSerializer(GetType(Encrypted))
        Using ms = New MemoryStream(Encoding.Unicode.GetBytes(response))
            Dim responseData = DirectCast(serializer.ReadObject(ms), Encrypted)
            Dim responseinfo As String = CreateXML(responseData)
            objEncrypted = responseData
        End Using
        Return objEncrypted
    End Function
    Public Shared Function GetResponse(ByVal content As String) As Decrypted
        Dim resData = New Decrypted()
        Dim serializer As New DataContractJsonSerializer(GetType(Decrypted))
        Using ms = New MemoryStream(Encoding.Unicode.GetBytes(content))
            Dim responseData = DirectCast(serializer.ReadObject(ms), Decrypted)
            Dim responseinfo As String = CreateXML(responseData)
            resData = responseData
        End Using
        Return resData
    End Function
    Public Shared Function Encrypt(ByVal clearText As String, ByVal EncryptionKey As String) As String
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Shared Function Decrypt(ByVal cipherText As String, ByVal EncryptionKey As String) As String
        Dim aes__1 As New AesManaged()
        aes__1.Padding = PaddingMode.Zeros
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Public Shared Function CreateXML(ByVal jsonData As [Object]) As String
        Dim xmlDoc As New XmlDocument()
        'Represents an XML document, 
        ' Initializes a new instance of the XmlDocument class.          
        Dim xmlSerializer As New XmlSerializer(jsonData.[GetType]())
        ' Creates a stream whose backing store is memory. 
        Using xmlStream As New MemoryStream()
            xmlSerializer.Serialize(xmlStream, jsonData)
            xmlStream.Position = 0
            'Loads the XML document from the specified string.
            xmlDoc.Load(xmlStream)
            Return xmlDoc.InnerXml
        End Using
    End Function
End Class