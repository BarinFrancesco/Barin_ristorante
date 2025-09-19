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
            this.Piatto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_SelezionePiatti
            // 
            this.cmb_SelezionePiatti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelezionePiatti.FormattingEnabled = true;
            this.cmb_SelezionePiatti.Location = new System.Drawing.Point(296, 88);
            this.cmb_SelezionePiatti.Name = "cmb_SelezionePiatti";
            this.cmb_SelezionePiatti.Size = new System.Drawing.Size(227, 21);
            this.cmb_SelezionePiatti.TabIndex = 0;
            // 
            // Piatto
            // 
            this.Piatto.Location = new System.Drawing.Point(293, 66);
            this.Piatto.Name = "Piatto";
            this.Piatto.Size = new System.Drawing.Size(100, 19);
            this.Piatto.TabIndex = 1;
            this.Piatto.Text = "label1";
            // 
            // FormOrdini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Piatto);
            this.Controls.Add(this.cmb_SelezionePiatti);
            this.Name = "FormOrdini";
            this.Text = "FromOrdini";
            this.Load += new System.EventHandler(this.FromOrdini_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_SelezionePiatti;
        private System.Windows.Forms.Label Piatto;
    }
}