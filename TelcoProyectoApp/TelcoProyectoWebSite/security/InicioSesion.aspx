<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InicioSesion.aspx.cs" Inherits="security_Default" %>
<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>InfoBancos | Inicio de sesión</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="../../bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../../bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="../../bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/AdminLTE.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="../../plugins/iCheck/square/blue.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition login-page">
<div class="login-box">
  <div class="login-logo">
    <a href="../../index2.html"><b>Info</b>Bancos</a>
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg">Inicia sesión para acceder a la banca en línea</p>

    <form id="_mainForm" runat="server">
      <asp:RequiredFieldValidator ID="_rfvUsuario" ControlToValidate="_txUsuario" 
        ErrorMessage="Debe ingresar un usuario valido" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
      <div class="form-group has-feedback">
        <%--<input type="email" class="form-control" placeholder="Usuario">--%>
        <asp:TextBox ID="_txUsuario" CssClass="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="_txContrasenia" 
        ErrorMessage="Debe ingresar una contraseña valida" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
      <div class="form-group has-feedback">
        <%--<input type="password" class="form-control" placeholder="Contraseña">--%>
        <asp:TextBox ID="_txContrasenia" TextMode="Password" CssClass="form-control" placeholder="Contraseña" runat="server"></asp:TextBox>
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="row">
        <!-- /.col -->
        <div class="col-xs-12">
          <asp:Label ID="_lbMensajeUsuario" runat="server"></asp:Label>
        </div>
      </div>
      <div class="row">
        <div class="col-xs-8">
          <div class="checkbox icheck">
            <label>
              <input type="checkbox"> Dejar sesión abierta
            </label>
          </div>
        </div>
        <div class="col-xs-4">
          <%--<button type="submit" class="btn btn-primary btn-block btn-flat">Ingresar</button>--%>
          <asp:Button ID="_btInicioSesion" CssClass="btn btn-primary btn-block btn-flat" Text="Ingresar" runat="server" OnClick="_btInicioSesion_Click" />
        </div>
        <!-- /.col -->
      </div>
    </form>

    <a href="#">Olvide mi contraseña</a><br>
    <a href="register.html" class="text-center">Eniar solicitud de usuario</a>

  </div>
  <!-- /.login-box-body -->
</div>
<!-- /.login-box -->

<!-- jQuery 3 -->
<script src="../../bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="../../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="../../plugins/iCheck/icheck.min.js"></script>
<script>
  $(function () {

    $("<%# _btInicioSesion.ClientID %>").click(event => {
      if ($("<%# _txUsuario.ClientID %>").val() == "" || $("<%# _txContrasenia.ClientID %>").val() == "") {
        $("<%# _lbMensajeUsuario.ClientID %>").text("Debe ingresar el usuario y contraseña");
      }
    });

    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' /* optional */
    });

  });
</script>
</body>
</html>
