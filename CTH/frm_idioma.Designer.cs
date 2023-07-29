namespace CTH
{
    partial class frm_idioma_NuevoIdioma
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
            this.lbl_Idioma_Idiomas = new System.Windows.Forms.Label();
            this.lbl_form_Formularios = new System.Windows.Forms.Label();
            this.cmb_formularios = new System.Windows.Forms.ComboBox();
            this.lbl_ctrl_Contoles = new System.Windows.Forms.Label();
            this.cmb_controles = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chxb_idiomaTerminado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Idioma_Idiomas
            // 
            this.lbl_Idioma_Idiomas.AutoSize = true;
            this.lbl_Idioma_Idiomas.Location = new System.Drawing.Point(20, 15);
            this.lbl_Idioma_Idiomas.Name = "lbl_Idioma_Idiomas";
            this.lbl_Idioma_Idiomas.Size = new System.Drawing.Size(43, 13);
            this.lbl_Idioma_Idiomas.TabIndex = 0;
            this.lbl_Idioma_Idiomas.Text = "Idiomas";
            // 
            // lbl_form_Formularios
            // 
            this.lbl_form_Formularios.AutoSize = true;
            this.lbl_form_Formularios.Location = new System.Drawing.Point(20, 52);
            this.lbl_form_Formularios.Name = "lbl_form_Formularios";
            this.lbl_form_Formularios.Size = new System.Drawing.Size(60, 13);
            this.lbl_form_Formularios.TabIndex = 2;
            this.lbl_form_Formularios.Text = "Formularios";
            // 
            // cmb_formularios
            // 
            this.cmb_formularios.FormattingEnabled = true;
            this.cmb_formularios.Location = new System.Drawing.Point(82, 44);
            this.cmb_formularios.Name = "cmb_formularios";
            this.cmb_formularios.Size = new System.Drawing.Size(121, 21);
            this.cmb_formularios.TabIndex = 3;
            this.cmb_formularios.SelectedIndexChanged += new System.EventHandler(this.selectedFormChange);
            // 
            // lbl_ctrl_Contoles
            // 
            this.lbl_ctrl_Contoles.AutoSize = true;
            this.lbl_ctrl_Contoles.Location = new System.Drawing.Point(277, 52);
            this.lbl_ctrl_Contoles.Name = "lbl_ctrl_Contoles";
            this.lbl_ctrl_Contoles.Size = new System.Drawing.Size(51, 13);
            this.lbl_ctrl_Contoles.TabIndex = 4;
            this.lbl_ctrl_Contoles.Text = "Controles";
            // 
            // cmb_controles
            // 
            this.cmb_controles.FormattingEnabled = true;
            this.cmb_controles.Location = new System.Drawing.Point(359, 44);
            this.cmb_controles.Name = "cmb_controles";
            this.cmb_controles.Size = new System.Drawing.Size(121, 21);
            this.cmb_controles.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // chxb_idiomaTerminado
            // 
            this.chxb_idiomaTerminado.AutoSize = true;
            this.chxb_idiomaTerminado.Location = new System.Drawing.Point(359, 7);
            this.chxb_idiomaTerminado.Name = "chxb_idiomaTerminado";
            this.chxb_idiomaTerminado.Size = new System.Drawing.Size(106, 17);
            this.chxb_idiomaTerminado.TabIndex = 7;
            this.chxb_idiomaTerminado.Text = "Idioma terminado";
            this.chxb_idiomaTerminado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Texto del control";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese el texto traducido";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(441, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_idioma_NuevoIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chxb_idiomaTerminado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_controles);
            this.Controls.Add(this.lbl_ctrl_Contoles);
            this.Controls.Add(this.cmb_formularios);
            this.Controls.Add(this.lbl_form_Formularios);
            this.Controls.Add(this.lbl_Idioma_Idiomas);
            this.Name = "frm_idioma_NuevoIdioma";
            this.Text = "frm_idioma";
            this.Load += new System.EventHandler(this.frm_idioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Idioma_Idiomas;
        private System.Windows.Forms.Label lbl_form_Formularios;
        private System.Windows.Forms.ComboBox cmb_formularios;
        private System.Windows.Forms.Label lbl_ctrl_Contoles;
        private System.Windows.Forms.ComboBox cmb_controles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chxb_idiomaTerminado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}