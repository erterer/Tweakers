<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorien.aspx.cs" Inherits="Tweakers.Categorien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="row">
        <div class="col-md-6">
            <h2>Smartphones</h2>
            <a href="Smartphones.aspx"><img src="Resources/Smartphones.jpeg" class="img-rounded" width="512" heigth="512"></a>
        </div>
        <div class="col-md-6">
            <h2>Tablets</h2>
            <a href="Tablets.aspx"><img src="Resources/Tablets.jpeg" class="img-rounded" width="320" heigth="320"></a> 
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-6">
            <h2>Koelkasten</h2>
            <a href="Koelkasten.aspx"><img src="Resources/Koelkasten.jpeg" class="img-rounded" width="320" heigth="320"></a>
        </div>
        <div class="col-md-6">
            <h2>Wasmachines</h2>
            <a href="Wasmachines.aspx"><img src="Resources/Wasmachines.jpeg" class="img-rounded" width="320" heigth="320"></a> 
        </div>
    </div>
</asp:Content>
