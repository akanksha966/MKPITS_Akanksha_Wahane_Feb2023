<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="departmentsdetails.aspx.cs" Inherits="TrustProject2.departmentsdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Departments Details</div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Height="317px" Width="625px">
            <br />
            <strong>Department Details<br />
            <br />
            Department Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            Department Name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Insert" Width="79px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="43px" OnClick="Button2_Click" Text="Update" Width="79px" />
            &nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="43px" OnClick="Button3_Click" Text="Delete" Width="79px" />
            &nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="43px" OnClick="Button4_Click" Text="Search" Width="79px" />
        </asp:Panel>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
