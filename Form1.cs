using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LV_dirs1.Items.Add("Jeden");
            LV_dirs1.Items.Add("Dwa");
            LB_files1.Items.Add("Jeden");
            LB_files1.Items.Add("Trzy");
            try
            {
                string[] pliki = Directory.GetFiles(TB1_dir1.Text);
                foreach (string plik in pliki)
                    LB_files1.Items.Add(plik);
            } catch (Exception ex)
            {
                ;
            }

            try
            {
                string[] katalogi = Directory.GetDirectories(TB1_dir1.Text);
                foreach (string katalog in katalogi)
                    LB_files1.Items.Add(katalog);
            } catch (Exception ex)
            {
                ;
            }

            label1.Text = "Przeczytano: "+TB1_dir1.Text;

            Read_Dir(TB1_dir1.Text);

            //test gałęzi zx_stacjonar
        }

        private void Btn_Read_C_Click(object sender, EventArgs e)
        {
            Read_Dir("C:\\");
        }

        private void Read_Dir(string path)
        {
            LB_files1.Items.Clear();
            string[] pliki = Directory.GetFiles(path);
            foreach (string plik in pliki)
                LB_files1.Items.Add(plik);
            label1.Text = "Przeczytano: " + path;

            LV_dirs1.Items.Clear();
            try
            {
                string[] katalogi = Directory.GetDirectories(path);
                foreach (string katalog in katalogi)
                    LV_dirs1.Items.Add(katalog);
            }
            catch (Exception ex)
            {
                ;
            }

            LB_Dirs2.Items.Clear();
            try
            {
                string[] katalogi = Directory.GetDirectories(path);
                foreach (string katalog in katalogi)
                    LB_Dirs2.Items.Add(katalog);
            }
            catch (Exception ex)
            {
                ;
            }

        }

        private void LV_dirs1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (string) LV_dirs1.SelectedItems[0].Tag;
                TB1_dir1.Text = selectedItem;
            } catch (Exception ex)
            {
                ;
            }
        }

        private void LB_files1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = LB_files1.SelectedIndex;
            label1.Text = "Index: "+a;
            TB1_dir1.Text = (string)LB_files1.Items[a];
        }

        private void LB_Dirs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = LB_Dirs2.SelectedIndex;
            label1.Text = "Index: " + a;
            TB1_dir1.Text = (string)LB_Dirs2.Items[LB_Dirs2.SelectedIndex];
        }

        private void Btn_CzytajObraz_Click(object sender, EventArgs e)
        {
            ///PicBox1.Image = Bitmap.FromFile("E:\\Laleczki\\jpg\\default-07d797133ed776fbb337d0c1cd539e48.jpg");
            PicBox1.Image = Bitmap.FromFile((string)LB_files1.Items[LB_files1.SelectedIndex]);
        }
    }
}
