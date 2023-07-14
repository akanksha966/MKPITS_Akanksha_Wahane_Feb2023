<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kycform.aspx.cs" Inherits="KYC.kycform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
<html>
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="StyleSheet1" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
     
    <title>Kyc Form</title>
  </head>
  <body>
      <div class="container-fluid bg-secondary text-light py-2 w-50">
          <header class="text-center">
              <h1 class="display-6">Welcome To Kyc Page</h1>

          </header>
          

      </div>
      <section class="container my-2 bg-dark w-50 text-light p-2 mt-0">

       <div class="row p-3">
       <div class="col-md-4">
    <label for="validationDefault01" class="form-label">First name</label>
           <asp:TextBox ID="TextBox1" runat="server" Height="50px" ></asp:TextBox>
  </div>
  <div class="col-md-4">
    <label for="validationDefault02" class="form-label">Last name</label>
      <asp:TextBox ID="TextBox2" runat="server" Height="50px"></asp:TextBox>
  </div>
  <div class="col-md-4">
    <label for="validationDefaultUsername" class="form-label">Username</label>
    
        <asp:TextBox ID="TextBox3" runat="server" Height="50px"></asp:TextBox>
    </div>
  </div>
           
<div class="row p-3">
       <div class="col-md-4">
    <label for="validationDefault01" class="form-label">Email</label>
     <asp:TextBox ID="TextBox4" runat="server" Height="50px" ></asp:TextBox>
  </div>
   
  <div class="col-md-4">
    <label for="inputPassword4" class="form-label">Password</label>
      <asp:TextBox ID="TextBox5" runat="server" Height="50px"></asp:TextBox>
  </div>

 <div class="col-md-4">
    <label for="inputContact" class="form-label">Contact</label>
      <asp:TextBox ID="TextBox6" runat="server" Height="50px"></asp:TextBox>
  </div>
   </div>
   
    <div class="row p-2" >
    <label for="inputAddress" class="form-label">Address</label>
        <asp:TextBox ID="TextBox7" runat="server" placeholder="1234 Main St" Height="50px" style="margin-left: 23px" Width="605px" ></asp:TextBox>

 </div>
   <div class="row p-2">
  
    <label for="inputAddress2" class="form-label">Address 2</label>
       <asp:TextBox ID="TextBox8" runat="server" placeholder="Apartment, studio, or floor"  Height="50px" style="margin-left: 20px" Width="611px"></asp:TextBox>  
  </div>
   <div class="row">
  <div class="col-md-4">
    <label for="inputCity" class="form-label">City</label>
      <asp:TextBox ID="TextBox9" runat="server"  Height="50px" style="margin-left: 17px"></asp:TextBox>
  </div>
  <div class="col-md-4">
    <label for="inputState" class="form-label">State</label>
    <%--<select id="inputState" class="form-select" style="height: 48px; width: 100%">
      <option selected>Choose...</option>
      <option>Maharashtra</option>
        <option>Assam</option>
              <option>Kerala</option>
              <option>Gujarat</option>--%>

        <asp:DropDownList ID="statecb"  runat="server" class="form-control" Height="51px">
                       <asp:ListItem>Choose...</asp:ListItem>
                       <asp:ListItem>Maharashtra</asp:ListItem>
                       <asp:ListItem>Kerala</asp:ListItem>
                        <asp:ListItem>Gujarat</asp:ListItem>
                        
                        </asp:DropDownList>





   <%-- </select>--%>
  </div>
  <div class="col-md-4">
    <label for="inputZip" class="form-label">Zip</label>
      <asp:TextBox ID="TextBox10" runat="server" Height="50px"></asp:TextBox>
  </div>
              </div>
  <div class="col-12">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" id="gridCheck">
      <label class="form-check-label" for="gridCheck">
        Check me out
      </label>
    </div>
  </div>
          <br />
          
  <div class="col-12">
