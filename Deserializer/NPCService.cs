using System.Xml.Serialization;

public class NPCService {

    private readonly List<NPC> NPCs;

    public NPCService(List<NPC> NPCs) {
        this.NPCs = NPCs;
    }

    public List<NPC> GetAllNPC() {
        return this.NPCs;
    }

    public void LoadFromXml() {
        XmlSerializer serializer = new XmlSerializer(typeof(ArrayOfNPC));
        using FileStream fs = new FileStream("enemies.xml", FileMode.Open);
        ArrayOfNPC loadedNPCs = (ArrayOfNPC)serializer.Deserialize(fs);

        this.NPCs.Clear();
        this.NPCs.AddRange(loadedNPCs.NPCs);
    }
}