<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseShipper.aspx.cs" Inherits="Primjer_01.ChooseShipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choose Shipper</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 166px; height: 33px">
            <tr>
                <td colspan="2" style="height: 20px">Welcome to Northwind</td>
            </tr>
            <tr>
                <td>Your name:</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Shipper</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                        DataSourceID="SqlDataSource1" 
                        DataTextField="CompanyName" 
                        DataValueField="ShipperID">
                    </asp:RadioButtonList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:NorthWindSqlConnectionString %>" 
                        SelectCommand="SELECT [ShipperID], [CompanyName] FROM [Shippers]">
                    </asp:SqlDataSource>
                    <br />
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" /></td>
                <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
            </tr>
            <td colspan="2"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
        </table>
    </div>
    </form>
</body>
</html>
