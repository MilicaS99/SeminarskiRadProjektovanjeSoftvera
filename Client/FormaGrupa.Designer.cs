
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
            this.Naziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDatumDO = new System.Windows.Forms.TextBox();
            this.txtDatumOD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbUčenik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVaspitač = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbUzrast = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZapamtiNovuGrupu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrai = new System.Windows.Forms.Button();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtDatumDO);
            this.groupBox1.Controls.Add(this.txtDatumOD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbUčenik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbVaspitač);
            this.groupBox1.Controls.Add(this.cbProgram);
            this.groupBox1.Controls.Add(this.cbUzrast);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.Naziv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DodavanjeGrupe";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "DodajUčenika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDatumDO
            // 
            this.txtDatumDO.Location = new System.Drawing.Point(136, 252);
            this.txtDatumDO.Name = "txtDatumDO";
            this.txtDatumDO.Size = new System.Drawing.Size(208, 22);
            this.txtDatumDO.TabIndex = 15;
            // 
            // txtDatumOD
            // 
            this.txtDatumOD.Location = new System.Drawing.Point(137, 204);
            this.txtDatumOD.Name = "txtDatumOD";
            this.txtDatumOD.Size = new System.Drawing.Size(208, 22);
            this.txtDatumOD.TabIndex = 14;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "ZapamtiGrupu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUčenik
            // 
            this.cbUčenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUčenik.FormattingEnabled = true;
            this.cbUčenik.Location = new System.Drawing.Point(137, 167);
            this.cbUčenik.Name = "cbUčenik";
            this.cbUčenik.Size = new System.Drawing.Size(207, 21);
            this.cbUčenik.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Učenik:";
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
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(137, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(207, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 151);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnZapamtiNovuGrupu
            // 
            this.btnZapamtiNovuGrupu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZapamtiNovuGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiNovuGrupu.Location = new System.Drawing.Point(801, 190);
            this.btnZapamtiNovuGrupu.Name = "btnZapamtiNovuGrupu";
            this.btnZapamtiNovuGrupu.Size = new System.Drawing.Size(129, 25);
            this.btnZapamtiNovuGrupu.TabIndex = 9;
            this.btnZapamtiNovuGrupu.Text = "ZapamtiNovuGrupu";
            this.btnZapamtiNovuGrupu.UseVisualStyleBackColor = false;
            this.btnZapamtiNovuGrupu.Click += new System.EventHandler(this.btnZapamtiNovuGrupu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPretraga.Location = new System.Drawing.Point(622, 309);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(183, 20);
            this.txtPretraga.TabIndex = 11;
            // 
            // btnPretrai
            // 
            this.btnPretrai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPretrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrai.Location = new System.Drawing.Point(830, 308);
            this.btnPretrai.Name = "btnPretrai";
            this.btnPretrai.Size = new System.Drawing.Size(100, 20);
            this.btnPretrai.TabIndex = 12;
            this.btnPretrai.Text = "Pretraži";
            this.btnPretrai.UseVisualStyleBackColor = false;
            this.btnPretrai.Click += new System.EventHandler(this.btnPretrai_Click);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(830, 341);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(99, 22);
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
            this.ClientSize = new System.Drawing.Size(967, 529);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnPretrai);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapamtiNovuGrupu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormaGrupa";
            this.Text = "FormaGrupa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZapamtiNovuGrupu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrai;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private ComboBox cbUčenik;
        private Label label5;
        private Button button1;
        private TextBox txtDatumOD;
        private Label label7;
        private Label label6;
        private Button button2;
        private TextBox txtDatumDO;

        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Naziv1 { get => Naziv; set => Naziv = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        
        public ComboBox CbVaspitač { get => cbVaspitač; set => cbVaspitač = value; }
        public ComboBox CbProgram { get => cbProgram; set => cbProgram = value; }
        public ComboBox CbUzrast { get => cbUzrast; set => cbUzrast = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Button BtnZapamtiNovuGrupu { get => btnZapamtiNovuGrupu; set => btnZapamtiNovuGrupu = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Button BtnPretrai { get => btnPretrai; set => btnPretrai = value; }
        public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
    }
}