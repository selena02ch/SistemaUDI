namespace ProyectoUDI
{
    partial class PanelMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMenu));
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelProv = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.DarkBlue;
            this.labelCliente.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.Lavender;
            this.labelCliente.Location = new System.Drawing.Point(447, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(88, 21);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "CLIENTES";
            this.labelCliente.Click += new System.EventHandler(this.labelCliente_Click);
            // 
            // labelProv
            // 
            this.labelProv.AutoSize = true;
            this.labelProv.BackColor = System.Drawing.Color.DarkBlue;
            this.labelProv.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProv.ForeColor = System.Drawing.Color.Lavender;
            this.labelProv.Location = new System.Drawing.Point(233, 9);
            this.labelProv.Name = "labelProv";
            this.labelProv.Size = new System.Drawing.Size(136, 21);
            this.labelProv.TabIndex = 1;
            this.labelProv.Text = "PROVEEDORES";
            this.labelProv.Click += new System.EventHandler(this.labelProv_Click);
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.BackColor = System.Drawing.Color.DarkBlue;
            this.labelProd.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.ForeColor = System.Drawing.Color.Lavender;
            this.labelProd.Location = new System.Drawing.Point(26, 9);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(117, 21);
            this.labelProd.TabIndex = 2;
            this.labelProd.Text = "PRODUCTOS";
            this.labelProd.Click += new System.EventHandler(this.labelProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(550, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // PanelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelProv);
            this.Controls.Add(this.labelCliente);
            this.Name = "PanelMenu";
            this.Text = "PanelMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelProv;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}