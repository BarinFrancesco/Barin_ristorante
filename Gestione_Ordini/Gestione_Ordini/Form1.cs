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
    public partial class Ristorante_da_Barin : Form
    {
        public Ristorante_da_Barin()
        {
            InitializeComponent();
            menù = new Cmenù();
        }

        Cmenù menù = new Cmenù();
        List<Cordine> Lista_ordini = new List<Cordine>();

        private void Ristorante_da_Barin_Load(object sender, EventArgs e)
        {
            
            lbl_Menù.Text = menù.VisualizzaMenù();

        }

        private void btn_Ordina_Click(object sender, EventArgs e)
        {
            using(FormOrdini form = new FormOrdini(menù.VisualizzaMenù()))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}