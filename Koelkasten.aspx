<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Koelkasten.aspx.cs" Inherits="Tweakers.Koelkasten" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <h1>Koelkasten:</h1>
    <asp:Table ID="TableKoelkasten" class="table" runat="server">
        <asp:TableHeaderRow ID="TableHeaderRow1" runat="server">
        <asp:TableHeaderCell ID="TableHeaderCell1" runat="server">Naam</asp:TableHeaderCell>
        <asp:TableHeaderCell ID="TableHeaderCell2" runat="server">Uitvoering</asp:TableHeaderCell>
        <asp:TableHeaderCell ID="TableHeaderCell3" runat="server">Kleur</asp:TableHeaderCell>
        <asp:TableHeaderCell ID="TableHeaderCell4" runat="server">Meer info</asp:TableHeaderCell>
    </asp:TableHeaderRow>
    </asp:Table>
    <br /> 
</asp:Content>
