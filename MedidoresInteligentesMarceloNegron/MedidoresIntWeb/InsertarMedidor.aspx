<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="InsertarMedidor.aspx.cs" Inherits="MedidoresIntWeb.InsertarMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <div class="form-group">
            <asp:Label for="nroMedidor" runat="server"> Numero del Medidor</asp:Label>
            <asp:TextBox ID="nrMedidor" runat="server" CssClass="form-control" Placeholder="Ingresa numero del medidor"> </asp:TextBox>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="fechaMedidor" runat="server"> Fecha</asp:Label>
            <asp:Calendar ID="fechaMedidor" runat="server" CssClass="form-control"></asp:Calendar>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="valorConsumoMedidor" runat="server"> valor de consumo</asp:Label>
            <asp:TextBox ID="valorConsumoMedidor" runat="server" CssClass="form-control" Placeholder="Ingresa valor de consumo"> </asp:TextBox>
        </div>
    </div>
    <div>
        <div class="form-group">
            <asp:Label for="tipMedidor" runat="server"> Tipo del Medidor</asp:Label>
            <asp:RadioButtonList runat="server" ID="tipMedidor" CssClass=" form-control">
                <asp:ListItem Selected="True" Value="Monofásicos" Text="Monofásicos"></asp:ListItem>
                <asp:ListItem Value="Bifásicos" Text="Bifásicos"></asp:ListItem>
                <asp:ListItem Value="Trifásicos" Text="Trifásicos"></asp:ListItem>
                <asp:ListItem Value="Para conexion semi-directa e indirecta" Text="Para conexion semi-directa e indirecta"></asp:ListItem>
                <asp:ListItem Value="Bidireccionales" Text="Bidireccionales"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>

    <div>
        <div class="form-group">
            <asp:Button runat="server" ID="InsertMed" OnClick="InsertMed_Click"
                Text="Insertar Medidor" CssClass=" btn btn-primary btn-lg" />
        </div>
    </div>

</asp:Content>
