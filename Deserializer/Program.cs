class Program {
    static void Main(string[] args) {
        NPCService npcService = new NPCService(new List<NPC>());
        
        Menu menu = new Menu(npcService);
        menu.ShowMainMenu();
    }
}