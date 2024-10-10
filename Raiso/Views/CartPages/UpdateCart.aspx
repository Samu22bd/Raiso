<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="Raiso.Views.CartPages.UpdateCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Stationery Name :"></asp:Label>
        <asp:Label ID="Lbl_StatName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Stationery Price :"></asp:Label>
        <asp:Label ID="Lbl_StatPrice" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity :"></asp:Label>
        <asp:TextBox ID="TBox_Quantity" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
    <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
</asp:Content>
