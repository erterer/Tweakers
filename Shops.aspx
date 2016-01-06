<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shops.aspx.cs" Inherits="Tweakers.Shops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <h1>Beschikbare winkels:</h1>
    <asp:Table ID="Table1" class="table" runat="server"></asp:Table>
    <br />
    <div class="row">
        <div class="col-md-6">
            <asp:TextBox ID="tb_NewShop" class="form-group" runat="server"></asp:TextBox>
            <asp:Button ID="btn_ShopToevoegen" class="btn btn-default" runat="server" Text="Shop Toevoegen" OnClick="btn_ShopToevoegen_Click" />
        </div>
        <div class="col-md-6">
            <asp:DropDownList ID="ddl_Shops" class="dropdown" runat="server"></asp:DropDownList>
            <asp:Button ID="btn_ShopVerijderen" class="btn btn-default" runat="server" Text="Shop Verwijderen" OnClick="btn_ShopVerijderen_Click" />
        </div>
    </div>    
</asp:Content>
