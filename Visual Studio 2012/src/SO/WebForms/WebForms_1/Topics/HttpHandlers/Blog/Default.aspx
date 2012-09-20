<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_1.Topics.HttpHandlers.Blog.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Topics/HttpHandlers/Comments.aspx" runat="server" Text="Comments" />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Topics/HttpHandlers/Posts.aspx" runat="server" Text="Comments" />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Topics/HttpHandlers/Default.aspx" runat="server" Text="Comments" />

    </div>
    </form>
</body>
</html>
