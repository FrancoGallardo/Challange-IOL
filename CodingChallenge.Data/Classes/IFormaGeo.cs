using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public interface IFormaGeo
    {
        int Tipo { get;}

        decimal CalcularArea();

        decimal CalcularPerimetro();
    }
}
