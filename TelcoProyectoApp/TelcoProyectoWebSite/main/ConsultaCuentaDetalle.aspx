<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="ConsultaCuentaDetalle.aspx.cs" Inherits="main_ConsultaCuentaDetalle" %>

<asp:Content ID="_mainContent" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:ScriptManager ID="_smMovimientoCuenta" EnablePartialRendering="true" runat="server"></asp:ScriptManager>
  <%-- Sección principal --%>
  <%-- Encabezado del contenido --%>
  <section class="content-header">
    <h1>Consulta estado de cuenta
      <b>
        <%= _obConsultaCuentaDetalle != null 
            ? _obConsultaCuentaDetalle.Cuenta != null 
            ? _obConsultaCuentaDetalle.Cuenta.TipoCuenta : "#N/A#" : "N/A" %>
      </b>
      ( <b>
        <%= _obConsultaCuentaDetalle != null 
            ? _obConsultaCuentaDetalle.Cuenta != null 
            ? _obConsultaCuentaDetalle.Cuenta.NumeroCuenta : "#N/A#" : "N/A" %>
        </b> )
    </h1>
    <small><b>Info</b>Bancos</small>
    <ol class="breadcrumb">
      <li>Inicio</li>
      <li>Productos</li>
      <li>Cuentas</li>
      <li>Estado de cuenta</li>
    </ol>
  </section>
  <%-- Fin del encabezado --%>
  <%-- Cuerpo del contendio --%>
  <section class="content">
    <div class="row">
      <div class="col-xs-12">
        <%-- Caja principal --%>
        <div class="box box-primary">
          <%-- Encabezado caja --%>
          <div class="box-header with-border">
            <div class="row">
              <div class="col-xs-4">
                <h5 class="box-title">Propietario: 
                  <%= _obConsultaCuentaDetalle != null 
                      ? _obConsultaCuentaDetalle.Cuenta != null 
                      ? _obConsultaCuentaDetalle.Cuenta.Propietario : "#N/A#" : "N/A" %>
                </h5>
              </div>
              <div class="col-xs-4">
                <h5 class="box-title">Tipo moneda: 
                  <%= _obConsultaCuentaDetalle != null 
                      ? _obConsultaCuentaDetalle.Cuenta != null 
                      ? _obConsultaCuentaDetalle.Cuenta.TipoMoneda : "#N/A#" : "N/A" %>
                </h5>
              </div>
            </div>
          </div>
          <%-- Fin encabezado caja --%>
          <%-- Cuerpo caja --%>
          <div class="box-body">
            <%-- Primera fila filtro --%>
            <div class="row">
              <div class="col-xs-12 col-lg-2">
                <label for="<%= _txFechaBusqueda.ClientID %>">Fecha para la busqueda:</label>
              </div>
              <div class="col-xs-12 col-lg-2">
                <asp:TextBox ID="_txFechaBusqueda" CssClass="form-control input-sm text-center" runat="server"></asp:TextBox>
              </div>
              <div class="col-xs-12 col-lg-2">
                <asp:Button ID="_btBuscarDetalle" CssClass="btn btn-primary col-xs-12 input-sm" Text="Buscar detalle" runat="server" OnClick="OnClicBuscarMovimiento" />
              </div>
            </div>
            <%-- Fin primera fila --%>
            <br />
            <%-- Segunda fila movimientos --%>
            <asp:UpdatePanel ID="_upMovimientoCuenta" UpdateMode="Conditional" runat="server">
              <Triggers>
                <asp:AsyncPostBackTrigger ControlID="_btBuscarDetalle" EventName="Click" />
              </Triggers>
              <ContentTemplate>
                <%-- Fila condicional mesaje de procesando --%>
                <asp:UpdateProgress ID="_upMensajeProceso" DynamicLayout="true" runat="server">
                  <ProgressTemplate>
                    <div class="row">
                      <div class="col-xs-12 text-center">
                        <span class="text-bold">Procesando...</span>
                      </div>
                    </div>
                  </ProgressTemplate>
                </asp:UpdateProgress>
                <%-- Fin fila condicional --%>
                <div class="row">
                  <div class="col-xs-12">
                    <table class="table table-bordered">
                      <thead>
                        <tr>
                          <th class="text-center">Fecha</th>
                          <th class="text-center">Documento</th>
                          <th class="text-center">Descripción</th>
                          <th class="text-center"><span class="text-danger">Deb.</span>/<span class="text-info">Cred.</span></th>
                          <th class="text-center">Saldo</th>
                          <th class="text-center">Agencia</th>
                        </tr>
                      </thead>
                      <tbody>
                        <asp:Repeater ID="_rpMovimientoCuenta" runat="server">
                          <ItemTemplate>
                            <tr>
                              <td class="text-left">
                                <%#DateTime.Parse(Eval("Fecha").ToString()).ToString("dd/MM/yyyy")%>
                              </td>
                              <td class="text-left"><%#Eval("Documento")%></td>
                              <td class="text-left"><%#Eval("Descripcion")%></td>
                              <td class="text-right <%#Convert.ToInt32(Eval("DebitoCredito").ToString()) < 0 
                                  ? "text-danger" : "text-info"%>">
                                <%#string.Format("{0:0,0.00}", Convert.ToDouble(Eval("DebitoCredito")))%>
                              </td>
                              <td class="text-right"><%#string.Format("{0:0,0.00}", Convert.ToDouble(Eval("Saldo")))%></td>
                              <td class="text-left"><%#Eval("Agencia")%></td>
                            </tr>
                          </ItemTemplate>
                        </asp:Repeater>
                      </tbody>
                    </table>
                  </div>
                </div>
                <%-- Fila mensaje de usuario --%>
                <div class="row">
                  <div class="col-xs-12">
                    <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
                  </div>
                </div>
                <%-- Fin fila mensaje de usaurio --%>
              </ContentTemplate>
            </asp:UpdatePanel>
            <%-- Fin segunda fila --%>
          </div>
          <%-- Fin cuerpo caja --%>
        </div>
        <%-- Fin caja principal --%>
      </div>
    </div>
  </section>
  <%-- Fin del cuerpo --%>
  <%-- Fin sección principal --%>
  <%-- Script --%>
  <script>
    <%= _txFechaBusqueda.ClientID %>.onkeydown = function (even) {
      console.log(this.value);
      console.log(event.keyCode);
      var _inValorKey = event.keyCode;
      var _stValorInput = this.value;
      if ((_inValorKey >= 48 && _inValorKey <= 57) || (_inValorKey >= 96 && _inValorKey <= 105) ) {
        if (_stValorInput.length == 0) {
          this.value = String.fromCharCode(_inValorKey) + "__/____";
          even.preventDefault();
          return;
        }
        else if (_stValorInput.length == 1) {
          this.value = "_/____";
        }
      }
      else if ( _inValorKey == 8 || _inValorKey == 46 || _inValorKey == 37
        || _inValorKey == 39 || _inValorKey == 111 || _inValorKey == 9 ) {

      }
      else {
        event.preventDefault();
        return;
      }
    }
  </script>
  <%-- Fin script --%>
</asp:Content>

