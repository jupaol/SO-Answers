<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartialCaching_01.ascx.cs" Inherits="WebForms_1.Topics.OutputCaching.PartialCaching_01" %>
<%@ OutputCache Duration="5" VaryByParam="none" %>

UC1: (5 seconds in cache) <asp:Label ID="lbl" runat="server" /><br />