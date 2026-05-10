class Program {
    static void Main(string[] args) {
        Warrior warrior = new Warrior(1, "Szkielet-goblin", 100, "Sword");

        Weapon thunderfury = new Weapon(1, "Thunderfury", 115);
        warrior.EquipWeapon(thunderfury);
        Console.WriteLine(warrior);
    }
}