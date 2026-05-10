using System.Xml.Serialization;

[XmlRoot("ArrayOfNPC")]
public class ArrayOfNPC {

    [XmlElement("NPC")]
    public List<NPC> NPCs { get; set; }
}