using System;
using System.Collections.Generic;
using System.Text;

namespace lez02_classi.Classes
{
    internal class Studente
    {
        public string Nominativo { get; set; } = null!;
        public string? Matricola { get; set; }
        public string Email { get; set; } = null!;

        public Studente()
        {
            Console.WriteLine("Sono il costruttore di default");
        }

        public Studente(string nominativo, string email)
        {
            Nominativo = nominativo;
            Email = email;
        }

        public Studente(string nominativo, string? matricola, string email)
        {
            Nominativo = nominativo;
            Matricola = matricola;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nominativo} {Matricola} {Email}";
        }
    }
}
