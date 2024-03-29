﻿namespace CTH
{
    partial class frm_cth
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cth));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarPermisosDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verOTCerradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misOrdenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_userLogin = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.moduloDeUsuariosToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.coordinadorToolStripMenuItem,
            this.tecnicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSeToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // iniciarSeToolStripMenuItem
            // 
            this.iniciarSeToolStripMenuItem.Name = "iniciarSeToolStripMenuItem";
            this.iniciarSeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.iniciarSeToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSeToolStripMenuItem.Click += new System.EventHandler(this.iniciarSeToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // moduloDeUsuariosToolStripMenuItem
            // 
            this.moduloDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeUsuarioToolStripMenuItem,
            this.desbloquearUsuarioToolStripMenuItem,
            this.perfilesDeUsuarioToolStripMenuItem,
            this.nuevoIdiomaToolStripMenuItem,
            this.configurarPermisosDeUsuarioToolStripMenuItem});
            this.moduloDeUsuariosToolStripMenuItem.Name = "moduloDeUsuariosToolStripMenuItem";
            this.moduloDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.moduloDeUsuariosToolStripMenuItem.Text = "Modulo de administracion";
            // 
            // altaDeUsuarioToolStripMenuItem
            // 
            this.altaDeUsuarioToolStripMenuItem.Name = "altaDeUsuarioToolStripMenuItem";
            this.altaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.altaDeUsuarioToolStripMenuItem.Text = "Alta de usuario";
            this.altaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaDeUsuarioToolStripMenuItem_Click);
            // 
            // desbloquearUsuarioToolStripMenuItem
            // 
            this.desbloquearUsuarioToolStripMenuItem.Name = "desbloquearUsuarioToolStripMenuItem";
            this.desbloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.desbloquearUsuarioToolStripMenuItem.Text = "Desbloquear usuario";
            this.desbloquearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.desbloquearUsuarioToolStripMenuItem_Click);
            // 
            // perfilesDeUsuarioToolStripMenuItem
            // 
            this.perfilesDeUsuarioToolStripMenuItem.Name = "perfilesDeUsuarioToolStripMenuItem";
            this.perfilesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.perfilesDeUsuarioToolStripMenuItem.Text = "Perfiles de usuario";
            this.perfilesDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.perfilesDeUsuarioToolStripMenuItem_Click);
            // 
            // nuevoIdiomaToolStripMenuItem
            // 
            this.nuevoIdiomaToolStripMenuItem.Name = "nuevoIdiomaToolStripMenuItem";
            this.nuevoIdiomaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.nuevoIdiomaToolStripMenuItem.Text = "Nuevo idioma";
            this.nuevoIdiomaToolStripMenuItem.Click += new System.EventHandler(this.nuevoIdiomaToolStripMenuItem_Click);
            // 
            // configurarPermisosDeUsuarioToolStripMenuItem
            // 
            this.configurarPermisosDeUsuarioToolStripMenuItem.Name = "configurarPermisosDeUsuarioToolStripMenuItem";
            this.configurarPermisosDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.configurarPermisosDeUsuarioToolStripMenuItem.Text = "Configurar permisos de usuario";
            this.configurarPermisosDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.configurarPermisosDeUsuarioToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSolicitudToolStripMenuItem,
            this.verMisSolicitudesToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // crearSolicitudToolStripMenuItem
            // 
            this.crearSolicitudToolStripMenuItem.Name = "crearSolicitudToolStripMenuItem";
            this.crearSolicitudToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.crearSolicitudToolStripMenuItem.Text = "Crear Solicitud";
            this.crearSolicitudToolStripMenuItem.Click += new System.EventHandler(this.crearSolicitudToolStripMenuItem_Click);
            // 
            // verMisSolicitudesToolStripMenuItem
            // 
            this.verMisSolicitudesToolStripMenuItem.Name = "verMisSolicitudesToolStripMenuItem";
            this.verMisSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.verMisSolicitudesToolStripMenuItem.Text = "Ver mis solicitudes";
            this.verMisSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.verMisSolicitudesToolStripMenuItem_Click);
            // 
            // coordinadorToolStripMenuItem
            // 
            this.coordinadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesToolStripMenuItem1,
            this.verOTCerradasToolStripMenuItem,
            this.informeDeEquipoToolStripMenuItem});
            this.coordinadorToolStripMenuItem.Name = "coordinadorToolStripMenuItem";
            this.coordinadorToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.coordinadorToolStripMenuItem.Text = "Coordinador";
            // 
            // solicitudesToolStripMenuItem1
            // 
            this.solicitudesToolStripMenuItem1.Name = "solicitudesToolStripMenuItem1";
            this.solicitudesToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.solicitudesToolStripMenuItem1.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem1.Click += new System.EventHandler(this.solicitudesToolStripMenuItem1_Click);
            // 
            // verOTCerradasToolStripMenuItem
            // 
            this.verOTCerradasToolStripMenuItem.Name = "verOTCerradasToolStripMenuItem";
            this.verOTCerradasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.verOTCerradasToolStripMenuItem.Text = "Ver Ordenes de trabajo";
            this.verOTCerradasToolStripMenuItem.Click += new System.EventHandler(this.verOTCerradasToolStripMenuItem_Click);
            // 
            // informeDeEquipoToolStripMenuItem
            // 
            this.informeDeEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.tecnicosToolStripMenuItem});
            this.informeDeEquipoToolStripMenuItem.Name = "informeDeEquipoToolStripMenuItem";
            this.informeDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.informeDeEquipoToolStripMenuItem.Text = "Informes";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            this.tecnicosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tecnicosToolStripMenuItem.Text = "Tecnicos";
            // 
            // tecnicoToolStripMenuItem
            // 
            this.tecnicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misOrdenesDeTrabajoToolStripMenuItem});
            this.tecnicoToolStripMenuItem.Name = "tecnicoToolStripMenuItem";
            this.tecnicoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tecnicoToolStripMenuItem.Text = "Tecnico";
            // 
            // misOrdenesDeTrabajoToolStripMenuItem
            // 
            this.misOrdenesDeTrabajoToolStripMenuItem.Name = "misOrdenesDeTrabajoToolStripMenuItem";
            this.misOrdenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.misOrdenesDeTrabajoToolStripMenuItem.Text = "Mis ordenes de trabajo";
            // 
            // lbl_userLogin
            // 
            this.lbl_userLogin.AutoSize = true;
            this.lbl_userLogin.Location = new System.Drawing.Point(1232, 11);
            this.lbl_userLogin.Name = "lbl_userLogin";
            this.lbl_userLogin.Size = new System.Drawing.Size(35, 13);
            this.lbl_userLogin.TabIndex = 1;
            this.lbl_userLogin.Text = "label1";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(12, 546);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 4;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // frm_cth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 579);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lbl_userLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_cth";
            this.Text = "CONTROL TECNICO HOPITALARIO CTH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_home_FormClosed);
            this.Load += new System.EventHandler(this.frm_cth_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_userLogin;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verOTCerradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misOrdenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ToolStripMenuItem nuevoIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarPermisosDeUsuarioToolStripMenuItem;
    }
}

