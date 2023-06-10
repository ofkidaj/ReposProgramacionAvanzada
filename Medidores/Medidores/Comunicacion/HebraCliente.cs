using MedidoresModel;
using ServidorSocketUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores.Comunicacion
{
    public class HebraCliente
    {
        private static IMedidorDAL medidorDAL = MedidorDALArchivos.GetInstancia();
        private ClienteCom clienteCom;

        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }
        public void Ejecutar()
        {

            clienteCom.Escribir("Ingresar numero de medidor : ");
            string nroMedidor = clienteCom.Leer();
            clienteCom.Escribir("Ingrese fecha");
            string fecha = clienteCom.Leer();
            clienteCom.Escribir("Ingrese valor del consumo");
            string valorConsumo = clienteCom.Leer();
            Medidor medidor = new Medidor()
            {
                NroMedidor = nroMedidor,
                Fecha = fecha,
                ValorConsumo = valorConsumo
            };
            lock (medidorDAL)
            {
                medidorDAL.AgregarMedidor(medidor);
            }

            clienteCom.Desconectar();
        }
    }
}

