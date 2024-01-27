using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    internal class Automovil : Vehiculo
    {
        #region Atributos
        /* puertas */

        private int puertas;
        #endregion
        public Automovil()
        {
            this.puertas = 4;
        }
        public Automovil(int puertas)
        {
            this.puertas = puertas;
        }
        #region Metodos
        public int Puertas
        {
            get { return puertas; }
            set { puertas = value; }
        }

        public int Id { get; set; }
        public int Llantas { get; set; }
        public int Color { get; set; }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public int Estado { get; set; }


        #endregion
    }

}
