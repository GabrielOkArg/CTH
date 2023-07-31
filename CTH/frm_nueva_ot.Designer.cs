namespace CTH
{
    partial class frm_nueva_ot
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
            this.grpb_datosDeLaSolicitud = new System.Windows.Forms.GroupBox();
            this.lbl_datoSolicitante = new System.Windows.Forms.Label();
            this.lbl_usuarioSolicitante = new System.Windows.Forms.Label();
            this.grpb_DetalleDeLaSolicitud = new System.Windows.Forms.GroupBox();
            this.txt_datoDetalle = new System.Windows.Forms.TextBox();
            this.lbl_datoFecha = new System.Windows.Forms.Label();
            this.lbl_fechasolicitud = new System.Windows.Forms.Label();
            this.lbl_datoequipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_datoSector = new System.Windows.Forms.Label();
            this.lbl_Sector = new System.Windows.Forms.Label();
            this.lbl_datoEdificio = new System.Windows.Forms.Label();
            this.lbl_Edificio = new System.Windows.Forms.Label();
            this.lbl_asignarTecnico = new System.Windows.Forms.Label();
            this.cb_asignartecnico = new System.Windows.Forms.ComboBox();
            this.lbl_detalleCoordinador = new System.Windows.Forms.Label();
            this.txt_detalletecnico = new System.Windows.Forms.TextBox();
            this.lbx_materialResultado = new System.Windows.Forms.ListBox();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxMaterialesAgregador = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grpb_datosDeLaSolicitud.SuspendLayout();
            this.grpb_DetalleDeLaSolicitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_datosDeLaSolicitud
            // 
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_datoSolicitante);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_usuarioSolicitante);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.grpb_DetalleDeLaSolicitud);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_datoFecha);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_fechasolicitud);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_datoequipo);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.label4);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_datoSector);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_Sector);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_datoEdificio);
            this.grpb_datosDeLaSolicitud.Controls.Add(this.lbl_Edificio);
            this.grpb_datosDeLaSolicitud.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_datosDeLaSolicitud.Location = new System.Drawing.Point(18, 30);
            this.grpb_datosDeLaSolicitud.Name = "grpb_datosDeLaSolicitud";
            this.grpb_datosDeLaSolicitud.Size = new System.Drawing.Size(1135, 236);
            this.grpb_datosDeLaSolicitud.TabIndex = 0;
            this.grpb_datosDeLaSolicitud.TabStop = false;
            this.grpb_datosDeLaSolicitud.Text = "Datos de la solicitud";
            this.grpb_datosDeLaSolicitud.Enter += new System.EventHandler(this.grpb_datosDeLaSolicitud_Enter);
            // 
            // lbl_datoSolicitante
            // 
            this.lbl_datoSolicitante.AutoSize = true;
            this.lbl_datoSolicitante.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoSolicitante.Location = new System.Drawing.Point(1012, 37);
            this.lbl_datoSolicitante.Name = "lbl_datoSolicitante";
            this.lbl_datoSolicitante.Size = new System.Drawing.Size(0, 18);
            this.lbl_datoSolicitante.TabIndex = 10;
            // 
            // lbl_usuarioSolicitante
            // 
            this.lbl_usuarioSolicitante.AutoSize = true;
            this.lbl_usuarioSolicitante.Location = new System.Drawing.Point(876, 37);
            this.lbl_usuarioSolicitante.Name = "lbl_usuarioSolicitante";
            this.lbl_usuarioSolicitante.Size = new System.Drawing.Size(123, 20);
            this.lbl_usuarioSolicitante.TabIndex = 9;
            this.lbl_usuarioSolicitante.Text = "Usuario solicitante";
            // 
            // grpb_DetalleDeLaSolicitud
            // 
            this.grpb_DetalleDeLaSolicitud.Controls.Add(this.txt_datoDetalle);
            this.grpb_DetalleDeLaSolicitud.Location = new System.Drawing.Point(100, 109);
            this.grpb_DetalleDeLaSolicitud.Name = "grpb_DetalleDeLaSolicitud";
            this.grpb_DetalleDeLaSolicitud.Size = new System.Drawing.Size(789, 100);
            this.grpb_DetalleDeLaSolicitud.TabIndex = 8;
            this.grpb_DetalleDeLaSolicitud.TabStop = false;
            this.grpb_DetalleDeLaSolicitud.Text = "Detalle de la solicitud";
            // 
            // txt_datoDetalle
            // 
            this.txt_datoDetalle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datoDetalle.Location = new System.Drawing.Point(17, 19);
            this.txt_datoDetalle.Multiline = true;
            this.txt_datoDetalle.Name = "txt_datoDetalle";
            this.txt_datoDetalle.ReadOnly = true;
            this.txt_datoDetalle.Size = new System.Drawing.Size(747, 67);
            this.txt_datoDetalle.TabIndex = 0;
            // 
            // lbl_datoFecha
            // 
            this.lbl_datoFecha.AutoSize = true;
            this.lbl_datoFecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoFecha.Location = new System.Drawing.Point(706, 34);
            this.lbl_datoFecha.Name = "lbl_datoFecha";
            this.lbl_datoFecha.Size = new System.Drawing.Size(0, 18);
            this.lbl_datoFecha.TabIndex = 7;
            // 
            // lbl_fechasolicitud
            // 
            this.lbl_fechasolicitud.AutoSize = true;
            this.lbl_fechasolicitud.Location = new System.Drawing.Point(569, 34);
            this.lbl_fechasolicitud.Name = "lbl_fechasolicitud";
            this.lbl_fechasolicitud.Size = new System.Drawing.Size(118, 20);
            this.lbl_fechasolicitud.TabIndex = 6;
            this.lbl_fechasolicitud.Text = "Fecha de solicitud";
            this.lbl_fechasolicitud.Click += new System.EventHandler(this.lbl_fechasolicitud_Click);
            // 
            // lbl_datoequipo
            // 
            this.lbl_datoequipo.AutoSize = true;
            this.lbl_datoequipo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoequipo.Location = new System.Drawing.Point(492, 36);
            this.lbl_datoequipo.Name = "lbl_datoequipo";
            this.lbl_datoequipo.Size = new System.Drawing.Size(0, 18);
            this.lbl_datoequipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Equipo";
            // 
            // lbl_datoSector
            // 
            this.lbl_datoSector.AutoSize = true;
            this.lbl_datoSector.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoSector.Location = new System.Drawing.Point(268, 36);
            this.lbl_datoSector.Name = "lbl_datoSector";
            this.lbl_datoSector.Size = new System.Drawing.Size(0, 18);
            this.lbl_datoSector.TabIndex = 3;
            // 
            // lbl_Sector
            // 
            this.lbl_Sector.AutoSize = true;
            this.lbl_Sector.Location = new System.Drawing.Point(206, 37);
            this.lbl_Sector.Name = "lbl_Sector";
            this.lbl_Sector.Size = new System.Drawing.Size(51, 20);
            this.lbl_Sector.TabIndex = 2;
            this.lbl_Sector.Text = "Sector";
            // 
            // lbl_datoEdificio
            // 
            this.lbl_datoEdificio.AutoSize = true;
            this.lbl_datoEdificio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoEdificio.Location = new System.Drawing.Point(85, 36);
            this.lbl_datoEdificio.Name = "lbl_datoEdificio";
            this.lbl_datoEdificio.Size = new System.Drawing.Size(0, 18);
            this.lbl_datoEdificio.TabIndex = 1;
            // 
            // lbl_Edificio
            // 
            this.lbl_Edificio.AutoSize = true;
            this.lbl_Edificio.Location = new System.Drawing.Point(23, 37);
            this.lbl_Edificio.Name = "lbl_Edificio";
            this.lbl_Edificio.Size = new System.Drawing.Size(53, 20);
            this.lbl_Edificio.TabIndex = 0;
            this.lbl_Edificio.Text = "Edificio";
            // 
            // lbl_asignarTecnico
            // 
            this.lbl_asignarTecnico.AutoSize = true;
            this.lbl_asignarTecnico.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asignarTecnico.Location = new System.Drawing.Point(23, 281);
            this.lbl_asignarTecnico.Name = "lbl_asignarTecnico";
            this.lbl_asignarTecnico.Size = new System.Drawing.Size(104, 20);
            this.lbl_asignarTecnico.TabIndex = 1;
            this.lbl_asignarTecnico.Text = "Asignar tecnico";
            // 
            // cb_asignartecnico
            // 
            this.cb_asignartecnico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_asignartecnico.FormattingEnabled = true;
            this.cb_asignartecnico.Location = new System.Drawing.Point(25, 311);
            this.cb_asignartecnico.Name = "cb_asignartecnico";
            this.cb_asignartecnico.Size = new System.Drawing.Size(372, 26);
            this.cb_asignartecnico.TabIndex = 2;
            this.cb_asignartecnico.SelectedIndexChanged += new System.EventHandler(this.cb_asignartecnico_SelectedIndexChanged);
            // 
            // lbl_detalleCoordinador
            // 
            this.lbl_detalleCoordinador.AutoSize = true;
            this.lbl_detalleCoordinador.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalleCoordinador.Location = new System.Drawing.Point(30, 347);
            this.lbl_detalleCoordinador.Name = "lbl_detalleCoordinador";
            this.lbl_detalleCoordinador.Size = new System.Drawing.Size(99, 20);
            this.lbl_detalleCoordinador.TabIndex = 3;
            this.lbl_detalleCoordinador.Text = "Detalle tecnico";
            // 
            // txt_detalletecnico
            // 
            this.txt_detalletecnico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalletecnico.Location = new System.Drawing.Point(25, 376);
            this.txt_detalletecnico.Multiline = true;
            this.txt_detalletecnico.Name = "txt_detalletecnico";
            this.txt_detalletecnico.Size = new System.Drawing.Size(372, 171);
            this.txt_detalletecnico.TabIndex = 4;
            // 
            // lbx_materialResultado
            // 
            this.lbx_materialResultado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_materialResultado.FormattingEnabled = true;
            this.lbx_materialResultado.ItemHeight = 18;
            this.lbx_materialResultado.Location = new System.Drawing.Point(416, 376);
            this.lbx_materialResultado.Name = "lbx_materialResultado";
            this.lbx_materialResultado.Size = new System.Drawing.Size(308, 166);
            this.lbx_materialResultado.TabIndex = 5;
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMaterial.Location = new System.Drawing.Point(416, 334);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(199, 26);
            this.txtNombreMaterial.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxMaterialesAgregador
            // 
            this.lbxMaterialesAgregador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMaterialesAgregador.FormattingEnabled = true;
            this.lbxMaterialesAgregador.ItemHeight = 18;
            this.lbxMaterialesAgregador.Location = new System.Drawing.Point(845, 376);
            this.lbxMaterialesAgregador.Name = "lbxMaterialesAgregador";
            this.lbxMaterialesAgregador.Size = new System.Drawing.Size(308, 166);
            this.lbxMaterialesAgregador.TabIndex = 8;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(730, 430);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(97, 47);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar >>";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(956, 575);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(197, 53);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_nueva_ot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 654);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbxMaterialesAgregador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.lbx_materialResultado);
            this.Controls.Add(this.txt_detalletecnico);
            this.Controls.Add(this.lbl_detalleCoordinador);
            this.Controls.Add(this.cb_asignartecnico);
            this.Controls.Add(this.lbl_asignarTecnico);
            this.Controls.Add(this.grpb_datosDeLaSolicitud);
            this.Name = "frm_nueva_ot";
            this.Text = "Nueva Orden de trabajo";
            this.Load += new System.EventHandler(this.frm_nueva_ot_Load);
            this.grpb_datosDeLaSolicitud.ResumeLayout(false);
            this.grpb_datosDeLaSolicitud.PerformLayout();
            this.grpb_DetalleDeLaSolicitud.ResumeLayout(false);
            this.grpb_DetalleDeLaSolicitud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_datosDeLaSolicitud;
        private System.Windows.Forms.GroupBox grpb_DetalleDeLaSolicitud;
        private System.Windows.Forms.TextBox txt_datoDetalle;
        private System.Windows.Forms.Label lbl_datoFecha;
        private System.Windows.Forms.Label lbl_fechasolicitud;
        private System.Windows.Forms.Label lbl_datoequipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_datoSector;
        private System.Windows.Forms.Label lbl_Sector;
        private System.Windows.Forms.Label lbl_datoEdificio;
        private System.Windows.Forms.Label lbl_Edificio;
        private System.Windows.Forms.Label lbl_datoSolicitante;
        private System.Windows.Forms.Label lbl_usuarioSolicitante;
        private System.Windows.Forms.Label lbl_asignarTecnico;
        private System.Windows.Forms.ComboBox cb_asignartecnico;
        private System.Windows.Forms.Label lbl_detalleCoordinador;
        private System.Windows.Forms.TextBox txt_detalletecnico;
        private System.Windows.Forms.ListBox lbx_materialResultado;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxMaterialesAgregador;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_guardar;
    }
}