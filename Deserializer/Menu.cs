public class Menu {

    private bool Running;
    private readonly NPCService NpcService;

    public Menu() {
        this.NpcService = new NPCService(new List<NPC>());
    }

    public void ShowMainMenu() {
        this.Running = true;

        while (Running) {
            Console.WriteLine("1. Load from XML");
            Console.WriteLine("2. Exit");

            string input = Console.ReadLine() ?? "";

            switch(input) {
                case "1": ListEnemiesFromXml(); break;
                case "2": this.Running = false; break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }
        }
    }

    private void ListEnemiesFromXml() {
        NpcService.LoadFromXml();
        List<NPC> npcs = NpcService.GetAllNPC();
        
        if (npcs == null || npcs.Count == 0) {
            Console.WriteLine("No enemies found");
            return;
        }

        foreach (NPC npc in npcs) {
            Console.WriteLine(npc);
        }
    }
}