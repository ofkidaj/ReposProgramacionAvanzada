using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOLAMUNDOASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Saludo_Click(object sender, EventArgs e)
        {
            string nombre= this.nombreTxt.Text.Trim();
            this.mensajeh1.InnerHtml = "hola "+ nombre + ", buen dia";
        }
    }
}