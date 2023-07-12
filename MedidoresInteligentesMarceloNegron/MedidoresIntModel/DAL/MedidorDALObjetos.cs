
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresIntModel
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
        
        public void Eliminar(int nroMedidor
            )
        {
            Medidor eliminado = medidores.Find(c => c.NroMedidor == nroMedidor);
            medidores.Remove(eliminado);
        }
    }
    }
