﻿                                                                                                                                            <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap-datetimepicker.css" />
</head>
<body style="background-image: url('img/block.jpg')">
    <form id="form1" runat="server">
    <div class="container">
        <div class="row  jumbotron">
            <div class="col-xs-6 ">
                <h2>
                    Bienvenidos</h2>
            </div>
            <div class="col-xs-3 ">
                <a class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">Accesa
                    a tu Cuenta</a>
            </div>
            <div class="col-xs-3 ">
                <a class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">Registrarte</a>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div id="carouselUno" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#carouselUno" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselUno" data-slide-to="1"></li>
                    <li data-target="#carouselUno" data-slide-to="2"></li>
                    <li data-target="#carouselUno" data-slide-to="3"></li>
                </ol>
                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <asp:PlaceHolder ID="phCarucel1" runat="server" />
                    <!-- Controls -->
                    <a class="left carousel-control" href="#carouselUno" role="button" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                            Previous</span> </a><a class="right carousel-control" href="#carouselUno" role="button"
                                data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                                </span><span class="sr-only">Next</span> </a>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div id="carouselDos" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#carouselDos" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselDos" data-slide-to="1"></li>
                    <li data-target="#carouselDos" data-slide-to="2"></li>
                    <li data-target="#carouselDos" data-slide-to="3"></li>
                </ol>
                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <asp:PlaceHolder ID="phCarrucel2" runat="server" />
                </div>
                <!-- Controls -->
                <a class="left carousel-control" href="#carouselDos" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                        Previous</span> </a><a class="right carousel-control" href="#carouselDos" role="button"
                            data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                            </span><span class="sr-only">Next</span> </a>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-md-3">
                        <asp:TextBox ID="Nombre" runat="server" placeholder="Nombre de la Pelicula" />
                    </div>
                    <div class="col-md-3">
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle" type="button" id="Generobtn" data-toggle="dropdown"
                                aria-haspopup="true" aria-expanded="true">
                                Genero <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" aria-labelledby="dropdownMenuGene">
                                <li><a href="#" class="list-group-item
    list-group-item-danger">Animadas</a></li>
                                <li><a href="#" class="list-group-item
    list-group-item-success">Ciencia Ficcion</a></li>
                                <li><a href="#" class="list-group-item
    list-group-item-info">Drama</a></li>
                                <li><a href="#" class="list-group-item list-group-item-warning">Terror</a></li>
                                <li><a href="#" class="list-group-item list-group-item-danger">Romantica</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="dropdown">
                            <button class="btn
    btn-default dropdown-toggle" type="button" id="Clasificacionbtn" data-toggle="dropdown" aria-haspopup="true"
                                aria-expanded="true">
                                Clasicicación <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" aria-labelledby="dropdownMenuClasi">
                                <li><a href="#" class="list-group-item list-group-item-success">A</a></li>
                                <li><a href="#" class="list-group-item list-group-item-info">B</a></li>
                                <li><a href="#" class="list-group-item
    list-group-item-warning">C</a></li>
                                <li><a href="#" class="list-group-item list-group-item-danger">D</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <div class='input-group
    date' id='datetimepicker1'>
                                <input type='text' class="form-control" />
                                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="congainer">
        <div class="row">
            <div class="panel-body">
                <div class="col-md-4">
                </div>
                <div class="col-md-4">
                </div>
                <div class="col-md-4">
                </div>
            </div>
        </div>
        <div class="row" style="margin-top: 20px;">
            <asp:PlaceHolder runat="server" ID="phCargarcartelera" />
        </div>
    </div>
    </form>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">
                        Introduce tus Datos
                    </h4>
                </div>
                <div class="modal-body">
                    <asp:Label Text="Login" runat="server" ID="lbllogin" />
                    <br />
                    <input type="text" name="login_name" id="login" />
                    <br />
                    <asp:Label Text="Password" runat="server" ID="lblPassword" />
                    <br />
                    <input type="text" name="password" id="password" />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Cerrar</button>
                    <button type="button" class="btn btn-primary">
                        Registrarte</button>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="js/jquery-2.1.4.js"></script>
    <script src="js/moment-with-locales.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script src="js/bootstrap-datetimepicker.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#datetimepicker1').datetimepicker({
                format: 'dd/MM/YYYY',
                locale: 'es'
            });
        });
    </script>
</body>
</html>
