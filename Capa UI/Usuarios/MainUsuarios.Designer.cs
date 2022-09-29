namespace TP_PAV_1._0.Capa_UI.Usuarios
{
    partial class MainUsuarios
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
            this.grbx_ = new System.Windows.Forms.GroupBox();
            this.cmb_Perfil = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Cuit = new System.Windows.Forms.Label();
            this.dgr_Usuarios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.grbx_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_
            // 
            this.grbx_.Controls.Add(this.cmb_Perfil);
            this.grbx_.Controls.Add(this.btnConsultar);
            this.grbx_.Controls.Add(this.lbl_Perfil);
            this.grbx_.Controls.Add(this.txt_Nombre);
            this.grbx_.Controls.Add(this.lbl_Cuit);
            this.grbx_.Location = new System.Drawing.Point(43, 27);
            this.grbx_.Name = "grbx_";
            this.grbx_.Size = new System.Drawing.Size(616, 143);
            this.grbx_.TabIndex = 0;
            this.grbx_.TabStop = false;
            this.grbx_.Text = "Filtros de Usuarios";
            // 
            // cmb_Perfil
            // 
            this.cmb_Perfil.FormattingEnabled = true;
            this.cmb_Perfil.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.cmb_Perfil.Location = new System.Drawing.Point(101, 59);
            this.cmb_Perfil.Name = "cmb_Perfil";
            this.cmb_Perfil.Size = new System.Drawing.Size(145, 21);
            this.cmb_Perfil.TabIndex = 8;
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
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Location = new System.Drawing.Point(25, 59);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(30, 13);
            this.lbl_Perfil.TabIndex = 3;
            this.lbl_Perfil.Text = "Perfil";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(101, 30);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(145, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Location = new System.Drawing.Point(25, 33);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(44, 13);
            this.lbl_Cuit.TabIndex = 0;
            this.lbl_Cuit.Text = "Nombre";
            // 
            // dgr_Usuarios
            // 
            this.dgr_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Usuarios.Location = new System.Drawing.Point(43, 191);
            this.dgr_Usuarios.Name = "dgr_Usuarios";
            this.dgr_Usuarios.Size = new System.Drawing.Size(616, 150);
            this.dgr_Usuarios.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 24);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(159, 371);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(95, 23);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "Modificar Usuario";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(43, 371);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(110, 23);
            this.btn_Alta.TabIndex = 9;
            this.btn_Alta.Text = "Agregar Usuario";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(260, 371);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(95, 23);
            this.btn_Baja.TabIndex = 10;
            this.btn_Baja.Text = "Dar de Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // MainUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 418);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgr_Usuarios);
            this.Controls.Add(this.grbx_);
            this.Name = "MainUsuarios";
            this.Text = "Usuarios";
            this.grbx_.ResumeLayout(false);
            this.grbx_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_;
        private System.Windows.Forms.Label lbl_Cuit;
        private System.Windows.Forms.Label lbl_Perfil;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgr_Usuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.ComboBox cmb_Perfil;
    }
}