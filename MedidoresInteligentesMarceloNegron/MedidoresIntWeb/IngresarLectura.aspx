<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresIntWeb.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="form-group">
            <asp:Label for="medidor" runat="server" > Numero del Medidor</asp:Label>
            <asp:DropDownList ID="med" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="fechaMedidor" runat="server" > Fecha</asp:Label>
            <asp:Calendar ID="fechaMedidor" runat="server" CssClass="form-control" > </asp:Calendar>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="valorConsumoLectura" runat="server" > valor de consumo</asp:Label>
            <asp:TextBox ID="valorConsumoLectura" runat="server" CssClass="form-control" Placeholder="Ingresa el valor del consumo"> </asp:TextBox>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="Hora" runat="server" > Hora de lectura</asp:Label>
                    <asp:TextBox ID="hora" runat="server" CssClass="form-control" Placeholder="Hora"> </asp:TextBox>
                    <asp:TextBox ID="minuto" runat="server" CssClass="form-control" Placeholder="Minutos"> </asp:TextBox>
        </div>
    </div>

    <div>
        <div class="form-group">
            <asp:Button runat="server" ID="InsertLect" OnClick="InsertLect_Click"
                        Text="Insertar Lectura" CssClass=" btn btn-primary btn-lg" />
        </div>
    </div>
</asp:Content>
