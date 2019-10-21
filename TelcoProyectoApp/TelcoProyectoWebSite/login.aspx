<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>InfoBanco Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container login-container">
                <div class="row">
                    <div class="col-md-12 login-form-1">
                        <h3>INFOBANCO</h3>                        
                        <div class="form-group">
                            <input type="text" class="form-control" placeholder="Usuario *" value="" />
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" placeholder="Contraseña *" value="" />
                        </div>
                        <div class="form-group">
                            <input type="submit" class="btnSubmit" value="Login" />
                        </div>
                        <div class="form-group">
                            <a href="#" class="ForgetPwd">Forget Password?</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

<!------ Include the above in your HEAD tag ---------->

