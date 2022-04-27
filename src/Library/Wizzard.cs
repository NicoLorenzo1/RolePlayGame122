using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizzard
    {

        public Wizzard(string name, int health, int attack, SpellBook book)
        {
            this.Name = name;
            this.Health = health;
            Attack = attack;
            this.inventory = new List<Item> { };
        }
        private string name;
        private int health;
        private int attack;
        private int armor;
        private SpellBook book;
        private List<Item> inventory { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        public int Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }

/*
        public void ReciveAttack(int damage)
        {

        }

        public void cure()
        {

        }
        */

        public void EquipItem(Item item)
        {
            bool agregado = false;
            ///Se recorre el inventario por si el item que se busca implementar ya se encuentra. En caso de que no se encuentre se agrega fuera del condicional.
            foreach (Item value in this.inventory)
            {
                if (value.ReturnName() == item.ReturnName())
                {
                    this.inventory.Remove(value);
                    this.inventory.Add(item);
                    /// se elimina el daño y armadura del objeto anterior
                    this.attack -= value.ReturnDamage();
                    this.armor -= value.ReturnArmor();
                    /// se agrega el daño y la armadura del objeto
                    this.attack = this.attack + item.ReturnDamage();
                    this.armor = this.armor + item.ReturnArmor();
                    agregado = true;
                }
            }
            if (!agregado)
            {
                this.inventory.Add(item);
                this.attack = this.attack + item.ReturnDamage();
                this.armor = this.armor + item.ReturnArmor();
                System.Console.WriteLine($"Objeto {item.ReturnName()} agregado correctamente al personale {this.name}.");
            }
            
        }

        public void ChangeItem(Item oldItem, Item newItem)
        {
            this.inventory.Remove(oldItem);
            this.inventory.Add(newItem);
            Console.WriteLine($"Objeto {newItem.ReturnName()} cambiado correctamente por {oldItem.ReturnName()}.");
        }
        public void RemoveItem(Item item)
        {
            this.inventory.Remove(item);
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
        }

        public void ReturnAttackValue()
        {
            int attackValue = 0;
            foreach (Item items in this.inventory)
            {
                attackValue = items.ReturnDamage() + this.attack;
            }
            Console.WriteLine($"El daño total del personaje {this.name} es de {attackValue}");
        }
        
    }
}