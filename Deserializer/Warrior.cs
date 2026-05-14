public class Warrior : NPC, IAttack{

    public string WeaponMastery  { get; set; }

    public override void Move() {
        Console.WriteLine("Warrior move");
    }

    public Warrior() {}

    public Warrior(string name, int hp, string weaponMastery) : base(name, hp) {
        WeaponMastery = weaponMastery;
    }

    public override string ToString() {
        return base.ToString() + $"[Weapon mastery:{WeaponMastery}]]";
    }

    public void BaseAttack() {
        Console.WriteLine("Warrior base attack");
    }

    public void AbilityAttack() {
        Console.WriteLine("Warrior ability attack");
    }
}