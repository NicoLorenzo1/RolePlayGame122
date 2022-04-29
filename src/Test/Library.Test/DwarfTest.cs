using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class DwarfTest
    {
        [Test]
        public void ReceiveAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);

            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);

            dwarf.ReceiveAttack(human.TotalAttack());
            Assert.AreEqual(70, dwarf.health);
        }

        [Test]
        public void CureTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);

            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);

            dwarf.ReceiveAttack(human.TotalAttack());
            dwarf.Cure();
            Assert.AreEqual(100, dwarf.health);
        }

        [Test]
        public void EquipItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);
            Assert.IsTrue(dwarf.inventory.Contains(hammer));
        }

        [Test]
        public void EquipExistingItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);
            dwarf.EquipItem(hammer);
            Assert.AreEqual(1, dwarf.inventory.Count);
        }
        [Test]
        public void ChangeItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            Item sword = new Item("Espada", 20, 0);
            dwarf.EquipItem(hammer);
            dwarf.ChangeItem(hammer, sword);
            Assert.IsFalse(dwarf.inventory.Contains(hammer));
            Assert.IsTrue(dwarf.inventory.Contains(sword));
        }
        [Test]
        public void RemoveItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);
            dwarf.RemoveItem(hammer);
            Assert.IsFalse(dwarf.inventory.Contains(hammer));
        }
        [Test]
        public void TotalAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);
            Assert.AreEqual(50, dwarf.TotalAttack());
        }

        [Test]
        public void ReturnTotalAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item hammer = new Item("Mazo", 30, 0);
            dwarf.EquipItem(hammer);
            Assert.AreEqual(50, dwarf.TotalAttack());
        }
        [Test]
        public void ReturnTotalDeffenseTest()
        {
            Dwarf dwarf = new Dwarf("Enano", 20);
            Item shield = new Item("Escudo", 0, 40);
            dwarf.EquipItem(shield);
            Assert.AreEqual(40, dwarf.ReturnTotalDefense());
        }
    }
}