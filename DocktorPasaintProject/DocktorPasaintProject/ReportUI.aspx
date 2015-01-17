
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportUI.aspx.cs" Inherits="DocktorPasaintProject.ReportUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:Button runat="server" ID="btnReport" Text="Report" 
        onclick="btnReport_Click" BackColor="#6600CC" />
</asp:Content>
