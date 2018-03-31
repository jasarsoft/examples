<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayShippers.aspx.cs" Inherits="Primjer_01.DisplayShippers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CompanyName" DataValueField="ShipperID">
        </asp:RadioButtonList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthWindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthWindConnectionString.ProviderName %>" SelectCommand="SELECT [ShipperID], [CompanyName] FROM [Shippers]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
