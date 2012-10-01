<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkingTwoDropDownLists.aspx.cs" Inherits="WebForms_1.Topics.DataBinding.ForDropDownList.LinkingTwoDropDownLists" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Linking two DropDownLists
        </h1>
        <asp:ScriptManager runat="server" ID="sm" />
        <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="updatePanel" DisplayAfter="0" DynamicLayout="true">
            <ProgressTemplate>
                Loading...
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel runat="server" ID="updatePanel">
            <ContentTemplate>
                <div>
                    <asp:Label ID="Label1" Text="From" runat="server" AssociatedControlID="from" />
                </div>
                <div>
                    <asp:DropDownList runat="server" ID="from" AutoPostBack="true" CausesValidation="false" OnSelectedIndexChanged="from_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div>
                    <asp:Label ID="Label2" Text="To" runat="server" AssociatedControlID="to" />
                </div>
                <div>
                    <asp:DropDownList runat="server" ID="to" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
