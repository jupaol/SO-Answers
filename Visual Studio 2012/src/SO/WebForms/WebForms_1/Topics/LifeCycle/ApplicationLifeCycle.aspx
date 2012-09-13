<%@ Page Trace="true" TraceMode="SortByTime" Language="C#" AutoEventWireup="true" CodeBehind="ApplicationLifeCycle.aspx.cs" Inherits="WebForms_1.Topics.LifeCycle.ApplicationLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="text" runat="server" OnClick="Unnamed_Click" />
        <asp:CheckBox Text="text" runat="server" AutoPostBack="true" OnCheckedChanged="Unnamed_CheckedChanged" />
    </div>
    </form>
</body>
</html>
