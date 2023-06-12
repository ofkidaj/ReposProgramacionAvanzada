using Medidores.Comunicacion;
using MedidoresModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medidores
{
    public class Program
    {
        private static IMedidorDAL mensajesDAL = MedidorDALArchivos.GetInstancia();
        static bool Menu()
        {
            bool contia = true;
            Console.WriteLine("\nQue hacer?");
            Console.WriteLine("1.- Ingresar \n2.- Mostrar \n3.- Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    Ingresar();
                    break;
                case "2":
                    Mostrar();
                    break;
                case "3":
                    contia = false;
                    break;
                default:
                    Console.WriteLine("\nerror, ingresa denuevo");
                    break;
            }
            return contia;
        }
        static void Main(string[] args)
        {
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();

            while (Menu())
            {
            }
        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese numero de medidor : ");
            if(int.TryParse(Console.ReadLine().Trim(), out int nroMedidor)){


                Console.WriteLine("Ingrese valor de consumo : ");
                DateTime datetime = new DateTime();
                datetime = DateTime.Now;

                if (double.TryParse(Console.ReadLine().Trim(), out double valorConsumo))
                {
                    Medidor medidor = new Medidor()
                    {
                        NroMedidor = nroMedidor,
                        Fecha = datetime.ToString("yyyy-MM-dd-HH-mm-ss"),
                        ValorConsumo = valorConsumo
                    };
                    lock (mensajesDAL)
                    {
                        mensajesDAL.AgregarMedidor(medidor);
                    }
                }
            }
        }
            

        static void Mostrar()
        {
            List<Medidor> medidor = null;
            lock (mensajesDAL)
            {
                medidor = mensajesDAL.ObtenerMedidor();
            }
            foreach (Medidor med in medidor)
            {
                Console.Write(med.ToString());
            }
        }
    }
}
