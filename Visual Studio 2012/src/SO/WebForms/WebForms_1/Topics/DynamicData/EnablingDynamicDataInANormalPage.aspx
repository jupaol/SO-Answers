<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnablingDynamicDataInANormalPage.aspx.cs" Inherits="WebForms_1.Topics.DynamicData.EnablingDynamicDataInANormalPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Enabling dynamic data on an ASP.Net WebForms page</h1>
        <asp:DynamicDataManager runat="server" ID="ddm" AutoLoadForeignKeys="true">
            <DataControls>
                <asp:DataControlReference ControlID="gv" />
            </DataControls>
        </asp:DynamicDataManager>
        <asp:ValidationSummary runat="server" ID="vs" />
        <asp:GridView runat="server" ID="gv" DataSourceID="lds" AutoGenerateEditButton="true"
            AllowPaging="true" AllowSorting="true"
            DataKeyNames="job_id">
        </asp:GridView>
        <asp:LinqDataSource runat="server" ID="lds"
            EnableUpdate="true"
            TableName="jobs"
            ContextTypeName="WebForms_1.DataAccess.PubsDataContext">
        </asp:LinqDataSource>
    </div>
    </form>
</body>
</html>
