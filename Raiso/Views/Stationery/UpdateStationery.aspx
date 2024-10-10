<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateStationery.aspx.cs" Inherits="Raiso.Views.Stationery.UpdateStationery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Lbl_OldName" runat="server" Text="Old Name : "></asp:Label>
        <asp:TextBox ID="TBox_OldName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_OldPrice" runat="server" Text="Old Price : "></asp:Label>
        <asp:TextBox ID="TBox_OldPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Update Name : "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Update Price : "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click"/>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
