using System.Xml.Serialization;

[XmlInclude(typeof(Warrior))]
[XmlInclude(typeof(Mage))]
public abstract class NPC {
    public string Name { get; set; }
    public int HP { get; set; }
    public Weapon? Weapon { get; set; }

    public abstract void move();

    public NPC() {}

    public NPC(string Name, int HP) {
        this.Name = Name;
        this.HP = HP;
    }

    public override string ToString() {
        return $"[Name:{this.Name}][HP:{this.HP}][Equipment:{this.Weapon?.Name ?? "---"}]";
    }

    public void EquipWeapon(Weapon Weapon) {
        this.Weapon = Weapon;
    }
}