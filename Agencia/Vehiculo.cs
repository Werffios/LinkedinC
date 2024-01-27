using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    # region    enumPublic
    public enum ColorVehiculo
    {
        Ninguno,
        Blanco,
        Gris,
        Rojo,
        Vino,
        Azul,
        Negro
    }
    public enum Estado
    {
        Existencia,
        Vendido,
        Entregado,
    }
    #endregion
    internal class Vehiculo
    {
        #region Atributos
        /* id, llantas, modelo, anio */
        private int id;
        private int llantas;
        private string modelo;
        private int anio;
        ColorVehiculo color;
        Estado estado;
        #endregion

        #region Metodos
        public string Capturar()
        {
            // Capturar in db
            return "capturado";
        }
        public string Vender()
        {
            // Registra la venta en la bd
            return "Vendido";
        }

        public Vehiculo()
        {
            id = 0;
            modelo = "";
            anio = 2017;
            color = ColorVehiculo.Ninguno;
            estado = Estado.Existencia;
        }


        #endregion
    }
}
