<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateGlobalizationJavaScript.aspx.cs" Inherits="WebForms_1.Topics.Globalization.DateGlobalizationJavaScript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" 
            EnableScriptGlobalization="true" EnableScriptLocalization="true">

        </asp:ScriptManager>

        <h1>
            Displaying date using the default globalization settings configured in the web.config file
        </h1>

        <asp:UpdatePanel runat="server" ID="panel" ChildrenAsTriggers="false" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="msg" runat="server" />
                <br />
                <asp:Button Text="Display date" runat="server" ID="button" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
        <script>
            Sys.UI.DomEvent.addHandler($get("button"), "click", formatDate);

            function formatDate() {
                var d = new Date();

                try {
                    $get("msg").innerHTML = d.localeFormat("dddd, dd MM yyyy HH:mm:ss");
                } catch (e) {
                    alert("Error: " + e.message);
                }
            }
        </script>
    </form>
</body>
</html>
