<%@ Page Culture="fr-CA" Language="C#" AutoEventWireup="true" CodeBehind="DateGlobalizationScriptOverridingCulture.aspx.cs" Inherits="WebForms_1.Topics.Globalization.DateGlobalizationScriptOverridingCulture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" EnableScriptGlobalization="true" EnableScriptLocalization="true">

        </asp:ScriptManager>

        <h1>
            Localizing javascript date overriding the culture settings defined in the web.configfile
        </h1>

        <asp:Button Text="Localize date" runat="server" ID="button" />
        <asp:Label ID="msg" runat="server" />

        <script>
            Sys.UI.DomEvent.addHandler($get("button"), "click", localizeDate);

            function localizeDate(e) {
                var d = new Date();

                e.preventDefault();

                try {
                    $get("msg").innerHTML = d.localeFormat("dddd, dd MM yyyy HH:mm:ss");
                } catch (error) {
                    alert("Error: " + error.message);
                }
            }
        </script>
    </div>
    </form>
</body>
</html>
