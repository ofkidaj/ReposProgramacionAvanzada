using StarCapModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {

        /// <summary>
        /// Este metodo se ejecuta cuando se carga el form
        /// - cuando es una peticion GET (!PostBack)
        /// - cuando es una peticion POST (PostBack)
        /// </summary>
 
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
                this.bebidaDdl.DataSource = bebidas;
                this.bebidaDdl.DataTextField = "Nombre";
                this.bebidaDdl.DataValueField = "Codigo";
                this.bebidaDdl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1.Obtener datos del formulario
            string nombre = this.nombretxt.Text.Trim();
            string rut = this.ruttxt.Text.Trim();
            //obtener valor del dropdown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //Obtener valor del texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Text.Trim();
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedValue);

            Bebida bebida = new Bebida()
            {
                Codigo = bebidaValor,
                Nombre= bebidaTexto
            };

            //2.Construir el objeto del tipo cliente
            Cliente cliente = new Cliente()
            { 
            Nombre= nombre,
            Rut= rut,
            Nivel= nivel,
            BebidaFavorita= bebida
            };

            //3.Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4.Mostrar Mensaje de texto
            this.mensaje.Text = "Cliente Ingresado";
        }
    }
}