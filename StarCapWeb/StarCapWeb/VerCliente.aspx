﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerCliente.aspx.cs" Inherits="StarCapWeb.VerCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Clientes</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" ID="grillaCliente"
                        AutoGenerateColumns="false"
                        OnRowCommand="grillaCliente_RowCommand"
                        EmptyDataText="No hay clientes">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="Rut del Cliente" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre del Cliente" />
                            <asp:BoundField DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="BebidaFavorita.Nombre" HeaderText="Favorita" />
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:Button CommandName="eliminar" CommandArgument=´<%# Eval("Rut") %>´ runat="server" CssClass="btn bg-danger" Text="Eliminar" />
                     </ItemTemplate>
                 </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
