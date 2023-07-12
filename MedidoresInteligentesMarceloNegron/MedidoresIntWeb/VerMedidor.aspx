<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="MedidoresIntWeb.VerMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView CssClass="table table-hover table-bordered" runat="server" ID="GrillaMedidor" AutoGenerateColumns="false"
            OnRowCommand="GrillaMedidor_RowCommand"
            EmptyDataText="No hay Medidores">
            <Columns>
                <asp:BoundField DataField="NroMedidor" HeaderText="Numero de Medidor" />
                <asp:BoundField DataField="FechaMedidor" HeaderText="fecha del Medidor" />
                <asp:BoundField DataField="ValorConsumoMedidor" HeaderText="Valor de consumo" />
                <asp:BoundField DataField="TipoMedidor" HeaderText="Tipo del Medidor" />
            </Columns>

        </asp:GridView>

    </div>

</asp:Content>
