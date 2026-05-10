public class Mage : NPC, IAttack{

    public string ArcaneDiscipline  { get; set; }

    public override void move() {
        Console.WriteLine("Mage move");
    }

    public Mage() {}

    public Mage(string Name, int HP, string ArcaneDiscipline) : base(Name, HP) {
        this.ArcaneDiscipline = ArcaneDiscipline;
    }

    public override string ToString() {
        return base.ToString() + $"[Arcane discipline:{this.ArcaneDiscipline}]]";
    }

    public void BaseAttack() {
        Console.WriteLine("Mage attack with wand");
    }

    public void AbilityAttack() {
        Console.WriteLine("Mage cast fireball");
    }
}