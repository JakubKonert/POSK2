using POSK2.Ekrany;
using System;
using System.Windows.Forms;

namespace POSK2
{
    public partial class StartMenuForms : Form
    {
        public StartMenuForms()
        {
            InitializeComponent();
            OpisLabel.Text = "Wybierz 1 z dostępnych testów i sprawdź swój czas reakcji";
        }

        private void TestAkusButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new TestAkustycznyForms(this).ShowDialog();
        }

        private void TestOptycznyButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new TestOptycznyForms(this).ShowDialog();
        }

        private void WyjscieButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
