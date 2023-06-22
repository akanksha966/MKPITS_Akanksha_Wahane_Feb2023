<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkmobile.aspx.cs" Inherits="meshosites.checkmobile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <table style="width: 100%; border-collapse: collapse; border-style: solid; border-width: 1px">
            <tr>
                <td style="font-size: x-large"><strong>&nbsp;OTP Details&nbsp;</strong></td>
            </tr>
            <tr>
                <td>Enter Otp&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="OK" Width="101px" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
