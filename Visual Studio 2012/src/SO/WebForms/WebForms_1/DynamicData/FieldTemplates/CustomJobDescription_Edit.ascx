<%@ Control Language="C#" CodeBehind="CustomJobDescription_Edit.ascx.cs" Inherits="WebForms_1.DynamicData.FieldTemplates.CustomJobDescription_EditField" %>

<asp:TextBox ID="TextBox1" runat="server" Text='<%# FieldValueEditString %>'></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBox1" Display="Dynamic" />
<asp:CustomValidator runat="server" ID="cv" ControlToValidate="TextBox1" Display="Dynamic" Text="=p" ErrorMessage="This custom validation returns 'true' randomly, keep trying" OnServerValidate="cv_ServerValidate"></asp:CustomValidator>