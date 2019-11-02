<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Seccion de encabezado --%>
  <section class="content-header">
    <h1>Menú principal</h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
    </ol>
  </section>
  <%-- Fin seccion de encabezado --%>
  <%-- Seccion cuerpo --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <%-- Caja principal --%>
        <div class="box box-default">
          <div class="box-body">
            <div class="row">
              <div class="col-xs-12">
                <%-- Caja cuentas --%>
                <div class="box box-primary">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title">Cuentas</h4>
                  </div>
                  <%-- Fin Encabezado Caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:Repeater ID="_rpListadoCuentas" runat="server" OnItemDataBound="OnItemDataBoundCuentas">
                          <ItemTemplate>
                            <div class="col-xs-12">
                              <div class="box box-success">
                                <div class="box-header"></div>
                                <div class="box-body">
                                  <div class="col-xs-4">
                                    <asp:HyperLink ID="_hyNumeroCuenta" CssClass="text-bold" Text='<%#Eval("NumeroCuenta")%>' runat="server"></asp:HyperLink>
                                    <br />
                                    <small>Tipo cuenta: <%#Eval("TipoCuenta")%></small>
                                  </div>
                                  <div class="col-xs-8">
                                    <asp:HyperLink ID="_hyPropietario" CssClass="text-bold" Text='<%#Eval("Propietario")%>' runat="server"></asp:HyperLink>
                                    <br />
                                    <small>Moneda: <%#Eval("TipoMoneda")%></small>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </ItemTemplate>
                        </asp:Repeater>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
                <%-- Fin caja cuentas --%>
              </div>
            </div>
            <%-- Caja tarjetas crédito --%>
            <div class="row">
              <div class="col-xs-12">
                <div class="box box-primary">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title">Tarjetas de crédito</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">

                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
            </div>
            <%-- Fin caja tarjetas crédito --%>
            <%-- Caja operaciones básicas --%>
            <div class="row">
              <div class="col-xs-12">
                <div class="box box-primary">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title">Operaciones básicas</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-12">
                        
                        <asp:HyperLink ID="_hyTransferenciasCuentaPropias" NavigateUrl="main/TransferenciaListadoCuentaPropias.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Transferencias entre cuentas propias
                        </asp:HyperLink>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:HyperLink ID="_hyTransferenciasCuentasTercerosBanco" NavigateUrl="main/TransferenciaListadoCuentaTerceros.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Transferencias a cuenta de tercero (mismo banco)
                        </asp:HyperLink>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:HyperLink ID="_hyTransferenciasCuentasTercerosInter" NavigateUrl="ach/transferenciaACH.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Transferencia a cuenta de terceros (inter bancaria)
                        </asp:HyperLink>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:HyperLink ID="_hySolicitudProductoBancario" NavigateUrl="main/SolicitudProductoBancarioListado.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Solicitud de productos bancarios
                        </asp:HyperLink>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:HyperLink ID="_hySolicitudBloqueoTarjeta" NavigateUrl="main/SolicitudBrolqueoTarjetaListado.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Solicitud para bloqueo de tarjeta crédito/débito
                        </asp:HyperLink>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12">
                        <asp:HyperLink ID="_hyMantenimientoAlertas" NavigateUrl="main/MantenimientoAlertasPrincipal.aspx" runat="server">
                          <i class="fa fa-arrow-circle-right"></i> Mantenimiento de tarjetas
                        </asp:HyperLink>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerpo caja --%>
                </div>
              </div>
            </div>
            <%-- Fin caja operaciones básicas --%>
            <%-- Mensaje usuario --%>
            <div class="row">
              <div class="col-xs-12">
                <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
              </div>
            </div>
            <%-- Fin mensaje usuario --%>
          </div>
        </div>
        <%-- Fin caja principal --%>
      </div>
    </div>
  </section>
  <%-- Fin seccion cuerpo --%>
</asp:Content>

