public class Warrior : NPC, IAttack{

    public string WeaponMastery  { get; private set; }

    public override void move() {
        Console.WriteLine("Warrior move");
    }

    public Warrior(long Id, string Name, int HP, string WeaponMastery) : base(Id, Name, HP) {
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