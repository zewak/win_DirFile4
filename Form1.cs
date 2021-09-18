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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ReadDir_Click(object sender, EventArgs e)
        {
            label1.Text = "Czytamy...";
            LV_files1.Items.Add("Jeden");
            LV_files1.Items.Add("Dwa");
            LB_files1.Items.Add("Jeden");
            LB_files1.Items.Add("Trzy");
            label1.Text = "Przeczytano";
        }
    }
}
