<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasaintEntry.aspx.cs" Inherits="DocktorPasaintProject.PasaintEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 21px;
        }
        .style2
        {
            height: 21px;
            width: 142px;
        }
        .style3
        {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:50%;">
        <tr>
            <td class="style2">
                Pasaint Name</td>
            <td class="style1">
                <asp:TextBox ID="txtPName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Pasaint Gender</td>
            <td>
                <asp:TextBox ID="txtPGender" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Pasaint Address</td>
            <td>
                <asp:TextBox ID="txtPAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Pasaint phone number</td>
            <td>
                <asp:TextBox ID="txtPPhnNmbr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Pasaint serial</td>
            <td>
                <asp:TextBox ID="txtPSerial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSubmitt" runat="server" Text="Submitt" 
                    onclick="btnSubmitt_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblSucesMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
