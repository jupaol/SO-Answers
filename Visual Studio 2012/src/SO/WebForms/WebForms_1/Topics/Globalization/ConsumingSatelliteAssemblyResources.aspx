<%@ Page UICulture="en-US" Culture="en-US" Language="C#" AutoEventWireup="true" CodeBehind="ConsumingSatelliteAssemblyResources.aspx.cs" Inherits="WebForms_1.Topics.Globalization.ConsumingSatelliteAssemblyResources" %>
<%@ Register Assembly="SampleControl" Namespace="SampleControl" TagPrefix="samples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" EnableScriptGlobalization="true" EnableScriptLocalization="true">
            <Scripts>
                <asp:ScriptReference Assembly="SampleControl" Name="SampleControl.CheckAnswer.js" />
            </Scripts>
        </asp:ScriptManager>
        <asp:DropDownList runat="server" ID="languages" CausesValidation="false" AutoPostBack="true" OnSelectedIndexChanged="languages_SelectedIndexChanged">
            <asp:ListItem Text="English" Value="en" />
            <asp:ListItem Text="Italian" Value="it" />
            <asp:ListItem Text="Spanish" Value="es" />
        </asp:DropDownList>
        <hr />
        <samples:ClientVerification runat="server">

        </samples:ClientVerification>
    </div>
    </form>
</body>
</html>
