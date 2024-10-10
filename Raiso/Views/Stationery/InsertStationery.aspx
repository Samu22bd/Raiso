<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertStationery.aspx.cs" Inherits="Raiso.Views.Stationery.InsertStationery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Stationery Name : "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Stationery Price : "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click"/>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
