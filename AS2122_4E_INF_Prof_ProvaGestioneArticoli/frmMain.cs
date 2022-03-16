using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmMain : Form
    {
        List<Articolo> articoli;

        public frmMain()
        {
            InitializeComponent();

            // TODO: (4) creazione lista articoli
            // ...
        }

        private void btnAggiungiArticolo_Click(object sender, EventArgs e)
        {
            frmArticolo f = new frmArticolo();

            f.ShowDialog();

            if (f.Status == DialogResult.OK)
            {
                // aggiungi l'articolo all'elenco di articoli
                // TODO: (1) aggiungere l'articolo creato dai dati di frmArticoli nella lista articoli
                // ...

                Articolo a = new Articolo(articoli.Count , f.Descrizione, f.UnitaDiMisura,f.Prezzo);
                articoli.Add(a);

                lblArticoliInseriti.Text = $"Articoli ({articoli.Count})";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":
                    // TODO: (2) aggiungere visualizzazione articoli inseriti nella listbox
                    // ... lstElenco.Items.Add(a.Visualizzati()); 
                    foreach(Articolo a in articoli)
                    {
                        lstElenco.Items.Add(a.Visualizzati());
                    }
                    break;
            }
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lstElenco.SelectedItem.ToString();

            // Find the string in ListBox.
            int index = lstElenco.FindString(curItem);

            // TODO: (3) aggiungere visualizzazione dettaglio articolo nelle label
            // ... lblDescrizione.Text = articoli[index].Descrizione;
            lblDescrizione.Text = articoli[index].Descrizione;
            lblUnitaMisura.Text = articoli[index].UnitaMisura;
            lblPrezzo.Text = articoli[index].Prezzo.toString();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
