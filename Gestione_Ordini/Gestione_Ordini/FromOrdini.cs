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
        public FormOrdini( string menù)
        {
            InitializeComponent();
            lista_piatti = menù;
        }
        string lista_piatti;

        public string Coustomer_name { get; private set; }

        public int Coustomer_dish { get; private set; }

        public int Coustomer_quantity { get; private set; }

        private void FromOrdini_Load(object sender, EventArgs e)
        {
              // Pulisce prima la combo se necessario
                cmb_SelezionePiatti.Items.Clear();

                string[] piatti = lista_piatti.Split('\n');

                cmb_SelezionePiatti.Items.AddRange(piatti); 
        }

        private void txt_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Coustomer_name = txt_Customer.Text.ToLower();
            Coustomer_dish = cmb_SelezionePiatti.SelectedIndex;
            Coustomer_quantity = (int)sel_Quantity.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
