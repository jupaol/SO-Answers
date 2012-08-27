<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingMultipleDynamicControls.aspx.cs" Inherits="WebForms_1.Topics.DynamicControls.AddingMultipleDynamicControls" %>

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
        Static controls from here
        <asp:Label ID="lbl" runat="server" />
    </div>
    </form>
</body>
</html>
