<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCaching_FilesDependency.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_FilesDependency" %>
<%@ OutputCache CacheProfile="files" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Output caching with files dependencies</h1>
        <asp:Label runat="server" ID="lblRendered" ></asp:Label><br />
        <asp:Label ID="lbl" runat="server" />
    </div>
    </form>
</body>
</html>
