<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindControlInLoginVieq.aspx.cs" Inherits="WebForms_1.Topics.Membership.FindControlInLoginVieq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginView runat="server" ID="login">
                <AnonymousTemplate>
                    <asp:HyperLink NavigateUrl="navigateurl" runat="server" Text="de" ID="link" />
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <asp:HyperLink NavigateUrl="navigateurl" runat="server" Text="de" ID="link" />
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
        <div>
            <asp:Button Text="FindControl" runat="server" OnClick="Unnamed_Click" />
            <br />
            <asp:Literal Text="text" runat="server" ID="msg" />
        </div>
    </form>
</body>
</html>
