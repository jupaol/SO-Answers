<%@ Page EnableViewState="false" Language="C#" AutoEventWireup="true" CodeBehind="ControlStateTesting.aspx.cs" Inherits="WebForms_1.Topics.ControlState.ControlStateTesting" %>

<%@ Register Assembly="WebForms_1" Namespace="WebForms_1.Topics.ControlState" TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc:AddressServerControl runat="server" ID="cc"></uc:AddressServerControl>
        <br />
        <asp:Button Text="Increment Count Value Using Control State" runat="server" ID="increment" OnClick="increment_Click" />
        <br />
        <asp:Label runat="server" ID="lbl"></asp:Label>
    </div>
    </form>
</body>
</html>
