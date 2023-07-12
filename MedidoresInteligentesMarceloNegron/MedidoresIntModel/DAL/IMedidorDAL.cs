
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresIntModel
{
    public interface IMedidorDAL
    {
            

            List<Medidor> ObtenerMedidores();

            void AgregarMedidores(Medidor medidor);
       
            void Eliminar(int nroMedidor);
    }
}
