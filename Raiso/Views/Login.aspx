<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raiso.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Password" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="TBox_Password" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        <asp:Label ID="Lbl_RememberMe" runat="server" Text="Remember Me :"></asp:Label>
        <asp:CheckBox ID="Check_RememberMe" runat="server" />
        <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click" />
    </div>
    <div>
        <asp:LinkButton ID="LinkBtn_Register" runat="server" OnClick="LinkBtn_Register_Click">Doesn't have account? Register here</asp:LinkButton>
    </div>
</div>
</asp:Content>
