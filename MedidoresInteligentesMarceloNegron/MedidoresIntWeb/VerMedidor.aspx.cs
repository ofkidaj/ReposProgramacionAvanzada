using MedidoresIntModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresIntWeb
{
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaGrilla();
            }
        }

        private void CargaGrilla()
        {
            List<Medidor> medidor = medidorDAL.ObtenerMedidores();
            this.GrillaMedidor.DataSource = medidor;
            this.GrillaMedidor.DataBind();
        }

        protected void GrillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string nroMedidor = Convert.ToString(e.CommandArgument);
                medidorDAL.Eliminar(Convert.ToInt32(nroMedidor));
                CargaGrilla();

            }
        }
    }
}