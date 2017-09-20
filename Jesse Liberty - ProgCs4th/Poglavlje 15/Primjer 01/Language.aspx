<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Language.aspx.cs" Inherits="Primjer_01.Language" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 600px;
            background-color: #99CCFF;
        }
        .auto-style2 {
            text-align: right;
            width: 181px;
        }
        .auto-style3 {
            width: 267px;
        }
        .auto-style4 {
            width: 181px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3"><strong>PRIJAVLJIVANJE</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" style="text-align: right">Ime:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Obavezan unos imena" ControlToValidate="txtIme" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email nije u odgovarajucem obliku" ControlToValidate="txtEmail" Display="Dynamic" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Lozinka</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLozinka" Display="Dynamic" ErrorMessage="Obavezan unos lozinke">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Potvrda lozinke</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtLozinkaPotvrda" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtLozinkaPotvrda" ErrorMessage="Lozinka i potvrda nisu iste">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnPrijava" runat="server" Text="Prijava" OnClick="btnPrijava_Click" />
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblPoruka" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
