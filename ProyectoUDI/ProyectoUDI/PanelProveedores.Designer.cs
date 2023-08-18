namespace ProyectoUDI
{
    partial class PanelProveedores
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
            this.listBoxProveedor = new System.Windows.Forms.ListBox();
            this.btnXProv = new System.Windows.Forms.Button();
            this.btnGProv = new System.Windows.Forms.Button();
            this.txtDomcProv = new System.Windows.Forms.TextBox();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProveedor
            // 
            this.listBoxProveedor.FormattingEnabled = true;
            this.listBoxProveedor.Location = new System.Drawing.Point(333, 75);
            this.listBoxProveedor.Name = "listBoxProveedor";
            this.listBoxProveedor.Size = new System.Drawing.Size(258, 160);
            this.listBoxProveedor.TabIndex = 48;
            // 
            // btnXProv
            // 
            this.btnXProv.Location = new System.Drawing.Point(236, 282);
            this.btnXProv.Name = "btnXProv";
            this.btnXProv.Size = new System.Drawing.Size(75, 23);
            this.btnXProv.TabIndex = 47;
            this.btnXProv.Text = "Eliminar";
            this.btnXProv.UseVisualStyleBackColor = true;
            // 
            // btnGProv
            // 
            this.btnGProv.Location = new System.Drawing.Point(109, 282);
            this.btnGProv.Name = "btnGProv";
            this.btnGProv.Size = new System.Drawing.Size(75, 23);
            this.btnGProv.TabIndex = 46;
            this.btnGProv.Text = "Guardar";
            this.btnGProv.UseVisualStyleBackColor = true;
            // 
            // txtDomcProv
            // 
            this.txtDomcProv.Location = new System.Drawing.Point(163, 156);
            this.txtDomcProv.Name = "txtDomcProv";
            this.txtDomcProv.Size = new System.Drawing.Size(100, 20);
            this.txtDomcProv.TabIndex = 45;
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(163, 92);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(100, 20);
            this.txtNomProv.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "PROVEEDORES";
            // 
            // PanelProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.Controls.Add(this.listBoxProveedor);
            this.Controls.Add(this.btnXProv);
            this.Controls.Add(this.btnGProv);
            this.Controls.Add(this.txtDomcProv);
            this.Controls.Add(this.txtNomProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelProveedores";
            this.Text = "PanelProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProveedor;
        private System.Windows.Forms.Button btnXProv;
        private System.Windows.Forms.Button btnGProv;
        private System.Windows.Forms.TextBox txtDomcProv;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}