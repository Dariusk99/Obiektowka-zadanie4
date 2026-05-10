public abstract class NPC {
    public long Id { get; private set; }
    public string Name { get; private set; }
    public int HP { get; private set; }
    public Weapon? Weapon { get; private set; }

    public abstract void move();

    public NPC(long Id, string Name, int HP) {
        this.Id = Id;
        this.Name = Name;
        this.HP = HP;
    }

    public override string ToString() {
        return $"[Id:{this.Id}][Name:{this.Name}][HP:{this.HP}][Equipment:{this.Weapon?.Name ?? "---"}]";
    }

    public void EquipWeapon(Weapon Weapon) {
        this.Weapon = Weapon;
    }
}