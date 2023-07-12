<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresIntWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        
        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
            Text="Insertar Medidor" CssClass=" btn btn-primary btn-lg" />
        <asp:Button runat="server" ID="lecbtn" OnClick="lecbtn_Click"
            Text="Insertar Lectura" CssClass=" btn btn-primary btn-lg" />
    </div>
        

</asp:Content>
