using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    internal class CPiatto
    {

        public string Name { get; private set; }
        public float Price { get; private set; }

        public CPiatto( string nome, float prezzo) {
            Name = nome;
            Price = prezzo;
        }
    }
}
