namespace Gestione_Ordini
{
    partial class FormOrdini
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
            this.cmb_SelezionePiatti = new System.Windows.Forms.ComboBox();
            this.btn_Order = new System.Windows.Forms.Button();
            this.lbl_Dish = new System.Windows.Forms.Label();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.sel_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sel_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_SelezionePiatti
            // 
            this.cmb_SelezionePiatti.BackColor = System.Drawing.Color.Silver;
            this.cmb_SelezionePiatti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelezionePiatti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.cmb_SelezionePiatti.FormattingEnabled = true;
            this.cmb_SelezionePiatti.Location = new System.Drawing.Point(145, 130);
            this.cmb_SelezionePiatti.Name = "cmb_SelezionePiatti";
            this.cmb_SelezionePiatti.Size = new System.Drawing.Size(227, 21);
            this.cmb_SelezionePiatti.TabIndex = 0;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.btn_Order.Location = new System.Drawing.Point(177, 298);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(107, 41);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "ORDINA";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // lbl_Dish
            // 
            this.lbl_Dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dish.Location = new System.Drawing.Point(142, 112);
            this.lbl_Dish.Name = "lbl_Dish";
            this.lbl_Dish.Size = new System.Drawing.Size(263, 15);
            this.lbl_Dish.TabIndex = 3;
            this.lbl_Dish.Text = "Piatto:";
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(142, 46);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(263, 15);
            this.lbl_Customer.TabIndex = 5;
            this.lbl_Customer.Text = "Nome Cliente:";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(145, 64);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(227, 20);
            this.txt_Customer.TabIndex = 6;
            this.txt_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Customer_KeyPress);
            // 
            // sel_Quantity
            // 
            this.sel_Quantity.Location = new System.Drawing.Point(145, 190);
            this.sel_Quantity.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sel_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sel_Quantity.Name = "sel_Quantity";
            this.sel_Quantity.Size = new System.Drawing.Size(38, 20);
            this.sel_Quantity.TabIndex = 7;
            this.sel_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(142, 172);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(263, 15);
            this.lbl_Quantity.TabIndex = 8;
            this.lbl_Quantity.Text = "Quantità:";
            // 
            // FormOrdini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(196)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.sel_Quantity);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.lbl_Customer);
            this.Controls.Add(this.lbl_Dish);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.cmb_SelezionePiatti);
            this.Name = "FormOrdini";
            this.Text = "FromOrdini";
            this.Load += new System.EventHandler(this.FromOrdini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sel_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_SelezionePiatti;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label lbl_Dish;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.NumericUpDown sel_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
    }
}