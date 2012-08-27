<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingDynamicUserControlsOnDemand.aspx.cs" Inherits="WebForms_1.Topics.DynamicControls.AddingDynamicUserControlsOnDemand" %>

<%@ Register Src="~/Topics/DynamicControls/AddressControl.ascx" TagPrefix="uc1" TagName="AddressControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField runat="server" ID="hidden" Value="0" />
        <asp:Panel runat="server" ID="panel"></asp:Panel>
        <br />
        <asp:Button Text="Add dynamic user control" runat="server" ID="add" OnClick="add_Click" />
    </div>
    </form>
</body>
</html>
