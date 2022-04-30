using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ElfTest
    {
        [Test]
        public void ReceiveAttackTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);

            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);

            elf.ReceiveAttack(human.TotalAttack());
            Assert.AreEqual(70, elf.health);
        }

        [Test]
        public void CuteTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);

            Human human = new Human("Humano", 10);
            Item sword = new Item("Espada", 20, 0);
            human.EquipItem(sword);

            elf.ReceiveAttack(human.TotalAttack());
            elf.Cure();
            Assert.AreEqual(100, elf.health);
        }

        [Test]
        public void EquipItemTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);
            Assert.IsTrue(elf.inventory.Contains(dagger));
        }

        [Test]
        public void EquipExistingItemTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);
            elf.EquipItem(dagger);
            Assert.AreEqual(1, elf.inventory.Count);
        }

        [Test]
        public void ChangeItemTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            Item sword = new Item("Espada", 20, 0);
            elf.EquipItem(dagger);
            elf.ChangeItem(dagger, sword);
            Assert.IsFalse(elf.inventory.Contains(dagger));
            Assert.IsTrue(elf.inventory.Contains(sword));
        }

        [Test]
        public void RemoveItemTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);
            elf.RemoveItem(dagger);
            Assert.IsFalse(elf.inventory.Contains(dagger));
        }

        [Test]
        public void TotalAttackTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);
            Assert.AreEqual(50, elf.TotalAttack());
        }

        [Test]
        public void ReturnTotalAttackTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item dagger = new Item("Daga", 5, 0);
            elf.EquipItem(dagger);
            Assert.AreEqual(50, elf.TotalAttack());
        }

        [Test]
        public void ReturnTotalDefenseTest()
        {
            Elf elf = new Elf("Elfo", 10);
            Item shield = new Item("Escudo", 0, 40);
            elf.EquipItem(shield);
            Assert.AreEqual(40, elf.ReturnTotalDefense());
        }
    }
}