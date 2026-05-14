using System.Xml.Serialization;

public class NPCService {

    private readonly List<NPC> NPCs;

    public NPCService(List<NPC> npcs) {
        NPCs = npcs;
    }

    public void CreateNPC() {
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Enter HP: ");
        int hp = int.Parse(Console.ReadLine() ?? "100");

        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");

        string input = Console.ReadLine() ?? "";

        NPC npc;

        switch(input) {
            case "1":
                Console.WriteLine("Choose weapon mastery: ");
                string weaponMastery = Console.ReadLine() ?? "";

                npc = NPCFactory.CreateWarrior(name, hp, weaponMastery);
                break;

            case "2": 
                Console.WriteLine("Choose arcane discipline: ");
                string arcaneDiscipline = Console.ReadLine() ?? "";

                npc = NPCFactory.CreateMage(name, hp, arcaneDiscipline);
                break;
            
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        NPCs.Add(npc);

        Console.WriteLine("Created: " + npc);
    }

    public List<NPC> GetAllNPC() {
        return NPCs;
    }

    public void SaveToXml() {
        XmlSerializer serializer = new XmlSerializer(typeof(List<NPC>));
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "enemies.xml"));
        using TextWriter writer = new StreamWriter(path);
        serializer.Serialize(writer, NPCs);
    }
}