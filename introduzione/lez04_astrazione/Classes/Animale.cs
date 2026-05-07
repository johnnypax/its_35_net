using System;
using System.Collections.Generic;
using System.Text;

namespace lez04_astrazione.Classes
{
    internal abstract class Animale
    {
        public bool HasPelo { get; set; }
        public int NumZampe { get; set; }
        public bool Vola { get; set; }

        public abstract void VersoEmesso();
    }
}
