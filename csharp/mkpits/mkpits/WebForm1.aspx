<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="mkpits.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
        .auto-style3 {
            width: 197px;
        }
        .auto-style4 {
            width: 181px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <p style="text-align: center">
        MKPITS SERVISES NAGPUR</p><hr />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Enter Number1</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Enter Number2</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Addition" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Substraction" />
&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiplication" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Division" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
    
   
</html>
