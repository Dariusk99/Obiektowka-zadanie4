public class Menu {

    private bool Running;
    private readonly NPCService NpcService;

    public Menu() {
        this.NpcService = new NPCService(new List<NPC>());
    }

    public void ShowMainMenu() {
        this.Running = true;

        while (Running) {
            Console.WriteLine("1. Create enemy");
            Console.WriteLine("2. List enemies");
            Console.WriteLine("3. Save enemies to XML");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine() ?? "";

            switch(input) {
                case "1": this.NpcService.CreateNPC(); break;
                case "2": ListEnemies(); break;
                case "3": this.NpcService.SaveToXml(); break;
                case "4": this.Running = false; break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }
        }
    }

    private void ListEnemies() {
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