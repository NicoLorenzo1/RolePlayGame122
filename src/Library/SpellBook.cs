using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase SpellBook la cual cumple con el patron SRP con la finalidad de solamente encargarse de los spell, tambien cumple 
    /// con el patron Expert ya que conoce toda la información necesaria para realizar su función.
    /// </summary>
    public class SpellBook
    {
        private string name;
        public static List<Spell> spells { get; private set; }
        public int spellsCount = 0;

        public SpellBook(string name)
        {
            this.name = name;
            spells = new List<Spell> { };
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

        /// <summary>
        /// Metodo para calular el daño total del libro del mago en base a los hechizos que el libro contenga.
        /// </summary>
        /// <returns></returns>
        public static int TotalDamageBook()
        {
            int damageBook = 0;
            foreach (Spell spellsInBook in spells)
            {
                damageBook = spellsInBook.Effect;
            }
            return damageBook;
        }

    }
}