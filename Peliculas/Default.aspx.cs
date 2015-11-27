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
                cargarcarrucel2();

            }
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
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


