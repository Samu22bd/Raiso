<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="PageCart.aspx.cs" Inherits="Raiso.Views.CartPages.PageCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_CartList" runat="server" OnRowUpdating="GV_CartList_RowUpdating" OnRowDeleting="GV_CartList_RowDeleting" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="ID" SortExpression="StationeryID"></asp:BoundField>
            <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"></asp:BoundField>
            <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="StationeryQuantity"></asp:BoundField>

            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="Btn_Update" runat="server" Text="Update" CommandName="Update" UseSubmitBehavior="false"/>
                    <asp:Button ID="Btn_Delete" runat="server" Text="Delete" CommandName="Delete" UseSubmitBehavior="false" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>

    <asp:Button ID="Btn_CheckOut" runat="server" Text="Check Out" OnClick="Btn_CheckOut_Click"/>
</asp:Content>
