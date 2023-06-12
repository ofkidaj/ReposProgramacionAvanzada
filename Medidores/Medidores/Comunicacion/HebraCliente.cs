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
            if(int.TryParse(clienteCom.Leer(), out int nroMedidor)) {
                clienteCom.Escribir("Ingrese valor del consumo");
                if(double.TryParse(clienteCom.Leer(),out double valorConsumo)) {
                    DateTime datetime = new DateTime();
                    datetime = DateTime.Now;
                    Medidor medidor = new Medidor()
                    {
                        NroMedidor = nroMedidor,
                        Fecha = datetime.ToString("yyyy-MM-dd-HH-mm-ss"),
                        ValorConsumo = valorConsumo
                    };
                    lock (medidorDAL)
                    {
                        medidorDAL.AgregarMedidor(medidor);
                    }
                }
            }
            
            clienteCom.Desconectar();
        }
    }
}

