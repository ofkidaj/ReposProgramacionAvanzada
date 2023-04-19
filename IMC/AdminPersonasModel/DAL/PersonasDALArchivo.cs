using IMC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivo : IPersonasDAL
    {
        private static string archivo = "personas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
        public void AgregarPersona(Persona p)
        {
            //1.crear Streamwriter
            //2.agregar linea del archivo
            //3.cerrar Streamwriter
            try
            {
                using (StreamWriter write = new StreamWriter(ruta,true)) {
                    String texto = p.Nombre + ";" +
                                    p.Estatura + ";" +
                                    p.Telefono + ";" +
                                    p.Peso + ";";
                    write.WriteLine(texto);
                    write.Flush();
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error al escribir el archivo "+ex.Message);
            }
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p =>  p.Nombre == nombre);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using (StreamReader reader = new StreamReader(ruta)) {
                String texto;
                do
                {
                    //leer desde el archivo hasta que no haya nada
                    texto = reader.ReadLine();
                    if(texto != null)
                    {
                        String[] textoarr = texto.Trim().Split(';');
                        String nombre = textoarr[0];
                        double estatura = Convert.ToDouble(textoarr[1]);
                        uint telefono = Convert.ToUInt32(textoarr[2]);
                        Double peso = Convert.ToDouble(textoarr[3]);
                        //crear una persona
                        Persona p = new Persona()
                        {
                            Nombre = nombre,
                            Estatura = estatura,
                            Telefono = telefono,
                            Peso = peso
                        };
                        // calcular IMC
                        p.calcularImc();
                        //agregar a la lista
                        personas.Add(p);
                    }
                    
                } while (texto!= null);
            }
            return personas;
        }
    }
}
