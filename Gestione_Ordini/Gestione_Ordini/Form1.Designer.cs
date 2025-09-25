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
            this.btn_Ordina = new System.Windows.Forms.Button();
            this.lst_Orders = new System.Windows.Forms.ListBox();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Oldorders = new System.Windows.Forms.Button();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.lbl_typeoforder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Menù
            // 
            this.lbl_Menù.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menù.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lbl_Menù.Location = new System.Drawing.Point(47, 103);
            this.lbl_Menù.Name = "lbl_Menù";
            this.lbl_Menù.Size = new System.Drawing.Size(289, 216);
            this.lbl_Menù.TabIndex = 0;
            this.lbl_Menù.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menù";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Ordina
            // 
            this.btn_Ordina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.btn_Ordina.FlatAppearance.BorderSize = 0;
            this.btn_Ordina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordina.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Ordina.Location = new System.Drawing.Point(47, 322);
            this.btn_Ordina.Name = "btn_Ordina";
            this.btn_Ordina.Size = new System.Drawing.Size(289, 32);
            this.btn_Ordina.TabIndex = 3;
            this.btn_Ordina.Text = "Ordina";
            this.btn_Ordina.UseVisualStyleBackColor = false;
            this.btn_Ordina.Click += new System.EventHandler(this.btn_Ordina_Click);
            // 
            // lst_Orders
            // 
            this.lst_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.lst_Orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Orders.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lst_Orders.FormattingEnabled = true;
            this.lst_Orders.ItemHeight = 17;
            this.lst_Orders.Location = new System.Drawing.Point(155, 44);
            this.lst_Orders.Name = "lst_Orders";
            this.lst_Orders.Size = new System.Drawing.Size(238, 272);
            this.lst_Orders.TabIndex = 4;
            this.lst_Orders.SelectedIndexChanged += new System.EventHandler(this.lst_Orders_SelectedIndexChanged);
            // 
            // btn_Total
            // 
            this.btn_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Total.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Total.Location = new System.Drawing.Point(32, 53);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(101, 32);
            this.btn_Total.TabIndex = 5;
            this.btn_Total.Text = "Conto";
            this.btn_Total.UseVisualStyleBackColor = false;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // btn_Oldorders
            // 
            this.btn_Oldorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_Oldorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Oldorders.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Oldorders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Oldorders.Location = new System.Drawing.Point(32, 228);
            this.btn_Oldorders.Name = "btn_Oldorders";
            this.btn_Oldorders.Size = new System.Drawing.Size(101, 58);
            this.btn_Oldorders.TabIndex = 6;
            this.btn_Oldorders.Text = "mostra ordini vecchi";
            this.btn_Oldorders.UseVisualStyleBackColor = false;
            this.btn_Oldorders.Click += new System.EventHandler(this.btn_Oldorders_Click);
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newOrder.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_newOrder.Location = new System.Drawing.Point(32, 128);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(101, 58);
            this.btn_newOrder.TabIndex = 7;
            this.btn_newOrder.Text = "mostra ordini odierni";
            this.btn_newOrder.UseVisualStyleBackColor = false;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // lbl_typeoforder
            // 
            this.lbl_typeoforder.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeoforder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lbl_typeoforder.Location = new System.Drawing.Point(155, 6);
            this.lbl_typeoforder.Name = "lbl_typeoforder";
            this.lbl_typeoforder.Size = new System.Drawing.Size(238, 30);
            this.lbl_typeoforder.TabIndex = 2;
            this.lbl_typeoforder.Text = "Ordini ";
            this.lbl_typeoforder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_typeoforder.Click += new System.EventHandler(this.lbl_typeoforder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(176)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.lst_Orders);
            this.panel2.Controls.Add(this.btn_newOrder);
            this.panel2.Controls.Add(this.lbl_typeoforder);
            this.panel2.Controls.Add(this.btn_Oldorders);
            this.panel2.Controls.Add(this.btn_Total);
            this.panel2.Location = new System.Drawing.Point(383, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 332);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 47);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trattoria da Marco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ristorante_da_Barin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(788, 372);
            this.Controls.Add(this.lbl_Menù);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Ordina);
            this.Controls.Add(this.label1);
            this.Name = "Ristorante_da_Barin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ristorante_da_Barin_FormClosing);
            this.Load += new System.EventHandler(this.Ristorante_da_Barin_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menù;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ordina;
        private System.Windows.Forms.ListBox lst_Orders;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Oldorders;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Label lbl_typeoforder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

