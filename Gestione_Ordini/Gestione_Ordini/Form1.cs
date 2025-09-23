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

        Cordine ordine;
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
                    int index_person = -1;
                    string name = form.Coustomer_name;
                    int dish = form.Coustomer_dish;
                    int quantity = form.Coustomer_quantity;

                    //funzione per trovare se la persona esiste o ne devo creare unaltra
                    for (int i = 0; i < Lista_ordini.Count; i++)
                    {
                        if (Lista_ordini[i].Cliente == name )
                        {
                            index_person = i;
                            break;
                        }
                    }
                     //se non esiste ne creo unaltra e gli metto i piattio se esiste aggiungo solamente il piatto
                    if (index_person == -1)
                    {
                        Lista_ordini.Add(ordine = new Cordine(name));
                        lst_Orders.Items.Add($"Cliente :{ordine.Cliente}");

                        for ( int i = 0; i<quantity; i++)
                        {
                            Lista_ordini[Lista_ordini.Count - 1].AggiunaPiatto(menù.Lista_piatti[dish]);
                        }
                        
                    } else
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            Lista_ordini[index_person].AggiunaPiatto(menù.Lista_piatti[dish]);
                        }
                    }

                }
            }
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"totale: {Lista_ordini[lst_Orders.SelectedIndex].totale()} $");
            
        }
    }
}