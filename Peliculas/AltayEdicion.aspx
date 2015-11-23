<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltayEdicion.aspx.cs" Inherits="AltayEdicion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-3 sol-sm-1">
            </div>
            <div class="col-md-6 sol-sm-10">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h1>
                            Alta y edición de peliculas Matus
                        </h1>
                    </div>
                    <div class="panel-body">
                        <div style="height: 200px; text-align: center; overflow: hidden;">
                            <asp:Image ID="imgPortada" ImageUrl="~/img/Imagen_no_disponible.png" Width="200px"
                                runat="server" /><br />
                            <asp:FileUpload runat="server" ID="fuPortada" Width="200px" />
                        </div>
                        <div class="well">
                            <div>
                                <div class="row">
                                    <div class="col-xs-6">
                                        <asp:Image ImageUrl="~/img/Imagen_no_disponible.png" Width="200px" runat="server"
                                            ID="imgMini" />
                                        <asp:FileUpload CssClass="form-control" Width="200px" runat="server" ID="fuFotoMini" />
                                        <br />
                                        <br />
                                        <asp:PlaceHolder runat="server" ID="phTrailer" />
                                        <asp:TextBox class="form-control" runat="server" ID="txtTrailer" Width="200px" placeholder="Ruta de video" />
                                    </div>
                                    <div class="col-xs-6">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtNombre" placeholder="Nombre de pelicula" />
                                        <br />
                                        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlClasificacion" AppendDataBoundItems="true">
                                            <asp:ListItem Text="[Elija clasificacion]" Value="-1" />
                                        </asp:DropDownList>
                                        <br />
                                        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlGeneracion" AppendDataBoundItems="true">
                                            <asp:ListItem Text="[Elige Genero]" Value="-1" />
                                        </asp:DropDownList>
                                        <br />
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaLanzamiento" />
                                        <br />
                                        <asp:Label Text="Sinópsis" runat="server" ID="lblSinopsis" />
                                        <asp:TextBox CssClass="form-control" runat="server" TextMode="Multiline" Rows="4"
                                            ID="txtSinopsis" MaxLength="499" />
                                    </div>
                                </div>
                                <div style="text-align: center">
                                    <asp:CheckBox Text="Estatus" runat="server" ID="chkEstatus" Checked="true" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-4" style="text-align: Center;">
                                <asp:ImageButton ID="imbActualizar" ImageUrl="~/img/edit.png" Width="40px" ToolTip="Actualizar"
                                    runat="server" />
                            </div>
                            <div class="col-xs-4" style="text-align: Center;">
                                <asp:ImageButton ID="imbEliminar" ImageUrl="~/img/delete.png" Width="40px" ToolTip="Eliminar"
                                    runat="server" />
                            </div>
                            <div class="col-xs-4" style="text-align: Center;">
                                <asp:ImageButton ID="imbGuardar" ImageUrl="~/img/save.png" Width="40px" ToolTip="Guardar"
                                    runat="server" />
                            </div>
                        </div>
                    </div>
                    <div class="panel-footer">
                        <asp:LinkButton ID="LinkButton1" Text="Regresar Pagina Principal" runat="server" />
                    </div>
                </div>
            </div>
            <div class="col-md-3 sol-sm-1">
            </div>
        </div>
    </div>
    <asp:HiddenField runat="server" ID="hfid" />
    <asp:HiddenField runat="server" ID="hfTrailer" />
    <asp:HiddenField runat="server" ID="hfFotoPortada" />
    <asp:HiddenField runat="server" ID="hfFotoMini" />
    </form>
    <script src="js/jquery-2.1.4.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>