<%--    <button type="submit" class="btn btn-primary">Sign in</button>--%>
      <asp:Button OnClientClick="return validateForm();" ID="Button1" runat="server" Text="SignIn"  width="181px" OnClick="Button1_Click" Height="50px" BackColor="#FF9900" BorderColor="White" ForeColor="Black" style="margin-left: 14px" />
  </div>
          <br />
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

      </section>
    
   
   
  </body>
</html>
    <script type="text/javascript">
        function validateForm() {
            var firstname = document.getElementById('<%= TextBox1.ClientID %>').value;
            var lastname = document.getElementById('<%= TextBox2.ClientID %>').value;
            var username = document.getElementById('<%= TextBox3.ClientID %>').value;
            var contact = document.getElementById('<%= TextBox6.ClientID %>').value;
            var password = document.getElementById('<%= TextBox5.ClientID %>').value;
            var address = document.getElementById('<%= TextBox7.ClientID %>').value;
            var address1 = document.getElementById('<%= TextBox8.ClientID %>').value;
            var city = document.getElementById('<%= TextBox9.ClientID %>').value;
            var pincode = document.getElementById('<%= TextBox10.ClientID %>').value;







            if (firstname.trim() === '') {
                alert('Please enter a firstname');

                document.getElementById("<%=TextBox1.ClientID%>").focus();

                return false;
            }
            var letters = /^[A-Za-z]+$/;
            if (firstname.match(letters)) {

            }
            else {
                alert("please enter only characters in firstname");
            }


            if (lastname.trim() === '') {
                alert('Please enter a lastname');

                document.getElementById("<%=TextBox2.ClientID%>").focus();

                return false;
            }

            if (username.trim() === '') {
                alert('Please enter a username');

                document.getElementById("<%=TextBox3.ClientID%>").focus();

                 return false;
            }

            if (document.getElementById("<%=TextBox4.ClientID %>").value=="")
             {
                  alert("Email Id Cannot Be Blank");
                document.getElementById("<%=TextBox4.ClientID %>").focus();
                return false;
            }

                    var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/;
                    var emailid = document.getElementById("<%=TextBox4.ClientID %>").value;
                  var matchArray = emailid.match(emailPat);
              if (matchArray == null)
             {
                    alert("Your email address seems incorrect. Please try again.");
                    document.getElementById("<%=TextBox4.ClientID %>").focus();
                      return false;
            }
            if (password.trim() === '') {
                alert('Please enter a password');

                document.getElementById("<%=TextBox5.ClientID%>").focus();

                return false;
            }
            var letters = /^[A-Za-z]+$/;
            if (password.match(letters)) {

            }
            else {
                alert("please enter only characters in password");
            }


            if (contact.trim() === '') {
                alert('Please enter a contact no');

                document.getElementById("<%=TextBox6.ClientID%>").focus();

                return false;
            }


            var numbers = /^\d{10}$/;
            var mobileno = document.getElementById("<%=TextBox6.ClientID %>").value;

            if (mobileno.match(numbers)) {

            }
            else {
                alert("please enter 10 numbers in mobileno");
                return false;
            }


            if (address.trim() === '') {
                alert('Please fill address box');

                document.getElementById("<%=TextBox7.ClientID%>").focus();

                return false;
            }

            if (address1.trim() === '') {
                alert('Please fill addresss details');

                document.getElementById("<%=TextBox8.ClientID%>").focus();

                return false;
            }

            if (city.trim() === '') {
                alert('Please enter a city');

                document.getElementById("<%=TextBox9.ClientID%>").focus();

                return false;
            }
            var letters = /^[A-Za-z]+$/;
            if (city.match(letters)) {

            }
            else {
                alert("please enter only characters in city");
            }


            if (pincode.trim() === '') {
                alert('Please enter a pin code');

                document.getElementById("<%=TextBox10.ClientID%>").focus();

                return false;
            }


            var numbers = /^\d{6}$/;
            var pincode = document.getElementById("<%=TextBox10.ClientID %>").value;

            if (pincode.match(numbers)) {

            }
            else {
                alert("please enter 6 digit numbers in pincode");
                return false;
            }
              return true;

            

           
        }


    </script>
</asp:Content>
