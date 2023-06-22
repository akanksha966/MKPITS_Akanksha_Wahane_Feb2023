<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="productdetails.aspx.cs" Inherits="meshosites.productdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
       table, th, td {
padding: 15px;
/*border: 1px solid lightgray;
*//*border-collapse: collapse;*/
        }
    </style>
    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="1" Width="100%">

        <ItemTemplate>
           <table cellpadding="2" cellspacing="0" border="1" style="width: 100%; height: 400px;
                    border: 2px solid grey #013220; background-color: #FFFFFF">
                      <tr>
                          <td>
                          <table Width="100%">
                              <tr>
                 <td align="center" >
                  <a href='<%# Eval("prodid","productdetails.aspx?prodid={0}") %>'>
                 <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/images/{0}") %>' runat="server"

              Height="250px"

          Width ="200px" />
                      </a>

                        </td>
                         </tr>
 <tr align="center">

 <td>

<a style="border=1;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;"href='<%# Eval("prodid","cart.aspx?prodid={0}") %>' >Add To Cart</a>

&nbsp;&nbsp;&nbsp;

<a style="border=1;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;"href="buy.aspx" >Buy Now</a>
</td>
  </tr>
                              
  </table>
     </td>
                 

               
              <td>
                  <table width="100%">
                      <tr>
                          <td>

              <span > <b><%# Eval("prodname") %></b></span><br />
             <span >Rs. <%# Eval("prodprice") %> onwards</span><br />
                              Free Delivery

                              </td>
                                </tr>
             <tr>
                 <td>
                     <b>Product Details</b></br>

             Name : <%# Eval("prodname") %></span><br />
             Description : <%# Eval("prodname") %></span><br />
             Size:M,L,XL,XXL,</br>
             Country Of Origin:India

                     </td>
                 </tr>
              
                  
                      </table>

</td>
 </tr>

</table>
                
        </ItemTemplate>
    </asp:DataList>
    
</asp:Content>
