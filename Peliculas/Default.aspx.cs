using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BlockBuster.Peliculas.Business.Entity;
using BlockBuster.Peliculas.Business;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                cargarcarrucel();

            }
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }

    private void CargarCartelera(string query)
    {
        List<entPelicula> lst = new busPelicula().Obtener();

        llenarlt(lst);


    }

    private void llenarlt(List<entPelicula> lst)
    {
        LiteralControl literal = new LiteralControl();
        literal.Text = "";
        foreach (entPelicula ent in lst)
        {



            literal.Text += "         <div class=\"col-sm-4\">";
            literal.Text += "                <div class=\"panel panel-default\">";
            literal.Text += "  <div class=\"panel-heading\" style=\"height: 200px;overflow: hidden;\">";
            literal.Text += "          <div style=\"height: 150px; overflow: hidden; text-align: center;\">";
            literal.Text += "                        <img src=\"" + ent.FotoPortada + "\" class=\"img-responsive img-rounded\"alt=\"\" style=\"margin: auto;\" />";
            literal.Text += "  </div>";
            literal.Text += " <div>";
            literal.Text += ent.Nombre;
            literal.Text += "                    </div>";
            literal.Text += "                    </div>";
            literal.Text += "                    <div class=\"panel-body\">";
            literal.Text += "                        <div class=\"row\" style=\"height: 150px;\">";
            literal.Text += "                            <div class=\"col-xs-4\">";
            literal.Text += "                                <img src=\"" + ent.FotoMini + "\"";
            literal.Text += "                                    class=\"img-responsive img-rounded\" />";
            literal.Text += "                            </div>";
            literal.Text += "                            <div class=\"col-xs-8\">";
            literal.Text += "                                <span>Año:&nbsp;&nbsp;</span><label>" + ent.AnioLanzamiento + "</label><br />";
            literal.Text += "                                <span>Clasificacion:&nbsp;&nbsp;</span><label>" + ent.Clasificacion + "</label><br />";
            literal.Text += "                                <span>Género:&nbsp;&nbsp;</span><label>" + ent.Genero + "</label><br />";
            literal.Text += "                                <span>";
            if (ent.Estatus)
                literal.Text += "                                    <input type=\"checkbox\" value=\"estatus\" checked disabled />";
            else
                literal.Text += "                                <input type=\"checkbox\" disabled value=\"estatus\"/>";
            literal.Text += "                                </span>";

            literal.Text += "<a href=\"AltaEdicion.aspx?ID=" + ent.Id.ToString() + "\"><img src=\"img\\edit.png\" width=\"40px\" /</a>";
            //    literal.Text += "    </div>";
            literal.Text += " </div>";

            // bien     literal.Text += "                            </div>";
            literal.Text += "                        </div>";
            literal.Text += "                    </div>";
            //      literal.Text += "                    <div id=\"Div2\" style=\"text-align: justify; margin: 5px auto;\">";
            literal.Text += "                        <textarea id=\"txtSinopsis\" class=\"form-control\" rows=\"5\" style=\"text-align: justify; background-color:White \" disabled=\"disabled\">" + ent.Sinopsis + "</textarea>";
            // bien  literal.Text += "                    </div>";
            literal.Text += "                    <div id=\"Div3\"; style=\"text-align: center;\">";
            literal.Text += "                        <iframe src=\"" + ent.Trailer + "\" frameborder=\"0\" allowfullscreen>";
            literal.Text += "                        </iframe>";
            literal.Text += "                    </div>";
            literal.Text += "                    <!--bien-->";
            literal.Text += "                    ";
            literal.Text += "                </div>";
            literal.Text += "            </div>";
        }

        phCargarcartelera.Controls.Add(literal);




    }
    public void cargarcarrucel()
    {
        List<entPelicula> lst = new List<entPelicula>();
        lst = new busPelicula().ObtenerEstrenos();


        LiteralControl literalDos = new LiteralControl();

        LiteralControl literal = new LiteralControl();
        literalDos.Text = "";
        literal.Text = "";
        int contador = 0;

        foreach (entPelicula ent in lst)
        {

            if (contador == 0)

                literal.Text += "<li data-target=\"#carouselDos\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
            else

                literal.Text += "<li data-target=\"#carouselDos\" data-slide-to=\"" + contador + "\"></li>";
            if (contador == 0)
                literalDos.Text += "<div class=\"item active\">";
            else
                literalDos.Text += "<div class=\"item \">";
            literalDos.Text += "                           <img src=\"" + ent.FotoPortada + "\" style=\"height: 200 px\" width=\"400 px\"/>";
            literalDos.Text += " <span class=\"style\"><strong>" + ent.Nombre + "</strong></span>";
            literalDos.Text += "  <div class=\"carousel-caption\">";

            literalDos.Text += "                           </div>";
            literalDos.Text += "                       </div>";

            contador++;

        }
        phCarucel1.Controls.Add(literal);
        phCarrucel2.Controls.Add(literalDos);


    }

    public void cargarcarrucel2()
    {
        List<entPelicula> lst = new List<entPelicula>();
        lst = new busPelicula().ObtenerEstrenos();


        LiteralControl literalTres = new LiteralControl();

        LiteralControl literalCua = new LiteralControl();
        literalTres.Text = "";
        literalCua.Text = "";
        int contador = 0;

        foreach (entPelicula ent in lst)
        {

            if (contador == 0)

                literalTres.Text += "<li data-target=\"#carouselDos\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
            else

                literalTres.Text += "<li data-target=\"#carouselDos\" data-slide-to=\"" + contador + "\"></li>";
            if (contador == 0)
                literalCua.Text += "<div class=\"item active\">";
            else
                literalCua.Text += "<div class=\"item \">";
            literalCua.Text += "                           <img src=\"" + ent.FotoPortada + "\" style=\"height: 200 px\" width=\"400 px\"/>";
            literalCua.Text += " <span class=\"style\"><strong>" + ent.Nombre + "</strong></span>";
            literalCua.Text += "  <div class=\"carousel-caption\">";

            literalCua.Text += "                           </div>";
            literalCua.Text += "                       </div>";

            contador++;

        }
        phCarucel1.Controls.Add(literalTres);
        phCarrucel2.Controls.Add(literalCua);


    }
}
//    protected void btnEntrar_Click(object sender, EventArgs e)
//    {
////        entUsuario user = new entUsuario();
////string mail = txtMail.Text;
////string pass = txtPass.Text;

////entUsuario = new busCatalogo.ObtenerUsuario(mail,pass);
////if (user != null)
////{

////    Session["User"] = user;
////    lbl.Mensaje.Text = "Bienvenido" + user.Nombre;
////}
////else
////    throw new ApplicationException("Usuario o contraseña incorrecta");
////    }
//}




//Page_Load
//{
//if(Sessio["User") == null)

//Response.Redirect("Default.aspx");
//else
//string id = Resquest.QueryString["ID"].ToString();
//}


