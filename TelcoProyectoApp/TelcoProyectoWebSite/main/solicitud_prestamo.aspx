<%@ Page Language="C#" AutoEventWireup="true" CodeFile="solicitud_prestamo.aspx.cs" Inherits="main_solicitud_prestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Solicitud de prestamo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="numero de financiera "></asp:Label>
            <asp:TextBox ID="txtid_financiera" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="DPI cliente"></asp:Label>
            <asp:TextBox ID="txtDPI_cliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Tipo de credito"></asp:Label>
            <asp:TextBox ID="txtTipo_credito" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Tipo_entrega"></asp:Label>
            <asp:TextBox ID="txtTipo_entrega" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Tipo desembolso"></asp:Label>
            <asp:TextBox ID="txtTipo_desembolso" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="capital"></asp:Label>
            <asp:TextBox ID="txtCapital" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="plazo"></asp:Label>
            <asp:TextBox ID="txtPlazo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Garantia"></asp:Label>
            <asp:TextBox ID="txtGarantia" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="utilidad de dinero"></asp:Label>
            <asp:TextBox ID="txtUtilidad_dinero" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Historial de compra"></asp:Label>
            <asp:TextBox ID="txtHistorial_compras" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label11" runat="server" Text="proyeccion de pago"></asp:Label>
            <asp:TextBox ID="txtProyeccion" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label12" runat="server" Text="Estado de Autorizacion"></asp:Label>
            <asp:TextBox ID="txtEstado_autorizacion" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label13" runat="server" Text="fecha de creacion"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsertar" runat="server" Text="Crear Solicitud" OnClick="btnInsertar_Click" />
        </div>
    </form>
</body>
</html>
