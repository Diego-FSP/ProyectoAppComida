namespace Comida_DJZ.PagServicio
{
    partial class SeleccionarComida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarComida));
            this.ListaC = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bpostre = new System.Windows.Forms.Button();
            this.Bbebida = new System.Windows.Forms.Button();
            this.Bcomida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaC
            // 
            this.ListaC.AllowUserToAddRows = false;
            this.ListaC.AllowUserToDeleteRows = false;
            this.ListaC.BackgroundColor = System.Drawing.Color.Beige;
            this.ListaC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListaC.ColumnHeadersHeight = 40;
            this.ListaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Imagen,
            this.Nombre,
            this.Cantidad,
            this.Precio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListaC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaC.EnableHeadersVisualStyles = false;
            this.ListaC.GridColor = System.Drawing.Color.DarkOrange;
            this.ListaC.Location = new System.Drawing.Point(0, 0);
            this.ListaC.Name = "ListaC";
            this.ListaC.ReadOnly = true;
            this.ListaC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ListaC.RowHeadersVisible = false;
            this.ListaC.RowHeadersWidth = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.ListaC.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ListaC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaC.Size = new System.Drawing.Size(800, 390);
            this.ListaC.TabIndex = 0;
            this.ListaC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaC_CellDoubleClick);
            this.ListaC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaC_CellDoubleClick);
            this.ListaC.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ImagenC);
            // 
            // ID
            // 
            this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen.FillWeight = 200F;
            this.Imagen.Frozen = true;
            this.Imagen.HeaderText = "IMG";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.MinimumWidth = 200;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Comida";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Disponible";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Bpostre);
            this.panel1.Controls.Add(this.Bbebida);
            this.panel1.Controls.Add(this.Bcomida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 1;
            // 
            // Bpostre
            // 
            this.Bpostre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bpostre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bpostre.BackgroundImage")));
            this.Bpostre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bpostre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bpostre.Location = new System.Drawing.Point(542, 0);
            this.Bpostre.Name = "Bpostre";
            this.Bpostre.Size = new System.Drawing.Size(258, 60);
            this.Bpostre.TabIndex = 2;
            this.Bpostre.UseVisualStyleBackColor = false;
            this.Bpostre.Click += new System.EventHandler(this.Bpostre_Click);
            // 
            // Bbebida
            // 
            this.Bbebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bbebida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bbebida.BackgroundImage")));
            this.Bbebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bbebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbebida.Location = new System.Drawing.Point(260, 0);
            this.Bbebida.Name = "Bbebida";
            this.Bbebida.Size = new System.Drawing.Size(276, 60);
            this.Bbebida.TabIndex = 1;
            this.Bbebida.UseVisualStyleBackColor = false;
            this.Bbebida.Click += new System.EventHandler(this.Bbebida_Click);
            // 
            // Bcomida
            // 
            this.Bcomida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bcomida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bcomida.BackgroundImage")));
            this.Bcomida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bcomida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcomida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcomida.Location = new System.Drawing.Point(0, 0);
            this.Bcomida.Name = "Bcomida";
            this.Bcomida.Size = new System.Drawing.Size(254, 60);
            this.Bcomida.TabIndex = 0;
            this.Bcomida.UseVisualStyleBackColor = false;
            this.Bcomida.Click += new System.EventHandler(this.Bcomida_Click);
            // 
            // SeleccionarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaC);
            this.Controls.Add(this.panel1);
            this.Name = "SeleccionarComida";
            this.Text = "SeleccionarComida";
            this.SizeChanged += new System.EventHandler(this.SeleccionarComida_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaC;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bpostre;
        private System.Windows.Forms.Button Bbebida;
        private System.Windows.Forms.Button Bcomida;
    }
}