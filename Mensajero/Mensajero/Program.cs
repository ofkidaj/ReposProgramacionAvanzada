﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mensajero.Comunicacion;
using MensajeroModel;
using ServidorSocketUtil;

namespace Mensajero
{
    public class Program
    {
        private static IMensajesDAL mensajesDAL = MensajesDALArchivos.GetInstancia();
        static bool Menu()
        {
            bool contia = true;
            Console.WriteLine("Que hacer?");
            Console.WriteLine("1.- Ingresar \n 2.Ingresar por TCP \n 3.Mostrar \n Salir");
            switch(Console.ReadLine().Trim()){
                case "1": Ingresar();
                    break;
                case "2": IniciarServidor();
                    break;
                case "3": Mostrar();
                    break;
                case "0":
                    contia = false;
                    break;
                default: Console.WriteLine("error, ingresa denuevo");
                    break;

                    
            }return contia;
        }

        static void IniciarServidor()
        {
            
        }

        static void Main(string[] args)
        {
            //1.iniciar servidor puerto 3000
            //2. puerto configurable en App.config
            //3. cuanod reciba un cliente, tiene que solicitar nombre, texto y agregar un nuevo mensaje tipo TCP
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();
            //IniciarServidor();
            //1. como atender mas de 1 cliente a la va¿ez
            //2. como evito que 2 clientres ingresen a  archivos a la vez
            //3. como evitar el bloqueo mutuo

            while (Menu()) { 
            }
        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese nombre : ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese texto : ");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "aplicacion"
            };
           mensajesDAL.AgregarMensaje(mensaje);
        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = null;
            lock (mensajesDAL) { 
                mensajes= mensajesDAL.ObtenerMensajes();
            }
            foreach(Mensaje men in mensajes)
            {
                Console.Write(men.ToString());
            }
        }
    }
}
