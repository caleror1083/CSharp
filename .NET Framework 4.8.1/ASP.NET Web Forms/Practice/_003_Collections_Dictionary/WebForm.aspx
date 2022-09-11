<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="_003_Collections_Dictionary.WebForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Dictionary</title>
    </head>
    <body>
        <form id="FrmIndex" runat="server">
            <div style="font-family:Arial">
                <table style="border:1px solid black">
                    <tr>
                        <td>Country Code:</td>
                        <td><asp:TextBox id="TxtCountryCode" runat="server" AutoPostBack="True" OnTextChanged="TxtCountryCode_TextChanged"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Name:</td>
                        <td><asp:TextBox id="TxtName" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Capital:</td>
                        <td><asp:TextBox id="TxtCapital" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label id="LblMessage" runat="server" ForeColor="Red"></asp:Label></td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>