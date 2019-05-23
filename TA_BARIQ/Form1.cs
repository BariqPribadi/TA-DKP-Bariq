using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_BARIQ
{
    public partial class Form1 : Form
    {
        public double Celcius, Reamur, Fahrenheit, Kelvin;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keluar kl = new Keluar();
            kl.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHasil.Text = String.Empty;
            txtSuhu.Text = String.Empty;
            kolomPilihan.Text = String.Empty;
        }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            
            int tujuan = kolomPilihan.SelectedIndex;
            try
            {
                double Celcius1, Celcius2, Celcius3, Reamur1, Reamur2, Reamur3, Fahrenheit1, Fahrenheit2, Fahrenheit3, Kelvin1, Kelvin2, Kelvin3;
                switch (tujuan)
                {
                    case (0):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Celcius = double.Parse(txtSuhu.Text);
                            double Reamur = Celcius * 0.8;
                            Reamur1 = Math.Round(Reamur, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Reamur1.ToString() + (" °R");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (1):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Celcius = double.Parse(txtSuhu.Text);
                            double Fahrenheit = Celcius * 1.8 + 32;
                            Fahrenheit1 = Math.Round(Fahrenheit, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Fahrenheit1.ToString() + (" °F");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;
                    case (2):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Celcius = double.Parse(txtSuhu.Text);
                            double Kelvin = Celcius + 273;
                            Kelvin1 = Math.Round(Kelvin, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Kelvin1.ToString() + (" K");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (3):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Reamur = double.Parse(txtSuhu.Text);
                            double Celcius = Reamur / 0.8;
                            Celcius1 = Math.Round(Celcius, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Celcius1.ToString() + (" °C");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (4):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Reamur = double.Parse(txtSuhu.Text);
                            double Fahrenheit = Reamur * 2.25 + 32;
                            Fahrenheit2 = Math.Round(Fahrenheit, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Fahrenheit2.ToString() + (" °F");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (5):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Reamur = double.Parse(txtSuhu.Text);
                            double Kelvin = Reamur / 0.8 + 273;
                            Kelvin2 = Math.Round(Kelvin, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Kelvin2.ToString() + (" K");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (6):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Fahrenheit = double.Parse(txtSuhu.Text);
                            double Celcius = (Fahrenheit - 32) / 1.8;
                            Celcius2 = Math.Round(Celcius, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Celcius2.ToString() + (" °C");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (7):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Fahrenheit = double.Parse(txtSuhu.Text);
                            double Reamur = (Fahrenheit - 32) / 2.25;
                            Reamur2 = Math.Round(Reamur, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Reamur2.ToString() + (" °R");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (8):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Fahrenheit = double.Parse(txtSuhu.Text);
                            double Kelvin = ((Fahrenheit - 32) / 1.8) + 273;
                            Kelvin2 = Math.Round(Kelvin, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Kelvin2.ToString() + (" K");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (9):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Kelvin = double.Parse(txtSuhu.Text);
                            double Celcius = Kelvin - 273;
                            Celcius3 = Math.Round(Celcius, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Celcius3.ToString() + (" °C");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (10):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Kelvin = double.Parse(txtSuhu.Text);
                            double Reamur = (Kelvin - 273) * 0.8;
                            Reamur3 = Math.Round(Reamur, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Reamur3.ToString() + (" °R");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;

                    case (11):
                        if (!"".Equals(txtSuhu.Text))
                        {
                            Hasil objek = new Hasil();
                            Kelvin = double.Parse(txtSuhu.Text);
                            double Fahrenheit = ((Kelvin - 273) * 1.8) + 32;
                            Fahrenheit3 = Math.Round(Fahrenheit, 2);
                            txtHasil.Text = System.Convert.ToString(objek.identitas()) + Fahrenheit3.ToString() + (" °F");
                            txtHasil.Enabled = false;
                        }
                        else
                        {
                            txtHasil.Text = "Masukan suhu awal!!!";
                            txtHasil.Enabled = false;
                        }
                        break;
                }
            }

            catch (Exception kesalahan)
            {
                MessageBox.Show("Telah terjadi kesalahan karena inputan bukan angka!!! ");
            }


        }
     }
   }
