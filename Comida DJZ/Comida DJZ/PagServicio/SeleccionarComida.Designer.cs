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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaC = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaC
            // 
            this.ListaC.BackgroundColor = System.Drawing.Color.Beige;
            this.ListaC.ColumnHeadersHeight = 40;
            this.ListaC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Descripcion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListaC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaC.Location = new System.Drawing.Point(0, 0);
            this.ListaC.Name = "ListaC";
            this.ListaC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaC.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ListaC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaC.Size = new System.Drawing.Size(631, 450);
            this.ListaC.TabIndex = 0;
            this.ListaC.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ImagenC);
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
            this.Precio.HeaderText = "$";
            this.Precio.Name = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pn,
            this.Comida});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(631, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(169, 450);
            this.dataGridView1.TabIndex = 1;
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
            this.Comida.Name = "Comida";
            // 
            // SeleccionarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarComida";
            this.Text = "SeleccionarComida";
            this.SizeChanged += new System.EventHandler(this.SeleccionarComida_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ListaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}