<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">   
            <h2> Latest InstantNotificationService JSON Response</h2>
 <p>
<asp:TextBox ID="txtResponse" runat="server" TextMode="MultiLine"  Width="700px" Height="200px"></asp:TextBox>
</p> 
<h2> Latest InstantNotification Response parsed into XML</h2>
<p>
<asp:TextBox ID="txtParsed" runat="server" TextMode="MultiLine" Width="700px" Height="200px"></asp:TextBox>
</p>
    </div>
    </form>
</body>
</html>
