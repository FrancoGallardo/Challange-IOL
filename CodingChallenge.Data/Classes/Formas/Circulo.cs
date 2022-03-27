using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeo
    {
        int IFormaGeo.Tipo { get => 3; }

        decimal _radio;

        #region Constructor

        public Circulo(decimal Radio)
        {

            try
            {
                _radio = Radio;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                Console.WriteLine("Se establecen valores por defecto");
                _radio = 1;
            }
        }

        #endregion

        #region Elementos de la Interfaz

        public decimal CalcularArea()
        {
            try
            {
                return (decimal)Math.PI * (this._radio * this._radio);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                return -1;
            }
            
        }

        public decimal CalcularPerimetro()
        {
            try
            {
                return (decimal)Math.PI * (this._radio * 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                return -1;
            }
        }

        #endregion
    }
}
