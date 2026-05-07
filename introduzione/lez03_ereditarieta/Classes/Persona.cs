using System;
using System.Collections.Generic;
using System.Text;

namespace lez03_ereditarieta.Classes
{
    internal class Persona
    {
        public string Nominativo { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual string Stampa()
        {
            return $"{Nominativo} {Email}";
        }
    }
}
