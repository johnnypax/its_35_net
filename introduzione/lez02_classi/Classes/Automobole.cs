using System;
using System.Collections.Generic;
using System.Text;

namespace lez02_classi.Classes
{
    internal class Automobole
    {
        public string? Marca { get; set; }
        public string? Colore { get; set; }
        public int Cilindrata { get; set; } = 0;

        private int porte;

        public int Porte
        {
            get { return porte; }
            set { 
                if (value >= 0)
                    porte = value; 
            }
        }

        public void Accendi()
        {
            Console.WriteLine("L'automobile è accesa");
        }

    }
}
