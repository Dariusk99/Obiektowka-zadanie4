using System.Xml.Serialization;

[XmlInclude(typeof(Warrior))]
[XmlInclude(typeof(Mage))]
public abstract class NPC {
    public string Name { get; set; }
    public int HP { get; set; }
    public Weapon? Weapon { get; set; }

    public abstract void Move();

    public NPC() {}

    public NPC(string name, int hp) {
        Name = name;
        HP = hp;
    }

    public override string ToString() {
        return $"[Name:{Name}][HP:{HP}][Equipment:{Weapon?.Name ?? "---"}]";
    }

    public void EquipWeapon(Weapon weapon) {
        Weapon = weapon;
    }
}