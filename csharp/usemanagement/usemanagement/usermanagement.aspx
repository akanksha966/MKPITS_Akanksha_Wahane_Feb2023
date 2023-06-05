<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usermanagement.aspx.cs" Inherits="usemanagement.usermanagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- javascript code jaise he button pe click kiye wiase he msgbox ayenga-->

    <script type="text/javascript"language="javascript">
        function alert_meth() {
            alert("client side messagebox");
        }
        function confirm_meth() {
            if (confirm("Do you want continue!click 'Yes'") == true) {
                document.writeln("<br> you had click on 'Yes' button<br>");
            }
            else {
                document.writeln("<br> you had click on 'No' Button <br>");
            }

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- call function alert_meth()-->
            <asp:Button OnClientClick="alert_meth()" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
