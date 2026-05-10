public static class NPCFactory {
    public static Warrior CreateWarrior(string name, int hp, string weaponMastery) {
        Weapon sword = new Weapon("Thunderfury", 115);

        Warrior warrior = new Warrior(name, hp, weaponMastery);
        warrior.EquipWeapon(sword);

        return warrior;
    }

    public static Mage CreateMage(string name, int hp, string arcaneDiscipline) {
        Weapon staff = new Weapon("Staff of Jordan", 115);

        Mage mage = new Mage(name, hp, arcaneDiscipline);
        mage.EquipWeapon(staff);
        
        return mage;
    }
}