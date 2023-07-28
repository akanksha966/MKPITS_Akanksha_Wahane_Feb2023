<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Shopsite2.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        SignUp Form</p>
    <table style="width: 100%; border-collapse: collapse; border: 1px solid #800000">
        <tr>
            <td style="width: 204px">Usename</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 204px">Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 204px">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="Button1" runat="server" Height="40px" Text="SignUp" Width="112px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 204px">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
