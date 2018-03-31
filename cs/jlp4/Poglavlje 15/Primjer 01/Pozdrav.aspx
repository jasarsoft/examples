<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pozdrav.aspx.cs" Inherits="Primjer_01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Pozdrav iz ASP.NET strane<br />
        <br />
        <br />
        Unesite svoje ime:<br />
        <asp:TextBox ID="txtIme" runat="server" Width="244px"></asp:TextBox>
        <asp:Button ID="btnPrikaz" runat="server" Text="Prikazi ime" OnClick="btnPrikaz_Click" />
    
        <br />
        <br />
        <asp:Label ForeColor="Red" ID="lblPozdrav" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
