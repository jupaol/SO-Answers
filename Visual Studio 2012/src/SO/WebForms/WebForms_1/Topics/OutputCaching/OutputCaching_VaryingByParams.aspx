<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCaching_VaryingByParams.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_VaryingByParams" %>

<%@ OutputCache Duration="60" Location="Server" VaryByParam="ddl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="ddl">
    <div>
        <h1>Output caching varying by param</h1>
        <h3>The page will be cached depending on the value specified in the list below</h3>
        <br />
        <asp:DropDownList runat="server" ID="ddl" AutoPostBack="true" />
        <br />
        Page cached and rendered at: <b><asp:Literal ID="literal" runat="server" /></b>
        <br />
        <asp:Substitution runat="server" ID="sus" MethodName="GetCurrentTime" />
    </div>
    </form>
</body>
</html>
