<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Raiso.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_StationeryList" runat="server" OnSelectedIndexChanged="Selecting_Click" OnRowDeleting="Deleting_Click" AutoGenerateColumns="False" OnRowUpdating="Updating_Click">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="ID" SortExpression="StationeryID"></asp:BoundField>
            <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"></asp:BoundField>
            <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice"></asp:BoundField>
            
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Select"></asp:CommandField>
            <asp:ButtonField CommandName="Update" Text="Update" ButtonType="Button" ShowHeader="True" HeaderText="Update"></asp:ButtonField>
            <asp:ButtonField CommandName="Delete" Text="Delete" ButtonType="Button" ShowHeader="True" HeaderText="Delete"></asp:ButtonField>
        </Columns>
    </asp:GridView>

    <asp:Button ID="Btn_Insert" runat="server" Text="Insert Stationery" OnClick="Btn_Insert_Click"/>
    <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
</asp:Content>
