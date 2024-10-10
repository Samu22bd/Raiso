<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Raiso.Views.UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <title>Update Profile</title>
    <div>
        <div>
            <asp:Label ID="Lbl_Name" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Date" runat="server" Text="DOB : "></asp:Label>
            <asp:TextBox ID="Tbox_dob" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Gender" runat="server" Text="Gender : "></asp:Label>
            <asp:RadioButtonList ID="GenderRadioButton" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Lbl_Address" runat="server" Text="Address : "></asp:Label>
            <asp:TextBox ID="TBox_Address" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Password" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="TBox_Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Phone" runat="server" Text="Phone : "></asp:Label>
            <asp:TextBox ID="TBox_Phone" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Btn_Update" runat="server" Text="Update Profile" OnClick="Btn_Update_Click" />
            <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
