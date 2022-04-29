using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class WizzardTest
    {

        /// <summary>
        /// Test para probar el metodo ReceiveAttack de la clase Wizzard.
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);
            wizzard.EquipItem(Sword);

            //Se crea el personaje Dwarf junto a sus items y se lo equipa.
            Dwarf dwarf = new Dwarf("dwarf", 20);
            Item Knife = new Item("Knife", 20, 0);
            dwarf.EquipItem(Knife);

            wizzard.ReceiveAttack(dwarf.TotalAttack());

            Assert.AreEqual(60, wizzard.Health);
        }

        /// <summary>
        /// Test para probar el metodo Cure de la clase wizzard.
        /// </summary>
        [Test]
        public void CureTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);
            wizzard.EquipItem(Sword);

            //Se crea el personaje Dwarf junto a sus items y se lo equipa.
            Dwarf dwarf = new Dwarf("dwarf", 20);
            Item Knife = new Item("Knife", 20, 0);
            dwarf.EquipItem(Knife);

            wizzard.ReceiveAttack(dwarf.TotalAttack());
            wizzard.cure();

            Assert.AreEqual(100, wizzard.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar que el metodo EquipItem de la clase Wizzard agregue correctamente los items al inventario.
        /// </summary>
        [Test]
        public void EquipItemTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);
            wizzard.EquipItem(Sword);

            Assert.IsTrue(wizzard.inventory.Contains(Sword));
        }

        /// <summary>
        ///Test que se encarga de probar el metodo EquipItem de la clase Wizzard.
        /// </summary>
        [Test]
        public void EquipExistentItemTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);

            wizzard.EquipItem(Sword);
            wizzard.EquipItem(Sword);

            Assert.AreEqual(1, wizzard.inventory.Count);
        }

        /// <summary>
        /// Test que se encarga de probar el metodo ChangeItem de la clase Wizzard.
        /// </summary>
        [Test]
        public void ChangeItemItemTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);
            Item Knife = new Item("Knife", 25, 0);

            wizzard.EquipItem(Sword);
            wizzard.ChangeItem(Sword, Knife);

            Assert.IsFalse(wizzard.inventory.Contains(Sword));
            Assert.IsTrue(wizzard.inventory.Contains(Knife));
        }

        //Test que se encarga de probar el metodo RemoveItem de la clase Wizzard.
        [Test]
        public void RemoveItemItemTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 5, WizardBook);
            Item Sword = new Item("espada", 25, 0);

            wizzard.EquipItem(Sword);
            wizzard.RemoveItem(Sword);

            Assert.IsFalse(wizzard.inventory.Contains(Sword));
        }

        //Test que se encarga de verificar el metodo totalAttack de la clase Wizzard.
        [Test]
        public void TotalAttackTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 30);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 10, WizardBook);
            Item Sword = new Item("espada", 5, 0);
            wizzard.EquipItem(Sword);

            Assert.AreEqual(45, wizzard.TotalAttack());
        }

        [Test]
        public void ReturnTotalAttackTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 30);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 10, WizardBook);
            Item Sword = new Item("espada", 5, 0);
            wizzard.EquipItem(Sword);

            Assert.AreEqual(45, wizzard.ReturnTotalAttack());
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo que retorna la defensa total del personaje.
        /// </summary>
        [Test]
        public void ReturnTotalDefenseTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 30);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            //Se crea el personaje Wizzard junto a sus items y se lo equipa.
            Wizzard wizzard = new Wizzard("mago", 10, WizardBook);
            Item Armor = new Item("armor", 0, 50);
            wizzard.EquipItem(Armor);

            Assert.AreEqual(50, wizzard.ReturnTotalDefense());
        }


    }
}