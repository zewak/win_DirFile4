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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ReadDir = new System.Windows.Forms.Button();
            this.LV_files1 = new System.Windows.Forms.ListView();
            this.TB1_dir1 = new System.Windows.Forms.TextBox();
            this.LB_files1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Btn_ReadDir
            // 
            this.Btn_ReadDir.Location = new System.Drawing.Point(605, 415);
            this.Btn_ReadDir.Name = "Btn_ReadDir";
            this.Btn_ReadDir.Size = new System.Drawing.Size(86, 23);
            this.Btn_ReadDir.TabIndex = 2;
            this.Btn_ReadDir.Text = "Czytaj katalog";
            this.Btn_ReadDir.UseVisualStyleBackColor = true;
            this.Btn_ReadDir.Click += new System.EventHandler(this.Btn_ReadDir_Click);
            // 
            // LV_files1
            // 
            this.LV_files1.HideSelection = false;
            this.LV_files1.Location = new System.Drawing.Point(17, 15);
            this.LV_files1.Name = "LV_files1";
            this.LV_files1.Size = new System.Drawing.Size(311, 421);
            this.LV_files1.TabIndex = 3;
            this.LV_files1.UseCompatibleStateImageBehavior = false;
            // 
            // TB1_dir1
            // 
            this.TB1_dir1.Location = new System.Drawing.Point(334, 414);
            this.TB1_dir1.Name = "TB1_dir1";
            this.TB1_dir1.Size = new System.Drawing.Size(265, 20);
            this.TB1_dir1.TabIndex = 4;
            this.TB1_dir1.Text = "c:\\temp";
            // 
            // LB_files1
            // 
            this.LB_files1.FormattingEnabled = true;
            this.LB_files1.Location = new System.Drawing.Point(334, 15);
            this.LB_files1.Name = "LB_files1";
            this.LB_files1.Size = new System.Drawing.Size(265, 290);
            this.LB_files1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_files1);
            this.Controls.Add(this.TB1_dir1);
            this.Controls.Add(this.LV_files1);
            this.Controls.Add(this.Btn_ReadDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Win_DirFile4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ReadDir;
        private System.Windows.Forms.ListView LV_files1;
        private System.Windows.Forms.TextBox TB1_dir1;
        private System.Windows.Forms.ListBox LB_files1;
    }
}

