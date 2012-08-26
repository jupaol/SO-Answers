<%@ Page Theme="BlueTheme" Language="C#" AutoEventWireup="true" CodeBehind="OverridingThemesWithThemeAttribute.aspx.cs" Inherits="WebForms_1.Topics.ThemesAndStyling.OverridingThemesWithThemeAttribute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="text" runat="server" Font-Bold="true" SkinID="HelpButton" style="background-color:aqua" />
        <asp:Button Text="text" runat="server" Font-Size="XX-Large" Font-Bold="true" style="background-color:aqua" />
    </div>
    </form>
</body>
</html>
