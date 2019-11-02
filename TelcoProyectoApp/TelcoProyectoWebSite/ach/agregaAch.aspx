<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="agregaAch.aspx.cs" Inherits="ach_agregaAch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Agrega Ach</h1>
        <small><b>Info</b>Bancos</small>
        <ol class="breadcrumb">
            <li>Inicio</li>
            <li>Productos</li>
            <li>Cuentas</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h3 class="box-title">Asociar cuenta
                        </h3>
                    </div>
                    <%-- Despliege de la información --%>
                    <div class="box-body">
                        <%-- Primera fila --%>
                        <div class="row">
                            <%-- Relleno --%>
                            <div class="col-xs-10 col-lg-1"></div>
                            <%-- Fin relleno --%>
                            <%-- Información general de la cuenta --%>
                            <div class="col-xs-10 col-lg-10">
                                <div class="box box-info">
                                    <div class="box-header with-border">
                                        <h4 class="box-title text-bold">Datos cuenta</h4>
                                    </div>
                                    <div class="box-body">
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <span>Número cuenta IBAN:</span>
                                            </div>
                                            <div class="col-xs-3">
                                                <asp:TextBox ID="txtNumCuenta" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <span>Nombre cuenta:</span>
                                            </div>
                                            <div class="col-xs-3">
                                                <asp:TextBox ID="txtNombreCuenta" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <span>Descripción cuenta:</span>
                                            </div>
                                            <div class="col-xs-3">
                                                <asp:TextBox ID="txtDesCuenta" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-lg-3">
                                                <asp:Button ID="btnAgregaCuenta" runat="server" Text="Agregar cuenta" CssClass="btn btn-default" OnClick="btnAgregaCuenta_Click" />
                                            </div>
                                            <%--error--%>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-lg-6">
                                                <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
                                            </div>
                                            <%--error--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
</asp:Content>

