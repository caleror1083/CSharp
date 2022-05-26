<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="_004_Collections_Queue.WebForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Sunshine DMV</title>
    </head>
    <body>
        <form id="MainForm" runat="server">
            <table style="font-family:Arial; border:1px solid black; text-align:center">
                <tr>
                    <td><b>Counter 1</b></td>
                    <td></td>
                    <td><b>Counter 2</b></td>
                    <td></td>
                    <td><b>Counter 3</b></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="Counter1Textbox" runat="server" BackColor="Blue" Font-Size="Large" Width="150px"></asp:TextBox></td>
                    <td></td>
                    <td><asp:TextBox ID="Counter2Textbox" runat="server" BackColor="Blue" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox></td>
                    <td></td>
                    <td><asp:TextBox ID="Counter3Textbox" runat="server" BackColor="Blue" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Counter1Button" runat="server" Text="Next" Width="150px" /></td>
                    <td></td>
                    <td><asp:Button ID="Counter2Button" runat="server" Text="Next" Width="150px" /></td>
                    <td></td>
                    <td><asp:Button ID="Counter3Button" runat="server" Text="Next" Width="150px" /></td>
                </tr>
                <tr>
                    <td colspan="5"><asp:TextBox ID="DisplayTextbox" runat="server" BackColor="#009900" Font-Size="Large" ForeColor="White" Width="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:ListBox ID="TokensList" runat="server" Font-Size="Large"></asp:ListBox></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Button ID="PrintTokenButton" runat="server" Text="Print Token" /></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="StatusLabel" runat="server" Font-Size="Large"></asp:Label></td>
                </tr>
            </table>
        </form>
    </body>
</html>