<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Header/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="Raiso.Views.TransactionPages.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>Transaction History</div>
    <asp:GridView ID="GV_trHistory" runat="server" OnRowEditing="GV_trHistory_RowEditing" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
        <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundField>
        <asp:BoundField DataField="UserName" HeaderText="CustomerName" SortExpression="UserName"></asp:BoundField>
        

        <asp:TemplateField HeaderText="Details">
            <ItemTemplate>
                <asp:Button ID="Btn_Detail" runat="server" Text="Transaction Detail" CommandName="Edit" UseSubmitBehavior="false"/>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
