<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Escuela.aspx.cs" Inherits="Cliente_CSharp.Escuela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consulta a la tabla Escuela</h1>
    <br />
    <p>Consultar: <asp:TextBox runat="server" Id="txtTexto"/>
    <asp:DropDownList runat="server">
        <asp:ListItem Text="CodEscuela" />
        <asp:ListItem Text="text2" />
    </asp:DropDownList>
    <asp:Button Text="Buscar" runat="server" Id="btnBuscar"/>
    </p>
    <p>
        <asp:GridView runat="server" Id ="gvEscuela" OnSelectedIndexChanged="gvEscuela_SelectedIndexChanged">
        </asp:GridView>
    </p>
</asp:Content>
