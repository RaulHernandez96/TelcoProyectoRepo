<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="Wsolicitud_prestamo.aspx.cs" Inherits="main_Wsolicitud_prestamo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="content-header">
        <h1>Solicitud de prestamo</h1>
        <small><b>Info</b>Bancos</small>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h4 class="box-title"></h4>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="form-group">
                            <div class="col-sm-4">
                                <asp:Label ID="Label1" class="control-label" runat="server" Text="numero de financiera "></asp:Label>
                            </div>                            
                            <div class="col-sm-8">                                                             
                                <asp:DropDownList ID="ddlFinanciera" cssclass="form-control" runat="server"></asp:DropDownList>                                
                            </div>
                        </div>

                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label2" class="control-label" runat="server" Text="DPI cliente"></asp:Label>
                                </div>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtDPI_cliente" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        
                        
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label3" class="control-label" runat="server" Text="Tipo de credito"></asp:Label>
                                </div>                                
                                <div class="col-sm-8">                                    
                                    <asp:DropDownList ID="ddlTipoCredito" cssclass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label4" class="control-label" runat="server" Text="Tipo de entrega"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">                                   
                                    <asp:DropDownList ID="ddlTipoEntrega" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label11" class="control-label" runat="server" Text="Tipo desembolso"></asp:Label>
                                </div>                                
                                <div class="col-sm-8">                                
                                    <asp:DropDownList ID="ddlTipoDesembolso" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>                        
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label12" class="control-label" runat="server" Text="capital"></asp:Label>
                                </div>                                
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtCapital" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>                          
                        </div>                                                
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label7" class="control-label" runat="server" Text="plazo"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtPlazo" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>                                                                      
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label14" class="control-label" runat="server" Text="Garantia"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtGarantia" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label8" class="control-label" runat="server" Text="utilidad de dinero"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtUtilidad_dinero" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label9" class="control-label" runat="server" Text="Historial de compra"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtHistorial_compras" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label10" class="control-label" runat="server" Text="proyeccion de pago"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtProyeccion" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>                                                                     
                        <div class="form-group">
                            <asp:Button ID="btnInsertar" CssClass="btn btn-primary col-xs-12" runat="server" Text="Crear Solicitud" OnClick="btnInsertar_Click" />                            
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <%--  --%>
</asp:Content>


