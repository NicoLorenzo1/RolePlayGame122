using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {

        private string Name;
        private int Health;   
        private Item Item;
        private int Attack;
        private int Armor;
        private List<Item> Inventory {get; set;  }
        public Dwarf(string name, int health, Item item, int attack, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.Item = item;
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

        public void recieveAttack(int damage)
        {
            this.Health = this.Health - damage;
        }

        public void heal()
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
                    this.Inventory.Remove(value);
                    this.Inventory.Add(item);
                    this.Attack -= value.ReturnDamage();
                    this.Armor -= value.ReturnArmor();
                    this.Attack += item.ReturnDamage();
                    this.Armor += item.ReturnArmor();
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

        
    }
}