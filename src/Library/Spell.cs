using System;

namespace Library
{
    public class Spell
    {
        private string name;
        private string description;
        private int effect;

        public string Name 
        {
            get
            {
                return this.name;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
        }
        public int Effect
        {
            get
            {
                return effect;
            }
        }
        
        public Spell(string name, string description, int effect) 
        {
            this.name = name;
            this.description = description;
            this.effect = effect;
        }

    }
}