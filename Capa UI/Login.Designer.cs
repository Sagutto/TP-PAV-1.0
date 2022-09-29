namespace TP_PAV_1._0
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login_Aceptar = new System.Windows.Forms.Button();
            this.txt_Login_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login_Salir = new System.Windows.Forms.Button();
            this.txt_Login_Contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_testConection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login_Aceptar
            // 
            this.btn_Login_Aceptar.Location = new System.Drawing.Point(39, 145);
            this.btn_Login_Aceptar.Name = "btn_Login_Aceptar";
            this.btn_Login_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Login_Aceptar.TabIndex = 0;
            this.btn_Login_Aceptar.Text = "Aceptar";
            this.btn_Login_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Login_Aceptar.Click += new System.EventHandler(this.btn_Login_Aceptar_Click);
            // 
            // txt_Login_User
            // 
            this.txt_Login_User.Location = new System.Drawing.Point(103, 68);
            this.txt_Login_User.Name = "txt_Login_User";
            this.txt_Login_User.Size = new System.Drawing.Size(132, 20);
            this.txt_Login_User.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // btn_Login_Salir
            // 
            this.btn_Login_Salir.Location = new System.Drawing.Point(132, 145);
            this.btn_Login_Salir.Name = "btn_Login_Salir";
            this.btn_Login_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Login_Salir.TabIndex = 3;
            this.btn_Login_Salir.Text = "Salir";
            this.btn_Login_Salir.UseVisualStyleBackColor = true;
            this.btn_Login_Salir.Click += new System.EventHandler(this.btn_Login_Salir_Click);
            // 
            // txt_Login_Contraseña
            // 
            this.txt_Login_Contraseña.Location = new System.Drawing.Point(103, 104);
            this.txt_Login_Contraseña.Name = "txt_Login_Contraseña";
            this.txt_Login_Contraseña.PasswordChar = '*';
            this.txt_Login_Contraseña.Size = new System.Drawing.Size(132, 20);
            this.txt_Login_Contraseña.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio de Sesión";
            // 
            // btn_testConection
            // 
            this.btn_testConection.Location = new System.Drawing.Point(244, 142);
            this.btn_testConection.Name = "btn_testConection";
            this.btn_testConection.Size = new System.Drawing.Size(59, 26);
            this.btn_testConection.TabIndex = 7;
            this.btn_testConection.Text = "button1";
            this.btn_testConection.UseVisualStyleBackColor = true;
            this.btn_testConection.Click += new System.EventHandler(this.btn_testConection_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 194);
            this.Controls.Add(this.btn_testConection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Login_Contraseña);
            this.Controls.Add(this.btn_Login_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Login_User);
            this.Controls.Add(this.btn_Login_Aceptar);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login_Aceptar;
        private System.Windows.Forms.TextBox txt_Login_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login_Salir;
        private System.Windows.Forms.TextBox txt_Login_Contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_testConection;
    }
}

