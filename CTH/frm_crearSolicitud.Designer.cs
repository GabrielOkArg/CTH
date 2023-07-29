namespace CTH
{
    partial class frm_crearSolicitud
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
            this.cmb_Edificios = new System.Windows.Forms.ComboBox();
            this.lbl_frmCrearSoli_Edificio = new System.Windows.Forms.Label();
            this.lbl_Sector = new System.Windows.Forms.Label();
            this.cmb_sectores = new System.Windows.Forms.ComboBox();
            this.lbl_Equipo = new System.Windows.Forms.Label();
            this.cmb_Equipos = new System.Windows.Forms.ComboBox();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Edificios
            // 
            this.cmb_Edificios.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Edificios.FormattingEnabled = true;
            this.cmb_Edificios.Location = new System.Drawing.Point(16, 47);
            this.cmb_Edificios.Name = "cmb_Edificios";
            this.cmb_Edificios.Size = new System.Drawing.Size(121, 28);
            this.cmb_Edificios.TabIndex = 0;
            this.cmb_Edificios.SelectedIndexChanged += new System.EventHandler(this.selectEdificio);
            // 
            // lbl_frmCrearSoli_Edificio
            // 
            this.lbl_frmCrearSoli_Edificio.AutoSize = true;
            this.lbl_frmCrearSoli_Edificio.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frmCrearSoli_Edificio.Location = new System.Drawing.Point(13, 24);
            this.lbl_frmCrearSoli_Edificio.Name = "lbl_frmCrearSoli_Edificio";
            this.lbl_frmCrearSoli_Edificio.Size = new System.Drawing.Size(53, 20);
            this.lbl_frmCrearSoli_Edificio.TabIndex = 1;
            this.lbl_frmCrearSoli_Edificio.Text = "Edificio";
            // 
            // lbl_Sector
            // 
            this.lbl_Sector.AutoSize = true;
            this.lbl_Sector.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sector.Location = new System.Drawing.Point(157, 24);
            this.lbl_Sector.Name = "lbl_Sector";
            this.lbl_Sector.Size = new System.Drawing.Size(51, 20);
            this.lbl_Sector.TabIndex = 5;
            this.lbl_Sector.Text = "Sector";
            // 
            // cmb_sectores
            // 
            this.cmb_sectores.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sectores.FormattingEnabled = true;
            this.cmb_sectores.Location = new System.Drawing.Point(161, 47);
            this.cmb_sectores.Name = "cmb_sectores";
            this.cmb_sectores.Size = new System.Drawing.Size(121, 28);
            this.cmb_sectores.TabIndex = 4;
            this.cmb_sectores.SelectedIndexChanged += new System.EventHandler(this.selectedSector);
            // 
            // lbl_Equipo
            // 
            this.lbl_Equipo.AutoSize = true;
            this.lbl_Equipo.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipo.Location = new System.Drawing.Point(14, 85);
            this.lbl_Equipo.Name = "lbl_Equipo";
            this.lbl_Equipo.Size = new System.Drawing.Size(52, 20);
            this.lbl_Equipo.TabIndex = 6;
            this.lbl_Equipo.Text = "Equipo";
            // 
            // cmb_Equipos
            // 
            this.cmb_Equipos.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Equipos.FormattingEnabled = true;
            this.cmb_Equipos.Location = new System.Drawing.Point(16, 108);
            this.cmb_Equipos.Name = "cmb_Equipos";
            this.cmb_Equipos.Size = new System.Drawing.Size(121, 28);
            this.cmb_Equipos.TabIndex = 7;
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalle.Location = new System.Drawing.Point(17, 148);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(52, 20);
            this.lbl_Detalle.TabIndex = 8;
            this.lbl_Detalle.Text = "Detalle";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Detalle.Location = new System.Drawing.Point(20, 180);
            this.txt_Detalle.Multiline = true;
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(449, 202);
            this.txt_Detalle.TabIndex = 9;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(331, 399);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(138, 39);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(161, 399);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(138, 39);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_crearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Detalle);
            this.Controls.Add(this.lbl_Detalle);
            this.Controls.Add(this.cmb_Equipos);
            this.Controls.Add(this.lbl_Equipo);
            this.Controls.Add(this.lbl_Sector);
            this.Controls.Add(this.cmb_sectores);
            this.Controls.Add(this.lbl_frmCrearSoli_Edificio);
            this.Controls.Add(this.cmb_Edificios);
            this.Name = "frm_crearSolicitud";
            this.Text = "Crear Solicitud";
            this.Load += new System.EventHandler(this.frm_crearSolicitud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Edificios;
        private System.Windows.Forms.Label lbl_frmCrearSoli_Edificio;
        private System.Windows.Forms.Label lbl_Sector;
        private System.Windows.Forms.ComboBox cmb_sectores;
        private System.Windows.Forms.Label lbl_Equipo;
        private System.Windows.Forms.ComboBox cmb_Equipos;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}