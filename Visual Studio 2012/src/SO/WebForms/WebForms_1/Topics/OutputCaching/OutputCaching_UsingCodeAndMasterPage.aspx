<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OutputCaching_UsingCodeAndMasterPage.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_UsingCodeAndMasterPage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Output caching using code and master page</h1>
    <h3>The page will be cached depending on the value that you choose from the list below</h3>
    <br />
    Name of the control: <b><asp:Label runat="server" ID="lblClient" /></b>
    <br />
    Server ID of the control: <b><asp:Label runat="server" ID="lblServer" /></b>
    <br />
    Unique name of the control: <b><asp:Label runat="server" ID="lblUnique" /></b>
    <br />
    <asp:DropDownList runat="server" ID="ddl" DataTextField="Text" DataValueField="Value"
        AppendDataBoundItems="true" AutoPostBack="true">
        <asp:ListItem Text="Select something pls" />
    </asp:DropDownList>
    <br />
    Page generated at: <asp:Label runat="server" ID="lbl" />
</asp:Content>
