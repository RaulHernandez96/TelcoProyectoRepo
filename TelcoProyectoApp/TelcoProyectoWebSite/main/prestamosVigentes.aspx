<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="prestamosVigentes.aspx.cs" Inherits="main_prestamosVigentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Prestamos vigentes</h1>
        <small><b>Info</b>Bancos</small>
       <%-- <ol class="breadcrumb">
            <li>Inicio</li>
            <li>Productos</li>
            <li>Cuentas</li>
        </ol>--%>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h3 class="box-title">Prestamos vigentes
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
                                        <h4 class="box-title text-bold">Prestamos vigentes</h4>
                                    </div>
                                    <div class="box-body">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <asp:GridView ID="grdPrestamosVigentes" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
                                                    <Columns>
                                                        <asp:BoundField DataField="montoAutorizado" HeaderText="Monto autorizado" />
                                                        <asp:BoundField DataField="fechaAutorizacion" HeaderText="Fecha Autorizacion" />
                                                        <asp:BoundField DataField="saldo_pendiente" HeaderText="Saldo pendiente" />
                                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                                    </Columns>
                                                </asp:GridView>
                                            </div>
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

