using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    internal class Moto : Vehiculo
    {
        #region Atributos
        /* casco */
        private bool casco;
        #endregion

        #region Metodos
        public bool Casco
        {
            get { return casco; }
            set { casco = value; }
        }
        #endregion
    }
}
