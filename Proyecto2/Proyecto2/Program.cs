using Proyecto2.Comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Iniciando servidor en puerto {0}",puerto);
            ServerSocket servidor = new ServerSocket(puerto);
            if (servidor.Iniciar())
            {
                //Conecta
                Console.WriteLine("Servidor iniciado");
                while (true)
                {
                    Console.WriteLine("Esperando cliente");
                    Socket socketCliente = servidor.ObtenerCliente();
                    //construir escritura y lectura
                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //protocolo de comunicacion
                    cliente.Escribir("Hola Mundo cliente, dame tu nombre");
                    String respuesta = cliente.Leer();
                    Console.WriteLine("El cliente mando {0}",respuesta);
                    cliente.Escribir("Chao");
                    cliente.Desconectar();
                }
            }
            else
            {
                //probando
                Console.WriteLine("Error, el puerto {0} esta en uso",puerto);
            }
        }
    }
}
