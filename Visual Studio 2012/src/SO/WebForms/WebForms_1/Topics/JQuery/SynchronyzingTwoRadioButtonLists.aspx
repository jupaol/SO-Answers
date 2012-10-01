<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SynchronyzingTwoRadioButtonLists.aspx.cs" Inherits="WebForms_1.Topics.JQuery.SynchronyzingTwoRadioButtonLists" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Scripts/jquery-1.7.1.min.js"></script>
    <script>
        $(function () {
            var $list1 = $("table[id$=list1] input:radio");
            var $list2 = $("table[id$=list2] input:radio");

            $list1.change(function () {
                var $current = $(this);

                $list2.filter(function () {
                    return $(this).val() === $current.val();
                }).prop("checked", true);
            });

            $list2.change(function () {
                var $current = $(this);

                $list1.filter(function () {
                    return $(this).val() === $current.val();
                }).prop("checked", true);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList runat="server" ID="list1">
            <asp:ListItem Text="text1" Selected="True" />
            <asp:ListItem Text="text2" />
            <asp:ListItem Text="text3" />
        </asp:RadioButtonList>
        <br />
        <hr />
        <br />
        <asp:RadioButtonList runat="server" ID="list2">
            <asp:ListItem Text="text1" Selected="True" />
            <asp:ListItem Text="text2" />
            <asp:ListItem Text="text3" />
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
