<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasaintSerial.aspx.cs" Inherits="DocktorPasaintProject.PasaintSerial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width:50%;">
        <tr>
            <td class="style1">
                <asp:Label ID="lblPasaintSerial" runat="server" Text="Pasaint Serial"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPasaintSerial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" 
                    onclick="btnSearch_Click"/>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Pasaint Name</td>
            <td>
                <asp:Label ID="lblPasaintName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Pasaint Genger</td>
            <td>
                <asp:Label ID="lblPasaintGender" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Pasaint Address</td>
            <td>
                <asp:Label ID="lblPasaintAddress" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Pasaint Phone number</td>
            <td>
                <asp:Label ID="lblpasaintPhoneNumber" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Pasaint Serial Number</td>
            <td>
                <asp:Label ID="lblPasaintSerialNumber" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
