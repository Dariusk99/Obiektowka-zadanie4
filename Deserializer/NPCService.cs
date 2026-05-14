using System.Xml.Serialization;

public class NPCService {

    private readonly List<NPC> NPCs;

    public NPCService(List<NPC> npcs) {
        NPCs = npcs;
    }

    public List<NPC> GetAllNPC() {
        return NPCs;
    }

    public void LoadFromXml() {
        XmlSerializer serializer = new XmlSerializer(typeof(ArrayOfNPC));
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "enemies.xml"));
        using FileStream fs = new FileStream(path, FileMode.Open);
        ArrayOfNPC loadedNPCs = (ArrayOfNPC)serializer.Deserialize(fs);

        NPCs.Clear();
        NPCs.AddRange(loadedNPCs.NPCs);
    }
}