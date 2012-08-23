<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCaching_VaryByBrowser.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_VaryByBrowser" %>

<%@ OutputCache Duration="30" VaryByCustom="browser" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lbl" />
    </div>
    </form>
</body>
</html>
