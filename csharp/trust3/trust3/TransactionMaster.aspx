<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TransactionMaster.aspx.cs" Inherits="trust3.TransactionMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;&nbsp;Transaction Detail</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    Mode&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" GroupName="mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
</p>
<asp:Label ID="Label1" runat="server" Text="Item Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Item_Name" DataValueField="Item_Id">
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:civicaConnectionString %>" ProviderName="<%$ ConnectionStrings:civicaConnectionString.ProviderName %>" SelectCommand="SELECT [Item_Id], [Item_Name] FROM [Item_Masters]"></asp:SqlDataSource>
<asp:Panel ID="Panel1" runat="server" Width="862px">
    <asp:Label ID="Label2" runat="server" Text="Department Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Depatment_Name" DataValueField="Department_Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:civicaConnectionString %>" SelectCommand="SELECT [Department_Id], [Depatment_Name] FROM [Department_Master]"></asp:SqlDataSource>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Vendor Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Vendor_Name" DataValueField="Vendor_Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:civicaConnectionString %>" SelectCommand="SELECT [Vendor_Id], [Vendor_Name] FROM [Vendor_Master]"></asp:SqlDataSource>
</asp:Panel>
<p>
    Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
</p>
<p>
    Quantity&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Saved" />
&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
