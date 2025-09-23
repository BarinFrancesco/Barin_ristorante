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
            this.lst_Orders = new System.Windows.Forms.ListBox();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Oldorders = new System.Windows.Forms.Button();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.lbl_typeoforder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Menù
            // 
            this.lbl_Menù.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menù.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lbl_Menù.Location = new System.Drawing.Point(4, 1);
            this.lbl_Menù.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Menù.Name = "lbl_Menù";
            this.lbl_Menù.Size = new System.Drawing.Size(377, 373);
            this.lbl_Menù.TabIndex = 0;
            this.lbl_Menù.Text = "Trattoria da Marco:";
            this.lbl_Menù.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(677, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menù";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lbl_Menù);
            this.panel1.Location = new System.Drawing.Point(669, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 380);
            this.panel1.TabIndex = 2;
            // 
            // btn_Ordina
            // 
            this.btn_Ordina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_Ordina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordina.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Ordina.Location = new System.Drawing.Point(669, 419);
            this.btn_Ordina.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ordina.Name = "btn_Ordina";
            this.btn_Ordina.Size = new System.Drawing.Size(385, 39);
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
            this.lst_Orders.ItemHeight = 20;
            this.lst_Orders.Location = new System.Drawing.Point(-2, 42);
            this.lst_Orders.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Orders.Name = "lst_Orders";
            this.lst_Orders.Size = new System.Drawing.Size(397, 400);
            this.lst_Orders.TabIndex = 4;
            // 
            // btn_Total
            // 
            this.btn_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Total.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Total.Location = new System.Drawing.Point(403, 41);
            this.btn_Total.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(135, 39);
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
            this.btn_Oldorders.Location = new System.Drawing.Point(403, 100);
            this.btn_Oldorders.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Oldorders.Name = "btn_Oldorders";
            this.btn_Oldorders.Size = new System.Drawing.Size(135, 71);
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
            this.btn_newOrder.Location = new System.Drawing.Point(403, 195);
            this.btn_newOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(135, 71);
            this.btn_newOrder.TabIndex = 7;
            this.btn_newOrder.Text = "mostra ordini odierni";
            this.btn_newOrder.UseVisualStyleBackColor = false;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // lbl_typeoforder
            // 
            this.lbl_typeoforder.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeoforder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lbl_typeoforder.Location = new System.Drawing.Point(-1, 0);
            this.lbl_typeoforder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_typeoforder.Name = "lbl_typeoforder";
            this.lbl_typeoforder.Size = new System.Drawing.Size(377, 38);
            this.lbl_typeoforder.TabIndex = 2;
            this.lbl_typeoforder.Text = "Ordini ";
            this.lbl_typeoforder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ristorante_da_Barin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1051, 458);
            this.Controls.Add(this.lbl_typeoforder);
            this.Controls.Add(this.btn_Ordina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newOrder);
            this.Controls.Add(this.btn_Oldorders);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.lst_Orders);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ristorante_da_Barin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ristorante_da_Barin_FormClosing);
            this.Load += new System.EventHandler(this.Ristorante_da_Barin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menù;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ordina;
        private System.Windows.Forms.ListBox lst_Orders;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Oldorders;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Label lbl_typeoforder;
    }
}

