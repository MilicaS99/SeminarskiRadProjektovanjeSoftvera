
using System.Windows.Forms;

namespace Client
{
    partial class FormaGrupa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGrupa));
            this.Naziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiUcenika = new System.Windows.Forms.Button();
            this.dgvDodatiUcenici = new System.Windows.Forms.DataGridView();
            this.btnDodajUcenika = new System.Windows.Forms.Button();
            this.txtDatumDO = new System.Windows.Forms.TextBox();
            this.txtDatumOD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapamtiNovuGrupu = new System.Windows.Forms.Button();
            this.cbUčenik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZapamtiGrupu = new System.Windows.Forms.Button();
            this.cbVaspitač = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbUzrast = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatiUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv.Location = new System.Drawing.Point(24, 30);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(43, 13);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzrast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Program:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vaspitač:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.btnObrisiUcenika);
            this.groupBox1.Controls.Add(this.dgvDodatiUcenici);
            this.groupBox1.Controls.Add(this.btnDodajUcenika);
            this.groupBox1.Controls.Add(this.txtDatumDO);
            this.groupBox1.Controls.Add(this.txtDatumOD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnZapamtiNovuGrupu);
            this.groupBox1.Controls.Add(this.cbUčenik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnZapamtiGrupu);
            this.groupBox1.Controls.Add(this.cbVaspitač);
            this.groupBox1.Controls.Add(this.cbProgram);
            this.groupBox1.Controls.Add(this.cbUzrast);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.Naziv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 573);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DodavanjeGrupe";
            // 
            // btnObrisiUcenika
            // 
            this.btnObrisiUcenika.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiUcenika.Location = new System.Drawing.Point(291, 290);
            this.btnObrisiUcenika.Name = "btnObrisiUcenika";
            this.btnObrisiUcenika.Size = new System.Drawing.Size(99, 23);
            this.btnObrisiUcenika.TabIndex = 13;
            this.btnObrisiUcenika.Text = "IzbrisiUčenika";
            this.btnObrisiUcenika.UseVisualStyleBackColor = false;
            this.btnObrisiUcenika.Click += new System.EventHandler(this.btnObrisiUcenika_Click);
            // 
            // dgvDodatiUcenici
            // 
            this.dgvDodatiUcenici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDodatiUcenici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDodatiUcenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDodatiUcenici.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDodatiUcenici.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDodatiUcenici.Location = new System.Drawing.Point(78, 332);
            this.dgvDodatiUcenici.Name = "dgvDodatiUcenici";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDodatiUcenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDodatiUcenici.RowHeadersWidth = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDodatiUcenici.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDodatiUcenici.Size = new System.Drawing.Size(312, 170);
            this.dgvDodatiUcenici.TabIndex = 15;
            // 
            // btnDodajUcenika
            // 
            this.btnDodajUcenika.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUcenika.Location = new System.Drawing.Point(188, 290);
            this.btnDodajUcenika.Name = "btnDodajUcenika";
            this.btnDodajUcenika.Size = new System.Drawing.Size(97, 23);
            this.btnDodajUcenika.TabIndex = 16;
            this.btnDodajUcenika.Text = "DodajUčenika";
            this.btnDodajUcenika.UseVisualStyleBackColor = false;
            this.btnDodajUcenika.Click += new System.EventHandler(this.btnDodajUcenika_Click);
            // 
            // txtDatumDO
            // 
            this.txtDatumDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumDO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDatumDO.Location = new System.Drawing.Point(138, 252);
            this.txtDatumDO.Name = "txtDatumDO";
            this.txtDatumDO.Size = new System.Drawing.Size(208, 21);
            this.txtDatumDO.TabIndex = 15;
            this.txtDatumDO.Text = "dd.MM.yyyy.";
            this.txtDatumDO.Enter += new System.EventHandler(this.txtDatumDO_Enter);
            this.txtDatumDO.Leave += new System.EventHandler(this.txtDatumDO_Leave);
            // 
            // txtDatumOD
            // 
            this.txtDatumOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumOD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDatumOD.Location = new System.Drawing.Point(137, 204);
            this.txtDatumOD.Name = "txtDatumOD";
            this.txtDatumOD.Size = new System.Drawing.Size(208, 21);
            this.txtDatumOD.TabIndex = 14;
            this.txtDatumOD.Text = "dd.MM.yyyy.";
            this.txtDatumOD.Enter += new System.EventHandler(this.txtDatumOD_Enter);
            this.txtDatumOD.Leave += new System.EventHandler(this.txtDatumOD_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "DatumDo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DatumOd:";
            // 
            // btnZapamtiNovuGrupu
            // 
            this.btnZapamtiNovuGrupu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZapamtiNovuGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiNovuGrupu.Location = new System.Drawing.Point(291, 521);
            this.btnZapamtiNovuGrupu.Name = "btnZapamtiNovuGrupu";
            this.btnZapamtiNovuGrupu.Size = new System.Drawing.Size(134, 25);
            this.btnZapamtiNovuGrupu.TabIndex = 9;
            this.btnZapamtiNovuGrupu.Text = "ZapamtiNovuGrupu";
            this.btnZapamtiNovuGrupu.UseVisualStyleBackColor = false;
            this.btnZapamtiNovuGrupu.Click += new System.EventHandler(this.btnZapamtiNovuGrupu_Click);
            // 
            // cbUčenik
            // 
            this.cbUčenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUčenik.FormattingEnabled = true;
            this.cbUčenik.Location = new System.Drawing.Point(137, 167);
            this.cbUčenik.Name = "cbUčenik";
            this.cbUčenik.Size = new System.Drawing.Size(207, 21);
            this.cbUčenik.TabIndex = 10;
            this.cbUčenik.SelectedValueChanged += new System.EventHandler(this.cbUčenik_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Učenik:";
            // 
            // btnZapamtiGrupu
            // 
            this.btnZapamtiGrupu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZapamtiGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiGrupu.Location = new System.Drawing.Point(126, 521);
            this.btnZapamtiGrupu.Name = "btnZapamtiGrupu";
            this.btnZapamtiGrupu.Size = new System.Drawing.Size(159, 25);
            this.btnZapamtiGrupu.TabIndex = 11;
            this.btnZapamtiGrupu.Text = "ZapamtiGrupu";
            this.btnZapamtiGrupu.UseVisualStyleBackColor = false;
            this.btnZapamtiGrupu.Click += new System.EventHandler(this.btnZapamtiGrupu_Click);
            // 
            // cbVaspitač
            // 
            this.cbVaspitač.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbVaspitač.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaspitač.FormattingEnabled = true;
            this.cbVaspitač.Location = new System.Drawing.Point(136, 120);
            this.cbVaspitač.Name = "cbVaspitač";
            this.cbVaspitač.Size = new System.Drawing.Size(208, 21);
            this.cbVaspitač.TabIndex = 7;
            // 
            // cbProgram
            // 
            this.cbProgram.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(136, 87);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(208, 21);
            this.cbProgram.TabIndex = 6;
            this.cbProgram.SelectedValueChanged += new System.EventHandler(this.cbProgram_SelectedValueChanged);
            // 
            // cbUzrast
            // 
            this.cbUzrast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUzrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUzrast.FormattingEnabled = true;
            this.cbUzrast.Location = new System.Drawing.Point(136, 53);
            this.cbUzrast.Name = "cbUzrast";
            this.cbUzrast.Size = new System.Drawing.Size(208, 21);
            this.cbUzrast.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNaziv.Location = new System.Drawing.Point(137, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(207, 21);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Text = "Naziv grupe";
            this.txtNaziv.Enter += new System.EventHandler(this.txtNaziv_Enter);
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(609, 12);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.Size = new System.Drawing.Size(438, 241);
            this.dgvGrupe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPretraga.Location = new System.Drawing.Point(830, 343);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(183, 21);
            this.txtPretraga.TabIndex = 11;
            this.txtPretraga.Text = "Naziv grupe";
            this.txtPretraga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPretraga_MouseClick);
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            this.txtPretraga.Enter += new System.EventHandler(this.txtPretraga_Enter);
            this.txtPretraga.Leave += new System.EventHandler(this.txtPretraga_Leave);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(1053, 110);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(99, 43);
            this.btnPrikaziDetalje.TabIndex = 13;
            this.btnPrikaziDetalje.Text = "PrikažiDetalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = false;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // FormaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1321, 638);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGrupe);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormaGrupa";
            this.Text = "FormaGrupa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatiUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVaspitač;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.ComboBox cbUzrast;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.Button btnZapamtiNovuGrupu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private ComboBox cbUčenik;
        private Label label5;
        private Button btnZapamtiGrupu;
        private TextBox txtDatumOD;
        private Label label7;
        private Label label6;
        private Button btnDodajUcenika;
        private TextBox txtDatumDO;
        private Button btnObrisiUcenika;
        private DataGridView dgvDodatiUcenici;

        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Naziv1 { get => Naziv; set => Naziv = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public ComboBox CbVaspitač { get => cbVaspitač; set => cbVaspitač = value; }
        public ComboBox CbProgram { get => cbProgram; set => cbProgram = value; }
        public ComboBox CbUzrast { get => cbUzrast; set => cbUzrast = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public DataGridView DgvGrupe { get => dgvGrupe; set => dgvGrupe = value; }
        public Button BtnZapamtiNovuGrupu { get => btnZapamtiNovuGrupu; set => btnZapamtiNovuGrupu = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
       // public Button BtnPretrai { get => btnPretrai; set => btnPretrai = value; }
        public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
        public ComboBox CbUčenik { get => cbUčenik; set => cbUčenik = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnZapamtiGrupu { get => btnZapamtiGrupu; set => btnZapamtiGrupu = value; }
        public TextBox TxtDatumOD { get => txtDatumOD; set => txtDatumOD = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnDodajUcenika { get => btnDodajUcenika; set => btnDodajUcenika = value; }
        public TextBox TxtDatumDO { get => txtDatumDO; set => txtDatumDO = value; }
        public Button BtnObrisiUcenika { get => btnObrisiUcenika; set => btnObrisiUcenika = value; }
        
        public DataGridView DgvDodatiUcenici { get => dgvDodatiUcenici; set => dgvDodatiUcenici = value; }
    }
}