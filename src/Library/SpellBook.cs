using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook
    {
        private string name;
        public List<Spell> spells { get; private set; }
        public int spellsCount = 0;

        public SpellBook(string name)
        {
            this.name = name;
            this.spells = new List<Spell> { };
        }

        /// <summary>
        /// Agrega hechizos al libro de Hechizos.
        /// </summary>
        /// <param name="spell">Instancia de hechizo</param>
        public void AddSpell(Spell spell)
        {
            if (!spells.Contains(spell))
            {
                spells.Add(spell);
                spellsCount++;
            }
            else
            {
                Console.WriteLine("El hechizo ya se encuentra dentro del libro.");
            }
        }

/*
        public int TotalDamageBook()
        {
            int damageBook = 0;
            foreach (Spell spellsInBook in spells)
            {
                damageBook = spellsInBook.Effect;
            }
            return damageBook;

        }*/
    }
}