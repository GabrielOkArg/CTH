namespace CTH
{
    partial class frm_misSolicitudes
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
            this.dgv_misSolicitudes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_misSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_misSolicitudes
            // 
            this.dgv_misSolicitudes.AllowUserToAddRows = false;
            this.dgv_misSolicitudes.AllowUserToDeleteRows = false;
            this.dgv_misSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_misSolicitudes.Location = new System.Drawing.Point(12, 243);
            this.dgv_misSolicitudes.Name = "dgv_misSolicitudes";
            this.dgv_misSolicitudes.ReadOnly = true;
            this.dgv_misSolicitudes.Size = new System.Drawing.Size(869, 195);
            this.dgv_misSolicitudes.TabIndex = 0;
            // 
            // frm_misSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.dgv_misSolicitudes);
            this.Name = "frm_misSolicitudes";
            this.Text = "frm_misSolicitudes";
            this.Load += new System.EventHandler(this.frm_misSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_misSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_misSolicitudes;
    }
}