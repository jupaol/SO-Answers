<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sales.aspx.cs" Inherits="WebForms_Routing.Sales1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
        Sales Report for:
            <asp:Literal ID="Literal1" Text="<%$RouteValue:locale %>" runat="server" /> - 
            <asp:Literal ID="Literal2" Text="<%$RouteValue:year %>" runat="server" />
    </h1>
    </div>
    </form>
</body>
</html>
