using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3
{
    public partial class EditeurPersonne : Form
    {
        private Personne qui;
        private static EditeurPersonne uniqueInstance = null;
        private EditeurPersonne() {
            InitializeComponent();
        }
        public static EditeurPersonne getInstance() {
            if (uniqueInstance == null)
                uniqueInstance = new EditeurPersonne();
            return uniqueInstance;
        }
        public void Modifier(Personne qui) {
            this.qui = qui;
            txtNom.Text = qui.Nom;
        }
        private void btOK_Click(object sender, EventArgs e) {
            qui.Nom = txtNom.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btAnnuler_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e) {
            btOK.Enabled = (txtNom.Text.Trim() != "");
        }
    }
}
