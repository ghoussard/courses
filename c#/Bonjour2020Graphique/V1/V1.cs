using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1
{
    public partial class V1 : Form
    {
        public V1() {
            InitializeComponent();
        }

        private void btSaluer_Click(object sender, EventArgs e) {
            string salut = "";
            if (txtTitre.Text != "")
                salut += "Bien le bonjour " + txtTitre.Text + " ";
            else
                salut += "Bonjour ";
            salut += txtNom.Text;
            salut += " !";
            txtSalut.Text = salut;
            txtTitre.Text = "";
            txtNom.Text = "";
        }

        private void btAjouter_Click(object sender, EventArgs e) {
            Personne p;
            if (txtTitre.Text != "")
                p = new VIP(txtTitre.Text, txtNom.Text);
            else
                p = new Personne(txtNom.Text);
            lstPersonnes.Items.Add(new ListViewItemPersonne(p));
            txtTitre.Text = "";
            txtNom.Text = "";
            txtSalut.Text = "";
        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (ListViewItemPersonne pi in lstPersonnes.SelectedItems)
                txtSalut.Text = pi.Qui.Salut();
        }
    }
}
