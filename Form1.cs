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
            string LineaOrigine = "";
            string LineaNuovo = "";
            string LineaRisultato = "";
            string IDNuovo = "";
            string IDOrigine = "";
            string PraticaOrigine = "";
            while (LineaNuovo != null)
            {
                LineaNuovo = AMBNuovo.ReadLine();
                if (LineaNuovo != null)
                {
                    IDNuovo = LineaNuovo.Substring(0, 44);
                    while (LineaOrigine != null)
                    {
                        LineaOrigine = AMBOrigine.ReadLine();
                        if (LineaOrigine != null)
                        {
                            IDOrigine = LineaOrigine.Substring(0, 44);
                            PraticaOrigine = LineaOrigine.Substring(44, 10);
                            if (IDOrigine == IDNuovo)
                            {
                                LineaRisultato = IDOrigine + PraticaOrigine + LineaNuovo.Substring(54, LineaNuovo.Length - 54);
                                Risultato.WriteLine(LineaRisultato);
                                MessageBox.Show("Scritto un record!");
                            }
                        }

                    }

                }
            }
            Risultato.Close();
            AMBNuovo.Close();
            AMBOrigine.Close();
        }
    }
}