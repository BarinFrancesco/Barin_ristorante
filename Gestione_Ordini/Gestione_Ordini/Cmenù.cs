using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    internal class Cmenù
    {
        public List<CPiatto> Lista_piatti  { get; private set;}
        private CPiatto Basepiatto;

        public Cmenù() {
            Lista_piatti = new List<CPiatto>();

            using (StreamReader lettore = new StreamReader(@"..\..\..\Files\Menù.csv"))
            {
                while (!lettore.EndOfStream)
                {
                    string piatto = lettore.ReadLine();
                    string[] dati = piatto.Split(';');
                    Lista_piatti.Add(Basepiatto = new CPiatto(dati[0], float.Parse(dati[1]) ) );
                }
            }
        
        }

        public string VisualizzaMenù()
        {
            string menù_completo = "";

            foreach (var piatto in Lista_piatti)
            {
                menù_completo += $"{piatto.Name} {piatto.Price}€ \n";
            }
            return menù_completo;
        }
    }
}
