using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exempleBdD
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (BdD.seConnecterALaBase() == false) {
                MessageBox.Show("Impossible de se connecter à la base de données !",
                                "ExempleBdD",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenetreRepertoire());
            BdD.seDeconnecterDeLaBase();
        }
    }
}
