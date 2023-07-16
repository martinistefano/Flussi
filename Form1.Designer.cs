﻿namespace Flussi
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ApriAMB
            // 
            ApriAMB.Location = new Point(12, 12);
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
            ApriNuovi.Location = new Point(12, 64);
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
            Destinazione.Location = new Point(12, 116);
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
            saveFileDialog1.Filter = "File TXT (*.txt)|*.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Percorso...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Percorso...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 132);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Percorso...";
            // 
            // Assembla
            // 
            Assembla.Dock = DockStyle.Bottom;
            Assembla.Enabled = false;
            Assembla.Location = new Point(0, 209);
            Assembla.Name = "Assembla";
            Assembla.Size = new Size(592, 46);
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
            Unisci.Location = new Point(6, 137);
            Unisci.Name = "Unisci";
            Unisci.Size = new Size(211, 30);
            Unisci.TabIndex = 8;
            Unisci.Text = "Unisci i file...";
            Unisci.UseVisualStyleBackColor = true;
            Unisci.Click += Unisci_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Unisci);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(357, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 180);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unisci diversi AMB 3 (opzionale)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(592, 255);
            Controls.Add(groupBox1);
            Controls.Add(Assembla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Destinazione);
            Controls.Add(ApriNuovi);
            Controls.Add(ApriAMB);
            Name = "Form1";
            Text = "Assemblaggio Flussi AMB";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
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
    }
}