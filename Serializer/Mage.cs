public class Mage : NPC, IAttack{

    public string ArcaneDiscipline  { get; set; }

    public override void Move() {
        Console.WriteLine("Mage move");
    }

    public Mage() {}

    public Mage(string name, int hp, string arcaneDiscipline) : base(name, hp) {
        ArcaneDiscipline = arcaneDiscipline;
    }

    public override string ToString() {
        return base.ToString() + $"[Arcane discipline:{ArcaneDiscipline}]]";
    }

    public void BaseAttack() {
        Console.WriteLine("Mage attack with wand");
    }

    public void AbilityAttack() {
        Console.WriteLine("Mage cast fireball");
    }
}