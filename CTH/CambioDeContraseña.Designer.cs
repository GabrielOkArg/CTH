namespace CTH
{
    partial class CambioDeContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassoriginal = new System.Windows.Forms.TextBox();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrepeticion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su contraseña actual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpassoriginal
            // 
            this.txtpassoriginal.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassoriginal.Location = new System.Drawing.Point(26, 46);
            this.txtpassoriginal.Name = "txtpassoriginal";
            this.txtpassoriginal.Size = new System.Drawing.Size(262, 25);
            this.txtpassoriginal.TabIndex = 1;
            this.txtpassoriginal.TextChanged += new System.EventHandler(this.txtpassoriginal_TextChanged);
            // 
            // txtnueva
            // 
            this.txtnueva.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnueva.Location = new System.Drawing.Point(26, 109);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(262, 25);
            this.txtnueva.TabIndex = 3;
            this.txtnueva.TextChanged += new System.EventHandler(this.txtnueva_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la nueva contraseña";
            // 
            // txtrepeticion
            // 
            this.txtrepeticion.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepeticion.Location = new System.Drawing.Point(26, 182);
            this.txtrepeticion.Name = "txtrepeticion";
            this.txtrepeticion.Size = new System.Drawing.Size(262, 25);
            this.txtrepeticion.TabIndex = 5;
            this.txtrepeticion.TextChanged += new System.EventHandler(this.txtrepeticion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vuelva a ingresar la nueva contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambioDeContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrepeticion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassoriginal);
            this.Controls.Add(this.label1);
            this.Name = "CambioDeContraseña";
            this.Text = "CambioDeContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassoriginal;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrepeticion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}