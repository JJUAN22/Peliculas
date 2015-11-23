<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
    <div class="row">
        <div class="col-xs-12 jumbotron">
        <h1>Bienvenidos</h1>
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
                        <div class="item active">
                            <img src="img/crepusculo-portada.png" alt="Romance" />
                            <div class="carousel-caption">
                                Crepsculo
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/avatar-carteles3.png" alt="Ficcion" />
                            <div class="carousel-caption">
                                Avatar
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/el-conjuro_1.png" alt="Terror" />
                            <div class="carousel-caption">
                                El Conjuro
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/devolucionesPortada.png" alt="Drama" />
                            <div class="carousel-caption">
                                No se aceptan devoluciones
                            </div>
                        </div>
                        ...
                    </div>
                    <!-- Controls -->
                    <a class="left carousel-control" href="#carouselUno" role="button" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                            Previous</span> </a><a class="right carousel-control" href="#carouselUno" role="button"
                                data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                                </span><span class="sr-only">Next</span> </a>
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
                        <div class="item active">
                            <img src="img/Monsters_inc.png" alt="Romance" />
                            <div class="carousel-caption">
                                Monters Inc
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/Transylvania1.png" alt="Ficcion" />
                            <div class="carousel-caption">
                                Hotel Transylvania
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/dory.png" alt="Terror" />
                            <div class="carousel-caption">
                                Buscando a Dory
                            </div>
                        </div>
                        <div class="item">
                            <img src="img/up.png" alt="Drama" />
                            <div class="carousel-caption">
                                Up (Una aventura de Altura)
                            </div>
                        </div>
                        ...
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
    </div>
    <div class="container">
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-md-3">
                        <asp:TextBox ID="Nombre" runat="server" placeholder="Nombre" />
                    </div>
                    <div class="col-md-3">
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle" type="button" id="Generobtn" data-toggle="dropdown"
                                aria-haspopup="true" aria-expanded="true">
                                Genero <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" aria-labelledby="dropdownMenuGene">
                                <li><a href="#" class="list-group-item list-group-item-danger">Animadas</a></li>
                                <li><a href="#" class="list-group-item list-group-item-success">Ciencia Ficcion</a></li>
                                <li><a href="#" class="list-group-item list-group-item-info">Drama</a></li>
                                <li><a href="#" class="list-group-item list-group-item-warning">Terror</a></li>
                                <li><a href="#" class="list-group-item list-group-item-danger">Romantica</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle" type="button" id="Clasificacionbtn"
                                data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                Clasicicación <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" aria-labelledby="dropdownMenuClasi">
                                <li><a href="#" class="list-group-item list-group-item-success">A</a></li>
                                <li><a href="#" class="list-group-item list-group-item-info">B</a></li>
                                <li><a href="#" class="list-group-item list-group-item-warning">C</a></li>
                                <li><a href="#" class="list-group-item list-group-item-danger">D</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker'>
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
    </form>
    <script src="js/jquery-2.1.4.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/bootstrap-datetimepicker.js"></script>
    <script type="text/javascript" src="js/moment-with-locales.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#datetimepicker').datetimepicker();
        });
    </script>
</body>
</html>
