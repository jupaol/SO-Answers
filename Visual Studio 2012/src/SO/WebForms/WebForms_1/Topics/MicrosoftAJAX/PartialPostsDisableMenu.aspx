<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartialPostsDisableMenu.aspx.cs" Inherits="WebForms_1.Topics.MicrosoftAJAX.PartialPostsDisableMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="sm" />
        <asp:SiteMapDataSource runat="server" ID="smds" />
        <asp:Menu runat="server" ID="menu" DataSourceID="smds" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">

            <DynamicHoverStyle BackColor="#990000" ForeColor="White"></DynamicHoverStyle>

            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px"></DynamicMenuItemStyle>

            <DynamicMenuStyle BackColor="#FFFBD6"></DynamicMenuStyle>

            <DynamicSelectedStyle BackColor="#FFCC66"></DynamicSelectedStyle>

            <StaticHoverStyle BackColor="#990000" ForeColor="White"></StaticHoverStyle>

            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px"></StaticMenuItemStyle>

            <StaticSelectedStyle BackColor="#FFCC66"></StaticSelectedStyle>
        </asp:Menu>
    </div>
        <div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button Text="Partial Post" runat="server" />
                    <div>
                        <%: DateTime.Now.ToString() %>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
