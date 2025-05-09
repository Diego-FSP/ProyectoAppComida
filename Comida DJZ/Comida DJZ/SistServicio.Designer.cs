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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Encabezado = new System.Windows.Forms.Panel();
            this.NEstado = new System.Windows.Forms.Label();
            this.Pagina = new System.Windows.Forms.Panel();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.ListaPP = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Encabezado.SuspendLayout();
            this.Pagina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPP)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(44)))));
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
            // Pagina
            // 
            this.Pagina.Controls.Add(this.B1);
            this.Pagina.Controls.Add(this.B2);
            this.Pagina.Controls.Add(this.ListaPP);
            this.Pagina.Controls.Add(this.panel1);
            this.Pagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pagina.Location = new System.Drawing.Point(0, 86);
            this.Pagina.Name = "Pagina";
            this.Pagina.Size = new System.Drawing.Size(800, 374);
            this.Pagina.TabIndex = 4;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.B1.FlatAppearance.BorderSize = 2;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.SystemColors.Control;
            this.B1.Location = new System.Drawing.Point(266, 88);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(184, 134);
            this.B1.TabIndex = 3;
            this.B1.Text = "Pedir Comida";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.B2.FlatAppearance.BorderSize = 2;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.SystemColors.Control;
            this.B2.Location = new System.Drawing.Point(515, 88);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(184, 134);
            this.B2.TabIndex = 3;
            this.B2.Text = "Calificar";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Visible = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // ListaPP
            // 
            this.ListaPP.AllowUserToAddRows = false;
            this.ListaPP.AllowUserToDeleteRows = false;
            this.ListaPP.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaPP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaPP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.Cantidad});
            this.ListaPP.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListaPP.EnableHeadersVisualStyles = false;
            this.ListaPP.GridColor = System.Drawing.Color.DarkOrange;
            this.ListaPP.Location = new System.Drawing.Point(0, 0);
            this.ListaPP.Name = "ListaPP";
            this.ListaPP.ReadOnly = true;
            this.ListaPP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ListaPP.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ListaPP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaPP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPP.Size = new System.Drawing.Size(144, 274);
            this.ListaPP.TabIndex = 4;
            this.ListaPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EleccionP);
            this.ListaPP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EleccionP);
            this.ListaPP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ImagenC);
            // 
            // Imagen
            // 
            this.Imagen.Frozen = true;
            this.Imagen.HeaderText = "Pedido";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 40F;
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(44)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // SistServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.Pagina);
            this.Controls.Add(this.Encabezado);
            this.Name = "SistServicio";
            this.Text = "SistServicio";
            this.Load += new System.EventHandler(this.SistServicio_Load);
            this.SizeChanged += new System.EventHandler(this.Tamaño);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.Pagina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Encabezado;
        public System.Windows.Forms.Label NEstado;
        private System.Windows.Forms.Panel Pagina;
        public System.Windows.Forms.DataGridView ListaPP;
        public System.Windows.Forms.Button B2;
        public System.Windows.Forms.Button B1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}