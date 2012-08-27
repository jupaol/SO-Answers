<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingDynamicControlsOnDemand.aspx.cs" Inherits="WebForms_1.Topics.DynamicControls.AddingDynamicControlsOnDemand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField runat="server" ID="n" />
        <asp:Panel runat="server" ID="panel"></asp:Panel>
        <br />
        Static controls from here
        <br />
        <asp:Button Text="Add dynamic contro" runat="server" ID="add" OnClick="add_Click" />
        <br />
        Event history
        <br />
        <asp:Label runat="server" ID="lbl"></asp:Label>
    </div>
    </form>
</body>
</html>
