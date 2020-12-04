using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V4
{
    public partial class EditeurVIP : Form, Editeur {
        private VIP qui;
        private static EditeurVIP uniqueInstance = null;
        private EditeurVIP() {
            InitializeComponent();
        }
        public static EditeurVIP getInstance() {
            if (uniqueInstance == null)
                uniqueInstance = new EditeurVIP();
            return uniqueInstance;
        }
        public void Modifier(Personne qui) {
            VIP v = (VIP)qui;
            this.qui = v;
            txtTitre.Text = v.Titre;
            txtNom.Text = v.Nom;
        }
        private void btOK_Click(object sender, EventArgs e) {
            qui.Titre = txtTitre.Text.Trim();
            qui.Nom = txtNom.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void btAnnuler_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private Boolean OKPossible() {
            return (txtTitre.Text.Trim() != "") && (txtNom.Text.Trim() != "");
        }
        private void txtTitre_TextChanged(object sender, EventArgs e) {
            btOK.Enabled = OKPossible();
        }
        private void txtNom_TextChanged(object sender, EventArgs e) {
            btOK.Enabled = OKPossible();
        }
    }
}
