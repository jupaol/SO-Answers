<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SortGridViewRows.aspx.cs" Inherits="WebForms_1.Topics.JQuery.SortGridViewRows" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style>
        .grid-rows {
            background-color:azure;
        }
        .grid-headers {
            background-color:yellow;
            cursor:pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            var $gv = $("table[id$=gv]");
            var $headers = $("th", $gv);
            var $rows = $("> tbody > tr:not(:has(table, th))", $gv);

            $rows.addClass("grid-rows");
            $headers.addClass("grid-headers");

            $headers.toggle(function (e) {
                sortGrid($(this), 0);
            }, function (e) {
                sortGrid($(this), 1);
            });

            function sortGrid(row, direction) {
                var colIndex = $(row).parent().children().index($(row));
                var $rowsArray = $.makeArray($rows);
                var $sortedArray = $rowsArray.sort(function (o, n) {
                    var $currentCell = $("td:nth-child(" + (colIndex + 1) + ")", $(o));
                    var $nextCell = $("td:nth-child(" + (colIndex + 1) + ")", $(n));
                    var currentValue = parseFloat($currentCell.text()) ? parseFloat($currentCell.text()) : $currentCell.text();
                    var nextValue = parseFloat($nextCell.text()) ? parseFloat($nextCell.text()) : $nextCell.text();

                    if (direction == 0) {
                        return currentValue < nextValue ? -1 : 1;
                    }
                    else {
                        return currentValue > nextValue ? -1 : 1;
                    }
                });

                $("> tbody > tr:not(:has(table, th))", $gv).remove();
                $("tbody", $gv).append($sortedArray);
            }
        });
    </script>
    <h1>
        Sort GridView rows using jQuery
    </h1>
    <asp:LinqDataSource runat="server" ID="lds" 
        ContextTypeName="WebForms_1.DataAccess.PubsDataContext"
        TableName="jobs"
        EntityTypeName="WebForms_1.DataAccess.jobs">
    </asp:LinqDataSource>
    <asp:GridView runat="server" ID="gv" DataSourceID="lds" DataKeyNames="job_id">

    </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SeondaryContent" runat="server">
</asp:Content>
