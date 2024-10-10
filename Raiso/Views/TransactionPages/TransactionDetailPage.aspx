<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="Raiso.Views.TransactionPages.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_TransactionDetail" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName"></asp:BoundField>
        <asp:BoundField DataField="StationeryPrice" HeaderText="Stationery Price" SortExpression="StationeryPrice"></asp:BoundField>
        <asp:BoundField DataField="Quantity" HeaderText="Quantity Bought" SortExpression="Quantity"></asp:BoundField>
    </Columns>

</asp:GridView>

</asp:Content>
