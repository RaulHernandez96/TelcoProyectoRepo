<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="TransferenciaCuentasPropias.aspx.cs" Inherits="main_TransferenciaCuentasPropias" %>

<asp:Content ID="_cMainContent" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Encabezado contenido --%>
  <section class="content-header">
    <h1>Transferencia entre cuentas propias</h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Operaciones</li>
      <li>Transferencias (propias)</li>
    </ol>
  </section>
  <%-- Fin encabezado --%>
  <%-- Cuerpo contenido --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <%-- Caja principal --%>
        <div class="box box-primary">
          <%-- Encabezado caja --%>
          <div class="box-header with-border">
            <h4 class="box-title">Transferencias</h4>
          </div>
          <%-- Fin encabezado caja --%>
          <%-- Cuerpo caja --%>
          <div class="box-body">
            <div class="row">
              <div class="col-xs-12">
                <%-- Tab --%>
                <div class="nav-tabs-custom">
                  <%-- Opciones para seleccionar --%>
                  <ul class="nav nav-tabs">
                    <li class="active"><a href="#Conten_Trans" data-toggle="tab">Transferencia</a></li>
                    <li><a href="#Conten_Calen" data-toggle="tab">Calendarizadas</a></li>
                  </ul>
                  <%-- Fin opciones para seleccionar --%>
                  <%-- Contenido del tab --%>
                  <div class="tab-content">
                    <%-- Transferencia --%>
                    <div class="tab-pane active" id="Conten_Trans">
                      <%-- Caja de transferencia --%>
                      <div class="row">
                        <div class="col-xs-12">
                          <div class="box box-warning">
                            <%-- Encabezado caja --%>
                            <div class="box-header with-border">
                              <h4 class="box-title">Paso 1 de 2</h4>
                            </div>
                            <%-- Fin encabezado caja --%>
                            <%-- Cuerpo caja --%>
                            <div class="box-body">
                              <%-- Primera fila --%>
                              <div class="row">
                                <div class="col-xs-4">
                                  <span class="text-bold">Cuenta de orgien</span><span class="text-bold text-danger">**</span>
                                </div>
                                <div class="col-xs-8">
                                  <asp:DropDownList ID="_dlCuentaOrigen" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                              </div>
                              <div class="row">
                                <div class="col-xs-12 col-lg-8 col-lg-offset-4">
                                  <asp:RequiredFieldValidator ID="_rfvValidaCuentaOrigen" ControlToValidate="_dlCuentaOrigen" 
                                    CssClass="text-bold text-danger" ErrorMessage="Debe seleccionar una cuenta de origen" 
                                    runat="server"></asp:RequiredFieldValidator>
                                </div>
                              </div>
                              <%-- Fin primera fila --%>
                              <%-- Segunda fila --%>
                              <div class="row">
                                <div class="col-xs-4">
                                  <span class="text-bold">Cuenta de destino</span><span class="text-bold text-danger">**</span>
                                </div>
                                <div class="col-xs-8">
                                  <asp:DropDownList ID="_dlCuentaDestino" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                              </div>
                              <div class="row">
                                <div class="col-xs-12 col-lg-8 col-lg-offset-4">
                                  <asp:RequiredFieldValidator ID="_rfvCuentaDestino" ControlToValidate="_dlCuentaDestino" 
                                    CssClass="text-bold text-danger" ErrorMessage="Debe seleccionar una cuenta de destino" 
                                    runat="server"></asp:RequiredFieldValidator>
                                </div>
                              </div>
                              <%-- Fin segunda fila --%>
                              <%-- Tercera fila --%>
                              <div class="row">
                                <div class="col-xs-4">
                                  <span class="text-bold">¿Calendarizar o programar transferencia?</span>
                                </div>
                                <div class="col-xs-4">
                                  <asp:DropDownList ID="_dlCalendarizarProgramas" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="0" Text="NO"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Calendarizar"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Programar"></asp:ListItem>
                                  </asp:DropDownList>
                                </div>
                              </div>
                              <br />
                              <%-- Fin tercera fila --%>
                              <%-- Cuerta fila --%>
                              <div class="row">
                                <div class="col-xs-4">
                                  <span class="text-bold">Monto a transferir</span><span class="text-bold text-danger">**</span>
                                </div>
                                <div class="col-xs-8">
                                  <asp:TextBox ID="_txMontoTransferir" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                              </div>
                              <div class="row">
                                <div class="col-xs-12 col-lg-8 col-lg-offset-4">
                                  <asp:RequiredFieldValidator ID="_rfvMontoTransferir" ControlToValidate="_txMontoTransferir" 
                                    CssClass="text-bold text-danger" ErrorMessage="Debe ingresar un monto valido para transferir" 
                                    runat="server"></asp:RequiredFieldValidator>
                                </div>
                              </div>
                              <%-- Fin cuarta fila --%>
                              <%-- Quinta fila --%>
                              <div class="row">
                                <div class="col-xs-4">
                                  <span class="text-bold">Descripción personalizada (opcional)</span>
                                </div>
                                <div class="col-xs-8">
                                  <asp:TextBox ID="_txDescripcionTrasnferir" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                              </div>
                              <%-- Fin quinta fila --%>
                            </div>
                            <%-- Fin cuerpo caja --%>
                            <%-- Pie de caja --%>
                            <div class="box-footer">
                              <div class="row">
                                <div class="col-xs-12 col-lg-2">
                                  <asp:Button ID="_btValidarTransferencia" Text="Validar" 
                                    CssClass="btn btn-primary col-xs-12" runat="server" />
                                </div>
                              </div>
                              <div class="row">
                                <div class="col-xs-12">
                                  <span class="text-bold text-danger">** Datos obligatorios</span>
                                </div>
                              </div>
                            </div>
                            <%-- Fin pie de caja --%>
                          </div>
                        </div>
                      </div>
                      <%-- Fin caja trasnferencia --%>
                    </div>
                    <%-- Fin transferencia --%>
                    <%-- Calendarizadas --%>
                    <div class="tab-pane" id="Conten_Calen">
                      Macion
                    </div>
                    <%-- Fin calendarizadas --%>
                  </div>
                  <%-- Fin contenido tab --%>
                </div>
                <%-- Fin tab --%>
              </div>
            </div>
            <%-- Mensaje usuario --%>
            <div class="row">
              <div class="col-xs-12">
                <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
              </div>
            </div>
            <%-- Fin mensaje usuario --%>
          </div>
          <%--Fin cuerpo caja--%>
        </div>
        <%-- Fin caja principal --%>
      </div>
    </div>
  </section>
  <%-- Fin cuerpo contenido --%>
</asp:Content>

