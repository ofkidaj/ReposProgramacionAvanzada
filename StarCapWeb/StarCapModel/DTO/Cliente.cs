using StarCapModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private string nivel;
        private Bebida bebidaFavorita;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}
