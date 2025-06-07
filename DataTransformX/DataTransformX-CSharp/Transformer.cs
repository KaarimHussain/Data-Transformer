using Newtonsoft.Json;
using System.Xml;

public static class Transformer
{
    public static string XmlToJson(string xmlContent)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlContent);
        return JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented, true);
    }

    public static string JsonToXml(string jsonContent)
    {
        var doc = JsonConvert.DeserializeXmlNode(jsonContent, "root");
        return doc.OuterXml;
    }
}