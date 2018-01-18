<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebPagesWithOwinAuth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:Login ID="LoginCtrl" runat="server" OnAuthenticate="LoginCtrl_Authenticate">
        </asp:Login>
    </form>
</body>
</html>
