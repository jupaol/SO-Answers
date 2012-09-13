<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumeAWebServiceUsingAjax.aspx.cs" Inherits="WebForms_1.Topics.JQuery.ConsumeAWebServiceUsingAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                url: '<%= this.ResolveClientUrl("~/Topics/JQuery/Ajax/TestWebService.asmx/HelloWorld") %>',
                type: 'POST',
                contentType: 'application/json; charset=utf-8;',
                dataType: 'json',
                data: '{}',
                async: true,
                cache: false,
                success: function (msg) {
                    $("#msg").text(msg.d);
                },
                error: function (xhr) {
                    alert(xhr.responseText);
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="msg"></div>
        </div>
    </form>
</body>
</html>
