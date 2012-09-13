<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWcfServiceFromAjax.aspx.cs" Inherits="WebForms_1.Topics.JQuery.TestWcfServiceFromAjax1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: "POST",
                url: "<%= this.ResolveClientUrl("~/Topics/JQuery/Ajax/TestWcfServiceFromAjax.svc/HelloWorld") %>",
                contentType: "application/json; charset=utf-8;",
                dataType: "json",
                data: "{}",
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
    <div id="msg">
    
    </div>
    </form>
</body>
</html>
