using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

public class DataConverter
{
    public static void ConvertCsvToXmlAndJson(string csvFilePath)
    {
        string[] lines = File.ReadAllLines(csvFilePath);
        XElement xml = new XElement("Clients",
            lines.Select(line => new XElement("Client",
                line.Split(',').Select((column, index) => new XElement($"Field{index + 1}", column))
            ))
        );

        xml.Save("Output.xml");

        string json = JsonConvert.SerializeObject(xml);
        File.WriteAllText("Output.json", json);
    }
}
