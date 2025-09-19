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
