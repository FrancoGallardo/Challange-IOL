using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        #region Test de Funcionalidad

        #region Listas Vacias

        [TestCase]
        public void TestResumenListaFormasVaciaEnCastellano()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeo>(), "Castellano"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeo>(), "Ingles"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeo>(), "Portugues"));
        }

        #endregion

        #region Listas con Contenido

        #region Venian con el Proyecto
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeo> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, "Castellano");

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas | Area 25 | Perimetro 20", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeo>
                    {
                        new Cuadrado(5),
                        new Cuadrado(1),
                        new Cuadrado(3)
                    };

            var resumen = FormaGeometrica.Imprimir(cuadrados, "Ingles");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes | Area 35 | Perimeter 36", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeo>
                    {
                        new Cuadrado(5),
                        new Circulo(3),
                        new Triangulo(4),
                        new Cuadrado(2),
                        new Triangulo(9),
                        new Circulo(2.75m),
                        new Triangulo(4.2m)
                    };

            var resumen = FormaGeometrica.Imprimir(formas, "Ingles");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>TOTAL:<br/>7 Shapes | Area 130,67 | Perimeter 115,73",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeo>
                    {
                        new Cuadrado(5),
                        new Circulo(3),
                        new Triangulo(4),
                        new Cuadrado(2),
                        new Triangulo(9),
                        new Circulo(2.75m),
                        new Triangulo(4.2m)
                    };

            var resumen = FormaGeometrica.Imprimir(formas, "Castellano");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>TOTAL:<br/>7 Formas | Area 130,67 | Perimetro 115,73",
                resumen);
        }

        #endregion

        #region Nuevas

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulos = new List<IFormaGeo> { new Rectangulo(7,3) };

            var resumen = FormaGeometrica.Imprimir(rectangulos, "Portugues");

            Assert.AreEqual("<h1>Relatório de formas</h1>1 Retângulo | Area 21 | Perimetro 20 <br/>TOTAL:<br/>1 Figura | Area 21 | Perimetro 20", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var rectangulos = new List<IFormaGeo> 
            {
                new Rectangulo(7, 3),
                new Rectangulo(6, 2)
            };

            var resumen = FormaGeometrica.Imprimir(rectangulos, "Ingles");

            Assert.AreEqual("<h1>Shapes report</h1>2 Rectangles | Area 33 | Perimeter 36 <br/>TOTAL:<br/>2 Shapes | Area 33 | Perimeter 36", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<IFormaGeo> { new Trapecio(15, 12, 6) };

            var resumen = FormaGeometrica.Imprimir(trapecios, "Portugues");

            Assert.AreEqual("<h1>Relatório de formas</h1>1 Trapézio | Area 81 | Perimetro 39,71 <br/>TOTAL:<br/>1 Figura | Area 81 | Perimetro 39,71", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var trapecios = new List<IFormaGeo>
            {
                new Trapecio(8,4,3),
                new Trapecio(10,4,4)
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, "Castellano");

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Area 46 | Perimetro 45,21 <br/>TOTAL:<br/>2 Formas | Area 46 | Perimetro 45,21", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortugues()
        {
            var formas = new List<IFormaGeo>
                    {
                        new Cuadrado(5),
                        new Circulo(3),
                        new Triangulo(4),
                        new Cuadrado(2),
                        new Triangulo(9),
                        new Circulo(2.75m),
                        new Triangulo(4.2m),
                        new Trapecio(8,4,3),
                        new Rectangulo(7, 3),
                        new Trapecio(10,4,4),
                        new Rectangulo(6, 2)
                    };

            var resumen = FormaGeometrica.Imprimir(formas, "Portugues");

            Assert.AreEqual(
                "<h1>Relatório de formas</h1>2 Quadrados | Area 29 | Perimetro 28 <br/>3 Triângulos | Area 49,64 | Perimetro 51,6 <br/>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>2 Trapézios | Area 46 | Perimetro 45,21 <br/>2 Retângulos | Area 33 | Perimetro 36 <br/>TOTAL:<br/>11 Figura | Area 209,67 | Perimetro 196,94",
                resumen);
        }

        #endregion

        #endregion

        #endregion

        #region Test de Traducciones

        #region En Singular

        [TestCase]
        public void TestTraduccionIngles()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo", "Ingles");
            Assert.AreEqual("Triangle", result);
        }

        [TestCase]
        public void TestTraduccionCastellano()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo", "Castellano");
            Assert.AreEqual("Triángulo", result);
        }

        [TestCase]
        public void TestTraduccionPortugues()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo", "Portugues");
            Assert.AreEqual("Triângulo", result);
        }

        #endregion

        #region En Plural

        [TestCase]
        public void TestTraduccionInglesPlural()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo_Plural", "Ingles");
            Assert.AreEqual("Triangles", result);
        }

        [TestCase]
        public void TestTraduccionCastellanoPlural()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo_Plural", "Castellano");
            Assert.AreEqual("Triángulos", result);
        }

        [TestCase]
        public void TestTraduccionPortuguesPlural()
        {
            Traduccion traduccionPruebas = new Traduccion();
            var result = traduccionPruebas.ObtenerTraduccion("Triangulo_Plural", "Portugues");
            Assert.AreEqual("Triângulos", result);
        }

        #endregion

        #endregion
    }
}
