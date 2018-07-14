<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProbarWS.aspx.cs" Inherits="ProbarWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 201px;
        }
    </style>
</head>
<body style="align-content:center">
    
    <form id="form1" runat="server">        
            <label aria-valuetext="Primer Número" />
            Primer Número
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox><br />  
            <label aria-valuetext="Segundo Número" />
        Segundo Número
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox><br />    
            <asp:Button ID="btnSuma" runat="server" Text="Suma" Width="104px" OnClick="btnSuma_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
