<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomizeDataFieldApperanceInDataBoundControls.aspx.cs" Inherits="WebForms_1.Topics.DynamicData.CustomizeDataFieldApperanceInDataBoundControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Customize data field apperance when using data-bound controls in ASP.Net Dynamic Data Web Applications</h1>
        <h3></h3>
        <asp:ValidationSummary runat="server" ID="vs" />

        <asp:GridView runat="server" ID="gv" DataSourceID="lds" AutoGenerateColumns="false"
            AllowPaging="true" AllowSorting="true" PageSize="5" AutoGenerateEditButton="true"
            DataKeyNames="job_id" EnablePersistedSelection="true">
            <Columns>
                <asp:DynamicField DataField="job_desc" UIHint="CustomJobDescription" />
                <asp:DynamicField DataField="job_id" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource runat="server" ID="lds"
            TableName="jobs"
            ContextTypeName="WebForms_1.DataAccess.PubsDataContext"
            EnableDelete="true"
            EnableUpdate="true"
            EnableInsert="true">
        </asp:LinqDataSource>
    </div>
    </form>
</body>
</html>
