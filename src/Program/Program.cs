using System;
using Library;

namespace Pprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea el hechizo del mago y se agrega al WizardBook.
            //Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            //WizardBook.AddSpell(spell1);
            
            //Se crea el mago.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            
            //Se crean los items.
           // Item Sword = new Item("espada", 25, 0);
            Item Sword2 = new Item("espada2", 25, 0);
            Item WizzardArmor = new Item("ArmorWizzard", 0, 20);

            //Se equipan los items.
            //wizzard.EquipItem(Sword);
            //wizzard.EquipItem(Sword2);
            //wizzard.EquipItem(Sword2);

           // wizzard.EquipItem(WizzardArmor);
            wizzard.EquipItem(WizzardArmor);

            //wizzard.RemoveItem(Sword);

            //wizzard.ReturnTotalAttack();
            //SpellBook.TotalDamageBook();
            //wizzard.cure();
            //wizzard.ReturnTotalDefense();

        Dwarf dwarf = new Dwarf("dwarf", 40, 20);
        wizzard.ReceiveAttack(dwarf.TotalAttack());
        }
    }
}
