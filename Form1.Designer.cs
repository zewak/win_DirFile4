namespace Win_DirFile4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_CzytajKat = new System.Windows.Forms.Button();
            this.TB_path1 = new System.Windows.Forms.TextBox();
            this.LB_Files1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(699, 415);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Wyjście";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_CzytajKat
            // 
            this.Btn_CzytajKat.Location = new System.Drawing.Point(604, 415);
            this.Btn_CzytajKat.Name = "Btn_CzytajKat";
            this.Btn_CzytajKat.Size = new System.Drawing.Size(75, 23);
            this.Btn_CzytajKat.TabIndex = 3;
            this.Btn_CzytajKat.Text = "Czytaj Kalog";
            this.Btn_CzytajKat.UseVisualStyleBackColor = true;
            this.Btn_CzytajKat.Click += new System.EventHandler(this.Btn_CzytajKat_Click);
            // 
            // TB_path1
            // 
            this.TB_path1.Location = new System.Drawing.Point(394, 418);
            this.TB_path1.Name = "TB_path1";
            this.TB_path1.Size = new System.Drawing.Size(193, 20);
            this.TB_path1.TabIndex = 4;
            this.TB_path1.Text = "c:\\temp";
            // 
            // LB_Files1
            // 
            this.LB_Files1.FormattingEnabled = true;
            this.LB_Files1.Location = new System.Drawing.Point(12, 7);
            this.LB_Files1.Name = "LB_Files1";
            this.LB_Files1.Size = new System.Drawing.Size(373, 433);
            this.LB_Files1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Files1);
            this.Controls.Add(this.TB_path1);
            this.Controls.Add(this.Btn_CzytajKat);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_CzytajKat;
        private System.Windows.Forms.TextBox TB_path1;
        private System.Windows.Forms.ListBox LB_Files1;
    }
}

