<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumingJavaScriptFromAnEmbeddedAssembly.aspx.cs" Inherits="WebForms_1.Topics.Globalization.ConsumingJavaScriptFromAnEmbeddedAssembly" %>
<%@ Register Assembly="SampleControl" Namespace="SampleControl" TagPrefix="samples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" EnablePartialRendering="true">
            <Scripts>
                <asp:ScriptReference Assembly="SampleControl" Name="SampleControl.UpdatePanelAnimation.js" />
            </Scripts>
        </asp:ScriptManager>

        <samples:UpdatePanelAnimationWithClientResource runat="server" ID="sample"
            BorderColor="Green" Animate="true" UpdatePanelID="panel">
            
        </samples:UpdatePanelAnimationWithClientResource>
        <asp:UpdatePanel runat="server" ID="panel" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Calendar runat="server" ID="calendar">

                </asp:Calendar>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
