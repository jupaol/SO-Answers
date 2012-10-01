<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormViewPagerBug.aspx.cs" Inherits="WebForms_1.Topics.DataBinding.FormViewPagerBug" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LinqDataSource runat="server" ID="lds"
        TableName="jobs" ContextTypeName="WebForms_1.DataAccess.PubsDataContext" >

    </asp:LinqDataSource>
    <asp:LinqDataSource runat="server" ID="ldse"
        TableName="employee" ContextTypeName="WebForms_1.DataAccess.PubsDataContext" OnSelecting="ldse_Selecting">

    </asp:LinqDataSource>

    <h1>
        In this sample, the `FormView` control behaves weird when it is bound with only one row
        and the `PagerSettings.Mode` property is set either to `Top` or `TopAndBottom`. When it is
        set to `Bottom` it works as expected...
    </h1>

    <asp:FormView runat="server" DefaultMode="Edit" ClientIDMode="Predictable" DataKeyNames="emp_id" DataSourceID="ldse"
        AllowPaging="true" OnItemCommand="Unnamed_ItemCommand" ID="formView">
        <EditItemTemplate>
            <div>
                <asp:DropDownList runat="server" ID="ddlJobs" DataSourceID="lds" DataTextField="job_desc" DataValueField="job_id">
                </asp:DropDownList>
            </div>
            <div>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDesc" />
            </div>
            <div>
                <asp:Button ID="Button1" Text="Save" runat="server" CommandName="Save" CausesValidation="true" />
                <asp:Button ID="Button2" Text="Cancel" runat="server" CommandName="Cancel" CausesValidation="false" />
            </div>
        </EditItemTemplate>
        <PagerSettings Mode="NextPreviousFirstLast" 
            Position="TopAndBottom" />
    </asp:FormView>
    <div>
        <asp:Label Text="text" runat="server" ID="res" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SeondaryContent" runat="server">
</asp:Content>
