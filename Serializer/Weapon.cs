public class Weapon {
    public string Name { get; set; } 
    public double Damage { get; set; }

    public Weapon() {}

    public Weapon(string Name, double Damage) {
        this.Name = Name;
        this.Damage = Damage;
    }
}