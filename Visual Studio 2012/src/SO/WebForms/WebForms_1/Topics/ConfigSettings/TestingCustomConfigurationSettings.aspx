<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestingCustomConfigurationSettings.aspx.cs" Inherits="WebForms_1.Topics.ConfigSettings.TestingCustomConfigurationSettings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body runat="server" id="body">
    <form id="form1" runat="server">
        <div>
            Some text
            <br />
            <asp:CheckBox runat="server" ID="chk" Text="Remote ONly" />
            <br />
            <asp:Label runat="server" ID="lbl"></asp:Label>
        </div>
    </form>
</body>
</html>
