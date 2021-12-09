using POSK2.Klasy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSK2.Ekrany
{
    public partial class TestOptycznyForms : Form
    {
        Form OknoRodzic;
        int LosowaLiczba;
        public TestOptycznyForms(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
            OpisOptycznyLabel.Text = $"Podczas testu musisz wcisnąć przcisk, którego opis będzie zgodny" +
                $"z napisem wyświetlanym nad przciskami 1-9, odpowiedź będzie poprawna dopiero gdy \nwciśniesz" +
                $"poprawny przycisk. \nTest posiada 2 warianty: Próba i badanie czasu reakcji. \nPodczas próby, wyniki" +
                $"nie są zbierane, natomiast podczas badania czasu reakcji, kluczowe będzie mieć znaczenie" +
                $"twoja szybkość wciskania POPRAWNEGO \nprzycisku. ";

        }

        private void WynikiOptycznyButton_Click(object sender, System.EventArgs e)
        {
            new WynikiForms(OknoRodzic, this).ShowDialog();
            this.Visible = false;
        }

        private void CzasOptycznyTimer_Tick(object sender, System.EventArgs e)
        {
            if (!TestOptyczny.CzasPomiaru.IsRunning)
            {
                TestOptyczny.CzasPomiaru.Reset();
                LosowaLiczba = TestOptyczny.ZmianaLiczby();
                LiczbaLabel.Text = LosowaLiczba.ToString();
                TestOptyczny.CzasPomiaru.Start();
            }
        }

        private void StartOptycznyButton_Click(object sender, System.EventArgs e)
        {
            TestOptyczny.TestOptycznyTrwa = !TestOptyczny.TestOptycznyTrwa;
            if (TestOptyczny.TestOptycznyTrwa)
            {
                ProbaOptycznyCheckBox.Enabled = false;
                StartOptycznyButton.Text = "Stop";

                CzasOptycznyTimer.Interval = (TestOptyczny.Losowe.Next(2000) + 2000);
                CzasOptycznyTimer.Enabled = true;

                JedenButton.Enabled = true;
                DwaButton.Enabled = true;
                TrzyButton.Enabled = true;
                CzteryButton.Enabled = true;
                PiecButton.Enabled = true;
                SzescButton.Enabled = true;
                SiedemButton.Enabled = true;
                OsiemButton.Enabled = true;
                DziewiecButton.Enabled = true;
            }
            else
            {
                ProbaOptycznyCheckBox.Enabled = true;
                StartOptycznyButton.Text = "Start";
                CzasOptycznyTimer.Enabled = false;
                LiczbaLabel.Text = "?";
                StanLiczbyLabel.Text = "";

                JedenButton.Enabled = false;
                DwaButton.Enabled = false;
                TrzyButton.Enabled = false;
                CzteryButton.Enabled = false;
                PiecButton.Enabled = false;
                SzescButton.Enabled = false;
                SiedemButton.Enabled = false;
                OsiemButton.Enabled = false;
                DziewiecButton.Enabled = false;

            }
        }

        private void TestOptycznyForms_Load(object sender, System.EventArgs e)
        {
            LiczbaLabel.Text = "?";
            StanLiczbyLabel.Text = "";
            ProbaOptycznyCheckBox.Checked = true;
            TestOptyczny.TestOptycznyTrwa = false;
            StartOptycznyButton.Text = "Start";
            TestOptyczny.NumerPomiaru = 0;
            CzasOptycznyTimer.Stop();
            TestOptyczny.WynikiOptycznyList = new List<int>();
            CzasOptycznyTimer.Enabled = false;
            WynikiOptycznyButton.Visible = false;

            JedenButton.Enabled = false;
            DwaButton.Enabled = false;
            TrzyButton.Enabled = false;
            CzteryButton.Enabled = false;
            PiecButton.Enabled = false;
            SzescButton.Enabled = false;
            SiedemButton.Enabled = false;
            OsiemButton.Enabled = false;
            DziewiecButton.Enabled = false;
        }

        private void WyjscieOptycznyButton_Click(object sender, System.EventArgs e)
        {
            OknoRodzic.Visible = true;
            CzasOptycznyTimer.Enabled = false;
            this.Close();
        }

        //de facto kliknięcie któregoś z 9 przyciskow
        private void LiczbaPrzycisk_Click(object sender, EventArgs e)
        {
            Button klawisz = (Button)sender;
            if (TestOptyczny.CzasPomiaru.IsRunning)
            {
                if (klawisz.Text == LosowaLiczba.ToString())
                {
                    StanLiczbyLabel.Text = "Dobrze";
                    TestOptyczny.CzasPomiaru.Stop();
                    LiczbaLabel.Text = "?";
                }
                else
                {
                    StanLiczbyLabel.Text = "Źle";
                }
                if (!ProbaOptycznyCheckBox.Checked)
                {
                    int CzasReakcji = (int)TestOptyczny.CzasPomiaru.ElapsedMilliseconds;
                    CzasOptycznyTimer.Interval = (TestOptyczny.Losowe.Next(2000) + 2000);
                    TestOptyczny.NumerPomiaru++;
                    TestOptyczny.WynikiOptycznyList.Add(CzasReakcji);
                    WynikiOptycznyButton.Visible = true;
                }
            }
            else { StanLiczbyLabel.Text="Za szybko wcisnąłeś klawisz"; }
        }
    }
}
