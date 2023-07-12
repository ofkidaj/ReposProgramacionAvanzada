
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresIntModel
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);
    }
}
