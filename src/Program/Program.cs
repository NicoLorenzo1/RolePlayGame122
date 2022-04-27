using System;
using Library;

namespace Pprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf dwarf = new Dwarf("Enano", 100, 20, 30);
            Dwarf dwarf1 = new Dwarf("Enano1", 110, 40, 20);

            dwarf.Attack(dwarf1.Vida);
            Console.WriteLine(dwarf1.Vida);
            dwarf1.recieveAttack(dwarf.Daño);
            Console.WriteLine(dwarf1.Vida);
        }
    }
}
