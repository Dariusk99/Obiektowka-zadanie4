public class Weapon {
    public long Id { get; private set; }
    public string Name { get; private set; } 
    public double Damage { get; private set; }

    public Weapon(long Id, string Name, double Damage) {
        this.Id = Id;
        this.Name = Name;
        this.Damage = Damage;
    }
}