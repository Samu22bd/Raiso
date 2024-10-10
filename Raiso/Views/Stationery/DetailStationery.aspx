<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="DetailStationery.aspx.cs" Inherits="Raiso.Views.Stationery.DetailStationery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Update Name : "></asp:Label>
        <asp:Label ID="StatName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Update Price : "></asp:Label>
        <asp:Label ID="StatPrice" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="TBox_Quantity" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_AddToCart" runat="server" Text="Add to Cart" OnClick="Btn_AddToCart_Click"/>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
