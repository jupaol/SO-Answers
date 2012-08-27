<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompressPageViewState.aspx.cs" Inherits="WebForms_1.Topics.Page_ViewState.CompressPageViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinqDataSource runat="server" ID="lds"
            ContextTypeName="WebForms_1.DataAccess.PubsDataContext"
            TableName="jobs">

        </asp:LinqDataSource>
        <asp:GridView runat="server" DataSourceID="lds"></asp:GridView>
        <br />
        Normal viewstate <br /><asp:TextBox runat="server" ID="normalViewState" Width="100%" TextMode="MultiLine" Rows="20"></asp:TextBox>
        <br />
        Encrypted viewstate <br /><asp:TextBox runat="server" ID="encryptedViewState" Width="100%" TextMode="MultiLine" Rows="20"></asp:TextBox>
    </div>
    </form>
</body>
</html>
