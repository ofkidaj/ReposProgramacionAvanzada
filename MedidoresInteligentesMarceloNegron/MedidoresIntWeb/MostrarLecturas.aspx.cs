using MedidoresIntModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresIntWeb
{
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
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
            List<Lectura> lectura = lecturaDAL.ObtenerLecturas();
            this.GrillaLecturas.DataSource = lectura;
            this.GrillaLecturas.DataBind();
        }


        protected void GrillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {


        }
    }
}