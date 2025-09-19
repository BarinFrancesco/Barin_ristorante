namespace Gestione_Ordini
{
    partial class Ristorante_da_Barin
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Menù = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Ordina = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Menù
            // 
            this.lbl_Menù.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menù.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lbl_Menù.Location = new System.Drawing.Point(3, 53);
            this.lbl_Menù.Name = "lbl_Menù";
            this.lbl_Menù.Size = new System.Drawing.Size(283, 254);
            this.lbl_Menù.TabIndex = 0;
            this.lbl_Menù.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menù";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lbl_Menù);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(491, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 317);
            this.panel1.TabIndex = 2;
            // 
            // btn_Ordina
            // 
            this.btn_Ordina.Location = new System.Drawing.Point(287, 142);
            this.btn_Ordina.Name = "btn_Ordina";
            this.btn_Ordina.Size = new System.Drawing.Size(94, 88);
            this.btn_Ordina.TabIndex = 3;
            this.btn_Ordina.Text = "button1";
            this.btn_Ordina.UseVisualStyleBackColor = true;
            this.btn_Ordina.Click += new System.EventHandler(this.btn_Ordina_Click);
            // 
            // Ristorante_da_Barin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ordina);
            this.Controls.Add(this.panel1);
            this.Name = "Ristorante_da_Barin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ristorante_da_Barin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menù;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ordina;
    }
}

