using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Triangulo : IFormaGeo
    {
        int IFormaGeo.Tipo { get => 2; }

        decimal _lado;

        #region Constructor

        public Triangulo(decimal Lado)
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
                return ((decimal)Math.Sqrt(3) / 4) * this._lado * this._lado;
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
                return this._lado * 3;
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
