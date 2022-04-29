using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizzard
    {

        /// <summary>
        /// Constructor de la clase wizzard la cual recibe un nombre, un valor de ataque y un libro de hechizos por parametro, la vida de este ya se setea en 100 al crearlo.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attack"></param>
        /// <param name="book"></param>
        public Wizzard(string name, int attack, SpellBook book)
        {
            this.Name = name;
            this.attack = attack + SpellBook.TotalDamageBook();
            this.Inventory = new List<Item> { };
        }
        private string name;
        private int health = 100;
        private int attack;
        private int armor;
        private List<Item> Inventory { get; set; }

        /// <summary>
        /// Metodo para devolver el nombre del personaje.
        /// </summary>
        /// <value></value>
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

        /// <summary>
        /// Metodo para devolver y modificar la vida del personaje.
        /// 
        /// </summary>
        /// <value></value>
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

        /// <summary>
        /// Metodo para devolver el valor de ataque del personaje.
        /// </summary>
        /// <value></value>
        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                this.attack = value;
            }

        }
        /// <summary>
        /// Metodo para devolver y modificar la armadura del personaje.
        /// </summary>
        /// <value></value>
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

        public List<Item> inventory
        {
            get
            {
                return this.Inventory;
            }
        }

        /// <summary>
        /// Metodo para recibir el ataque el cual realiza el calculo al daño en base a la armadura;
        /// </summary>
        /// <param name="damage"></param>
        public void ReceiveAttack(int damage)
        {
            this.health = this.health - (damage / (this.armor + 1));
            Console.WriteLine($"El personaje {this.name} ha sido atacado y su vida ahora es de {this.health}");
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
                this.attack = this.attack + item.ReturnDamage();
                this.armor = this.armor + item.ReturnArmor();
                Console.WriteLine($"Objeto {item.ReturnName()} agregado correctamente al personaje {this.name}.");
            }
        }

        public void ChangeItem(Item oldItem, Item newItem)
        {
            this.Inventory.Remove(oldItem);
            this.Inventory.Add(newItem);
            Console.WriteLine($"Objeto {newItem.ReturnName()} cambiado correctamente por {oldItem.ReturnName()}.");
        }
        public void RemoveItem(Item item)
        {
            this.Inventory.Remove(item);
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            Console.WriteLine($"El objeto {item.ReturnName()} ha sido quitado del inventario correctamente");
        }

        /// <summary>
        /// Metodo que retorna el ataque total del personaje Wizzard en base a los items que tiene equipados en el inventario y su propio ataque
        /// Este metodo es usado para calcular el daño que debe realizarle al enemigo.
        /// </summary>
        /// <returns></returns>
        public int TotalAttack()
        {
            int attackValue = this.attack;
            return attackValue;
        }

        /// <summary>
        /// Metodo que imprime por consola el valor total de ataque del personaje Wizzard
        /// </summary>
        public int ReturnTotalAttack()
        {
            int attackValue =  this.attack;
            Console.WriteLine($"El daño total del personaje {this.name} es de {attackValue}");
            return attackValue;
        }

        /// <summary>
        /// Metodo que retorna el valor total de defensa del personaje Wizzard. 
        /// </summary>
        /// <returns></returns>
        public int ReturnTotalDefense()
        {
            int totalDefense = this.armor;

            Console.WriteLine($"La defensa total del personaje {this.name} es de {totalDefense}");
            return totalDefense;
        }



    }
}