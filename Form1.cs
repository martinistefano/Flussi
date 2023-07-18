using System.ComponentModel.DataAnnotations;
using System;

namespace Flussi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++) listBox1.Items.Add(s[i]);
            Unisci.Enabled = true;
        }

        private void ApriAMB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                ApriNuovi.Enabled = true;
                listBox1.Enabled = true;
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
            bool Trovato = true;

            while (LineaNuovo != null)
            {
                LineaNuovo = AMBNuovo.ReadLine(); // Leggo una riga del file NUOVO
                if (LineaNuovo != null)
                {
                    string IDNuovo = LineaNuovo.Substring(0, 44);
                    Log.Write(IDNuovo);
                    Trovato = false;
                    while (LineaOrigine != null) // Alla prima esecuzione LineaOrigine è ""
                    {
                        LineaOrigine = AMBOrigine.ReadLine(); // Imposto LineaOrigine leggendo la prossima riga di AMBOrigine
                        if (LineaOrigine != null)
                        {
                            string IDOrigine = LineaOrigine.Substring(0, 44);
                            if (IDOrigine == IDNuovo)
                            {
                                Trovato = true;
                                string PraticaOrigine = LineaOrigine.Substring(44, 10);
                                string LineaRisultato = IDOrigine + PraticaOrigine + LineaNuovo.Substring(54, LineaNuovo.Length - 54);
                                Risultato.WriteLine(LineaRisultato); // Se gli ID corrispondono scrivo una riga nel file Risultato
                                Log.Write(" trovato e inserito con pratica numero " + PraticaOrigine + "\n");
                                AMBOrigine.Close();
                                AMBOrigine = new StreamReader(openFileDialog1.FileName);
                                break;
                            }
                        }
                    }
                    if (Trovato == false) Log.Write(" NON trovato!\n");
                }
            }
            Risultato.Close();
            AMBNuovo.Close();
            AMBOrigine.Close();
            Log.Close();
            MessageBox.Show("Fatto!");
        }

        private void Unisci_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                int quanti = listBox1.Items.Count;
                for (int i = 0; i < quanti; i++)
                {
                    StreamReader Fonte = new StreamReader(listBox1.Items[i].ToString());
                    File.AppendAllText(saveFileDialog2.FileName, Fonte.ReadToEnd());
                    Fonte = new StreamReader(listBox1.Items[i].ToString());
                    Fonte.Close();
                }
                label2.Text = saveFileDialog2.FileName;
                openFileDialog2.FileName = saveFileDialog2.FileName;
                Destinazione.Enabled = true;
                listBox1.Items.Clear();
            }
        }
    }
}