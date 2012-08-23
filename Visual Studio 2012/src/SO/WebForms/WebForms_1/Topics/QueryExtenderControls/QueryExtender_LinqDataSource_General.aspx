<%@ Page MaintainScrollPositionOnPostback="true" Language="C#" AutoEventWireup="true" CodeBehind="QueryExtender_LinqDataSource_General.aspx.cs" Inherits="WebForms_1.Topics.QueryExtenderControls.QueryExtender_LinqDataSource_General" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="jobDescriptionFilter">
    <div>
        <asp:LinqDataSource runat="server" ID="lds"
            ContextTypeName="WebForms_1.DataAccess.PubsDataContext"
            EntityTypeName="WebForms_1.DataAccess.job"
            TableName="jobs">
        </asp:LinqDataSource>
        <asp:QueryExtender runat="server" ID="jobIDQueryFilter" TargetControlID="lds">
            <asp:RangeExpression DataField="job_id" MinType="Inclusive" MaxType="Inclusive">
                <asp:ControlParameter ControlID="minJobIDFilter" />
                <asp:ControlParameter ControlID="maxJobIDFilter" />
            </asp:RangeExpression>
            <asp:SearchExpression ComparisonType="InvariantCultureIgnoreCase" SearchType="Contains" DataFields="job_desc">
                <asp:ControlParameter ControlID="jobDescriptionFilter" />
            </asp:SearchExpression>
            <asp:PropertyExpression>
                <asp:ControlParameter Name="job_id" ControlID="availableJobIds" />
            </asp:PropertyExpression>
            <asp:CustomExpression OnQuerying="minLevelShowEvenValuesOnly_Querying">
                <asp:ControlParameter ControlID="showOnlyEvenValuesForMinValue" PropertyName="Checked" Name="applyFilter" />
            </asp:CustomExpression>
            <asp:MethodExpression MethodName="ApplyFilterByMethod">
                <asp:ControlParameter Name="applyFilterToMaxLevel" ControlID="showOnlyOddValuesForMinValue" PropertyName="Checked" />
            </asp:MethodExpression>
            <asp:OrderByExpression DataField="job_desc" Direction="Descending">
                <asp:ThenBy DataField="min_lvl" Direction="Ascending" />
                <asp:ThenBy DataField="max_lvl" Direction="Ascending" />
            </asp:OrderByExpression>
        </asp:QueryExtender>
        <table>
            <tr valign="top" style="border: thick double #800000">
                <th>
                    <asp:Panel runat="server" ID="jobDescriptionHeaderPanel" DefaultButton="applyJobDescriptionFilter">
                        <asp:Label AssociatedControlID="jobDescriptionFilter" Text="Job Description" runat="server" ID="jobDescriptionTitle" /><br />
                        <asp:TextBox runat="server" ID="jobDescriptionFilter"></asp:TextBox><br />
                        <asp:Button ID="applyJobDescriptionFilter" runat="server" style="display:none" />
                    </asp:Panel>
                </th>
                <th>
                    <asp:Panel runat="server" ID="jobIdHeaderPanel" DefaultButton="applyJobIDFilter">
                        <asp:Label AssociatedControlID="minJobIDFilter" Text="Min Job ID" runat="server" ID="minJobID" />
                        <asp:TextBox runat="server" ID="minJobIDFilter" MaxLength="2" /><br />
                        <asp:Label AssociatedControlID="maxJobIDFilter" Text="Max Job ID" runat="server" ID="maxJobID" />
                        <asp:TextBox runat="server" ID="maxJobIDFilter" MaxLength="2" /><br />
                        <asp:Button ID="applyJobIDFilter" runat="server" style="display:none" />
                        <asp:DropDownList runat="server" ID="availableJobIds" DataSourceID="lds" AutoPostBack="true"
                            DataTextField="job_id" DataValueField="job_id" AppendDataBoundItems="true">
                            <asp:ListItem Text="All..." Value="" />
                        </asp:DropDownList><br />
                    </asp:Panel>                
                </th>
                <th>
                    <asp:Panel runat="server" ID="minLevelHeaderPanel">
                        <asp:CheckBox Text="Show ONLY EVEN values" ID="showOnlyEvenValuesForMinValue" runat="server" Checked="false" AutoPostBack="true" /><br />
                    </asp:Panel>
                </th>
                <th>
                    <asp:Panel runat="server" ID="Panel1">
                        <asp:CheckBox Text="Show ONLY ODD values" ID="showOnlyOddValuesForMinValue" runat="server" Checked="false" AutoPostBack="true" /><br />
                    </asp:Panel>
                </th>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton Text="Reset" runat="server" ID="resetJobDescriptionFilter" OnClick="resetJobDescriptionFilter_Click" />
                </td>
                <td>
                    <asp:LinkButton Text="Reset" runat="server" ID="resetJobIdFilter" OnClick="resetJobIdFilter_Click" />
                </td>
                <td>
                    <asp:LinkButton Text="Reset" runat="server" ID="resetMinLevelFilter" OnClick="resetMinLevelFilter_Click" />
                </td>
                <td>
                    <asp:LinkButton Text="Reset" runat="server" ID="resetMaxLevelFilter" OnClick="resetMaxLevelFilter_Click" />
                </td>
            </tr>
                <asp:ListView runat="server" ID="lv"
                    DataSourceID="lds"
                    ClientIDMode="Predictable"
                    ClientIDRowSuffix="job_id">
                    <LayoutTemplate>
                        <tr runat="server" id="ItemPlaceholder"></tr>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr runat="server">
                            <td>
                                <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "job_desc") %>' runat="server" ID="jobDescription" />
                                <hr />
                            </td>
                            <td>
                                <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "job_id") %>' runat="server" ID="Label1" />
                                <hr />
                            </td>
                            <td>
                                <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "min_lvl") %>' runat="server" ID="Label2" />
                                <hr />
                            </td>
                            <td>
                                <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "max_lvl") %>' runat="server" ID="Label3" />
                                <hr />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            <tr>
                <td style="background-color:aqua" colspan="4">
                    <asp:DataPager runat="server" ID="dp" PagedControlID="lv">
                        <Fields>
                            <asp:NumericPagerField ButtonCount="3" />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
