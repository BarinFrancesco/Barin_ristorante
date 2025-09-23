using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Ordini
{
    internal class Cordine
    {
        public List<CPiatto> Comanda { get; private set; } 
        public string Cliente { get; private set; }


        public Cordine(string nome) {
            Cliente = nome;
            Comanda = new List<CPiatto>();
        }

        public void AggiunaPiatto(CPiatto piatto_aggiunto)
        {
            Comanda.Add(piatto_aggiunto);
        }
        public float totale ()
        {
            float Tot = 0;
            foreach (var item in Comanda)
            {
                Tot += item.Price;
            }
            return Tot;
        }
    }
}
