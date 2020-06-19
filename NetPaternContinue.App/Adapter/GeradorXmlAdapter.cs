using System.IO;
using System.Xml.Serialization;

namespace NetPaternContinue.App.Adapter
{
    public static class GeradorXmlAdapter
    {
        public static string GerarXml(object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}