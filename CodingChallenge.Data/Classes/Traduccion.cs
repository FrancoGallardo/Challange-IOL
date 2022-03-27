using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodingChallenge.Data.Classes
{
    public class Traduccion
    {
        private const string RESOURCE_PATH = @"..\CodingChallenge\CodingChallenge.Data\Resources\Lenguajes.xml";
        XmlDocument xmlDocument = new XmlDocument();

        private static Traduccion Inst_Traduccion = new Traduccion();

        public Traduccion()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
            }
        }

        public static Traduccion GetInstance()
        {
            return Inst_Traduccion;
        }

        public string ObtenerTraduccion(string etiquetaXML, string idioma, bool Singular = true) 
        {
            try
            {
                if (!Singular)
                {
                    etiquetaXML += "_Plural";
                }
                xmlDocument.Load(RESOURCE_PATH);
                foreach (XmlNode xmlNode in xmlDocument.ChildNodes[1].ChildNodes)
                {
                    if (xmlNode.Name == idioma) 
                    {
                        foreach (XmlNode item in xmlNode.ChildNodes)
                        {
                            if (item.OuterXml.Split('>')[0].Substring(1) == etiquetaXML) 
                            {
                                return item.InnerXml;
                            }
                        }
                    }
                }
                return etiquetaXML;
            }
            catch (Exception ex)
            {
                return etiquetaXML;
            }
        }
    }
}
