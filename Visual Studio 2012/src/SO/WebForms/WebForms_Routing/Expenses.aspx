<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expenses.aspx.cs" Inherits="WebForms_Routing.Expenses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Expenses Report for: 
            <asp:Literal ID="Literal1" Text="<%$RouteValue:locale %>" runat="server" /> - 
            <asp:Literal ID="Literal2" Text="<%$RouteValue:year %>" runat="server" />
        </h1>
        <h2>
            <%: this.Request.QueryString["game"] %>
        </h2>
        <h3>
            <asp:Literal Text="<%$RouteValue: extraInfo %>" runat="server" />
        </h3>
        <asp:BulletedList runat="server" ID="subCategories" BulletStyle="LowerRoman" ClientIDMode="Predictable" />
    </div>
    </form>
</body>
</html>
