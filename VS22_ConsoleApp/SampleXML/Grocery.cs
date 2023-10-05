using System.Xml.Serialization;

namespace PROG260_Week5.SampleXML
{
    [XmlRoot(ElementName = "menu")]
    public class Grocery
    {
        [XmlElement(ElementName = "item")]
        public List<GroceryItem> Inventory { get; set; }
    }
}