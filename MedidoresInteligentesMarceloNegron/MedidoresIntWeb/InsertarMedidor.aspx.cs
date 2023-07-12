using MedidoresIntModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresIntWeb
{
    public partial class InsertarMedidor : System.Web.UI.Page
    {

        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 

        protected void InsertMed_Click(object sender, EventArgs e)
        {
            //obtener datos
            int numero = Convert.ToInt32(nrMedidor.Text.Trim());
            DateTime fecha = fechaMedidor.SelectedDate;
            double valor = Convert.ToDouble(valorConsumoMedidor.Text.Trim());
            string tipo = tipMedidor.Text.Trim();
            //crear objeto
            Medidor medidor = new Medidor()
            {
                NroMedidor = numero,
                FechaMedidor = fecha,
                ValorConsumoMedidor = valor,
                TipoMedidor = tipo
            };

            //llamar DAL
            medidorDAL.AgregarMedidores(medidor);
            //redirijir
            Response.Redirect("VerMedidor.aspx");
        }
    }
}