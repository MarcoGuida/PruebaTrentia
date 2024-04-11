namespace Usuario
{
    partial class Peticion
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
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.cbPeticion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lvPetAnt = new System.Windows.Forms.Label();
            this.lvPeticionesAnt = new System.Windows.Forms.ListView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peticion_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(12, 25);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(157, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(9, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            // 
            // cbPeticion
            // 
            this.cbPeticion.Enabled = false;
            this.cbPeticion.Location = new System.Drawing.Point(12, 65);
            this.cbPeticion.Name = "cbPeticion";
            this.cbPeticion.Size = new System.Drawing.Size(776, 171);
            this.cbPeticion.TabIndex = 2;
            this.cbPeticion.Text = "";
            this.cbPeticion.TextChanged += new System.EventHandler(this.cbPeticion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Petición:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(12, 242);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(776, 45);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lvPetAnt
            // 
            this.lvPetAnt.AutoSize = true;
            this.lvPetAnt.Location = new System.Drawing.Point(12, 300);
            this.lvPetAnt.Name = "lvPetAnt";
            this.lvPetAnt.Size = new System.Drawing.Size(108, 13);
            this.lvPetAnt.TabIndex = 6;
            this.lvPetAnt.Text = "Peticiones anteriores:";
            // 
            // lvPeticionesAnt
            // 
            this.lvPeticionesAnt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeStamp,
            this.Peticion_});
            this.lvPeticionesAnt.HideSelection = false;
            this.lvPeticionesAnt.Location = new System.Drawing.Point(15, 316);
            this.lvPeticionesAnt.MultiSelect = false;
            this.lvPeticionesAnt.Name = "lvPeticionesAnt";
            this.lvPeticionesAnt.Size = new System.Drawing.Size(773, 263);
            this.lvPeticionesAnt.TabIndex = 7;
            this.lvPeticionesAnt.UseCompatibleStateImageBehavior = false;
            this.lvPeticionesAnt.View = System.Windows.Forms.View.Details;
            this.lvPeticionesAnt.SelectedIndexChanged += new System.EventHandler(this.lvPeticionesAnt_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(15, 585);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(773, 45);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borra Peticion";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "TimeStamp";
            this.TimeStamp.Width = 100;
            // 
            // Peticion_
            // 
            this.Peticion_.Text = "Peticion_";
            this.Peticion_.Width = 667;
            // 
            // Peticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lvPeticionesAnt);
            this.Controls.Add(this.lvPetAnt);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeticion);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "Peticion";
            this.Text = "Petición de material";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.RichTextBox cbPeticion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lvPetAnt;
        private System.Windows.Forms.ListView lvPeticionesAnt;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ColumnHeader TimeStamp;
        private System.Windows.Forms.ColumnHeader Peticion_;
    }
}

