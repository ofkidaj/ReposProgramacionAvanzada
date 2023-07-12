using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresIntModel
{
    public class Medidor
    {
        private int nroMedidor;
        private DateTime fechaMedidor;
        private double valorConsumoMedidor;
        private string tipoMedidor;

        public int NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public DateTime FechaMedidor { get => fechaMedidor; set => fechaMedidor = value; }
        public double ValorConsumoMedidor { get => valorConsumoMedidor; set => valorConsumoMedidor = value; }
        public string TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
