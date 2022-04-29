using System;
using System.Collections.Generic;

namespace Library
{
    public class Human
    {

        private string Name;
        private int Health = 100;
        private int Attack;
        private int Armor;
        private List<Item> Inventory { get; set; }
        public Human(string name, int attack)
        {
            this.Name = name;
            this.Attack = attack;
            this.Inventory = new List<Item> { };
        }

        public string name
        {
            get
            {
                return this.Name;
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
         public List<Item> inventory
        {
            get
            {
                return this.Inventory;
            }
        }

        public void ReceiveAttack(int damage)
        {
            this.health = this.health - (damage / (this.armor + 1));
            Console.WriteLine($"El personaje {this.name} ha sido atacado y su vida ahora es de {this.health}");
        }

        public void Cure()
        {
            this.Health = 100;
        }

        /// <summary>
        /// Metodo para equipar el Item, primero se fija que no este en el inventario y si no está lo agrega.
        /// </summary>
        /// <param name="item"></param>
        public void EquipItem(Item item)
        {
            bool agregado = false;
            foreach (Item value in this.Inventory)
            {
                if (value.ReturnName() == item.ReturnName())
                {
                    Console.WriteLine($"El objeto {item.ReturnName()} ya se encuentra dentro del inventario del personaje {this.name}");
                    agregado = true;
                }
            }

            if (!agregado)
            {
                this.Inventory.Add(item);
                this.Attack += item.ReturnDamage();
                this.Armor += item.ReturnArmor();
                Console.WriteLine($"Objeto {item.ReturnName()} agregado correctamente al personaje {this.name}.");

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

        /// <summary>
        /// Metodo que retorna el ataque total del personaje Human en base a los items que tiene equipados en el inventario y su propio ataque
        /// Este metodo es usado para calcular el daño que debe realizarle al enemigo.
        /// </summary>
        /// <returns></returns>
        public int TotalAttack()
        {
            int attackValue = this.attack;
            return attackValue;
        }

        public int ReturnTotalDefense()
        {
            int totalDefense = this.armor;

            Console.WriteLine($"La defensa total del personaje {this.name} es de {totalDefense}");
            return totalDefense;
        }
    }
}