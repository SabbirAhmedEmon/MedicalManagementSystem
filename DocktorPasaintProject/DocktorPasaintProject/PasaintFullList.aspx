<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasaintFullList.aspx.cs" Inherits="DocktorPasaintProject.PasaintFullList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="776px">
        <Columns>
            <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblID" Text='<%#Bind("Id") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Pasaint Name">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblName" Text='<%#Bind("Name") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Pasaint Gender">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblPasaintGender" Text='<%#Bind("Gender") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Pasaint Address">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblPasaintAddress" Text='<%#Bind("Address") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Pasaint Phone Number">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblPasaintPhoneNumber" Text='<%#Bind("Phnnmbr") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Pasaint Serial">
            <ItemTemplate>
            <asp:Label runat="server" ID="lblPasaintSerial" Text='<%#Bind("Serial") %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
