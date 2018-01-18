<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebPagesWithOwinAuth.adm.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hi <%: Page.User.Identity.Name%>! You have entered to a restricted area</h1>
</body>
</html>
