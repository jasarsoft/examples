<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWeb1.aspx.cs" Inherits="Primjer_01.HelloWeb1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Speedy Express</asp:ListItem>
            <asp:ListItem>United Package</asp:ListItem>
            <asp:ListItem>Federal Shipping</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
    </form>
</body>
</html>
