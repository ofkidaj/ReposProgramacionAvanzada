using MedidoresIntModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresIntWeb
{
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
                List<Medidor> medidor = medidorDAL.ObtenerMedidores();
                this.med.DataSource = medidor;
                this.med.DataTextField = "nroMedidor";
                this.med.DataValueField = "nroMedidor";
                this.med.DataBind();
                
            

        }

        protected void InsertLect_Click(object sender, EventArgs e)
        {
            //obtener datos
            int medidorvalor= Convert.ToInt32(med.SelectedValue.Trim());
            string medidortecto = this.med.SelectedItem.Text.Trim();

            DateTime fecha = fechaMedidor.SelectedDate;
            double valor = Convert.ToDouble(valorConsumoLectura.Text.Trim());
            string horalec = hora.Text.Trim()+minuto.Text.Trim();


            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            Medidor m1 = medidores.Find(b => b.NroMedidor ==  Convert.ToInt32(this.med.SelectedItem.Value)); ;


            //crear objeto
            Lectura lectura = new Lectura()
            {
                Medidor = m1,
                FechaDeLectura = fecha,
                ValorConsumoLectura = valor,
                HoradeLectura1 = horalec
            };

            //llamar DAL
            lecturaDAL.AgregarLectura(lectura);
            //redirijir
            
            Response.Redirect("MostrarLecturas.aspx");

        }
    }
}