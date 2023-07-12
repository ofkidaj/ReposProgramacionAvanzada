<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresIntWeb.MostrarLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:GridView CssClass="table table-hover table-bordered" runat="server" ID="GrillaLecturas" AutoGenerateColumns="false"
            OnRowCommand="GrillaLecturas_RowCommand"
            EmptyDataText="No hay Lecturas">
            <Columns>
                <asp:BoundField DataField="NroMedidor" HeaderText="Numero de Medidor" />
                <asp:BoundField DataField="FechaMedidor" HeaderText="fecha del Medidor" />
                <asp:BoundField DataField="ValorConsumoMedidor" HeaderText="Valor de consumo" />
                <asp:BoundField DataField="TipoMedidor" HeaderText="Tipo del Medidor" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
