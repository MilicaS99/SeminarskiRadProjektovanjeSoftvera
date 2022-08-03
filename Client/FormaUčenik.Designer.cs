
using System.Windows.Forms;

namespace Client
{
    partial class FormaUčenik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.txtKontaktRoditelja = new System.Windows.Forms.TextBox();
            this.btnSacuvajUcenika = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DodavanjeUčenika = new System.Windows.Forms.GroupBox();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DodavanjeUčenika.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DatumRodjenja:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pol:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KontaktRoditelja:";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIme.Location = new System.Drawing.Point(209, 13);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 20);
            this.txtIme.TabIndex = 5;
            this.txtIme.Text = "Ime";
            this.txtIme.Enter += new System.EventHandler(this.txtIme_Enter);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrezime.Location = new System.Drawing.Point(209, 53);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(178, 20);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Text = "Prezime";
            this.txtPrezime.Enter += new System.EventHandler(this.txtPrezime_Enter);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumRodjenja.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumRodjenja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(209, 101);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(178, 20);
            this.txtDatumRodjenja.TabIndex = 7;
            this.txtDatumRodjenja.Text = "dd.MM.yyyy. HH:mm";
            this.txtDatumRodjenja.Enter += new System.EventHandler(this.txtDatumRodjenja_Enter);
            this.txtDatumRodjenja.Leave += new System.EventHandler(this.txtDatumRodjenja_Leave);
            // 
            // txtPol
            // 
            this.txtPol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPol.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPol.Location = new System.Drawing.Point(209, 145);
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(178, 20);
            this.txtPol.TabIndex = 8;
            this.txtPol.Text = "Pol";
            this.txtPol.Enter += new System.EventHandler(this.txtPol_Enter);
            this.txtPol.Leave += new System.EventHandler(this.txtPol_Leave);
            // 
            // txtKontaktRoditelja
            // 
            this.txtKontaktRoditelja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKontaktRoditelja.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtKontaktRoditelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontaktRoditelja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKontaktRoditelja.Location = new System.Drawing.Point(209, 193);
            this.txtKontaktRoditelja.Name = "txtKontaktRoditelja";
            this.txtKontaktRoditelja.Size = new System.Drawing.Size(178, 20);
            this.txtKontaktRoditelja.TabIndex = 9;
            this.txtKontaktRoditelja.Text = "KontaktRoditelja";
            this.txtKontaktRoditelja.Enter += new System.EventHandler(this.txtKontaktRoditelja_Enter);
            this.txtKontaktRoditelja.Leave += new System.EventHandler(this.txtKontaktRoditelja_Leave);
            // 
            // btnSacuvajUcenika
            // 
            this.btnSacuvajUcenika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajUcenika.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSacuvajUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajUcenika.Location = new System.Drawing.Point(249, 234);
            this.btnSacuvajUcenika.Name = "btnSacuvajUcenika";
            this.btnSacuvajUcenika.Size = new System.Drawing.Size(103, 37);
            this.btnSacuvajUcenika.TabIndex = 10;
            this.btnSacuvajUcenika.Text = "DodajUčenika";
            this.btnSacuvajUcenika.UseVisualStyleBackColor = false;
            this.btnSacuvajUcenika.Click += new System.EventHandler(this.btnSacuvajUcenika_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "PretražiUčenika";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(768, 36);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(147, 20);
            this.txtPretraga.TabIndex = 12;
            this.txtPretraga.Text = "Ime ucenika";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 139);
            this.dataGridView1.TabIndex = 14;
            // 
            // DodavanjeUčenika
            // 
            this.DodavanjeUčenika.Controls.Add(this.btnSacuvajUcenika);
            this.DodavanjeUčenika.Controls.Add(this.txtKontaktRoditelja);
            this.DodavanjeUčenika.Controls.Add(this.txtPol);
            this.DodavanjeUčenika.Controls.Add(this.txtDatumRodjenja);
            this.DodavanjeUčenika.Controls.Add(this.txtPrezime);
            this.DodavanjeUčenika.Controls.Add(this.txtIme);
            this.DodavanjeUčenika.Controls.Add(this.label5);
            this.DodavanjeUčenika.Controls.Add(this.label4);
            this.DodavanjeUčenika.Controls.Add(this.label3);
            this.DodavanjeUčenika.Controls.Add(this.label2);
            this.DodavanjeUčenika.Controls.Add(this.label1);
            this.DodavanjeUčenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodavanjeUčenika.Location = new System.Drawing.Point(24, 23);
            this.DodavanjeUčenika.Name = "DodavanjeUčenika";
            this.DodavanjeUčenika.Size = new System.Drawing.Size(408, 290);
            this.DodavanjeUčenika.TabIndex = 15;
            this.DodavanjeUčenika.TabStop = false;
            this.DodavanjeUčenika.Text = "DodavanjeUčenika";
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(1003, 29);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(108, 33);
            this.btnPrikaziDetalje.TabIndex = 16;
            this.btnPrikaziDetalje.Text = "PrikažiDetalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = false;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormaUčenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1228, 331);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.DodavanjeUčenika);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label6);
            this.Name = "FormaUčenik";
            this.Text = "FormaUčenik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DodavanjeUčenika.ResumeLayout(false);
            this.DodavanjeUčenika.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.TextBox txtKontaktRoditelja;
        private System.Windows.Forms.Button btnSacuvajUcenika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox DodavanjeUčenika;
        private Button btnPrikaziDetalje;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtDatumRodjenja { get => txtDatumRodjenja; set => txtDatumRodjenja = value; }
        public TextBox TxtPol { get => txtPol; set => txtPol = value; }
        public TextBox TxtKontaktRoditelja { get => txtKontaktRoditelja; set => txtKontaktRoditelja = value; }
        public Button BtnSacuvajUcenika { get => btnSacuvajUcenika; set => btnSacuvajUcenika = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
   
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public GroupBox DodavanjeUčenika1 { get => DodavanjeUčenika; set => DodavanjeUčenika = value; }
    }
}