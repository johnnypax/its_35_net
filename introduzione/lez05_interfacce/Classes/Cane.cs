using System;
using System.Collections.Generic;
using System.Text;

namespace lez04_astrazione.Classes
{
    internal class Cane : Animale
    {
        public bool HasPelo { get; set; }
        public int NumZampe { get; set; }
        public bool Vola { get; set; }

        public void VersoEmesso()
        {
            Console.WriteLine("Il cane emette un verso: Bau!");
        }
    }
}
