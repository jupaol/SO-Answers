<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleDynamicControls.aspx.cs" Inherits="WebForms_1.Topics.DynamicControls.SimpleDynamicControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel runat="server" ID="panel"></asp:Panel>
        <br />
        From here are static controls:
        <br />
        <asp:Label ID="lbl" runat="server" />
    </div>
    </form>
</body>
</html>
