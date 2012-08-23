<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OutputCaching_VaryingByParamWithMasterPage.aspx.cs" Inherits="WebForms_1.Topics.OutputCaching.OutputCaching_VaryingByParamWithMasterPage" %>

<%@ OutputCache Duration="60" Location="Server" VaryByParam="ctl00$MainContent$ddl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Output caching varying by param</h1>
    <h3>The page will be cached depending on the value specified in the list below</h3>
    <br />
    <asp:DropDownList runat="server" ID="ddl" AutoPostBack="true" />
    <br />
    Page cached and rendered at: <b><asp:Literal ID="literal" runat="server" /></b>
    <br />
    <asp:Substitution runat="server" ID="sus" MethodName="GetCurrentTime" />
</asp:Content>
