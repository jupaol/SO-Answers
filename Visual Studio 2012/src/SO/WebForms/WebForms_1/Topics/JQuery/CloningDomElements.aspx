<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CloningDomElements.aspx.cs" Inherits="WebForms_1.Topics.JQuery.CloningDomElements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var lastID = 1;

            function remove($source) {
                $source.remove();
            }

            $("#add").click(function () {
                var $file = $(".file:first").clone();
                var $fileInput = $file.find("input:file");
                var $remove = $("<input />").attr("type", "button").val("Remove").attr("id", "remove");

                $remove.appendTo($file);
                ++lastID;
                $fileInput.attr("id", "file" + lastID);
                $file.insertBefore("#add");

                $remove.click(function () {
                    remove($file);
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="file">
                <input type="file" id="file1" />
            </div>
            <input type="button" id="add" value="Add new file" />
            <input type="submit" id="save" value="Save" />
        </div>
    </form>
</body>
</html>
