using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Ordini
{
    public partial class FormOrdini : Form
    {
        public FormOrdini()
        {
            InitializeComponent();
        }

        private void FromOrdini_Load(object sender, EventArgs e)
        {
            /*
              // Pulisce prima la combo se necessario
                cmb_SelezionePiatti.Items.Clear();

                // Dividi per newline o virgola
                var piatti = input
                    .Split(new[] { '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim()) // Rimuove spazi extra
                    .Where(p => !string.IsNullOrEmpty(p)) // Evita voci vuote
                    .ToArray();

                cmb_SelezionePiatti.Items.AddRange(piatti); 
              */
            cmb_SelezionePiatti.Items.AddRange(new string[]
            {
                "tagliatelle al ragù",
                "spaghetti di mare",
                "bucatini all'amatriciana",
                "tagliata di manzo",
                "fritto misto",
                "pollo arrosto",
                "panna cotta",
                "torta della nonna",
                "tiramisù"
            });
        }
    }
}
