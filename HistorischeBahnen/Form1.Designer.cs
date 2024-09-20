namespace HistorischeBahnen
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
            panel1 = new Panel();
            btnExit = new Button();
            btnLöschen = new Button();
            btnHinzufügen = new Button();
            btnÄÄndern = new Button();
            txtBeschreibung = new TextBox();
            label5 = new Label();
            txtGewichtinKg = new TextBox();
            txtProduktionsdatum = new TextBox();
            txtNamedesZugeges = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLöschen);
            panel1.Controls.Add(btnHinzufügen);
            panel1.Controls.Add(btnÄÄndern);
            panel1.Controls.Add(txtBeschreibung);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGewichtinKg);
            panel1.Controls.Add(txtProduktionsdatum);
            panel1.Controls.Add(txtNamedesZugeges);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 150);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(507, 112);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLöschen
            // 
            btnLöschen.Location = new Point(507, 83);
            btnLöschen.Name = "btnLöschen";
            btnLöschen.Size = new Size(75, 23);
            btnLöschen.TabIndex = 12;
            btnLöschen.Text = "löschen";
            btnLöschen.UseVisualStyleBackColor = true;
            btnLöschen.Click += btnLöschen_Click;
            // 
            // btnHinzufügen
            // 
            btnHinzufügen.Location = new Point(507, 54);
            btnHinzufügen.Name = "btnHinzufügen";
            btnHinzufügen.Size = new Size(75, 23);
            btnHinzufügen.TabIndex = 11;
            btnHinzufügen.Text = "hinzufügen";
            btnHinzufügen.UseVisualStyleBackColor = true;
            btnHinzufügen.Click += btnHinzufügen_Click;
            // 
            // btnÄÄndern
            // 
            btnÄÄndern.Location = new Point(507, 25);
            btnÄÄndern.Name = "btnÄÄndern";
            btnÄÄndern.Size = new Size(75, 23);
            btnÄÄndern.TabIndex = 10;
            btnÄÄndern.Text = "ändern";
            btnÄÄndern.UseVisualStyleBackColor = true;
            btnÄÄndern.Click += btnÄÄndern_Click;
            // 
            // txtBeschreibung
            // 
            txtBeschreibung.Location = new Point(383, 55);
            txtBeschreibung.Name = "txtBeschreibung";
            txtBeschreibung.Size = new Size(118, 23);
            txtBeschreibung.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 37);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Beschreibung";
            // 
            // txtGewichtinKg
            // 
            txtGewichtinKg.Location = new Point(277, 55);
            txtGewichtinKg.Name = "txtGewichtinKg";
            txtGewichtinKg.Size = new Size(100, 23);
            txtGewichtinKg.TabIndex = 7;
            // 
            // txtProduktionsdatum
            // 
            txtProduktionsdatum.Location = new Point(165, 55);
            txtProduktionsdatum.Name = "txtProduktionsdatum";
            txtProduktionsdatum.Size = new Size(106, 23);
            txtProduktionsdatum.TabIndex = 6;
            // 
            // txtNamedesZugeges
            // 
            txtNamedesZugeges.Location = new Point(59, 55);
            txtNamedesZugeges.Name = "txtNamedesZugeges";
            txtNamedesZugeges.Size = new Size(100, 23);
            txtNamedesZugeges.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(3, 55);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 37);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Gewicht in Kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 37);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Produktionsdatum";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 37);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Neme des Zuges";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(754, 300);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBeschreibung;
        private Label label5;
        private TextBox txtGewichtinKg;
        private TextBox txtProduktionsdatum;
        private TextBox txtNamedesZugeges;
        private TextBox txtId;
        private Button btnExit;
        private Button btnLöschen;
        private Button btnHinzufügen;
        private Button btnÄÄndern;
        private DataGridView dataGridView1;
    }
}
