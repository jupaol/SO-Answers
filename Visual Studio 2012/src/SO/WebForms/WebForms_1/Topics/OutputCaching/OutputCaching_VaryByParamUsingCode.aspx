<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCaching_VaryByParamUsingCode.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_VaryByParamUsingCode" %>

<%--<%@ OutputCache Duration="60" Location="Server" VaryByParam="ddl" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="ddl">
    <div>
        <h1>Output caching using code</h1>
        <h3>The page will be cached depending on the value that you choose from the list below</h3>
        <br />
        Name of the control: <b><asp:Label runat="server" ID="lblClient" /></b>
        <br />
        Server ID of the control: <b><asp:Label runat="server" ID="lblServer" /></b>
        <br />
        Unique name of the control: <b><asp:Label runat="server" ID="lblUnique" /></b>
        <br />
        <asp:DropDownList runat="server" ID="ddl" DataTextField="Text" DataValueField="Value"
            AppendDataBoundItems="true" AutoPostBack="true">
            <asp:ListItem Text="Select something pls" />
        </asp:DropDownList>
        <br />
        Page generated at: <asp:Label runat="server" ID="lbl" />
    </div>
    </form>
</body>
</html>
