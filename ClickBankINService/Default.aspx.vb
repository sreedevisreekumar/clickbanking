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
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim dsInput As New DataSet
        dsInput = getResponse("DecryptedJson")
        If dsInput.Tables(0).Rows.Count > 0 Then
            txtResponse.Text = dsInput.Tables(0).Rows(0).Item("eventDesc").ToString()
        End If
        Dim dsXml As New DataSet
        dsXml = getResponse("XML")

        If dsXml.Tables(0).Rows.Count > 0 Then
            txtParsed.Text = dsXml.Tables(0).Rows(0).Item("eventDesc").ToString
        End If


    End Sub
    Protected Function getResponse(ByVal eventname As String) As DataSet
        Dim dsResult As New DataSet
        Dim cmd As New SqlCommand
        Dim conn As SqlConnection
        Dim adp As New SqlDataAdapter

        cmd.CommandText = "SELECT  top 1  eventhistory.* FROM eventhistory where eventName like @eventName ORDER BY eventID DESC"
        Dim connString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ToString()

        If String.IsNullOrEmpty(eventname) Then
            eventname = "%"
        End If
        cmd.Connection = New SqlConnection(connString)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@eventName", eventname)
       
        adp.SelectCommand = cmd
        Try
            cmd.Connection.Open()
            adp.Fill(dsResult)

            cmd.Connection.Close()

        Catch ex As Exception

        End Try
        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        cmd.Dispose()
        Return dsResult
    End Function
End Class
