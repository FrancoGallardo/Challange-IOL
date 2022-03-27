using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeo
    {
        public int Tipo => 5;
        private decimal ladoMayor;
        private decimal ladoMenor;

        #region Constructor

        public Rectangulo(decimal LadoMayor, decimal LadoMenor)
        {
            try
            {
                this.ladoMayor = LadoMayor;
                this.ladoMenor = LadoMenor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error. INFO: " + ex.Message);
                Console.WriteLine("Se establecen valores por defecto");
                this.ladoMayor = 1;
                this.ladoMenor = 1;
            }
        }

        #endregion

        #region Elementos de la Interfaz

        public decimal CalcularArea()
        {
            try
            {
                return this.ladoMenor * ladoMayor;
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
                return this.ladoMayor * 2 + this.ladoMenor * 2;
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
