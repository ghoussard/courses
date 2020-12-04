using System.Windows.Forms;

namespace V4
{
    public interface Editeur {
        void Modifier(Personne p);
        DialogResult ShowDialog();

    }
}
