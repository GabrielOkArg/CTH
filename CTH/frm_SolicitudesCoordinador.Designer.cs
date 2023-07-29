namespace CTH
{
    partial class frm_SolicitudesCoordinador
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
            this.dgv_solicitudesCoordinador = new System.Windows.Forms.DataGridView();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitudesCoordinador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_solicitudesCoordinador
            // 
            this.dgv_solicitudesCoordinador.AllowUserToAddRows = false;
            this.dgv_solicitudesCoordinador.AllowUserToDeleteRows = false;
            this.dgv_solicitudesCoordinador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solicitudesCoordinador.Location = new System.Drawing.Point(12, 12);
            this.dgv_solicitudesCoordinador.Name = "dgv_solicitudesCoordinador";
            this.dgv_solicitudesCoordinador.ReadOnly = true;
            this.dgv_solicitudesCoordinador.Size = new System.Drawing.Size(1066, 356);
            this.dgv_solicitudesCoordinador.TabIndex = 0;
            this.dgv_solicitudesCoordinador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_solicitudesCoordinador_CellContentClick);
            this.dgv_solicitudesCoordinador.SelectionChanged += new System.EventHandler(this.selectedSolicitud);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(876, 523);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(202, 46);
            this.btn_Continuar.TabIndex = 1;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Location = new System.Drawing.Point(17, 383);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(40, 13);
            this.lbl_Detalle.TabIndex = 2;
            this.lbl_Detalle.Text = "Detalle";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Location = new System.Drawing.Point(20, 415);
            this.txt_Detalle.Multiline = true;
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.ReadOnly = true;
            this.txt_Detalle.Size = new System.Drawing.Size(744, 154);
            this.txt_Detalle.TabIndex = 3;
            // 
            // frm_SolicitudesCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 587);
            this.Controls.Add(this.txt_Detalle);
            this.Controls.Add(this.lbl_Detalle);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.dgv_solicitudesCoordinador);
            this.Name = "frm_SolicitudesCoordinador";
            this.Text = "frm_SolicitudesCoordinador";
            this.Load += new System.EventHandler(this.frm_SolicitudesCoordinador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitudesCoordinador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_solicitudesCoordinador;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.TextBox txt_Detalle;
    }
}