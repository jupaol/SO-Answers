<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveRowUsingJQueryAfterCallingService.aspx.cs" Inherits="WebForms_1.Topics.JQuery.Ajax.RemoveRowUsingJQueryAfterCallingService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../../Scripts/jquery-1.7.1.min.js"></script>
    <script>
        $(function () {
            var $list = $("table[id*=myDataListID]");
            var $buttons = $("input:submit[id*=remove]", $list);

            $buttons.click(function (e) {
                e.preventDefault();

                if (!confirm("Are you sure?")) {
                    return false;
                }

                var $self = $(this);
                var $jobID = $self.closest("tr").children().find("span[id*=jobID]");

                $buttons.prop("disabled", true);

                $.ajax({
                    url: "<%: this.ResolveClientUrl("~/Topics/JQuery/Ajax/RemoveRowUsingJQueryAfterCallingService.aspx/Remove") %>",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: "{id: " + $jobID.text() + "}",
                    async: true,
                    cache: false,
                    success: function () {
                        $buttons.prop("disabled", false);
                        $self.closest("tr").remove();
                    },
                    error: function (XHResponse, errorMessage, errorCode) {
                        $buttons.prop("disabled", false);
                        alert(errorMessage);
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinqDataSource runat="server" ID="lds"
            TableName="jobs" ContextTypeName="WebForms_1.DataAccess.PubsDataContext">

        </asp:LinqDataSource>
        <asp:DataList runat="server" DataKeyField="job_id" DataSourceID="lds" ID="myDataListID">
            <HeaderTemplate>
                <tr>
                    <th>
                        &nbsp;
                    </th>
                    <th>
                        ID
                    </th>
                    <th>
                        Name
                    </th>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Button Text="Remove" runat="server" ID="remove" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("job_id") %>' runat="server" ID="jobID" />
                    </td>
                    <td>
                        <asp:Label ID="jobDesc" Text='<%# Eval("job_desc") %>' runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
