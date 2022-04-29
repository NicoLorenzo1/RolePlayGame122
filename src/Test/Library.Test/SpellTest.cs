using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class SpellTest
    {

        /// <summary>
        /// Test para verificar que se le asigna correctamente el nombre al spell en la clase Spell.
        /// </summary>
        [Test]
        public void NameSpellTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            Assert.AreEqual("fire", spell1.Name);
        }

        /// <summary>
        /// Test para verificar que se le asigna correctamente la descripción al spell en la clase Spell.
        /// </summary>
        [Test]
        public void DescriptionSpellTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            Assert.AreEqual("shot of fire", spell1.Description);
        }

        /// <summary>
        /// Test para verificar que se le asigna correctamente el valor del efecto al spell en la clase Spell.
        /// </summary>
        [Test]
        public void EffectSpellTest()
        {
            Spell spell1 = new Spell("fire", "shot of fire", 40);
            Assert.AreEqual(40, spell1.Effect);
        }
    }
}