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
            Attack = attack + SpellBook.TotalDamageBook();
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

        /// <summary>
        /// Metodo para recibir el ataque el cual realiza el calculo al daño en base a la armadura;
        /// </summary>
        /// <param name="damage"></param>
        public void ReciveAttack(int damage)
        {
            this.health += (damage * 10) / this.armor;

        }

        /// <summary>
        /// Metodo para curar al personaje y restaura su vida al 100
        /// </summary>
        public void cure()
        {
            this.health = 100;
            Console.WriteLine($"El personaje {this.name} ha sido curado y su vida se restauro a {this.health}");
        }

        /// <summary>
        /// Metodo para equipar el item al inventario del personaje.
        /// </summary>
        /// <param name="item"></param>
        public void EquipItem(Item item)
        {

            ///Se recorre el inventario por si el item que se busca implementar ya se encuentra. En caso de que no se encuentre se agrega fuera del condicional.
            bool agregado = false;
            foreach (Item value in this.inventory)
            {
                if (value.ReturnName() == item.ReturnName())
                {
                    agregado = true;
                    Console.WriteLine($"El objeto {item.ReturnName()} ya se encuentra dentro del inventario del personaje {this.name}");
                }
            }
            if (!agregado)
            {
                this.inventory.Add(item);
                this.attack = this.attack + item.ReturnDamage();
                this.armor = this.armor + item.ReturnArmor();
                Console.WriteLine($"Objeto {item.ReturnName()} agregado correctamente al personaje {this.name}.");
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
            Console.WriteLine($"El objeto {item.ReturnName()} ha sido quitado del inventario correctamente");
        }

        /// <summary>
        /// Se calcula el daño total del personaje en base a los items que contenga en su inventario y el poder que ya tiene por ser un mago(junto a su SpellBook).
        /// </summary>
        public int ReturnTotalAttack()
        {
            int attackValue = 0;
            foreach (Item items in this.inventory)
            {
                attackValue = items.ReturnDamage() + this.attack;
            }
            Console.WriteLine($"El daño total del personaje {this.name} es de {attackValue}");
            return attackValue;
        }

        public int ReturnTotalDefense()
        {
            int totalDefense = 0;
            foreach (Item items in this.inventory)
            {
                totalDefense = items.ReturnArmor() + this.Armor;
            }
            Console.WriteLine($"La defensa total del personaje {this.name} es de {totalDefense}");
            return totalDefense;
        }



    }
}