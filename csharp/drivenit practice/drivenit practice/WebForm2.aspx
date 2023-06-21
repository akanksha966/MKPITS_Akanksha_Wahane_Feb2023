<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="drivenit_practice.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Transaction Form</p>
    <p>
        ItemId&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitConnectionString %>" ProviderName="<%$ ConnectionStrings:drivenitConnectionString.ProviderName %>" SelectCommand="SELECT [ItemId], [ItemDescr] FROM [Itemmaster]"></asp:SqlDataSource>
    </p>
    <p>
        ransaction Type&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ts" Text="Issue" />
&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ts" Text="Received" />
    </p>
    <p>
        Transaction Quantity&nbsp; <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Transaction Date&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Edit" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
