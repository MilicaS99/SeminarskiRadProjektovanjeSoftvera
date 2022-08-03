
using System.Windows.Forms;

namespace Client
{
    partial class FormaVaspitač
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.btnDodajVaspitača = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnIzmeniVaspitača = new System.Windows.Forms.Button();
            this.btnPrikaziDetljnije = new System.Windows.Forms.Button();
            this.btnobrisivaspitaca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pol:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kontakt:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program:";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIme.Location = new System.Drawing.Point(210, 62);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(204, 20);
            this.txtIme.TabIndex = 5;
            this.txtIme.Text = "Ime";
            this.txtIme.Enter += new System.EventHandler(this.txtIme_Enter);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrezime.Location = new System.Drawing.Point(210, 98);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(204, 20);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Text = "Prezime";
            this.txtPrezime.Enter += new System.EventHandler(this.txtPrezime_Enter);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtKontakt
            // 
            this.txtKontakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKontakt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontakt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKontakt.Location = new System.Drawing.Point(210, 164);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(204, 20);
            this.txtKontakt.TabIndex = 7;
            this.txtKontakt.Text = "06XXXXXXXX";
            this.txtKontakt.Enter += new System.EventHandler(this.txtKontakt_Enter);
            this.txtKontakt.Leave += new System.EventHandler(this.txtKontakt_Leave);
            // 
            // txtPol
            // 
            this.txtPol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPol.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPol.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPol.Location = new System.Drawing.Point(210, 132);
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(204, 20);
            this.txtPol.TabIndex = 8;
            this.txtPol.Text = "Pol";
            this.txtPol.Enter += new System.EventHandler(this.txtPol_Enter);
            this.txtPol.Leave += new System.EventHandler(this.txtPol_Leave);
            // 
            // cbProgram
            // 
            this.cbProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProgram.BackColor = System.Drawing.Color.Ivory;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(210, 197);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(205, 21);
            this.cbProgram.TabIndex = 9;
            // 
            // btnDodajVaspitača
            // 
            this.btnDodajVaspitača.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajVaspitača.BackColor = System.Drawing.Color.LightCoral;
            this.btnDodajVaspitača.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVaspitača.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVaspitača.Location = new System.Drawing.Point(81, 233);
            this.btnDodajVaspitača.Name = "btnDodajVaspitača";
            this.btnDodajVaspitača.Size = new System.Drawing.Size(130, 35);
            this.btnDodajVaspitača.TabIndex = 10;
            this.btnDodajVaspitača.Text = "DodajVaspitača";
            this.btnDodajVaspitača.UseVisualStyleBackColor = false;
            this.btnDodajVaspitača.Click += new System.EventHandler(this.btnDodajVaspitača_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.Location = new System.Drawing.Point(23, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 148);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(625, 292);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(137, 20);
            this.txtPretraga.TabIndex = 13;
            this.txtPretraga.Text = "Unesite program";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretraga.Enter += new System.EventHandler(this.txtPretraga_Enter);
            this.txtPretraga.Leave += new System.EventHandler(this.txtPretraga_Leave);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.LightCoral;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(784, 292);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(108, 21);
            this.btnPretrazi.TabIndex = 14;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnIzmeniVaspitača
            // 
            this.btnIzmeniVaspitača.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniVaspitača.BackColor = System.Drawing.Color.LightCoral;
            this.btnIzmeniVaspitača.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniVaspitača.ForeColor = System.Drawing.Color.Black;
            this.btnIzmeniVaspitača.Location = new System.Drawing.Point(375, 233);
            this.btnIzmeniVaspitača.Name = "btnIzmeniVaspitača";
            this.btnIzmeniVaspitača.Size = new System.Drawing.Size(130, 35);
            this.btnIzmeniVaspitača.TabIndex = 15;
            this.btnIzmeniVaspitača.Text = "IzmeniVaspitača";
            this.btnIzmeniVaspitača.UseVisualStyleBackColor = false;
            this.btnIzmeniVaspitača.Click += new System.EventHandler(this.btnIzmeniVaspitača_Click);
            // 
            // btnPrikaziDetljnije
            // 
            this.btnPrikaziDetljnije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetljnije.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrikaziDetljnije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDetljnije.Location = new System.Drawing.Point(784, 333);
            this.btnPrikaziDetljnije.Name = "btnPrikaziDetljnije";
            this.btnPrikaziDetljnije.Size = new System.Drawing.Size(108, 21);
            this.btnPrikaziDetljnije.TabIndex = 16;
            this.btnPrikaziDetljnije.Text = "PrikažiDetaljnije";
            this.btnPrikaziDetljnije.UseVisualStyleBackColor = false;
            this.btnPrikaziDetljnije.Click += new System.EventHandler(this.btnPrikaziDetljnije_Click);
            // 
            // btnobrisivaspitaca
            // 
            this.btnobrisivaspitaca.BackColor = System.Drawing.Color.LightCoral;
            this.btnobrisivaspitaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnobrisivaspitaca.Location = new System.Drawing.Point(567, 233);
            this.btnobrisivaspitaca.Name = "btnobrisivaspitaca";
            this.btnobrisivaspitaca.Size = new System.Drawing.Size(119, 35);
            this.btnobrisivaspitaca.TabIndex = 17;
            this.btnobrisivaspitaca.Text = "ObrisiVaspitaca";
            this.btnobrisivaspitaca.UseVisualStyleBackColor = false;
            this.btnobrisivaspitaca.Click += new System.EventHandler(this.btnobrisivaspitaca_Click);
            // 
            // FormaVaspitač
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(931, 452);
            this.Controls.Add(this.btnobrisivaspitaca);
            this.Controls.Add(this.btnPrikaziDetljnije);
            this.Controls.Add(this.btnIzmeniVaspitača);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodajVaspitača);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaVaspitač";
            this.Text = "FormaVaspitač";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Button btnDodajVaspitača;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnIzmeniVaspitača;
        private System.Windows.Forms.Button btnPrikaziDetljnije;
        private Button btnobrisivaspitaca;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtKontakt { get => txtKontakt; set => txtKontakt = value; }
        public TextBox TxtPol { get => txtPol; set => txtPol = value; }
        public ComboBox CbProgram { get => cbProgram; set => cbProgram = value; }
        public Button BtnDodajVaspitača { get => btnDodajVaspitača; set => btnDodajVaspitača = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Button BtnIzmeniVaspitača { get => btnIzmeniVaspitača; set => btnIzmeniVaspitača = value; }
        public Button BtnPrikaziDetljnije { get => btnPrikaziDetljnije; set => btnPrikaziDetljnije = value; }
    }
}