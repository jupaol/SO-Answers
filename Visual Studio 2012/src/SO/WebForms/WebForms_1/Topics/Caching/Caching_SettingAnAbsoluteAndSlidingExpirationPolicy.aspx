<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caching_SettingAnAbsoluteAndSlidingExpirationPolicy.aspx.cs" Inherits="WebForms_1.Topics.Caching.Caching_SettingAnAbsoluteAndSlidingExpirationPolicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Caching an object setting absolute and sliding expiration policies</h1>
        <h2>
            The object will stay in cache max 15 seconds. If you do not refresh the page
            more often than 5 seconds, the object will be rmeoved from the cache.
            Even if you keep refreshing the page, the object will be removed after 15 seconds
        </h2>
        Object from cache: <asp:Label ID="lbl" runat="server" />
        <br />
        <%: DateTime.Now.ToString() %>
    </div>
    </form>
</body>
</html>
