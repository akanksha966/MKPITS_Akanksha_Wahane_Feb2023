<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="designPage.aspx.cs" Inherits="TrustProject.designPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style6 {
            width: 573px;
        }
        .auto-style4 {
            margin-left: 17px;
            margin-top: 0px;
        }
        .auto-style8 {
            width: 573px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 500px;
        }
        .auto-style11 {
            height: 26px;
            width: 500px;
        }
        .auto-style12 {
            margin-top: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">Store Management System Inventory Development</span>&nbsp;</p>
        <p>
            &nbsp;</p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style6">
                    <asp:Panel ID="Panel3" runat="server" Height="406px" Width="514px">
                        <strong>Product Details</strong><br />
                        <br />
                        Category&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                        <br />
                        <br />
                        Item Name&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                        <br />
                        <br />
                        Balance Quantity&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Total Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </asp:Panel>
                </td>
                <td class="auto-style10">
                    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style4" Height="382px" Width="471px">
                        <strong>Department Details</strong><br />
                        <br />
                        Department Name&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel4" runat="server" Height="381px" Width="564px">
                        <strong>Transaction Details</strong><br />
                        <br />
                        Product Name&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        Payment Mode&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Payment Mode" Text="Offline" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Payment Mode" Text="Online" />
                        <br />
                        <br />
                        Payment Date&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox8" runat="server" TextMode="Date"></asp:TextBox>
                        <br />
                        <br />
                        Total Amount Including Gst&nbsp;
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="44px" Text="Add" Width="84px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style12" Height="48px" Text="Modify" Width="84px" />
                </td>
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Height="42px" Text="Delete" Width="79px" />
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" Height="47px" Text="Search" Width="86px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
