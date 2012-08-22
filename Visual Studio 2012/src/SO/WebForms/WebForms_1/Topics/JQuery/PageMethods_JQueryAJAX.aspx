<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageMethods_JQueryAJAX.aspx.cs" Inherits="WebForms_1.Topics.JQuery.PageMethods_JQueryAJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Scripts/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: 'POST',
                url: '<%: this.ResolveClientUrl("~/Topics/JQuery/PageMethods_JQueryAJAX.aspx/GetJobs") %>',
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                data: '{}',
                async: true,
                cache: false,
                success: function (data) {
                    $.each(data.d, function (i, item) {
                        $('<option />').val(item.JobID).text(item.Description).appendTo('#jobs');
                    });
                },
                error: function (xhr) {
                    alert(xhr.responseText);
                }
            });

            $('#jobs').change(function () {
                var jobID = $('#jobs option:selected').val();

                $.ajax({
                    type: 'POST',
                    url: '<%: this.ResolveClientUrl("~/Topics/JQuery/PageMethods_JQueryAJAX.aspx/GetEmployees") %>',
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    data: '{"jobID" : ' + jobID +'}',
                    async: false,
                    cache: false,
                    success: function (data) {
                        $('#employees').find('option').remove();
                        $.each(data.d, function (i, item) {
                            $('<option />').val(item.EmployeeID).text(item.FirstName).appendTo('#employees');
                        });
                    },
                    error: function (xhr) {
                        alert(xhr.responseText);
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select id="jobs">
            <option value="0">Please select a job...</option>
        </select>
        <br />
        <select id="employees"></select>
    </div>
    </form>
</body>
</html>
