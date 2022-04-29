using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {

        private string Name;
        private int Health = 100;
        private int Attack;
        private int Armor;
        private List<Item> Inventory { get; set; }
        public Dwarf(string name, int attack, int armor)
        {
            this.Name = name;
            this.Attack = attack;
            this.Armor = armor;
            this.Inventory = new List<Item> { };
        }

        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public int health
        {
            get
            {
                return this.Health;
            }
            set
            {
                this.Health = value;
            }
        }

        public int attack
        {
            get
            {
                return Attack;
            }
            set
            {
                Attack = value;
            }
        }
        public int armor
        {
            get
            {
                return this.Armor;
            }
            set
            {
                this.Armor = value;
            }
        }

        public void ReceiveAttack(int damage)
        {
            this.health -= damage * 3 / (this.armor + 1);
            Console.WriteLine($"El personaje {this.name} ha sido atacado y su vida ahora es de {this.health}");
        }

        public void healt()
        {
            this.Health = 100;
        }

        public void EquipItem(Item item)
        {
            bool added = false;
            foreach (Item value in this.Inventory)
            {
                if (value.ReturnName() == item.ReturnName())
                {
                    added = true;
                }
            }

            if (!added)
            {
                this.Inventory.Add(item);
                this.Attack += item.ReturnDamage();
                this.Armor += item.ReturnArmor();
            }
        }

        public void ChangeItem(Item oldItem, Item newItem)
        {
            this.Inventory.Remove(oldItem);
            this.Inventory.Add(newItem);
        }

        public void RemoveItem(Item item)
        {
            this.Inventory.Remove(item);
            this.Armor -= item.ReturnArmor();
            this.Attack -= item.ReturnDamage();
        }

        public int TotalAttack()
        {
            int attackValue = this.Attack;
            foreach (Item item in this.Inventory)
            {
                attackValue += item.ReturnDamage() + this.attack;
            }
            return attackValue;
        }

        /// <summary>
        /// Metodo que retorna el valor total de ataque del personaje Dwarf
        /// </summary>
        public void ReturnTotalAttack()
        {
            int attackValue = 0;
            foreach (Item items in this.Inventory)
            {
                attackValue = items.ReturnDamage() + this.attack;
            }
            Console.WriteLine($"El daño total del personaje {this.name} es de {attackValue}");
        }
    }
}