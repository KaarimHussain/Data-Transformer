using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: dotnet run [xml2json|json2xml] [filePath]");
            return;
        }

        string mode = args[0];
        string path = args[1];

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string content = File.ReadAllText(path);

        if (mode == "xml2json")
        {
            string result = Transformer.XmlToJson(content);
            Console.WriteLine(result);
        }
        else if (mode == "json2xml")
        {
            string result = Transformer.JsonToXml(content);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid mode.");
        }
    }
}