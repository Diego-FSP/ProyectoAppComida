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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaC = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaPP = new System.Windows.Forms.DataGridView();
            this.Pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPP)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaC
            // 
            this.ListaC.BackgroundColor = System.Drawing.Color.Beige;
            this.ListaC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ListaC.ColumnHeadersHeight = 40;
            this.ListaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Imagen,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Descripcion});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.DefaultCellStyle = dataGridViewCellStyle10;
            this.ListaC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaC.EnableHeadersVisualStyles = false;
            this.ListaC.Location = new System.Drawing.Point(0, 0);
            this.ListaC.Name = "ListaC";
            this.ListaC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ListaC.RowHeadersVisible = false;
            this.ListaC.RowHeadersWidth = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.ListaC.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ListaC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaC.Size = new System.Drawing.Size(631, 450);
            this.ListaC.TabIndex = 0;
            this.ListaC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaC_CellDoubleClick);
            this.ListaC.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ImagenC);
            // 
            // ID
            // 
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
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Comida";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Disponible";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // ListaPP
            // 
            this.ListaPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pn,
            this.Comida});
            this.ListaPP.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListaPP.Location = new System.Drawing.Point(631, 0);
            this.ListaPP.Name = "ListaPP";
            this.ListaPP.RowHeadersVisible = false;
            this.ListaPP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPP.Size = new System.Drawing.Size(169, 450);
            this.ListaPP.TabIndex = 1;
            this.ListaPP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ImagenC);
            // 
            // Pn
            // 
            this.Pn.Frozen = true;
            this.Pn.HeaderText = "n°";
            this.Pn.Name = "Pn";
            this.Pn.Width = 25;
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Comida.Name = "Comida";
            this.Comida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SeleccionarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaC);
            this.Controls.Add(this.ListaPP);
            this.Name = "SeleccionarComida";
            this.Text = "SeleccionarComida";
            this.SizeChanged += new System.EventHandler(this.SeleccionarComida_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaC;
        private System.Windows.Forms.DataGridView ListaPP;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pn;
        private System.Windows.Forms.DataGridViewImageColumn Comida;
    }
}