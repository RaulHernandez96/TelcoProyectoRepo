<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="TransferenciaListadoCuentaTerceros.aspx.cs" Inherits="main_TransferenciaListadoCuentaTerceros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Encabezado --%>
  <section class="content-header">
    <h1>Listado de cuentas para transferencias a terceros</h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Operaciones</li>
      <li>Transferencias a terceros (mismo banco)</li>
    </ol>
  </section>
  <%-- Fin encabezado --%>
  <%-- Cuerpo --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <%-- Caja principal --%>
        <div class="box box-primary">
          <%-- Caja encabezdo --%>
          <div class="box-header with-border">
            <h4 class="box-title">Cuentas propias</h4>
          </div>
          <%-- Fin caja encabezado --%>
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
              <div class="col-xs-12">
                <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
              </div>
            </div>
          </div>
          <%-- Fin cuerpo caja --%>
        </div>
        <%-- Fin caja principal --%>
      </div>
    </div>
  </section>
  <%-- Fin cuerpo --%>
</asp:Content>

