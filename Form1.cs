using System.ComponentModel.DataAnnotations;
using System;

namespace Flussi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApriAMB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                ApriNuovi.Enabled = true;
            }
        }

        private void ApriNuovi_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                label2.Text = openFileDialog2.FileName;
                Destinazione.Enabled = true;
            }
        }

        private void Destinazione_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = saveFileDialog1.FileName;
                Assembla.Enabled = true;
            }
        }

        private void Assembla_Click(object sender, EventArgs e)
        {
            StreamReader AMBOrigine = new StreamReader(openFileDialog1.FileName);
            StreamReader AMBNuovo = new StreamReader(openFileDialog2.FileName);
            StreamWriter Risultato = new StreamWriter(saveFileDialog1.FileName);
            StreamWriter Log = new StreamWriter(saveFileDialog1.FileName + ".log");

            string LineaOrigine = "";
            string LineaNuovo = "";
            while (LineaNuovo != null)
            {
                LineaNuovo = AMBNuovo.ReadLine(); // Leggo una riga del file NUOVO
                if (LineaNuovo != null)
                {
                    string IDNuovo = LineaNuovo.Substring(0, 44);
                    Log.WriteLine(IDNuovo);
                    while (LineaOrigine != null) // Alla prima esecuzione LineaOrigine è ""
                    {
                        LineaOrigine = AMBOrigine.ReadLine(); // Imposto LineaOrigine leggendo la prossima riga di AMBOrigine
                        if (LineaOrigine != null)
                        {
                            string IDOrigine = LineaOrigine.Substring(0, 44);
                            if (IDOrigine == IDNuovo)
                            {
                                string PraticaOrigine = LineaOrigine.Substring(44, 10);
                                string LineaRisultato = IDOrigine + PraticaOrigine + LineaNuovo.Substring(54, LineaNuovo.Length - 54);
                                Risultato.WriteLine(LineaRisultato); // Se gli ID corrispondono scrivo una riga nel file Risultato
                                Log.WriteLine("Trovato e inserito con pratica numero " + PraticaOrigine + "\n");
                                AMBOrigine.Close();
                                AMBOrigine = new StreamReader(openFileDialog1.FileName);
                                break;
                            }
                        }
                    }
                }
            }
            Risultato.Close();
            AMBNuovo.Close();
            AMBOrigine.Close();
            Log.Close();
            MessageBox.Show("Fatto!");
        }
    }
}