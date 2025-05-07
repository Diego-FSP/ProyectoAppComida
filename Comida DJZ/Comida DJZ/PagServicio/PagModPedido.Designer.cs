namespace Comida_DJZ.PagServicio
{
    partial class PagModPedido
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
            this.TX1 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.MasC = new System.Windows.Forms.Button();
            this.MenosC = new System.Windows.Forms.Button();
            this.Comida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Descripcion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TX1
            // 
            this.TX1.AutoSize = true;
            this.TX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX1.Location = new System.Drawing.Point(395, 362);
            this.TX1.Name = "TX1";
            this.TX1.Size = new System.Drawing.Size(89, 24);
            this.TX1.TabIndex = 0;
            this.TX1.Text = "Cantidad:";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(536, 362);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(20, 24);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "0";
            // 
            // MasC
            // 
            this.MasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasC.Location = new System.Drawing.Point(562, 357);
            this.MasC.Name = "MasC";
            this.MasC.Size = new System.Drawing.Size(45, 34);
            this.MasC.TabIndex = 3;
            this.MasC.Text = "+";
            this.MasC.UseVisualStyleBackColor = true;
            this.MasC.Click += new System.EventHandler(this.MasC_Click);
            // 
            // MenosC
            // 
            this.MenosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenosC.Location = new System.Drawing.Point(485, 357);
            this.MenosC.Name = "MenosC";
            this.MenosC.Size = new System.Drawing.Size(45, 34);
            this.MenosC.TabIndex = 4;
            this.MenosC.Text = "-";
            this.MenosC.UseVisualStyleBackColor = true;
            this.MenosC.Click += new System.EventHandler(this.MenosC_Click);
            // 
            // Comida
            // 
            this.Comida.AutoSize = true;
            this.Comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comida.Location = new System.Drawing.Point(394, 30);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(250, 29);
            this.Comida.TabIndex = 5;
            this.Comida.Text = "Nombre de la Comida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Comida_DJZ.Properties.Resources.icono;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(399, 76);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(375, 144);
            this.Descripcion.TabIndex = 8;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Comida);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.MenosC);
            this.panel1.Controls.Add(this.TX1);
            this.panel1.Controls.Add(this.MasC);
            this.panel1.Controls.Add(this.Cantidad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 9;
            // 
            // PagModPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PagModPedido";
            this.Text = "PagModPedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Button MasC;
        private System.Windows.Forms.Button MenosC;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.Button Descripcion;
        private System.Windows.Forms.Panel panel1;
    }
}