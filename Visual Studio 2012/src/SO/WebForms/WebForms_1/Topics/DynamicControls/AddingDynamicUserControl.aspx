<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingDynamicUserControl.aspx.cs" Inherits="WebForms_1.Topics.DynamicControls.AddingDynamicUserControl" %>

<%@ Register Src="~/Topics/DynamicControls/AddressControl.ascx" TagPrefix="uc1" TagName="AddressControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel runat="server" ID="panel"></asp:Panel>
    </div>
    </form>
</body>
</html>
