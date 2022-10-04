namespace TP_PAV_1._0.Capa_UI.Productos
{
    partial class ProductosMain
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
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgr_Productos = new System.Windows.Forms.DataGridView();
            this.grbx_ = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_CodProducto = new System.Windows.Forms.TextBox();
            this.lbl_Cuit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Productos)).BeginInit();
            this.grbx_.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(264, 473);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(126, 23);
            this.btn_Baja.TabIndex = 22;
            this.btn_Baja.Text = "Eliminar producto";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(18, 474);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(110, 23);
            this.btn_Alta.TabIndex = 21;
            this.btn_Alta.Text = "Agregar producto ";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(134, 474);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(124, 23);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar producto";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(782, 463);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 24);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgr_Productos
            // 
            this.dgr_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Productos.Location = new System.Drawing.Point(12, 165);
            this.dgr_Productos.Name = "dgr_Productos";
            this.dgr_Productos.Size = new System.Drawing.Size(904, 292);
            this.dgr_Productos.TabIndex = 18;
            // 
            // grbx_
            // 
            this.grbx_.Controls.Add(this.btnConsultar);
            this.grbx_.Controls.Add(this.label2);
            this.grbx_.Controls.Add(this.txt_Nombre);
            this.grbx_.Controls.Add(this.txt_CodProducto);
            this.grbx_.Controls.Add(this.lbl_Cuit);
            this.grbx_.Location = new System.Drawing.Point(12, 16);
            this.grbx_.Name = "grbx_";
            this.grbx_.Size = new System.Drawing.Size(616, 143);
            this.grbx_.TabIndex = 17;
            this.grbx_.TabStop = false;
            this.grbx_.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(490, 113);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 24);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(101, 56);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(145, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_CodProducto
            // 
            this.txt_CodProducto.Location = new System.Drawing.Point(101, 33);
            this.txt_CodProducto.Name = "txt_CodProducto";
            this.txt_CodProducto.Size = new System.Drawing.Size(145, 20);
            this.txt_CodProducto.TabIndex = 1;
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Location = new System.Drawing.Point(25, 36);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cuit.TabIndex = 0;
            this.lbl_Cuit.Text = "Codigo";
            // 
            // ProductosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 518);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgr_Productos);
            this.Controls.Add(this.grbx_);
            this.Name = "ProductosMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Productos)).EndInit();
            this.grbx_.ResumeLayout(false);
            this.grbx_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgr_Productos;
        private System.Windows.Forms.GroupBox grbx_;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_CodProducto;
        private System.Windows.Forms.Label lbl_Cuit;
    }
}