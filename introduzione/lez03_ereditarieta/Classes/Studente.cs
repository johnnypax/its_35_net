using System;
using System.Collections.Generic;
using System.Text;

namespace lez03_ereditarieta.Classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public override string Stampa()
        {
            return $"{Nominativo} {Email} {Matricola}";
        }
    }
}
