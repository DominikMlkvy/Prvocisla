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

namespace Prvocisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] pole;
        string file="";

        private void vytvorPole_Click(object sender, EventArgs e)
        {
            try
            {
                int velkost = Convert.ToInt32(Velkost.Text);
                int min = Convert.ToInt32(Min.Text);
                int max = Convert.ToInt32(Max.Text);
                if (velkost < 50)
                {
                    MessageBox.Show("Minimalna velkost pola je 50", "Nespravny vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (min < 0)
                {
                    MessageBox.Show("Prvočisla môzu byt iba kladné", "Nespravny vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (max - min < 1000)
                {
                    MessageBox.Show("Rozsah má byť aspoň 1000 čísel", "Nespravny vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pole = new int[velkost];
                Random rand = new Random();
                Vypis.Clear();
                Prvocisla.Clear();
                for (int i = 0; i < velkost; i++)
                {
                    pole[i] = rand.Next(min, max);
                    Vypis.Text += Convert.ToString(pole[i]) + ", ";
                }
            }
            catch
            {
                MessageBox.Show("Vstup zadavajte ako cele čísla", "Nespravny vstup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zistiPrvocisla_Click(object sender, EventArgs e)
        {
            try
            {
                Prvocisla.Clear();
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] < 2)
                        continue;
                    bool prvocislo = true;
                    double root = Math.Sqrt(Convert.ToDouble(pole[i]));
                    for (int j = 2; j < root + 1; j++)
                    {
                        if ((pole[i] % j == 0) && (pole[i] != j))
                        {
                            prvocislo = false;
                            break;
                        }
                    }
                    if (prvocislo == true)
                        Prvocisla.Text += pole[i] + ", ";
                }
            } catch { MessageBox.Show("Pole nie je vygenerovane", "Chyba poľa", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void save_Click(object sender, EventArgs e)
        {

            {
                if (file.Equals("")) {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        file = saveFileDialog1.FileName;
                        System.IO.StreamWriter write = File.CreateText(file);
                        write.WriteLine(Prvocisla.Text + "\n");
                        write.Dispose();
                    }
                }
                else
                {
                    System.IO.StreamWriter write = File.AppendText(file);
                    write.WriteLine(Prvocisla.Text + "\n");
                    write.Dispose();
                }
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {

            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                    System.IO.StreamWriter write = File.CreateText(file);
                    write.WriteLine(Prvocisla.Text + "\n");
                    write.Dispose();
                }
            }
        }
    }
}
