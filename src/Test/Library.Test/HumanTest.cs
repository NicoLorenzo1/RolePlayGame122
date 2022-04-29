using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class HumanTest
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

            human.ReceiveAttack(dwarf.TotalAttack());
            Assert.AreEqual(50, human.health);
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

            human.ReceiveAttack(dwarf.TotalAttack());
            human.Cure();
            Assert.AreEqual(100, human.health);
        }

        [Test]
        public void EquipItemTest()
        {
            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);
            Assert.IsTrue(human.inventory.Contains(sword));
        }

        [Test]
        public void EquipExistingItemTest()
        {
            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);
            human.EquipItem(sword);
            Assert.AreEqual(1, human.inventory.Count);
        }
        [Test]
        public void ChangeItemTest()
        {
            Human human = new Human("Humano", 10);
            Item hammer = new Item("Mazo", 30, 0);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(hammer);
            human.ChangeItem(hammer, sword);
            Assert.IsFalse(human.inventory.Contains(hammer));
            Assert.IsTrue(human.inventory.Contains(sword));
        }
        [Test]
        public void RemoveItemTest()
        {
            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);
            human.RemoveItem(sword);
            Assert.IsFalse(human.inventory.Contains(sword));
        }
        [Test]
        public void TotalAttackTest()
        {
            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);
            Assert.AreEqual(30, human.TotalAttack());
        }

        [Test]
        public void ReturnTotalAttackTest()
        {
            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);
            Assert.AreEqual(30, human.TotalAttack());
        }
        [Test]
        public void ReturnTotalDeffenseTest()
        {
            Human human = new Human("Humano", 10);
            Item shield = new Item("Escudo", 0, 40);
            human.EquipItem(shield);
            Assert.AreEqual(40, human.ReturnTotalDefense());
        }
    }
}