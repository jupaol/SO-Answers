<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageMethods_ScriptManager.aspx.cs" Inherits="WebForms_1.Topics.MicrosoftAJAX.PageMethods_ScriptManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Scripts/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            Sys.Application.add_init(function () {
                PageMethods.GetJobs(function (data) {
                    $.each(data, function (i, item) {
                        $("<option />").val(item.JobID).text(item.Description).appendTo("#jobs");
                    });
                }, function (error) {
                    alert(error.get_message());
                });

                $("#jobs").change(function () {
                    PageMethods.GetEmployees($("#jobs option:selected").val(), function (data) {
                        $("#employees").find("option").remove().end();
                        $.each(data, function (i, item) {
                            $("<option/>").text(item.FirstName).appendTo("#employees");
                        });
                    }, function (error) {
                        alert(error.get_message());
                    });
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" EnablePageMethods="true" />
        <select id="jobs">
            <option value="0">Select a job...</option>
        </select>
        <br />
        <select id="employees">
        </select>
    </div>
    </form>
</body>
</html>
