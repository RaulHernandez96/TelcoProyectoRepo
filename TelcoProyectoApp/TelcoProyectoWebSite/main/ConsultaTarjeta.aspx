<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="ConsultaTarjeta.aspx.cs" Inherits="main_ConsultaTarjeta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <%-- Encabezado del contendo --%>
  <section class="content-header">
      <h1>Consulta de Tarjeta</h1>
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
            <h4 class="col-sm-4">Ingrese el numero de tarjeta:                               
            </h4>
              <div class="col-sm-8">
                  <asp:TextBox ID="txtNumeroTarjeta" CssClass="form-control" runat="server"></asp:TextBox> 
                  <asp:Button ID="btnBuscar" CssClass="btn btn-primary col-xs-12" runat="server" Text="Buscar" OnClick="buscarInfo" />
              </div>

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
                        <asp:Label ID="lbCliente" runat="server"></asp:Label>
                          <asp:GridView ID="gvPrueba" runat="server"></asp:GridView>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Numero de Tarjeta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbNumeroTarjeta" runat="server"></asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Nombre de la tarjeta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbNombreTarjeta" runat="server"></asp:Label>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xs-4">
                        <span>Interes de Tarjeta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbInteresTarjeta" runat="server"></asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Proveedor de la tarjeta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbProveedorTarjet" runat="server"></asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Limite de credito:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbLimite" runat="server"></asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Fecha de pago:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbFechaPago" runat="server"></asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Fecha de Corte:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbFechaCorte" runat="server"></asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Fecha de Vencimiento:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbFechaVencimineto" runat="server">    </asp:Label>
                      </div>
                    </div>
                      <div class="row">
                      <div class="col-xs-4">
                        <span>Estado de la tarjeta:</span>
                      </div>
                      <div class="col-xs-8">
                        <asp:Label ID="lbEstado" runat="server"></asp:Label>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <%-- Fin de información general --%>
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
              <%-- Información sobre giros --%>              
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

