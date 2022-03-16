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
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...
        string descrizione { get; set; } 
        string unitaMisura { get; set; }
        double prezzo { get; set; }

        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        public String Descrizione
        {
            get {return descrizione; }
        }
        public String UnitaDiMisura
        {
            get { return unitaMisura; }
        }
        public double Prezzo
        {
            get { return prezzo; }
        }




        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo

            this.descrizione = txtDescrizione.Text;
            this.unitaMisura = cmbUnitaMisura.Text;
            this.prezzo = Convert.ToDouble(txtPrezzo.Text);

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }

        private void frmArticolo_Load(object sender, EventArgs e)
        {

        }
    }
}
