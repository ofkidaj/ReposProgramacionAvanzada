using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresIntModel
{
    public class Lectura
    {
        private Medidor medidor;
        private DateTime fechaDeLectura;
        private double valorConsumoLectura;
        private string HoradeLectura;

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public DateTime FechaDeLectura { get => fechaDeLectura; set => fechaDeLectura = value; }
        public double ValorConsumoLectura { get => valorConsumoLectura; set => valorConsumoLectura = value; }
        public string HoradeLectura1 { get => HoradeLectura; set => HoradeLectura = value; }
    }
}
