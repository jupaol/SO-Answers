<%@ Page ViewStateMode="Disabled" EnableViewState="true" Language="C#" AutoEventWireup="true" CodeBehind="EnablingViewStatePerControl.aspx.cs" Inherits="WebForms_1.Topics.Page_ViewState.EnablingViewStatePerControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" PageSize="3" 
            OnPageIndexChanging="GridView1_PageIndexChanging"
            EnableViewState="true"
            ViewStateMode="Enabled">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
