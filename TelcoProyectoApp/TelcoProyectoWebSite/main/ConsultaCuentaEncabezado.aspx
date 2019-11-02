<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="ConsultaCuentaEncabezado.aspx.cs" Inherits="main_ConsultaCuentaEncabezado" %>

<asp:Content ID="_mainContent" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Encabezado del contendo --%>
  <section class="content-header">
    <h1>Consulta de cuenta 
      <b>
        <%= _obConsultaCuentaEncabezado != null 
          ? _obConsultaCuentaEncabezado.Cuenta != null
          ? _obConsultaCuentaEncabezado.Cuenta.TipoCuenta : "##N/A##" : "##N/A##" %> 
      </b>
      ( <b>
          <%= _obConsultaCuentaEncabezado != null 
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.NumeroCuenta : "##N/A##" : "##N/A##" %> 
        </b>)</h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Productos</li>
      <li>Cuentas</li>
    </ol>
  </section>
  <%-- Fin del encabezado --%>
  <%-- Cuerto del contenido --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <div class="box box-primary">
          <div class="box-header with-border">
            <h3 class="box-title">Propietario: 
              <%= _obConsultaCuentaEncabezado != null 
                  ? _obConsultaCuentaEncabezado.Cuenta != null
                  ? _obConsultaCuentaEncabezado.Cuenta.Propietario : "##N/A##" : "##N/A##" %>
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
              <div class="col-xs-10 col-lg-5">
                <div class="box box-info">
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Información general</h4>
                  </div>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Propietario:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbPropietarioCuenta" runat="server">Ejemplo de propietario</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Tipo de cuenta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbTipoCuenta" runat="server">Ejemplo tipo de cuenta</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Tipo de moneda:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbTipoMoneda" runat="server">Ejemplo tipo de moneda</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Fecha de creación:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbFechaCreacion" runat="server">Ejemplo fecha de creación</asp:Label>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <%-- Fin de información general --%>
              <%-- Información de saldo de la cuenta --%>
              <div class="col-xs-10 col-lg-5">
                <div class="box box-info">
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Saldo</h4>
                  </div>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo disponible:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoDisponible" runat="server">Ejemplo saldo disponible</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo en efectivo:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoEfectivo" runat="server">Ejemplo saldo en efectivo</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo en cheques:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoCheques" runat="server">Ejemplo saldo en cheques</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo en reserva:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoReserva" runat="server">Ejemplo saldo en reserva</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo contable:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoContable" runat="server">Ejemplo saldo contable</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo inicial:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoInicial" runat="server">Ejemplo saldo inicial</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Intereses del mes:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbInteresesMes" runat="server">Ejemplo intereses del mes</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Depósitos ATM:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbDepositosATM" runat="server">Ejemplo depositos ATM</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Saldo bloqueado:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSaldoBloqueado" runat="server">Ejemplo saldo bloqueado</asp:Label>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <%-- Fin información de saldo --%>
              <%-- Relleno --%>
              <div class="col-xs-10 col-lg-1"></div>
              <%-- Fin relleno --%>
            </div>
            <%-- Fin primera fila --%>
            <%-- Segunda fila --%>
            <div class="row">
              <%-- Relleno --%>
              <div class="col-xs-10 col-lg-1"></div>
              <%-- Fin relleno --%>
              <%-- Información reserva --%>
              <div class="col-xs-10 col-lg-5">
                <div class="box box-info">
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Reserva</h4>
                  </div>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-4">
                        <span>24 Horas:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lb24Horas" runat="server">Ejemplo 24 horas</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>48 Horas:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lb48Horas" runat="server">Ejemplo 48 horas</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>72 Horas:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lb72Horas" runat="server">Ejemplo 72 horas</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Giros exterior:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbGirosExterior" runat="server">Ejemplo giros exterior</asp:Label>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <%-- Fin información reserva --%>
              <%-- Información sobre giros --%>
              <div class="col-xs-10 col-lg-5">
                <div class="box box-info">
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Sobregiros</h4>
                  </div>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Intereses x Sobreg.:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbInteresesSobregiro" runat="server">Ejemplo intereses sobregiro</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Sobreg. Autorizado:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSobregiroAutorizado" runat="server">Ejemplo sobregiro autorizado</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Tasa sobregiro:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbTasaSobregiro" runat="server">Ejemplo tasa sobregiro</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Int. Sobreg. Acum.:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbIntereseSobregiroAcumulado" runat="server">Ejemplo intereses sobregiro acumulado</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Expira. de Sobreg.:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbExpiracionSobregiro" runat="server">Ejemplo expiración sobregiro</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Sobreg. Disponible:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="_lbSobregiroDisponible" runat="server">Ejemplo sobregiro disponible</asp:Label>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <%-- Fin información sobre giros --%>
              <%-- Relleno --%>
              <div class="col-xs-10 col-lg-1"></div>
              <%-- Fin relleno --%>
            </div>
            <%-- Fin segunda fila --%>
            <%-- Tercera fila --%>
            <div class="row">
              <%-- Relleno --%>
              <div class="col-xs-10 col-lg-1"></div>
              <%-- Fin relleno --%>
              <%-- Boton ver estado de cuenta --%>
              <div class="col-xs-10 col-lg-4">
                <asp:Button ID="_btVerEstadoCuenta" CssClass="btn btn-primary col-xs-12 text-bold" 
                  Text="Ver estado de cuenta" runat="server" OnClick="OnClicVerEstadoCuenta" />
              </div>
              <%-- Fin boton ver estado de cuenta --%>
            </div>
            <%-- Fin tercera fila --%>
            <br />
            <%-- Cuarta fila --%>
            <%-- Despliege mensaje a usuario --%>
            <div class="row">
              <div class="col-xs-12">
                <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
              </div>
            </div>
            <%-- Fin despliege mensaje a usaurio --%>
            <%-- Fin cuarta fila --%>
          </div>
          <%-- Fin del despliege --%>
        </div>
      </div>
    </div>
  </section>
  <%-- Fin del cuerpo --%>
</asp:Content>

