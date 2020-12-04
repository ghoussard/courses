using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class ListViewItemVoiture : System.Windows.Forms.ListViewItem
    {
        private Voiture garé;

        public ListViewItemVoiture(Voiture v) : base()
        {
            garé = v;
            Text = v.ToString();
        }

        public Voiture Garé
        {
            get => garé;
        }

        public void changerText(Voiture v)
        {
            Text = v.ToString();
        }
    }
}
