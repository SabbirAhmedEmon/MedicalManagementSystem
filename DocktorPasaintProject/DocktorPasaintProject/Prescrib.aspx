<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prescrib.aspx.cs" Inherits="DocktorPasaint.Prescrib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 164px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
DR. moklas
</h1>

    <table style="width:50%;">
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="MEDICIN NAME"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMedicinName" runat="server" Height="104px" Width="297px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:TextBox ID="txtMadisinD" runat="server" Height="104px" Width="297px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSubmitt" runat="server" Text="Submitt" 
                    onclick="btnSubmitt_Click" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="lbl1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
      DR MOKLAS
     <br/>
    MMBS,FCPS,MD,PhD.<br/>
    prf at matha vanga.<br/>
    agdum bagdum.<br/>
</asp:Content>
