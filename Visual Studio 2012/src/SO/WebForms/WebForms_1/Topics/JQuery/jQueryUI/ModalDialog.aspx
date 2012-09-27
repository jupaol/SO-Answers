<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModalDialog.aspx.cs" Inherits="WebForms_1.Topics.JQuery.jQueryUI.ModalDialog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="../../../Scripts/jquery-ui-1.8.20.min.js"></script>
    <link type="text/css" rel="stylesheet" href="../../../Content/themes/base/jquery.ui.all.css" />
    <script type="text/javascript">
        $(function () {
            var $dialog = $("#dialog");
            var $foo = $("input:submit[id$=foo]");
            var confirmed = false;

            $dialog.hide();

            $dialog.dialog({
                width: "300px",
                modal: true,
                autoOpen: false,
                buttons: {
                    OK: function (e) {
                        $dialog.dialog("close");
                        confirmed = true;
                        $foo.click();
                    },
                    Cancel: function (e) {
                        $dialog.dialog("close");
                        confirmed = false;
                    }
                }
            });

            $foo.click(function (e) {
                if (!confirmed) {
                    $dialog.dialog("open");
                }

                return confirmed;
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="Submit" runat="server" ID="foo" OnClick="foo_Click" />
        </div>
        <div>
            <asp:Label runat="server" ID="msg"></asp:Label>
        </div>
        <div id="dialog">
            <asp:Label Text="Are u sure u wanna do it?" runat="server" />
        </div>
    </form>
</body>
</html>
