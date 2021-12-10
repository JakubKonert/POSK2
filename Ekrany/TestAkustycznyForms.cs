using POSK2.Klasy;
using System;
using System.Collections.Generic;
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
            OpisAkustycznyLabel.Text = $"Podczas testu musisz wcisnąć przcisk, gdy usłyszysz dźwięk." +
                $" \nTest posiada 2 warianty: Próba i badanie czasu reakcji. \nPodczas próby, wyniki" +
                $"nie są zbierane, natomiast podczas badania czasu reakcji, kluczowe będzie mieć znaczenie" +
                $"twoja szybkość \nwciskania przycisku. ";
        }

        private void WyjscieAkustycznyButton_Click(object sender, System.EventArgs e)
        {
            OknoRodzic.Visible = true;
            CzasAkustycznyTimer.Enabled = false;
            this.Close();
        }

        private void DzwiekButton_Click(object sender, System.EventArgs e)
        {
            if (TestAkustyczny.CzasPomiaru.IsRunning)
            {
                DzwiekAkustycznyLabel.Text = "Dobrze";
                TestAkustyczny.CzasPomiaru.Stop();
                if (!ProbaAkustycznyCheckBox.Checked)
                {
                    int CzasReakcji = (int)TestAkustyczny.CzasPomiaru.ElapsedMilliseconds;
                    CzasAkustycznyTimer.Interval = (TestAkustyczny.Losowe.Next(2000) + 2000);
                    TestAkustyczny.NumerPomiaru++;
                    TestAkustyczny.WynikiAkustycznyList.Add(CzasReakcji);
                    WynikiAkustycznyButton.Visible = true;
                }
            }
            else { DzwiekAkustycznyLabel.Text = "Za szybko wcisnąłeś klawisz"; }
        }

        private void WynikiAkustycznyButton_Click(object sender, System.EventArgs e)
        {
            new WynikiForms(OknoRodzic, this, TestAkustyczny.WynikiAkustycznyList).ShowDialog();
            this.Visible = false;
        }

        private void StartAkustycznyButton_Click(object sender, System.EventArgs e)
        {
            TestAkustyczny.TestAkustycznyTrwa = !TestAkustyczny.TestAkustycznyTrwa;
            if (TestAkustyczny.TestAkustycznyTrwa)
            {
                ProbaAkustycznyCheckBox.Enabled = false;
                StartAkustycznyButton.Text = "Stop";

                CzasAkustycznyTimer.Interval = (TestAkustyczny.Losowe.Next(2000) + 2000);
                CzasAkustycznyTimer.Enabled = true;
            }
            else
            {
                ProbaAkustycznyCheckBox.Enabled = true;
                StartAkustycznyButton.Text = "Start";
                CzasAkustycznyTimer.Enabled = false;
            }
        }

        private void CzasAkustycznyTimer_Tick(object sender, System.EventArgs e)
        {
            if (!TestAkustyczny.CzasPomiaru.IsRunning)
            {
                TestAkustyczny.CzasPomiaru.Reset();
                Console.Beep();
                TestAkustyczny.CzasPomiaru.Start();
            }
        }

        private void TestAkustycznyForms_Load(object sender, System.EventArgs e)
        {
            ProbaAkustycznyCheckBox.Checked = true;
            TestAkustyczny.TestAkustycznyTrwa = false;
            StartAkustycznyButton.Text = "Start";
            TestAkustyczny.NumerPomiaru = 0;
            CzasAkustycznyTimer.Stop();
            TestAkustyczny.WynikiAkustycznyList = new List<int>();
            CzasAkustycznyTimer.Enabled = false;
            WynikiAkustycznyButton.Visible = false;
            DzwiekAkustycznyLabel.Text = "";
        }
    }
}
