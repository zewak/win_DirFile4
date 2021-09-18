using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_DirFile4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // wyście z aplikacji
        }

        private void Btn_CzytajKat_Click(object sender, EventArgs e)
        {
            label1.Text = "Czytamy ...";

            LB_Files1.Items.Add("Pierszy");
            LB_Files1.Items.Add("Drugi");
            LB_Files1.Items.Add("Trzeci");

            label1.Text = "Przeczytano";
        }
    }
}
