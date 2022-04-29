using System;
using Library;

namespace Pprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea el hechizo del mago y se agrega al WizardBook.
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item WizzardArmor = new Item("ArmorWizzard",0, 20);
            Item Sword = new Item("espada", 25, 0);
            Item Sword2 = new Item("espada2", 50, 0);

            wizzard.EquipItem(WizzardArmor);
            wizzard.EquipItem(Sword);
            wizzard.EquipItem(Sword2);

            //Se crea el personaje Dwarf junto a sus items y se lo equipa.
            Dwarf dwarf = new Dwarf("dwarf", 20);
            Item Knife = new Item("Knife", 25, 0);
            Item dwarfArmor = new Item("dwarfArmor", 0, 20);
            dwarf.EquipItem(Knife);
            dwarf.EquipItem(dwarfArmor);


            //Se crea el personaje Human junto a sus items y se lo equipa.
            Human human = new Human("human", 50);
            Item weapon = new Item("weapon", 60, 0);
            Item humanArmor = new Item("humanArmor", 0, 60);
            human.EquipItem(weapon);
            human.EquipItem(humanArmor);

            //Se crea el personaje Elf junto a sus items y se lo equipa.
            Elf elf = new Elf("elf", 25);
            Item darkKnife = new Item("DarkKnife", 50, 0);
            Item elfArmor = new Item("elfArmor", 0, 25);
            elf.EquipItem(darkKnife);
            elf.EquipItem(elfArmor);

            //Pelea entre los personajes.
            wizzard.ReceiveAttack(dwarf.TotalAttack());
            elf.ReceiveAttack(wizzard.TotalAttack());
            human.ReceiveAttack(elf.TotalAttack());
            dwarf.ReceiveAttack(human.TotalAttack());

        }
    }
}
