using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class SpellBookTest
    {

        /// <summary>
        /// Test para probar el metodo AddSpell de la clase SpellBook.
        /// </summary>
        [Test]
        public void AddSpellTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            Assert.AreEqual(1, WizardBook.spellsCount);
        }

        /// <summary>
        ///Test para probar el metodo TotalDamageBook de la clase SpellBook.
        /// </summary>
        [Test]
        public void TotalDamageBookTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);

            Assert.AreEqual(40, spell1.Effect);
        }

        /// <summary>
        ///Test para verificar el TotalDamageBook en caso de tener mas de un hechizo en el libro.
        /// </summary>
        [Test]
        public void TotalDamageBookWithTwoSpellsTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            Spell spell2 = new Spell("fire2", "shot of fire2", 40);
            SpellBook WizardBook = new SpellBook("WizardBook");
            WizardBook.AddSpell(spell1);
            WizardBook.AddSpell(spell2);
            int totalEffect = spell1.Effect + spell2.Effect;

            Assert.AreEqual(80, totalEffect);
        }
    }
}