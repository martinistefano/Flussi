namespace Flussi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ApriAMB = new Button();
            ApriNuovi = new Button();
            Destinazione = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Assembla = new Button();
            listBox1 = new ListBox();
            Unisci = new Button();
            saveFileDialog2 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ApriAMB
            // 
            ApriAMB.Location = new Point(6, 22);
            ApriAMB.Name = "ApriAMB";
            ApriAMB.Size = new Size(116, 46);
            ApriAMB.TabIndex = 0;
            ApriAMB.Text = "Seleziona flusso AMB 1...";
            ApriAMB.UseVisualStyleBackColor = true;
            ApriAMB.Click += ApriAMB_Click;
            // 
            // ApriNuovi
            // 
            ApriNuovi.Enabled = false;
            ApriNuovi.Location = new Point(6, 74);
            ApriNuovi.Name = "ApriNuovi";
            ApriNuovi.Size = new Size(116, 46);
            ApriNuovi.TabIndex = 1;
            ApriNuovi.Text = "Seleziona AMB 3 da inserire...";
            ApriNuovi.UseVisualStyleBackColor = true;
            ApriNuovi.Click += ApriNuovi_Click;
            // 
            // Destinazione
            // 
            Destinazione.Enabled = false;
            Destinazione.Location = new Point(7, 126);
            Destinazione.Name = "Destinazione";
            Destinazione.Size = new Size(116, 46);
            Destinazione.TabIndex = 2;
            Destinazione.Text = "Seleziona destinazione...";
            Destinazione.UseVisualStyleBackColor = true;
            Destinazione.Click += Destinazione_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "File TXT (*.txt)|*.txt";
            // 
            // openFileDialog2
            // 
            openFileDialog2.Filter = "File TXT (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "File TXT (*.txt)|*.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Percorso...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Percorso...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 142);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Percorso...";
            // 
            // Assembla
            // 
            Assembla.Dock = DockStyle.Bottom;
            Assembla.Enabled = false;
            Assembla.Location = new Point(0, 215);
            Assembla.Name = "Assembla";
            Assembla.Size = new Size(528, 46);
            Assembla.TabIndex = 6;
            Assembla.Text = "Crea il nuovo file";
            Assembla.UseVisualStyleBackColor = true;
            Assembla.Click += Assembla_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 109);
            listBox1.TabIndex = 7;
            // 
            // Unisci
            // 
            Unisci.Enabled = false;
            Unisci.Location = new Point(6, 142);
            Unisci.Name = "Unisci";
            Unisci.Size = new Size(211, 30);
            Unisci.TabIndex = 8;
            Unisci.Text = "Unisci i file...";
            Unisci.UseVisualStyleBackColor = true;
            Unisci.Click += Unisci_Click_1;
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.DefaultExt = "txt";
            saveFileDialog2.Filter = "File TXT (*.txt)|*.txt";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(Unisci);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(305, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 215);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unisci diversi AMB 3 (opzionale)";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(ApriAMB);
            groupBox2.Controls.Add(ApriNuovi);
            groupBox2.Controls.Add(Destinazione);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 215);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleziona file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(528, 261);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Assembla);
            MinimumSize = new Size(544, 300);
            Name = "Form1";
            Text = "Assemblaggio Flussi AMB";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ApriAMB;
        private Button ApriNuovi;
        private Button Destinazione;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Assembla;
        private ListBox listBox1;
        private Button Unisci;
        private SaveFileDialog saveFileDialog2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}