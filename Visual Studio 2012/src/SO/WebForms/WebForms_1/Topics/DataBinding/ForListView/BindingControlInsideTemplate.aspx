<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BindingControlInsideTemplate.aspx.cs" Inherits="WebForms_1.Topics.DataBinding.ForListView.BindingControlInsideTemplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinqDataSource runat="server" ID="lds"
            TableName="jobs" ContextTypeName="WebForms_1.DataAccess.PubsDataContext">

        </asp:LinqDataSource>
        <asp:ListView runat="server" ID="listView" DataKeyNames="job_id" DataSourceID="lds" 
            OnItemCommand="listView_ItemCommand" OnItemCreated="listView_ItemCreated">
            <ItemTemplate>
                <div>
                    <asp:Label Text='<%# Eval("job_desc") %>' runat="server" ID="descLabel" />
                </div>
            </ItemTemplate>
            <InsertItemTemplate>
                <asp:DropDownList runat="server" ID="myDropDownListInsideATemplate">
                </asp:DropDownList>
            </InsertItemTemplate>
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                </div>
                <hr />
                <div>
                    <asp:Button ID="Button1" Text="Insert mode" runat="server" CommandName="New" />
                </div>
            </LayoutTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
