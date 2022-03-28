/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {

        #region Nuevo Sistema

        public static string Imprimir(List<IFormaGeo> formas, string idioma)
        {
            try
            {
                var sb = new StringBuilder();

                Traduccion traduccion = new Traduccion();

                if (!formas.Any()) //Verifica si esta vacia la lista
                {
                    sb.Append(traduccion.ObtenerTraduccion("Header_vacio", idioma));
                }
                else
                {
                    // Hay por lo menos una forma
                    // HEADER
                    sb.Append(traduccion.ObtenerTraduccion("Header", idioma));

                    int totalFormas = 0;
                    decimal totalArea = 0m;
                    decimal totalPerimetro = 0m;

                    for (int i = 1; i <= 5; i++)
                    {
                        int numeroForma = 0;
                        decimal areaForma = 0m;
                        decimal perimetroForma = 0m;
                        var Listformas = formas.Where(f => f.Tipo == i);

                        foreach (var forma in Listformas)
                        {
                            numeroForma++;
                            areaForma += forma.CalcularArea();
                            perimetroForma += forma.CalcularPerimetro();
                        }

                        if (numeroForma > 0)
                        {
                            string Linea = numeroForma + " ";


                            switch (i)
                            {
                                case 1:
                                    Linea += traduccion.ObtenerTraduccion("Cuadrado", idioma, numeroForma == 1 ? true : false);
                                    break;
                                case 2:
                                    Linea += traduccion.ObtenerTraduccion("Triangulo", idioma, numeroForma == 1 ? true : false);
                                    break;
                                case 3:
                                    Linea += traduccion.ObtenerTraduccion("Circulo", idioma, numeroForma == 1 ? true : false);
                                    break;
                                case 4:
                                    Linea += traduccion.ObtenerTraduccion("Trapecio", idioma, numeroForma == 1 ? true : false);
                                    break;
                                case 5:
                                    Linea += traduccion.ObtenerTraduccion("Rectangulo", idioma, numeroForma == 1 ? true : false);
                                    break;

                            }
                            Linea += traduccion.ObtenerTraduccion("Area", idioma) + areaForma.ToString("#.##") + traduccion.ObtenerTraduccion("Perimetro", idioma) + perimetroForma.ToString("#.##");
                            sb.Append(Linea + " <br/>");

                            totalFormas += numeroForma;
                            totalArea += areaForma;
                            totalPerimetro += perimetroForma;
                        }
                    }

                    // FOOTER
                    string footer = traduccion.ObtenerTraduccion("Total", idioma) + "<br/>" + totalFormas + traduccion.ObtenerTraduccion("Formas", idioma) +
                          traduccion.ObtenerTraduccion("Area", idioma) + totalArea.ToString("#.##") + traduccion.ObtenerTraduccion("Perimetro", idioma) + totalPerimetro.ToString("#.##");
                    sb.Append(footer);
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "Ocurrio un error. INFO:" + ex.Message;
            }
           
        }

        #endregion

        #region Anterior Sistema

       /* #region Formas

        public int Tipo { get; set; } // Representa la forma

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion

        private readonly decimal _lado;


        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }*/

      /*  public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any()) //Verifica si esta vacia la lista
            {
                if (idioma == Castellano)
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                if (idioma == Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else
                    // default es inglés
                    sb.Append("<h1>Shapes report</h1>");

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo == Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                }
                
                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }*/

        /* private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
         {
             if (cantidad > 0)
             {
                 if (idioma == Castellano)
                     return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                 return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
             }

             return string.Empty;
         }

          private static string TraducirForma(int tipo, int cantidad, int idioma)
          {
              switch (tipo)
              {
                  case Cuadrado:
                      if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                      else return cantidad == 1 ? "Square" : "Squares";
                  case Circulo:
                      if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                      else return cantidad == 1 ? "Circle" : "Circles";
                  case TrianguloEquilatero:
                      if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                      else return cantidad == 1 ? "Triangle" : "Triangles";
              }

              return string.Empty;
          }

          public decimal CalcularArea()
          {
              switch (Tipo)
              {
                  case Cuadrado: return _lado * _lado;
                  case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                  case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                  default:
                      throw new ArgumentOutOfRangeException(@"Forma desconocida");
              }
          }

          public decimal CalcularPerimetro()
          {
              switch (Tipo)
              {
                  case Cuadrado: return _lado * 4;
                  case Circulo: return (decimal)Math.PI * _lado;
                  case TrianguloEquilatero: return _lado * 3;
                  default:
                      throw new ArgumentOutOfRangeException(@"Forma desconocida");
              }
          }*/

        #endregion
    }
}
