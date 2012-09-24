<%@ Page Title="" Language="C#" MasterPageFile="~/Topics/Page_ViewState/Nested.Master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="WebForms_1.Topics.Page_ViewState.Content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        IN content page
    </h1>
    <asp:DropDownList runat="server" AutoPostBack="true" ID="ddl">
    </asp:DropDownList>
</asp:Content>
