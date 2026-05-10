public class Warrior : NPC, IAttack{

    public string WeaponMastery  { get; set; }

    public override void move() {
        Console.WriteLine("Warrior move");
    }

    public Warrior() {}

    public Warrior(string Name, int HP, string WeaponMastery) : base(Name, HP) {
        this.WeaponMastery = WeaponMastery;
    }

    public override string ToString() {
        return base.ToString() + $"[Weapon mastery:{this.WeaponMastery}]]";
    }

    public void BaseAttack() {
        Console.WriteLine("Warrior base attack");
    }

    public void AbilityAttack() {
        Console.WriteLine("Warrior ability attack");
    }
}