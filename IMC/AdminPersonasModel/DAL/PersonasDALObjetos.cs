using IMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALObjetos : IPersonasDAL
    {
        //1. crear lista para guardar personas

        private static List<Persona> personas = new List<Persona>();

        //2. crear las operaciones ingresar, mostrar y buscar
        public void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public List<Persona> FiltrarPersonas(String nombre)
        {
            List<Persona> filtrada = new List<Persona>();

            /* metodo 1

           for (int i=0; i < personas.Count(); i++)
             {
                 if (personas[i].Nombre == nombre)
                 {
                     filtrada.Add(personas[i]);
                 }
           */
            /* metodo 2

            foreach (Persona persona in personas)
            { if(p.Nombre == nombre)
                {
                    filtrada.Add(persona);
                }
            }
            */
            //metodo 3
            return personas.FindAll(p => p.Nombre == nombre);

            //return filtrada;
        }
    }
}
