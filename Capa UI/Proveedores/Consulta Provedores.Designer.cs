namespace TP_PAV_1._0.Capa_UI.Proveedores
{
    partial class MainProveedores
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
            this.dgr_Proveedores = new System.Windows.Forms.DataGridView();
            this.grbx_ = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RzSocial = new System.Windows.Forms.TextBox();
            this.txt_Cuit = new System.Windows.Forms.TextBox();
            this.lbl_Cuit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Proveedores)).BeginInit();
            this.grbx_.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(278, 361);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(95, 23);
            this.btn_Baja.TabIndex = 16;
            this.btn_Baja.Text = "Dar de Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(32, 362);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(110, 23);
            this.btn_Alta.TabIndex = 15;
            this.btn_Alta.Text = "Agregar Provedor";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(148, 362);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(124, 23);
            this.btn_Modificar.TabIndex = 13;
            this.btn_Modificar.Text = "Modificar Provedor";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(528, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 24);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgr_Proveedores
            // 
            this.dgr_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Proveedores.Location = new System.Drawing.Point(32, 182);
            this.dgr_Proveedores.Name = "dgr_Proveedores";
            this.dgr_Proveedores.Size = new System.Drawing.Size(616, 150);
            this.dgr_Proveedores.TabIndex = 12;
            // 
            // grbx_
            // 
            this.grbx_.Controls.Add(this.btnConsultar);
            this.grbx_.Controls.Add(this.label2);
            this.grbx_.Controls.Add(this.txt_RzSocial);
            this.grbx_.Controls.Add(this.txt_Cuit);
            this.grbx_.Controls.Add(this.lbl_Cuit);
            this.grbx_.Location = new System.Drawing.Point(32, 18);
            this.grbx_.Name = "grbx_";
            this.grbx_.Size = new System.Drawing.Size(616, 143);
            this.grbx_.TabIndex = 11;
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
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razon Social";
            // 
            // txt_RzSocial
            // 
            this.txt_RzSocial.Location = new System.Drawing.Point(101, 56);
            this.txt_RzSocial.Name = "txt_RzSocial";
            this.txt_RzSocial.Size = new System.Drawing.Size(145, 20);
            this.txt_RzSocial.TabIndex = 2;
            // 
            // txt_Cuit
            // 
            this.txt_Cuit.Location = new System.Drawing.Point(101, 33);
            this.txt_Cuit.Name = "txt_Cuit";
            this.txt_Cuit.Size = new System.Drawing.Size(145, 20);
            this.txt_Cuit.TabIndex = 1;
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Location = new System.Drawing.Point(25, 33);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(25, 13);
            this.lbl_Cuit.TabIndex = 0;
            this.lbl_Cuit.Text = "Cuit";
            // 
            // MainProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgr_Proveedores);
            this.Controls.Add(this.grbx_);
            this.Name = "MainProveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Proveedores)).EndInit();
            this.grbx_.ResumeLayout(false);
            this.grbx_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgr_Proveedores;
        private System.Windows.Forms.GroupBox grbx_;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RzSocial;
        private System.Windows.Forms.TextBox txt_Cuit;
        private System.Windows.Forms.Label lbl_Cuit;
    }
}