<%@ Page EnableEventValidation="false" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Shopsite2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Shop Site</h1>
            <p class="lead">My Shop Site For Good Buing Experience.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div>

<asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal"
RepeatColumns="4" Width="100%" OnItemCommand="DataList1_ItemCommand"
OnSelectedIndexChanged="DataList1_SelectedIndexChanged" >
<HeaderTemplate>
<table>
<tr>
<td>
<h1>Product for you</h1>
</td>
</tr>
</table>
</HeaderTemplate>

<ItemStyle CssClass="itemstyle" />
<ItemTemplate>
<table align="center">
<tr>
<td>
<table border="0" >
    <center>
<tr>

<td >
   
<asp:ImageButton OnClick="Button1_Click" ID="prodimg" runat="server" ImageUrl='
<%# "~/images/" + Eval("prodimage") %>' Height="180px" Width="200px" />

</td>

 
</tr>
   
<tr>

<td align="center">
<asp:Label ID="lblprodname" runat="server" Text='<%# Eval("prodname") %>'>
</asp:Label>
</td>
</tr>
    
 

<tr>

<td align="center">
<asp:Label ID="lblprodid" runat="server" Text='<%# Eval("prodid") %>' visible="false">

</asp:Label>
<asp:Label ID="lblprodprice" runat="server" Text='<%# Eval("prodprice") %>'>
</asp:Label>
</td>

</tr>

</table>
</td>
    </td>
</tr>
</table>
</ItemTemplate>

</asp:DataList>
</div>

<hr />

        
    </main>

</asp:Content>
