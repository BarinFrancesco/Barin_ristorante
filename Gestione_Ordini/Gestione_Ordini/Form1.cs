using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        List<Cordine> Lista_ordini_oggi = new List<Cordine>();
        List<Cordine> Lista_ordini_vecchi = new List<Cordine>();
        bool Stato_lista = false;

        private void Ristorante_da_Barin_Load(object sender, EventArgs e)
        {
            lbl_Menù.Text = menù.VisualizzaMenù();
            caricamento_vecchi_ordini();
            Visualizza_ordini(false);
        }

        private void Ristorante_da_Barin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Salvataggio_ordini();
        }

        //funzione che crea l'rdine, si assicura che siamo nel registro di giornata, poi aptr un form per prendere la comanda e la salva
        private void btn_Ordina_Click(object sender, EventArgs e)
        {
            Visualizza_ordini(true);
            using (FormOrdini form = new FormOrdini(menù.VisualizzaMenù()))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    int index_person = -1;
                    string name = form.Coustomer_name;
                    int dish = form.Coustomer_dish;
                    int quantity = form.Coustomer_quantity;

                    //funzione per trovare se la persona esiste o ne devo creare unaltra
                    for (int i = 0; i < Lista_ordini_oggi.Count; i++)
                    {
                        if (Lista_ordini_oggi[i].Cliente == name )
                        {
                            index_person = i;
                            break;
                        }
                    }

                    //se non esiste ne creo unaltra e gli metto i piatti o se esiste aggiungo solamente il piatto
                    if (index_person == -1)
                    {
                        Lista_ordini_oggi.Add(ordine = new Cordine(name));
                        lst_Orders.Items.Add($"Cliente :{ordine.Cliente}");
                        index_person = Lista_ordini_oggi.Count - 1;
                    }

                    for (int i = 0; i < quantity; i++)
                    {
                        Lista_ordini_oggi[index_person].AggiunaPiatto(menù.Lista_piatti[dish]);
                    }
                   
                }
            }
            Visualizza_ordini(true); //lancio la funzione prima e dop operché così lavora solo sull'ordine di oggi e fa il "refresh" della schermata
        }

        //funzione che va a far vedere il totale di ogni conto
        private void btn_Total_Click(object sender, EventArgs e)
        {

            List<Cordine> lista;
            if (Stato_lista)
            {
                lista = Lista_ordini_oggi;
            } else
            {
                lista = Lista_ordini_vecchi;
            }

            if (lst_Orders.SelectedIndex == -1)
            {
                MessageBox.Show($"Selezionare un ordine per visualittarne il totale");
            }
            else
            {

                MessageBox.Show($"{lista[lst_Orders.SelectedIndex].Scontrino().ordini}" +
                                $" ------------------------ " +
                                $"\n Totale :{lista[lst_Orders.SelectedIndex].Scontrino().costo} €");
            }
        }

        //salva gli ordini quando si chiude il form
        private void Salvataggio_ordini()
        {
            if (!File.Exists(@"..\..\..\Files\Ordini.csv"))
            {
                throw new FileNotFoundException("Non è stato trovato il file sorgente");
            }
            using (StreamWriter scrittore = new StreamWriter(@"..\..\..\Files\ordini.csv", append: true))
            {
                foreach (var ordine in Lista_ordini_oggi)
                {
                    string dati_ordine = "";
                    dati_ordine += $"{ordine.Cliente};";

                    foreach (var piatto in ordine.Comanda)
                    {
                        dati_ordine += $"{piatto.Name};";
                    }

                    scrittore.WriteLine(dati_ordine);
                }
            }
        }

        //funzione che legge i gli ordini passati e li carica nella sua lista
        private void caricamento_vecchi_ordini()
        {
            using (StreamReader lettore = new StreamReader(@"..\..\..\Files\Ordini.csv"))
            {
                while (!lettore.EndOfStream)
                {
                    string riga = lettore.ReadLine();
                    string[] dati = riga.Split(';');

                    Lista_ordini_vecchi.Add(ordine = new Cordine(dati[0]));

                    for ( int i = 1; i<dati.Length; i++)
                    {
                        foreach (var piatto in menù.Lista_piatti)
                        {
                            if(piatto.Name == dati[i])
                            {
                                Lista_ordini_vecchi[Lista_ordini_vecchi.Count - 1].AggiunaPiatto(piatto);
                                break;
                            }
                        } 
                    }
                }
            }
        }

        //funzione per vederli gli ordini, vecchi e nuovi
        private void Visualizza_ordini( bool status)
        {
            lst_Orders.Items.Clear();
            List<Cordine> lista;
            if (status)
            {
                Stato_lista = true;
                lista = Lista_ordini_oggi;
                lbl_typeoforder.Text = "Ordini della giornata";
            }
            else
            {
                Stato_lista = false;
                lista = Lista_ordini_vecchi;
                lbl_typeoforder.Text = "Registro ordini passati";
            }

            foreach (var ordine in lista)
            {
            lst_Orders.Items.Add($"Nome : {ordine.Cliente.PadRight(10)} totale {ordine.Scontrino().costo}€ ");
            }
            
        }

        private void btn_Oldorders_Click(object sender, EventArgs e)
        {
            Visualizza_ordini(false);
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            Visualizza_ordini(true);
        }

        private void lbl_typeoforder_Click(object sender, EventArgs e)
        {

        }

        private void lst_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}