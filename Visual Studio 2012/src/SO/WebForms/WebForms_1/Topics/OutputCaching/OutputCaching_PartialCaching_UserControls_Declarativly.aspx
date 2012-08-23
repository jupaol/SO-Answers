<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCaching_PartialCaching_UserControls_Declarativly.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_PartialCaching_UserControls_Declarativly" %>


<%@ Register Src="~/Topics/OutputCaching/PartialCaching_01.ascx" TagName="PartialCaching01" TagPrefix="uc" %>
<%@ Register Src="~/Topics/OutputCaching/PartialCaching_02.ascx" TagName="PartialCaching02" TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <uc:PartialCaching01 runat="server" ID="uc1" />
                <br />
                <uc:PartialCaching02 runat="server" ID="uc2" />
                <br />
                Page: <asp:Label ID="lbl" runat="server" />
                <asp:Timer runat="server" ID="timer" Interval="1000" Enabled="true" OnLoad="timer_Load" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
