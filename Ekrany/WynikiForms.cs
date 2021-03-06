using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using POSK2.Klasy;
using System.Windows.Forms;

namespace POSK2.Ekrany
{
    public partial class WynikiForms : Form
    {
        Form OknoRodzic;
        Form OknoTest;
        List<int> WynikiLista = new List<int>();

        public WynikiForms(Form OknoRodzic, Form OknoTest, List<int> WynikiLista)
        {
            this.WynikiLista = WynikiLista;
            this.OknoRodzic = OknoRodzic;
            this.OknoTest = OknoTest;
            InitializeComponent();

            ZaladujWyniki();

        }

        private void ZaladujWyniki()
        {
            int i = 1;
            foreach (var Wynik in WynikiLista)
            {
                WynikiLiczbyLabel.Text += $"{i}. {Wynik.ToString()}ms.\n ";
               WynikiWykresChart.Series[0].Points.AddXY(i, Wynik);
                i++;
            }
            SredniaLabel.Text = $"Średnia: {Math.Round(WynikiLista.Average(),2)} ms.";
        }

        private void WyjscieDoMenuButton_Click(object sender, EventArgs e)
        {
            WynikiWykresChart.Series[0].Points.Clear();
            WynikiLiczbyLabel.Text = "";

            OknoRodzic.Visible = true;
            OknoTest.Close();
            this.Close();
        }
    }
}
