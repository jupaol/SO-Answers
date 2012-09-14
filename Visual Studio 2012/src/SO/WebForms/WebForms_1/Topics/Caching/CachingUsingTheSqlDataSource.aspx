<%@ Page Trace="true" TraceMode="SortByTime" Language="C#" AutoEventWireup="true" CodeBehind="CachingUsingTheSqlDataSource.aspx.cs" Inherits="WebForms_1.Topics.Caching.CachingUsingTheSqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource runat="server" ID="sds"
            ConnectionString="<%$ConnectionStrings:pubsConnectionString %>"
            CacheDuration="30"
            EnableCaching="true"
            SelectCommand="select * from jobs"
            DataSourceMode="DataSet"
            OnSelecting="sds_Selecting">

        </asp:SqlDataSource>
        <div>
            <asp:Literal runat="server" ID="msg" Mode="Encode"></asp:Literal>
        </div>
        <asp:GridView runat="server" DataSourceID="sds"></asp:GridView>
    </div>
    </form>
</body>
</html>
