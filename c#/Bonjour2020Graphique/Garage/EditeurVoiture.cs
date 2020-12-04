using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class EditeurVoiture : Form
    {

        private Voiture voiture;

        public EditeurVoiture()
        {
            InitializeComponent();
        }

        public void Modifier(Voiture v)
        {
            voiture = v;
            nomTextBox.Text = v.Nom;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            voiture.Nom = nomTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
