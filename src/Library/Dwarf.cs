using System;

namespace Library
{
    public class Dwarf
    {

        private string Name{get; }
        private int Health{get; set; }
        public int Vida
        {
            get
            {
                return this.Health;
            }
        }   
        //private Item Item{get; }
        private int Damage{get; }
        public int Daño
        {
            get
            {
                return this.Damage;
            } 
        }
        private int Deffense{get; }
        public Dwarf(string name, int health, /*Item item,*/ int damage, int deffense)
        {
            this.Name = name;
            this.Health = health;
            //this.Item = item;
            this.Damage = damage;
            this.Deffense = deffense;
        }

        public void Attack(int health)
        {
            health = health - this.Damage;
        }

        public void recieveAttack(int damage)
        {
            this.Health = this.Health - damage;
        }
    }
}