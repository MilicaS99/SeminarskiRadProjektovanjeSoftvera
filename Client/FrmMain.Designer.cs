
namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnVaspitac = new System.Windows.Forms.Button();
            this.btnGrupa = new System.Windows.Forms.Button();
            this.btnUčenik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgram
            // 
            this.btnProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgram.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProgram.Location = new System.Drawing.Point(624, 2);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(160, 54);
            this.btnProgram.TabIndex = 0;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnVaspitac
            // 
            this.btnVaspitac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaspitac.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVaspitac.Location = new System.Drawing.Point(444, 3);
            this.btnVaspitac.Name = "btnVaspitac";
            this.btnVaspitac.Size = new System.Drawing.Size(160, 53);
            this.btnVaspitac.TabIndex = 1;
            this.btnVaspitac.Text = "Vaspitač";
            this.btnVaspitac.UseVisualStyleBackColor = true;
            this.btnVaspitac.Click += new System.EventHandler(this.btnVaspitac_Click);
            // 
            // btnGrupa
            // 
            this.btnGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGrupa.Location = new System.Drawing.Point(624, 60);
            this.btnGrupa.Name = "btnGrupa";
            this.btnGrupa.Size = new System.Drawing.Size(160, 48);
            this.btnGrupa.TabIndex = 2;
            this.btnGrupa.Text = "Grupa";
            this.btnGrupa.UseVisualStyleBackColor = true;
            this.btnGrupa.Click += new System.EventHandler(this.btnGrupa_Click);
            // 
            // btnUčenik
            // 
            this.btnUčenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUčenik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUčenik.Location = new System.Drawing.Point(444, 60);
            this.btnUčenik.Name = "btnUčenik";
            this.btnUčenik.Size = new System.Drawing.Size(160, 48);
            this.btnUčenik.TabIndex = 3;
            this.btnUčenik.Text = "Učenik";
            this.btnUčenik.UseVisualStyleBackColor = true;
            this.btnUčenik.Click += new System.EventHandler(this.btnUčenik_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.btnUčenik);
            this.Controls.Add(this.btnGrupa);
            this.Controls.Add(this.btnVaspitac);
            this.Controls.Add(this.btnProgram);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "FrmMain";
            this.Text = "Vrtic Kreativno Pero";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnVaspitac;
        private System.Windows.Forms.Button btnGrupa;
        private System.Windows.Forms.Button btnUčenik;
    }
}