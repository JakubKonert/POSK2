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

        public WynikiForms(Form OknoRodzic, Form OknoTest)
        {
            this.OknoRodzic = OknoRodzic;
            this.OknoTest = OknoTest;
            InitializeComponent();

            ZaladujWynikiOptyczne();

        }

        private void ZaladujWynikiOptyczne()
        {
            int i = 1;
            foreach (var Wynik in TestOptyczny.WynikiOptycznyList)
            {
                WynikiLiczbyLabel.Text += $"{i}. {Wynik.ToString()}ms.\n ";
               WynikiWykresChart.Series[0].Points.AddXY(i, Wynik);
                i++;
            }
            SredniaLabel.Text = $"Średnia: {Math.Round(TestOptyczny.WynikiOptycznyList.Average(),2)} ms.";
        }

        private void WyjscieDoMenuButton_Click(object sender, EventArgs e)
        {
            WynikiWykresChart.Series[0].Points.Clear();
            WynikiLiczbyLabel.Text = "";

            OknoRodzic.Visible = true;
            OknoTest.Close();
            this.Close();
        }

        private void WynikiForms_Load(object sender, EventArgs e)
        {

        }
    }
}
