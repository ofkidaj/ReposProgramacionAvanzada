using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresIntWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarMedidor.aspx");
        }


        protected void lecbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresarLectura.aspx");
        }
    }
}