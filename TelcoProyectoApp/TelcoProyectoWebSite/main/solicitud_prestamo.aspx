<%@ Page Language="C#" AutoEventWireup="true" CodeFile="solicitud_prestamo.aspx.cs" Inherits="main_solicitud_prestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <link rel="stylesheet" href="/bower_components/bootstrap//dist/css/bootstrap.min.css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <title>Prestamo</title>
</head>
<body>
    <form class="form-horizontal">
        <fieldset>
            <!-- Form Name -->
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="">Search for client</label>
                <div class="col-md-8">
                    <input id="txtdpi" name="dpi" type="text" placeholder="ingrese DPI del cliente" class="form-control input-md">
                    
                </div>
            </div>
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="selectbasic">This Invoice (Bank Slip) If repeated?</label>
                <div class="col-md-4">
                    <select id="selectbasic" name="selectbasic" class="form-control">
                        <option value="1">Yes, Monthly</option>
                        <option value="2">Yes, Bimonthly</option>
                        <option value="">Yes, Quarterly</option>
                        <option value="">Yes, Every Six Months</option>
                        <option value="">Yes, Annually</option>
                        <option value="">unrepeatable</option>
                    </select>
                </div>
            </div>
            <!-- Multiple Radios (inline) -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="radios">Bank slip have a date to end?</label>
                <div class="col-md-4">
                    <label class="radio-inline" for="radios-0">
                        <input type="radio" name="radios" id="radios-0" value="1" checked="checked">
                        Sim
                    </label>
                    <label class="radio-inline" for="radios-1">
                        <input type="radio" name="radios" id="radios-1" value="2">
                        Não
                    </label>
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">How many installments?</label>
                <div class="col-md-4">
                    <input id="textinput" name="textinput" type="text" placeholder="e.g. 12" class="form-control input-md">
                    <span class="help-block">How many bank slips will be generated.</span>
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">Bank Slip Description</label>
                <div class="col-md-8">
                    <input id="textinput" name="textinput" type="text" placeholder="e.g. Hosting Website" class="form-control input-md">
                    
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">E-mail Description</label>
                <div class="col-md-8">
                    <input id="textinput" name="textinput" type="text" placeholder="" class="form-control input-md">
                    <span class="help-block">Invoice (bank slip) details such as product or service.</span>
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">Slip Bank Amount</label>
                <div class="col-md-5">
                    <input id="textinput" name="textinput" type="text" placeholder="0,00" class="form-control input-md">
                    <span class="help-block">Due date of the invoice to be sent.</span>
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">Due Date</label>
                <div class="col-md-5">
                    <input id="textinput" name="textinput" type="text" placeholder="28/02/2016" class="form-control input-md">
                    <span class="help-block">Due date of the banck slip to be sent.</span>
                </div>
            </div>
            <!-- Button (Double) -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="button1id"></label>
                <div class="col-md-8">
                    <button id="button1id" name="button1id" class="btn btn-success">Register</button>
                    <button id="button2id" name="button2id" class="btn btn-danger">Cancel</button>
                </div>
            </div>
        </fieldset>
    </form>
</body>
</html>
