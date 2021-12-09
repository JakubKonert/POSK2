
namespace POSK2
{
    partial class StartMenuForms
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.WyjscieButton = new System.Windows.Forms.Button();
            this.TestOptycznyButton = new System.Windows.Forms.Button();
            this.TestAkusButton = new System.Windows.Forms.Button();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WyjscieButton
            // 
            this.WyjscieButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WyjscieButton.Location = new System.Drawing.Point(513, 567);
            this.WyjscieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WyjscieButton.Name = "WyjscieButton";
            this.WyjscieButton.Size = new System.Drawing.Size(130, 56);
            this.WyjscieButton.TabIndex = 0;
            this.WyjscieButton.Text = "Wyjście";
            this.WyjscieButton.UseVisualStyleBackColor = true;
            this.WyjscieButton.Click += new System.EventHandler(this.WyjscieButton_Click);
            // 
            // TestOptycznyButton
            // 
            this.TestOptycznyButton.Location = new System.Drawing.Point(496, 344);
            this.TestOptycznyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestOptycznyButton.Name = "TestOptycznyButton";
            this.TestOptycznyButton.Size = new System.Drawing.Size(164, 70);
            this.TestOptycznyButton.TabIndex = 1;
            this.TestOptycznyButton.Text = "Test optyczny";
            this.TestOptycznyButton.UseVisualStyleBackColor = true;
            this.TestOptycznyButton.Click += new System.EventHandler(this.TestOptycznyButton_Click);
            // 
            // TestAkusButton
            // 
            this.TestAkusButton.Location = new System.Drawing.Point(482, 198);
            this.TestAkusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestAkusButton.Name = "TestAkusButton";
            this.TestAkusButton.Size = new System.Drawing.Size(194, 72);
            this.TestAkusButton.TabIndex = 2;
            this.TestAkusButton.Text = "Test akustyczny";
            this.TestAkusButton.UseVisualStyleBackColor = true;
            this.TestAkusButton.Click += new System.EventHandler(this.TestAkusButton_Click);
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(430, 75);
            this.OpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(64, 25);
            this.OpisLabel.TabIndex = 3;
            this.OpisLabel.Text = "label1";
            // 
            // StartMenuForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.WyjscieButton;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.TestAkusButton);
            this.Controls.Add(this.TestOptycznyButton);
            this.Controls.Add(this.WyjscieButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartMenuForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt nr 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WyjscieButton;
        private System.Windows.Forms.Button TestOptycznyButton;
        private System.Windows.Forms.Button TestAkusButton;
        private System.Windows.Forms.Label OpisLabel;
    }
}

