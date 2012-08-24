<%@ Control Language="C#" CodeBehind="MyCustomFieldTemplate.ascx.cs" Inherits="DynamicDataLinq.DynamicData.FieldTemplates.MyCustomFieldTemplate" %>

<div style="background-color:lightcyan"><asp:Label runat="server" ID="Literal1" Text="<%# FieldValueString %>" /></div>
