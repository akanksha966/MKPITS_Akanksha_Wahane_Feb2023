<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="project2.aspx.cs" Inherits="project2.project2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 194px;
        }
        .auto-style4 {
            width: 251px;
        }
        .auto-style5 {
            margin-left: 33px;
        }
        .auto-style6 {
            width: 194px;
            height: 24px;
        }
        .auto-style7 {
            width: 251px;
            height: 24px;
        }
        .auto-style8 {
            height: 24px;
        }
        .auto-style9 {
            width: 194px;
            height: 53px;
        }
        .auto-style10 {
            width: 251px;
            height: 53px;
        }
        .auto-style11 {
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Find Result</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Subject 1</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Subject 2</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Width="216px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Subject 3</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" Width="221px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="36px" OnClick="Button1_Click" Text="Button" Width="119px" />
                </td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Total </td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Percentage</td>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Grade</td>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
