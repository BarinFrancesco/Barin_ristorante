using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    internal class Cordine
    {
        public List<CPiatto> Comanda { get; private set; } 
        public string Cliente { get; private set; }

        public Cordine(string nome) {
        Cliente = nome;
        }

        public void AggiunaPiatto()
        {

        }
    }
}
