namespace CTH
{
    partial class frm_FamiliaPatente
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
            this.grpbox_Familias = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardarFamilia = new System.Windows.Forms.Button();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            this.btnConfigurarFamilia = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.lbl_TodasLasFamilias = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nueva = new System.Windows.Forms.GroupBox();
            this.btnGuardarPatente = new System.Windows.Forms.Button();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPatente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.grpbox_Familias.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Nueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_Familias
            // 
            this.grpbox_Familias.Controls.Add(this.groupBox3);
            this.grpbox_Familias.Controls.Add(this.btnAddFamilia);
            this.grpbox_Familias.Controls.Add(this.btnConfigurarFamilia);
            this.grpbox_Familias.Controls.Add(this.cboFamilias);
            this.grpbox_Familias.Controls.Add(this.lbl_TodasLasFamilias);
            this.grpbox_Familias.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_Familias.Location = new System.Drawing.Point(350, 33);
            this.grpbox_Familias.Name = "grpbox_Familias";
            this.grpbox_Familias.Size = new System.Drawing.Size(344, 332);
            this.grpbox_Familias.TabIndex = 2;
            this.grpbox_Familias.TabStop = false;
            this.grpbox_Familias.Text = "Familias";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarFamilia);
            this.groupBox3.Controls.Add(this.txtNombreFamilia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 201);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva";
            // 
            // btnGuardarFamilia
            // 
            this.btnGuardarFamilia.Location = new System.Drawing.Point(11, 103);
            this.btnGuardarFamilia.Name = "btnGuardarFamilia";
            this.btnGuardarFamilia.Size = new System.Drawing.Size(117, 32);
            this.btnGuardarFamilia.TabIndex = 2;
            this.btnGuardarFamilia.Text = "Guardar";
            this.btnGuardarFamilia.UseVisualStyleBackColor = true;
            this.btnGuardarFamilia.Click += new System.EventHandler(this.btnGuardarFamilia_Click_1);
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(11, 48);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(282, 25);
            this.txtNombreFamilia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // btnAddFamilia
            // 
            this.btnAddFamilia.Location = new System.Drawing.Point(139, 91);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(112, 28);
            this.btnAddFamilia.TabIndex = 3;
            this.btnAddFamilia.Text = "Agregar >>";
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            this.btnAddFamilia.Click += new System.EventHandler(this.btnAddFamilia_Click_1);
            // 
            // btnConfigurarFamilia
            // 
            this.btnConfigurarFamilia.Location = new System.Drawing.Point(10, 91);
            this.btnConfigurarFamilia.Name = "btnConfigurarFamilia";
            this.btnConfigurarFamilia.Size = new System.Drawing.Size(111, 27);
            this.btnConfigurarFamilia.TabIndex = 2;
            this.btnConfigurarFamilia.Text = "Configurar";
            this.btnConfigurarFamilia.UseVisualStyleBackColor = true;
            this.btnConfigurarFamilia.Click += new System.EventHandler(this.btnConfigurarFamilia_Click_1);
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(12, 55);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(317, 28);
            this.cboFamilias.TabIndex = 1;
            // 
            // lbl_TodasLasFamilias
            // 
            this.lbl_TodasLasFamilias.AutoSize = true;
            this.lbl_TodasLasFamilias.Location = new System.Drawing.Point(6, 32);
            this.lbl_TodasLasFamilias.Name = "lbl_TodasLasFamilias";
            this.lbl_TodasLasFamilias.Size = new System.Drawing.Size(115, 20);
            this.lbl_TodasLasFamilias.TabIndex = 0;
            this.lbl_TodasLasFamilias.Text = "Todas las Familias";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.treeConfigurarFamilia);
            this.groupBox4.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(710, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 332);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurar Familia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 33);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(7, 21);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(392, 228);
            this.treeConfigurarFamilia.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nueva);
            this.groupBox1.Controls.Add(this.btnAddPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPatentes);
            this.groupBox1.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 333);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patentes";
            // 
            // Nueva
            // 
            this.Nueva.Controls.Add(this.btnGuardarPatente);
            this.Nueva.Controls.Add(this.txtNombrePatente);
            this.Nueva.Controls.Add(this.label3);
            this.Nueva.Controls.Add(this.cboPermisos);
            this.Nueva.Controls.Add(this.label2);
            this.Nueva.Location = new System.Drawing.Point(7, 125);
            this.Nueva.Name = "Nueva";
            this.Nueva.Size = new System.Drawing.Size(296, 202);
            this.Nueva.TabIndex = 3;
            this.Nueva.TabStop = false;
            this.Nueva.Text = "Nueva";
            // 
            // btnGuardarPatente
            // 
            this.btnGuardarPatente.Location = new System.Drawing.Point(10, 147);
            this.btnGuardarPatente.Name = "btnGuardarPatente";
            this.btnGuardarPatente.Size = new System.Drawing.Size(111, 33);
            this.btnGuardarPatente.TabIndex = 4;
            this.btnGuardarPatente.Text = "Guardar";
            this.btnGuardarPatente.UseVisualStyleBackColor = true;
            this.btnGuardarPatente.Click += new System.EventHandler(this.btnGuardarPatente_Click_1);
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(10, 103);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(230, 25);
            this.txtNombrePatente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // cboPermisos
            // 
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(10, 44);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(266, 28);
            this.cboPermisos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Permiso";
            // 
            // btnAddPatente
            // 
            this.btnAddPatente.Location = new System.Drawing.Point(7, 90);
            this.btnAddPatente.Name = "btnAddPatente";
            this.btnAddPatente.Size = new System.Drawing.Size(121, 28);
            this.btnAddPatente.TabIndex = 2;
            this.btnAddPatente.Text = "Agregar >>";
            this.btnAddPatente.UseVisualStyleBackColor = true;
            this.btnAddPatente.Click += new System.EventHandler(this.btnAddPatente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Todas las Patentes";
            // 
            // cboPatentes
            // 
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(7, 55);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(275, 28);
            this.cboPatentes.TabIndex = 0;
            // 
            // frm_FamiliaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpbox_Familias);
            this.Name = "frm_FamiliaPatente";
            this.Text = "frm_FamiliaPatente";
            this.Load += new System.EventHandler(this.frm_FamiliaPatente_Load);
            this.grpbox_Familias.ResumeLayout(false);
            this.grpbox_Familias.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Nueva.ResumeLayout(false);
            this.Nueva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_Familias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarFamilia;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFamilia;
        private System.Windows.Forms.Button btnConfigurarFamilia;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.Label lbl_TodasLasFamilias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TreeView treeConfigurarFamilia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Nueva;
        private System.Windows.Forms.Button btnGuardarPatente;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPatentes;
    }
}