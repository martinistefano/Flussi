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
            StreamReader AMB1 = new(label1.Text);
            StreamReader AMB3 = new(label2.Text);
            StreamWriter FileNuovo = new(label3.Text);
            StreamWriter FileLog = new(label3.Text + ".log");
            String LineaAMB3 = AMB3.ReadLine();

            while (LineaAMB3 != null)
            {
                String LineaAMB1 = AMB1.ReadLine();
                if (LineaAMB1 == null)
                {
                    FileLog.WriteLine(LineaAMB3.Substring(0, 44) + " NON trovato!");
                    AMB1.Close();
                    AMB1 = new(label1.Text);
                    LineaAMB3 = AMB3.ReadLine();
                }
                else if (LineaAMB3.Substring(0,44) == LineaAMB1.Substring(0,44))
                {
                    FileNuovo.WriteLine(LineaAMB1.Substring(0, 54) + LineaAMB3.Substring(54, LineaAMB3.Length - 54));
                    FileLog.WriteLine(LineaAMB3.Substring(0,44) + " trovato e inserito con pratica numero " + LineaAMB1.Substring(44,10));
                    AMB1.Close();
                    AMB1 = new(label1.Text);
                    LineaAMB3 = AMB3.ReadLine();
                }            
            }
            AMB1.Close();
            AMB3.Close();
            FileNuovo.Close();
            FileLog.Close();
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
                openFileDialog2.FileName = saveFileDialog2.FileName;
                label2.Text = saveFileDialog2.FileName;
                Destinazione.Enabled = true;
                listBox1.Items.Clear();
            }
        }
    }
}