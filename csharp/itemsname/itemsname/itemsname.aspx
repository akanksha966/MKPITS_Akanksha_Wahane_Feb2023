<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="itemsname.aspx.cs" Inherits="itemsname.itemsname" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style6 {
            width: 316px;
        }
        .auto-style7 {
            text-align: left;
            width: 53px;
        }
        .auto-style8 {
            text-align: left;
            height: 26px;
            width: 53px;
        }
        .auto-style9 {
            width: 316px;
            height: 26px;
        }
        .auto-style10 {
            width: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp; Product Category<table class="auto-style2">
                <tr>
                    <td class="auto-style7">ItemName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Price</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Quantity</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Order" Width="104px" />
                        &nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Total&nbsp; Amount:&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
