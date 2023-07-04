﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Authors.aspx.cs" Inherits="OnlineBookShopping.Views.Admin.Authors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col"> <h3 class="text-left">Manage Authors</h3> </div>
       </div>

         <div class = "row">
             <div class="col-md-4">
                  <div class="mb-3" >
                     
                      <label for=""class="form-label text-success">Author Name</label>
                   <input type="text" placeholder="Title" autocomplete="off" runat="server" class="form-control" id="aname" />


                      
                 </div>


                 <div class="mb-3" >
                     <label for=""class = "form-label text-success ">Author Gender</label>
                     <asp:DropDownList runat="server" class="form-control" id="Gencb">
                         <asp:ListItem>Male</asp:ListItem>
                       <asp:ListItem>Female</asp:ListItem>
                     </asp:DropDownList>

                      
                 </div>
                 <div class="mb-3" >
                     <label for=""class = "form-label text-success ">Country</label>
                   <asp:DropDownList ID="Countrycb"  runat="server" class="form-control">
                       <asp:ListItem>USA</asp:ListItem>
                       <asp:ListItem>India</asp:ListItem>
                       <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>SPAIN</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                        </asp:DropDownList>

                      
                 </div>







                  

                
                     
             
                
                 <div class="row">
                     <asp:Label ID="Errormsg" runat="server" class="text-danger"></asp:Label> 
                     
                     
                     <div class="col d-grid"><asp:Button Text="Update" runat="server" id="EditBtn" class="btn-warning btn-block btn" OnClick="Unnamed1_Click" /></div>
                     <div class="col d-grid"><asp:Button Text="Save" runat="server" id="SaveBtn" class="btn-success btn-block btn" OnClick="Unnamed2_Click" /></div>
                      <div class="col d-grid"> <asp:Button Text="Delete" runat="server" id="DeleteBtn" class="btn-danger btn-block btn" OnClick="Unnamed3_Click" /></div>
                  </div>
                 
             
                </div>
            

                
            
                
              <div class="col-md-8">
               <asp:GridView ID="AuthorsLists" runat="server" class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorsLists_SelectedIndexChanged">
                   <AlternatingRowStyle BackColor="White" />
                   <EditRowStyle BackColor="#7C6F57" />
                   <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                   <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#E3EAEB" />
                   <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#F8FAFA" />
                   <SortedAscendingHeaderStyle BackColor="#246B61" />
                   <SortedDescendingCellStyle BackColor="#D4DFE1" />
                   <SortedDescendingHeaderStyle BackColor="#15524A" />
                  </asp:GridView>

             </div>
             </div>
             </div>
</asp:Content>
