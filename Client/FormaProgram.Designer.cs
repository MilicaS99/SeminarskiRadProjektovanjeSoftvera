
using System.Windows.Forms;

namespace Client
{
    partial class FormaProgram
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretražiProgram = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodajProgram = new System.Windows.Forms.Button();
            this.btnPrikaziProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.SlateBlue;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(21, 43);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.BackColor = System.Drawing.Color.SlateBlue;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(21, 85);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(36, 13);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Opis:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(24, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 67;
            this.dataGridView1.Size = new System.Drawing.Size(344, 194);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKriterijum.BackColor = System.Drawing.Color.Thistle;
            this.txtKriterijum.Location = new System.Drawing.Point(451, 269);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(178, 20);
            this.txtKriterijum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pretraga:";
            // 
            // btnPretražiProgram
            // 
            this.btnPretražiProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretražiProgram.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPretražiProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretražiProgram.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPretražiProgram.Location = new System.Drawing.Point(489, 295);
            this.btnPretražiProgram.Name = "btnPretražiProgram";
            this.btnPretražiProgram.Size = new System.Drawing.Size(104, 30);
            this.btnPretražiProgram.TabIndex = 10;
            this.btnPretražiProgram.Text = "PretražiProgram";
            this.btnPretražiProgram.UseVisualStyleBackColor = false;
            this.btnPretražiProgram.Click += new System.EventHandler(this.btnPretražiProgram_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.Thistle;
            this.txtNaziv.Location = new System.Drawing.Point(121, 40);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.BackColor = System.Drawing.Color.Thistle;
            this.richTextBoxOpis.Location = new System.Drawing.Point(121, 82);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(215, 121);
            this.richTextBoxOpis.TabIndex = 12;
            this.richTextBoxOpis.Text = "";
            // 
            // btnDodajProgram
            // 
            this.btnDodajProgram.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDodajProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProgram.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDodajProgram.Location = new System.Drawing.Point(174, 220);
            this.btnDodajProgram.Name = "btnDodajProgram";
            this.btnDodajProgram.Size = new System.Drawing.Size(122, 29);
            this.btnDodajProgram.TabIndex = 13;
            this.btnDodajProgram.Text = "DodajProgram";
            this.btnDodajProgram.UseVisualStyleBackColor = false;
            this.btnDodajProgram.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrikaziProgram
            // 
            this.btnPrikaziProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziProgram.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPrikaziProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziProgram.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrikaziProgram.Location = new System.Drawing.Point(489, 344);
            this.btnPrikaziProgram.Name = "btnPrikaziProgram";
            this.btnPrikaziProgram.Size = new System.Drawing.Size(104, 30);
            this.btnPrikaziProgram.TabIndex = 14;
            this.btnPrikaziProgram.Text = "PrikažiProgram";
            this.btnPrikaziProgram.UseVisualStyleBackColor = false;
            this.btnPrikaziProgram.Click += new System.EventHandler(this.btnPrikaziProgram_Click);
            // 
            // FormaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(641, 478);
            this.Controls.Add(this.btnPrikaziProgram);
            this.Controls.Add(this.btnDodajProgram);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPretražiProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FormaProgram";
            this.Text = "FormaProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretražiProgram;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.Button btnDodajProgram;
        private Button btnPrikaziProgram;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnPretražiProgram { get => btnPretražiProgram; set => btnPretražiProgram = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public RichTextBox RichTextBoxOpis { get => richTextBoxOpis; set => richTextBoxOpis = value; }
        public Button BtnDodajProgram { get => btnDodajProgram; set => btnDodajProgram = value; }
    }
}