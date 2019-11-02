<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="transferenciaAch.aspx.cs" Inherits="ach_transferenciaAch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Transferencia ACH</h1>
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
                        <h3 class="box-title">Transferencia ACH
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
                                            <div class="col-xs-4">
                                                <span class="text-bold">Cuenta de origen</span><span class="text-bold text-danger">**</span>
                                            </div>
                                            <div class="col-xs-8">
                                                <asp:DropDownList ID="cboCuentaOrigen" CssClass="form-control" runat="server" OnSelectedIndexChanged="cboCuentaOrigen_SelectedIndexChanged"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-4">
                                                <span class="text-bold">Cuenta de destino</span><span class="text-bold text-danger">**</span>
                                            </div>
                                            <div class="col-xs-8">
                                                <asp:DropDownList ID="cboCuentaDestino" CssClass="form-control" runat="server"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-4">
                                                <span class="text-bold">Monto</span><span class="text-bold text-danger">**</span>
                                            </div>
                                            <div class="col-xs-4">
                                                <asp:TextBox ID="txtMonto" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-4">
                                                <span class="text-bold">Moneda</span><span class="text-bold text-danger">**</span>
                                            </div>
                                            <div class="col-xs-8">
                                                <asp:DropDownList ID="cboMoneda" CssClass="form-control" runat="server"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-4">
                                                <span class="text-bold">Descripcion</span>
                                            </div>
                                            <div class="col-xs-4">
                                                <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-xs-6">
                                                <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-default" Text="Realizar transferencia" OnClick="btnAgregar_Click" />
                                            </div>
                                        </div>
                                        <br />
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

