<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="ConfirmacionTrasnferencia.aspx.cs" Inherits="main_ConfirmacionTrasnferencia" %>

<asp:Content ID="_cMainContent" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <%-- Seccion encabezado --%>
  <section class="content-header">
    <h1>Transferencia entre cuentas propias</h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Operaciones</li>
      <li>Transferencias (propias)</li>
    </ol>
  </section>
  <%-- Fin seccion encabezado --%>
  <%-- Seccion cuerpo --%>
  <section class="content">
    <%-- Caja principal --%>
    <div class="row">
      <div class="col-xs-12">
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
                <%-- Caja paso 2 --%>
                <div class="box box-default">
                  <%-- Encabezado caja --%>
                  <div class="box-header with-border">
                    <h4 class="box-title">Paso 2 de 2</h4>
                  </div>
                  <%-- Fin encabezado caja --%>
                  <%-- Cuerpo caja --%>
                  <div class="box-body">
                    <div class="row">
                      <div class="col-xs-12 col-lg-6">
                        <span class="text-bold">Transferencia de la cuenta de 
                          <asp:Label ID="_lbTipoCuentaOrigen" runat="server"></asp:Label> 
                          <asp:Label ID="_lbTipoMonedaOrigen" runat="server"></asp:Label>
                          :
                        </span>
                      </div>
                      <div class="col-xs-12 col-lg-6">
                        <asp:Label ID="_lbInformacionCuentaOrigen" runat="server"></asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12 col-lg-6">
                        <span class="text-bold">A la cuenta de 
                          <asp:Label ID="_lbTipoCuentaDestino" runat="server"></asp:Label> 
                          <asp:Label ID="_lbTipoMonedaDestino" runat="server"></asp:Label>
                          :
                        </span>
                      </div>
                      <div class="col-xs-12 col-lg-6">
                        <asp:Label ID="_lbInformacionCuentaDestino" runat="server"></asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-12 col-lg-6">
                        <span class="text-bold">Por un monto de:</span>
                      </div>
                      <div class="col-xs-12 col-lg-6">
                        <asp:Label ID="_lbMontoTrasnferencia" runat="server"></asp:Label>
                      </div>
                    </div>
                  </div>
                  <%-- Fin cuerop caja --%>
                </div>
                <%-- Fin caja paso 2 --%>
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
          <%-- Fin cuerpo caja --%>
          <%-- Pie caja --%>
          <div class="box-footer">
            <div class="row">
              <div class="col-xs-6 col-lg-4">
                <asp:Button ID="_btConfirmacion" CssClass="btn btn-primary col-xs-12" Text="Confirmar trasnferencia" runat="server" OnClick="OnClicConfirmar" />
              </div>
              <div class="col-xs-6 col-lg-4">
                <asp:Button ID="_btCancelar" CssClass="btn btn-danger col-xs-12" Text="Cancelar transferencia" runat="server" OnClick="OnClicCancelar" />
              </div>
            </div>
          </div>
          <%-- Fin pei caja --%>
        </div>
      </div>
    </div>
    <%-- Fin caja principal --%>
  </section>
  <%-- Fin seccion cuerpo --%>
</asp:Content>

