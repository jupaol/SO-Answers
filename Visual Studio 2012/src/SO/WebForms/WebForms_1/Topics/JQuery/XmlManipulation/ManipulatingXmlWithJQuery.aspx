<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManipulatingXmlWithJQuery.aspx.cs" Inherits="WebForms_1.Topics.JQuery.XmlManipulation.ManipulatingXmlWithJQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script src="../../../Scripts/jquery-ui-1.8.20.min.js"></script>
    <link href="../../../Content/themes/base/jquery.ui.all.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <script>
            $(function () {
                var $btn = $("input:submit[id$=processXml]");
                var $txt = $("textarea[id$=txt]");
                var $dialog = $("#dialog");
                var $res = $("#res");

                $dialog.dialog({
                    autoOpen: false,
                    closeOnEscape: false,
                    height: 140,
                    modal: true,
                    open: function (e, ui) {
                        $(this).closest(".ui-dialog").find(".ui-dialog-titlebar-close").hide();
                    }
                });

                $.ajaxSetup({
                    async: true,
                    cache: false,
                    error: function (xhr, responseText, errorCode) {
                        alert(responseText);
                    },
                    complete: function () {
                        $btn.prop("disabled", false);
                        $dialog.dialog("close");
                    }
                });

                $btn.click(function (e) {
                    e.preventDefault();

                    $(this).prop("disabled", true);
                    $dialog.dialog("open");

                    $.get(
                        "<%: this.ResolveClientUrl("~/Topics/JQuery/XmlManipulation/CustomXmlService.asmx/GetCustomXml") %>",
                        "{}",
                        function (msg) {
                            var text = $(msg).text();
                            var $xml = $(text);

                            $txt.val(text);

                            $res.text("");
                            
                            if ($xml.length > 0) {
                                $($xml).find("DomainUser").each(function (i, x) {
                                    var $it = $(x);
                                    var $fname = $it.find("FirstName");
                                    var $lname = $it.find("LastName");

                                    $res
                                        .append("<br />").append("ID : " + $it.attr("ID"))
                                        .append("<br />").append("First Name: " + $fname.text())
                                        .append("<br />").append("Last Name: " + $lname.text());
                                });
                            }
                            else {
                                $res.text("No records found");
                            }
                        },
                        "xml");
                });
            });
        </script>
    <div class="content">
        <h1>
            Processing XML with JQuery 1.7
        </h1>
        <div>
            <asp:Button Text="Process XML..." runat="server" ID="processXml" />
        </div>
        <div id="res">

        </div>
        <div>
            <asp:TextBox runat="server" ID="txt" TextMode="MultiLine" Width="90%" Rows="10" />
        </div>
        <div id="dialog" style="display:none;">
            Processing...
        </div>
    </div>
    </form>
</body>
</html>
