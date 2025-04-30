namespace Comida_DJZ
{
    partial class SistServicio
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
            this.B1 = new System.Windows.Forms.Button();
            this.Encabezado = new System.Windows.Forms.Panel();
            this.NEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.B2 = new System.Windows.Forms.Button();
            this.Pagina = new System.Windows.Forms.Panel();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Gainsboro;
            this.B1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B1.Location = new System.Drawing.Point(152, 226);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(184, 134);
            this.B1.TabIndex = 0;
            this.B1.Text = "Pedir Comida";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.OrangeRed;
            this.Encabezado.Controls.Add(this.NEstado);
            this.Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(800, 86);
            this.Encabezado.TabIndex = 1;
            // 
            // NEstado
            // 
            this.NEstado.AutoSize = true;
            this.NEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.NEstado.Location = new System.Drawing.Point(62, 29);
            this.NEstado.Name = "NEstado";
            this.NEstado.Size = new System.Drawing.Size(135, 42);
            this.NEstado.TabIndex = 4;
            this.NEstado.Text = "Estado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 81);
            this.panel2.TabIndex = 2;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(498, 226);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(184, 134);
            this.B2.TabIndex = 3;
            this.B2.Text = "Calificar";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // Pagina
            // 
            this.Pagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pagina.Location = new System.Drawing.Point(0, 86);
            this.Pagina.Name = "Pagina";
            this.Pagina.Size = new System.Drawing.Size(800, 405);
            this.Pagina.TabIndex = 4;
            // 
            // SistServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.Pagina);
            this.Controls.Add(this.Encabezado);
            this.Controls.Add(this.panel2);
            this.Name = "SistServicio";
            this.Text = "SistServicio";
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label NEstado;
        public System.Windows.Forms.Button B1;
        public System.Windows.Forms.Button B2;
        private System.Windows.Forms.Panel Pagina;
    }
}