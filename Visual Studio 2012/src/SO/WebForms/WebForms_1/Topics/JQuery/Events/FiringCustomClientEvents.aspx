<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FiringCustomClientEvents.aspx.cs" Inherits="WebForms_1.Topics.JQuery.Events.FiringCustomClientEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".Results input:checkbox").click(function (e) {
                var checked = $(this).is("input:checked");

                $(".Results").trigger("onrowselected", checked);
            });

            $(".Results").bind("onrowselected", function (chk) {
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Results">
            <table>
                <tr>
                    <td>
                        <input type="checkbox" id="Checkbox1" />
                    </td>
                    <td>
                        Something 1
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" checked="checked" id="Checkbox2" />
                    </td>
                    <td>
                        Something 2
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" id="Checkbox3" />
                    </td>
                    <td>
                        Something 3
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
