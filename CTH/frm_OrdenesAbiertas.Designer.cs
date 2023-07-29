namespace CTH
{
    partial class frm_OrdenesAbiertas
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
            this.dgv_ordenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ordenes
            // 
            this.dgv_ordenes.AllowUserToAddRows = false;
            this.dgv_ordenes.AllowUserToDeleteRows = false;
            this.dgv_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenes.Location = new System.Drawing.Point(13, 33);
            this.dgv_ordenes.Name = "dgv_ordenes";
            this.dgv_ordenes.ReadOnly = true;
            this.dgv_ordenes.Size = new System.Drawing.Size(763, 313);
            this.dgv_ordenes.TabIndex = 0;
            // 
            // frm_OrdenesAbiertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ordenes);
            this.Name = "frm_OrdenesAbiertas";
            this.Text = "Ordenes Abiertas";
            this.Load += new System.EventHandler(this.frm_OrdenesAbiertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ordenes;
    }
}