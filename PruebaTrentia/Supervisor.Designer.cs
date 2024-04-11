namespace PruebaTrentia
{
    partial class Supervisor
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.listUsuarios = new System.Windows.Forms.ListView();
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txUsu = new System.Windows.Forms.TextBox();
            this.txContras = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chbEsSupervisor = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbContrasUsu = new System.Windows.Forms.TextBox();
            this.tbUsuarioUsu = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EsSupervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(126, 205);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(111, 23);
            this.btnBaja.TabIndex = 12;
            this.btnBaja.Text = "Baja seleccionado";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supervisor:";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(100, 59);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(357, 20);
            this.tboxNombre.TabIndex = 5;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(100, 33);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(357, 20);
            this.tboxDNI.TabIndex = 4;
            this.tboxDNI.TextChanged += new System.EventHandler(this.tboxDNI_TextChanged);
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(100, 85);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(357, 20);
            this.tboxApellido.TabIndex = 6;
            this.tboxApellido.TextChanged += new System.EventHandler(this.tboxApellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 205);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(108, 23);
            this.btnAlta.TabIndex = 11;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // listUsuarios
            // 
            this.listUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DNI,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Usuario,
            this.Contraseña,
            this.EsSupervisor});
            this.listUsuarios.HideSelection = false;
            this.listUsuarios.Location = new System.Drawing.Point(15, 263);
            this.listUsuarios.MultiSelect = false;
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(442, 287);
            this.listUsuarios.TabIndex = 16;
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.View = System.Windows.Forms.View.Details;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Apellidos";
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(243, 205);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(111, 23);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifica seleccionado";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Enabled = false;
            this.btnBusca.Location = new System.Drawing.Point(360, 205);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(97, 23);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.Text = "Busca*";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(442, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña";
            // 
            // txUsu
            // 
            this.txUsu.Location = new System.Drawing.Point(551, 30);
            this.txUsu.Name = "txUsu";
            this.txUsu.Size = new System.Drawing.Size(96, 20);
            this.txUsu.TabIndex = 1;
            // 
            // txContras
            // 
            this.txContras.Location = new System.Drawing.Point(551, 66);
            this.txContras.Name = "txContras";
            this.txContras.PasswordChar = '*';
            this.txContras.Size = new System.Drawing.Size(96, 20);
            this.txContras.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(488, 109);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chbEsSupervisor
            // 
            this.chbEsSupervisor.AutoSize = true;
            this.chbEsSupervisor.Location = new System.Drawing.Point(12, 182);
            this.chbEsSupervisor.Name = "chbEsSupervisor";
            this.chbEsSupervisor.Size = new System.Drawing.Size(91, 17);
            this.chbEsSupervisor.TabIndex = 10;
            this.chbEsSupervisor.Text = "Es Supervisor";
            this.chbEsSupervisor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Usuario:";
            // 
            // tbContrasUsu
            // 
            this.tbContrasUsu.Location = new System.Drawing.Point(100, 163);
            this.tbContrasUsu.Name = "tbContrasUsu";
            this.tbContrasUsu.Size = new System.Drawing.Size(357, 20);
            this.tbContrasUsu.TabIndex = 9;
            // 
            // tbUsuarioUsu
            // 
            this.tbUsuarioUsu.Location = new System.Drawing.Point(100, 137);
            this.tbUsuarioUsu.Name = "tbUsuarioUsu";
            this.tbUsuarioUsu.Size = new System.Drawing.Size(357, 20);
            this.tbUsuarioUsu.TabIndex = 8;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(100, 111);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(357, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Dirección:";
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.Text = "Contraseña";
            // 
            // EsSupervisor
            // 
            this.EsSupervisor.Text = "EsSupervisor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "*Busca funciona solo con Nombre, Apellido y DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Se accede con admin admin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Con más tiempo puedo comprobar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "las contraseñas (encriptadas con hash)";
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 563);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbUsuarioUsu);
            this.Controls.Add(this.tbContrasUsu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chbEsSupervisor);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txContras);
            this.Controls.Add(this.txUsu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaja);
            this.Name = "Supervisor";
            this.Text = "Supervisor";
            this.Load += new System.EventHandler(this.Supervisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListView listUsuarios;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txUsu;
        private System.Windows.Forms.TextBox txContras;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chbEsSupervisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbContrasUsu;
        private System.Windows.Forms.TextBox tbUsuarioUsu;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Contraseña;
        private System.Windows.Forms.ColumnHeader EsSupervisor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

