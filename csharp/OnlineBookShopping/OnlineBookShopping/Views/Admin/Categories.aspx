﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="OnlineBookShopping.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">

    <div class="container-fluid">
    <div class="row">
        <div class="col"> <h3 class="text-left">Manage Categories</h3> </div>
       </div>

         <div class = "row">
             <div class="col-md-4">
                  <div class="mb-3" >
                     
                      <label for=""class="form-label text-success">Category Name</label>
                   <input type="text" placeholder="Title" autocomplete="off" class="form-control" />


                      
                 </div>


                 <div class="mb-3" >
                     <label for=""class = "form-label text-success ">Category Description</label>
                    <input type="text" placeholder="Description" autocomplete="off" class="form-control" />


                      
                 </div>
                
             
                
                 <div class="row">
                     <div class="col d-grid"><asp:Button Text="Update" runat="server" class="btn-warning btn-block btn" /></div>
                     <div class="col d-grid"><asp:Button Text="Save" runat="server" class="btn-success btn-block btn" /></div>
                      <div class="col d-grid"> <asp:Button Text="Delete" runat="server" class="btn-danger btn-block btn" /></div>
                  </div>
                 
             
                </div>
            

                
            
                
              <div class="col-md-8">
               <asp:GridView ID="GridView1" runat="server"></asp:GridView>

             </div>
             </div>
             </div>
             
           
             
</asp:Content>
