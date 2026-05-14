public class Weapon {
    public string Name { get; set; } 
    public double Damage { get; set; }

    public Weapon() {}

    public Weapon(string name, double damage) {
        Name = name;
        Damage = damage;
    }
}