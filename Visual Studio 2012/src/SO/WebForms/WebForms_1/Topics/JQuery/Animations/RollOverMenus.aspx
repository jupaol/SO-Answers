<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RollOverMenus.aspx.cs" Inherits="WebForms_1.Topics.JQuery.Animations.RollOverMenus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".dropdown-menu").css("cursor", "pointer").hover(function () {
                $(".menu-items", this).slideDown(200);
            }, function () {
                $(".menu-items", this).slideUp(200);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="dropdown-menu">
            <div class="menu-title">Menu One</div>
            <div class="menu-items" style="display:none;">
                <div><a href="#">Item One</a></div>
                <div><a href="#">Item Two</a></div>
            </div>
        </div>
        <div class="dropdown-menu">
            <div class="menu-title">Menu Two</div>
            <div class="menu-items" style="display:none;">
                <div><a href="#">Item Three</a></div>
                <div><a href="#">Item Four</a></div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
