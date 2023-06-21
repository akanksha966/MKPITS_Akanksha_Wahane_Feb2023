<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="meshosites._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Meesho</h1>
            <p class="lead">Lowest PricesBest Quality Shopping</p>
            <p></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Free Delivery</h2>
                <p>
                  Register As a Meesho Supplier
                    <br /><br />
                    Sell online to 14 Cr+ customers at
0% Commission
Become a Meesho seller and grow your business across India
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"></a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Cash On Delivery</h2>
                <p>
                    Register As a Meesho Supplier
                     <br /><br />
                    Sell online to 14 Cr+ customers at
0% Commission
Become a Meesho seller and grow your business across India
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949"></a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle"></h2>
                <p>
                   <img src="img1.jpg" style="width:350px;height:250px;" />
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950"></a>
                </p>
            </section>
        </div>
        
            <div class="row">

          <p align="center">   -----------------Top Category To Choose From--------------</p>
                </div>
        <!-- data list plase -->

           <div class="row">

               <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%">
                           <ItemTemplate>
                       <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;
                    border: dashed 2px #013220; background-color: #FFFFFF">
                      <tr>
                 <td align="center">
                 <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/images/{0}") %>' runat="server"

              Height="100"

          Width ="100" />

            </td>
                 </tr>

               <tr>
               <td align="center">
              <span > <%# Eval("prodname") %></span><br />
             <span > <%# Eval("proddescription") %></span><br />
              <span >Rs. <%# Eval("prodprice") %> onwards</span><br />

</td>
</tr>
</table>
</ItemTemplate>
</asp:DataList>





               </div>
       

    </main>

</asp:Content>
