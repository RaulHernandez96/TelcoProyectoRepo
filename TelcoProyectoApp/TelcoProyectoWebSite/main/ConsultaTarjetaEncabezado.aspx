<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="ConsultaTarjetaEncabezado.aspx.cs" Inherits="main_ConsultaTarjetaEncabezado" %>

<asp:Content ID="_mainContent" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Section de encabezado --%>
  <section class="content-header">
    <h1>Consulta de tarjeta
      <b>{{ _tipoTarjeta }}</b>
      (<b>
        {{ _numeroTarjeta }}
       </b>)
    </h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Productos</li>
      <li>Tarjetas</li>
    </ol>
  </section>
  <%-- Fin seccion encabezado --%>
  <%-- Section cuerpo contenido --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <%-- Caja principal --%>
        <div class="box box-primary">
          <%-- Encabezado de la caja --%>
          <div class="box-header with-border">
            <h4 class="box-title">Propietario: {{ _propietarioTarjeta }}</h4>
          </div>
          <%-- Fin encabezado de la caja --%>
          <%-- Cuerpo de la caja --%>
          <div class="box-body">
            <%-- Primera fila --%>
            <div class="row">
              <div class="col-xs-12 col-lg-6">
                <%-- Caja Información general --%>
                <div class="box box-info">
                  <%-- Encabejado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Información general</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Propietario tarjeta:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbPropietarioTarjeta" runat="server">Ejemplo propietario</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Proveedor:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbProveedorTarjeta" runat="server">Ejemplo proveedor tarjeta</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Número tarjeta:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbNumeroTarjeta" runat="server">Ejemplo número de tarjeta</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Nombre tarjeta:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbNombreTarjeta" runat="server">Ejemplo nombre tarjeta</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Fecha creación:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbFechaCreacion" runat="server">Ejemplo fecha creación</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Fecha vencimiento:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbFechaVencimiento" runat="server">Ejemplo fecha vencimiento</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Fecha límite de pago:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbFechaLimitePago" runat="server">Ejemplo fecha limite pago</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-5">
                        <span>Puntos acumulados:</span>
                      </div>
                      <div class="col-xs-7">
                        <asp:Label ID="_lbPuntosAcumulados" runat="server">Ejemplo puntos acumulados</asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
                <%-- Fin caja información general --%>
              </div>
            </div>
            <%-- Fin primera fila --%>
            <%-- Segunda fila (info de saldos) --%>
            <div class="row">
              <%-- Caja de saldos --%>
              <div class="col-xs-12 col-lg-4">
                <div class="box box-info">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Información de saldos</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Saldo actual:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Saldo anterior:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Límite de crédito:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Saldo al corte:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Disponible:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Valor flotante:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Extra financiamiento:</span>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja de saldos --%>
              <%-- Caja saldos quetzales --%>
              <div class="col-xs-12 col-lg-4">
                <div class="box box-info">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Quetzales</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body text-right">
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoAcutalQgt" runat="server">Ejemplo saldo actual QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoAnteriorQgt" runat="server">Ejemplo saldo anterior QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbLimiteCreditoQgt" runat="server">Ejemplo límite crédito QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoAlCorteQgt" runat="server">Ejemplo saldo al corte QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbDisponibleQgt" runat="server">Ejemplo disponible QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorFlotanteQgt" runat="server">Ejemplo valor flotante QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbExtraFinanciamientoQgt" runat="server">Ejemplo extra financiamiento QGT</asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja saldos quetzales --%>
              <%-- Caja saldos dolares --%>
              <div class="col-xs-4">
                <div class="box box-info">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Dolares</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body text-right">
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoActualUsa" runat="server">Ejemplo sado actual USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoAnteriorUsa" runat="server">Ejemplo saldo anterior USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbLimiteCreditoUsa" runat="server">Ejemplo límite crédito USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbSaldoAlCorteUsa" runat="server">Ejemplo saldo al corte USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbDisponibleUsa" runat="server">Ejemplo disponible USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorFlotanteUsa" runat="server">Ejemplo valor flotante USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbExtraFinanciamientoUsa" runat="server">Ejemplo extraFinanciamiento USA</asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja saldos dolares --%>
            </div>
            <%-- Fin segunda fila --%>
            <%-- Tercera fila (info pagos) --%>
            <div class="row">
              <%-- Caja informacion pagos --%>
              <div class="col-xs-4">
                <div class="box box-info">
                  <%-- Encabezdo caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Información de pagos</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Pago de contado:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Pago mínimo:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Pagos y créditos:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Fecha Ult. compra:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Fecha Ult. pago:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Compras y débitos:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Valor Ult. compra:</span>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <span>Valor Ult. pago:</span>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja informacion pagos --%>
              <%-- Caja pagos quetzales --%>
              <div class="col-xs-4">
                <div class="box box-info">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Quetzales</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body text-right">
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagoContadoQgt" runat="server">Ejemplo pago contado QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagoMinimoQgt" runat="server">Ejemplo pago mínimo QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagosCreditosQgt" runat="server">Ejemplo pagos y créditos QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbFechaUltimaCompraQgt" runat="server">Ejemplo fecha ultima compra QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbFechaUltimoPagoQgt" runat="server">Ejemplo fecha ultimo pago QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbComprasDebitosQgt" runat="server">Ejemplo compras y débitos QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorUltimaCompraQgt" runat="server">Ejemplo valor ultima compra QGT</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorUltimoPagoQgt" runat="server">Ejemplo valor ultimo pago QGT</asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja pagos quetzales --%>
              <%-- Caja pagos dolares --%>
              <div class="col-xs-4">
                <div class="box box-info">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title text-bold">Dolares</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body text-right">
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagoContadoUsa" runat="server">Ejemplo pago contado USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagoMinimoUsa" runat="server">Ejemplo pago mínimo USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbPagosCreditosUsa" runat="server">Ejemplo pagos y créditos USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbFechaUltimaCompraUsa" runat="server">Ejemplo fecha ultima compra USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbFechaUltimoPagoUsa" runat="server">Ejemplo fecha ultimo pago USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbComprasDebitosUsa" runat="server">Ejemplo compras y débitos USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorUltimaCompaUsa" runat="server">Ejemplo valor ultima compra USA</asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Label ID="_lbValorUltimoPagoUsa" runat="server">Ejemplo valor ultimo pago USA</asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
              <%-- Fin caja pagos dolares --%>
            </div>
            <%-- Fin tercera fila --%>
            <%-- Cuarta fila (info saldos vencidos) --%>

            <%-- Fin cuarta fila --%>
          </div>
          <%-- Fin cuerpo de la caja --%>
        </div>
        <%-- Fin caja principal --%>
      </div>
    </div>
  </section>
  <%-- Fin section cuerpo contenido --%>
</asp:Content>

