<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUsingScriptServices.aspx.cs" Inherits="WebForms_1.Topics.Membership.ScriptServices.LoginUsingScriptServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm">
        </asp:ScriptManager>
        <h1>
            Testing the membership services using AJAX
        </h1>
        <h3>
            Remmeber to set authentication mode to Forms
        </h3>
        <asp:BulletedList ID="BulletedList1" runat="server">
            <asp:ListItem Text="User: user, Password: password!" />
        </asp:BulletedList>
        <asp:LoginView runat="server">
            <AnonymousTemplate>
                <input type="tel" name="user" id="user" />
                <br />
                <input type="password" name="pass" id="pass" />
                <br />
                <input type="button" value="Login" name="login" id="login" onclick="attemptLogin(this);" />
            </AnonymousTemplate>
            <LoggedInTemplate>
                <input type="button" name="logout" id="logout" value="Logout" onclick="attemptLogout(this);" />
            </LoggedInTemplate>
        </asp:LoginView>
        <asp:LoginName FormatString="Welcome {0}!" runat="server" />
    </div>
        <script>
            function attemptLogin(e) {
                Sys.Services.AuthenticationService.login(
                    $get("user").value,
                    $get("pass").value,
                    false,
                    null,
                    null,
                    function success(validCredentials, userContext, methodName) {
                        if (validCredentials == true) {
                            alert("user logged in");
                            window.location = window.location;
                        }
                        else {
                            alert("user name or password incorrect");
                        }
                    }, function fail(error, userContext, methodName) {
                        alert(error.get_message());
                    }, null);
            }

            function attemptLogout(e) {
                Sys.Services.AuthenticationService.logout(
                    window.location,
                    null,
                    null,
                    null
                );
            }
        </script>
    </form>
</body>
</html>
