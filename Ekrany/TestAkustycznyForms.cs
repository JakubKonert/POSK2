using System.Windows.Forms;

namespace POSK2.Ekrany
{
    public partial class TestAkustycznyForms : Form
    {
        Form OknoRodzic;
        public TestAkustycznyForms(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
        }

    }
}
