using System;

namespace Library
{
    public class Item
    {
        private int damage { get; set; }
        private string name { get; set; }
        private int armor { get; set; }

        public Item(string name, int damage, int armor)
        {
            this.damage = damage;
            this.name = name;
            this.armor = armor;
        }

        public int ReturnDamage()
        {
            return this.damage;
        }
        public int ReturnArmor()
        {
            return this.armor;
        }

        public string ReturnName()
        {
            return this.name;
        }
    }
}