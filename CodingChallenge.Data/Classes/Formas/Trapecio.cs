using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : IFormaGeo
    {
        public int Tipo => 4;

        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;

        #region Constructor

        public Trapecio(decimal BaseMayor, decimal BaseMenor, decimal Altura) 
        {
            try
            {
                if (baseMenor > baseMayor)
                {
                    this.baseMayor = BaseMenor;
                    this.baseMenor = BaseMayor;
                }
                else 
                {
                    this.baseMayor = BaseMayor;
                    this.baseMenor = BaseMenor;
                }
                this.altura = Altura;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                Console.WriteLine("Se establecen valores por defecto");
                this.baseMayor = 1M;
                this.baseMenor = 2M;
                this.altura = 2M;
            }
        }

        #endregion

        #region Elementos de la Interfaz

        public decimal CalcularArea()
        {
            try
            {
                return ((baseMayor + baseMenor) /2) * altura;
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
                double baseTriangulo = Convert.ToDouble(baseMayor - baseMenor);
                double hipotenusa = Math.Sqrt(Convert.ToDouble((altura * altura)) + (baseTriangulo * baseTriangulo));

                return baseMayor + baseMenor + altura + Convert.ToDecimal(hipotenusa);
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
