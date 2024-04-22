using System.Xml.Linq;

public class SchemaGenerator
{
    public static void GenerateXSD()
    {
        XNamespace xs = "http://www.w3.org/2001/XMLSchema";
        XElement schema = new XElement(xs + "schema",
            new XElement(xs + "element", new XAttribute("name", "Client"),
                new XElement(xs + "complexType",
                    new XElement(xs + "sequence",
                        new XElement(xs + "element", new XAttribute("name", "FirstName"), new XAttribute("type", "xs:string")),
                        new XElement(xs + "element", new XAttribute("name", "LastName"), new XAttribute("type", "xs:string")),
                        new XElement(xs + "element", new XAttribute("name", "ID"), new XAttribute("type", "xs:int"))
                    )
                )
            )
        );

        schema.Save("ClientSchema.xsd");
    }
}
