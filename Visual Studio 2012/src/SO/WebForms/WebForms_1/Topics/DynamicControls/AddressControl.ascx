<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressControl.ascx.cs" Inherits="WebForms_1.Topics.DynamicControls.AddressControl" %>

<asp:Label Text="City" runat="server" Font-Bold="true" />
<br />
<asp:TextBox runat="server" ID="txt"></asp:TextBox>
<asp:Button Text="Process" runat="server" ID="process" OnClick="process_Click" />
<br />
City: <asp:Label runat="server" ID="lbl"></asp:Label>