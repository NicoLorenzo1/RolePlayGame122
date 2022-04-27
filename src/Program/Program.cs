using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea el hechizo del mago y se agrega al WizardBook.
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);
            
            //Se crea el mago.
            Wizzard wizzard = new Wizzard("mago",20, 5, WizardBook);
            
            //Se crean los items.
            Item Sword = new Item("espada", 25, 0);
            Item WizzardArmor = new Item("ArmorWizzard", 0, 50);

            //Se equipan los items.
            wizzard.EquipItem(Sword);
            wizzard.EquipItem(WizzardArmor);
            wizzard.RemoveItem(Sword);

            wizzard.ReturnTotalAttack();
            SpellBook.TotalDamageBook();
            wizzard.cure();
            wizzard.ReturnTotalDefense();

        }
    }
}
