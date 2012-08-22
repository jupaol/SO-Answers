<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanel_Trigger_FromInside.aspx.cs" Inherits="WebForms_1.UpdatePanel_Trigger_FromInside" %>

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
                <asp:Timer runat="server" Interval="1000" ID="timer" OnLoad="timer_Load" OnTick="timer_Tick"></asp:Timer>
                <%: DateTime.Now.ToString() %>
            </ContentTemplate>
            <%--This trigger is only needed when the target control is outside of the UpdatePanel control--%>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="timer" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
