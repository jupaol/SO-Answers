<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SplittingRequestUrl.aspx.cs" Inherits="WebForms_1.Topics.General.SplittingRequestUrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView runat="server" ID="gv" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#FFCC66" ForeColor="#333333"></PagerStyle>

            <RowStyle BackColor="#FFFBD6" ForeColor="#333333"></RowStyle>

            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#FDF5AC"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#4D0000"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#FCF6C0"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#820000"></SortedDescendingHeaderStyle>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
