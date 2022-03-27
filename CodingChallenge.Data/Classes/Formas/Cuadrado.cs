using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Cuadrado : IFormaGeo
    {
        int IFormaGeo.Tipo { get => 1; }

        decimal _lado;

        #region Constructor

        public Cuadrado(decimal Lado) 
        {
            try
            {
                _lado = Lado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                Console.WriteLine("Se establecen valores por defecto");
                _lado = 1;
            }
        }

        #endregion

        #region Elementos de la Interfaz

        public decimal CalcularArea()
        {
            try
            {
                return this._lado * this._lado;
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
                return this._lado * 4;
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
