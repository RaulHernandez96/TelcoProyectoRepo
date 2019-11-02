<%@ Page Title="" Language="C#" MasterPageFile="~/main/MainLayout.master" AutoEventWireup="true" CodeFile="WSolicitudTarjetaCredito.aspx.cs" Inherits="main_WSolicitudTarjetaCredito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="content-header">
        <h1>Solicitud tarjeta</h1>
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
                                    <asp:DropDownList ID="ddlIdFinan" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label9" class="control-label" runat="server" Text="DPI cliente"></asp:Label>
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
                                    <asp:DropDownList ID="ddlTipoCredito" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>      
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label4" class="control-label" runat="server" Text="Tipo tarjeta"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">                                    
                                    <asp:DropDownList ID="ddlTipoTarjeta" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div> 
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label5" class="control-label" runat="server" Text="Tipo_entrega"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">                                   
                                    <asp:DropDownList ID="ddlTipoEntrega" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                             <div class="form-group">
                                 <div class="col-sm-4">
                                     <asp:Label ID="Label6" class="control-label" runat="server" Text="Tipo desembolso"></asp:Label>
                                 </div>                            
                                 <div class="col-sm-8">                                    
                                     <asp:DropDownList ID="ddlTipoDesembolso" CssClass="form-control"  runat="server"></asp:DropDownList>
                                 </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label7" class="control-label" runat="server" Text="Limite"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtlimite" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label11" class="control-label" runat="server" Text="Historial de compra"></asp:Label>
                                </div>                            
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtHistorialCompra" cssclass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group">
                                <div class="col-sm-4">
                                    <asp:Label ID="Label8" class="control-label" runat="server" Text="categoria de la tarjeta "></asp:Label>
                                </div>                            
                                <div class="col-sm-8">                                   
                                    <asp:DropDownList ID="ddlCategoriaTarjeta" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div> 
                        </div>                                                                                                                                                                                                                                                                   
                        <div class="form-group">
                            <asp:Button ID="Button1" CssClass="btn btn-primary col-xs-12" runat="server" Text="Crear Solicitud" OnClick="btnInsertar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <%--  --%>




</asp:Content>

