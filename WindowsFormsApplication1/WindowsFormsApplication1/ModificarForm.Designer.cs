namespace WindowsFormsApplication1
{
    partial class ModificarForm
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
            this.txt_numInt = new System.Windows.Forms.TextBox();
            this.txt_numExt = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_numInt = new System.Windows.Forms.Label();
            this.lbl_numExt = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_limite_Credito = new System.Windows.Forms.TextBox();
            this.txt_codigo_Postal = new System.Windows.Forms.TextBox();
            this.txt_poblacion = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.lbl_limite_Credito = new System.Windows.Forms.Label();
            this.lbl_codigo_Postal = new System.Windows.Forms.Label();
            this.lbl_poblacion = new System.Windows.Forms.Label();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.txt_activo = new System.Windows.Forms.TextBox();
            this.lbl_activo = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numInt
            // 
            this.txt_numInt.Location = new System.Drawing.Point(274, 318);
            this.txt_numInt.Name = "txt_numInt";
            this.txt_numInt.Size = new System.Drawing.Size(183, 26);
            this.txt_numInt.TabIndex = 24;
            this.txt_numInt.Visible = false;
            this.txt_numInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numInt_KeyPress);
            // 
            // txt_numExt
            // 
            this.txt_numExt.Location = new System.Drawing.Point(274, 265);
            this.txt_numExt.Name = "txt_numExt";
            this.txt_numExt.Size = new System.Drawing.Size(183, 26);
            this.txt_numExt.TabIndex = 23;
            this.txt_numExt.Visible = false;
            this.txt_numExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numExt_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(274, 208);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(183, 26);
            this.txt_calle.TabIndex = 22;
            this.txt_calle.Visible = false;
            this.txt_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(274, 156);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(183, 26);
            this.txt_rfc.TabIndex = 21;
            this.txt_rfc.Visible = false;
            this.txt_rfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rfc_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(274, 93);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(183, 26);
            this.txt_nombre.TabIndex = 20;
            this.txt_nombre.Visible = false;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_numInt
            // 
            this.lbl_numInt.AutoSize = true;
            this.lbl_numInt.Location = new System.Drawing.Point(104, 324);
            this.lbl_numInt.Name = "lbl_numInt";
            this.lbl_numInt.Size = new System.Drawing.Size(126, 20);
            this.lbl_numInt.TabIndex = 19;
            this.lbl_numInt.Text = "numero_Interior:";
            this.lbl_numInt.Visible = false;
            // 
            // lbl_numExt
            // 
            this.lbl_numExt.AutoSize = true;
            this.lbl_numExt.Location = new System.Drawing.Point(104, 271);
            this.lbl_numExt.Name = "lbl_numExt";
            this.lbl_numExt.Size = new System.Drawing.Size(130, 20);
            this.lbl_numExt.TabIndex = 18;
            this.lbl_numExt.Text = "numero_Exterior:";
            this.lbl_numExt.Visible = false;
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(104, 214);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(45, 20);
            this.lbl_calle.TabIndex = 17;
            this.lbl_calle.Text = "calle:";
            this.lbl_calle.Visible = false;
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(104, 162);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(31, 20);
            this.lbl_rfc.TabIndex = 16;
            this.lbl_rfc.Text = "rfc:";
            this.lbl_rfc.Visible = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(104, 99);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_nombre.TabIndex = 15;
            this.lbl_nombre.Text = "nombre:";
            this.lbl_nombre.Visible = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(274, 42);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(183, 26);
            this.txt_codigo.TabIndex = 14;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(104, 48);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(114, 20);
            this.lbl_codigo.TabIndex = 13;
            this.lbl_codigo.Text = "Buscar codigo:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_buscar.Location = new System.Drawing.Point(927, 73);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(132, 46);
            this.btn_buscar.TabIndex = 25;
            this.btn_buscar.Text = "Buscar Usuario";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(927, 146);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(132, 46);
            this.btn_modificar.TabIndex = 26;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_limite_Credito
            // 
            this.txt_limite_Credito.Location = new System.Drawing.Point(684, 259);
            this.txt_limite_Credito.Name = "txt_limite_Credito";
            this.txt_limite_Credito.Size = new System.Drawing.Size(157, 26);
            this.txt_limite_Credito.TabIndex = 34;
            this.txt_limite_Credito.Visible = false;
            this.txt_limite_Credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limite_Credito_KeyPress);
            // 
            // txt_codigo_Postal
            // 
            this.txt_codigo_Postal.Location = new System.Drawing.Point(684, 207);
            this.txt_codigo_Postal.Name = "txt_codigo_Postal";
            this.txt_codigo_Postal.Size = new System.Drawing.Size(157, 26);
            this.txt_codigo_Postal.TabIndex = 33;
            this.txt_codigo_Postal.Visible = false;
            this.txt_codigo_Postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_Postal_KeyPress);
            // 
            // txt_poblacion
            // 
            this.txt_poblacion.Location = new System.Drawing.Point(684, 144);
            this.txt_poblacion.Name = "txt_poblacion";
            this.txt_poblacion.Size = new System.Drawing.Size(157, 26);
            this.txt_poblacion.TabIndex = 32;
            this.txt_poblacion.Visible = false;
            this.txt_poblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poblacion_KeyPress);
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(684, 93);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(157, 26);
            this.txt_colonia.TabIndex = 31;
            this.txt_colonia.Visible = false;
            this.txt_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_colonia_KeyPress);
            // 
            // lbl_limite_Credito
            // 
            this.lbl_limite_Credito.AutoSize = true;
            this.lbl_limite_Credito.Location = new System.Drawing.Point(532, 265);
            this.lbl_limite_Credito.Name = "lbl_limite_Credito";
            this.lbl_limite_Credito.Size = new System.Drawing.Size(109, 20);
            this.lbl_limite_Credito.TabIndex = 30;
            this.lbl_limite_Credito.Text = "limite_Credito:";
            this.lbl_limite_Credito.Visible = false;
            // 
            // lbl_codigo_Postal
            // 
            this.lbl_codigo_Postal.AutoSize = true;
            this.lbl_codigo_Postal.Location = new System.Drawing.Point(532, 213);
            this.lbl_codigo_Postal.Name = "lbl_codigo_Postal";
            this.lbl_codigo_Postal.Size = new System.Drawing.Size(113, 20);
            this.lbl_codigo_Postal.TabIndex = 29;
            this.lbl_codigo_Postal.Text = "codigo_Postal:";
            this.lbl_codigo_Postal.Visible = false;
            // 
            // lbl_poblacion
            // 
            this.lbl_poblacion.AutoSize = true;
            this.lbl_poblacion.Location = new System.Drawing.Point(532, 150);
            this.lbl_poblacion.Name = "lbl_poblacion";
            this.lbl_poblacion.Size = new System.Drawing.Size(81, 20);
            this.lbl_poblacion.TabIndex = 28;
            this.lbl_poblacion.Text = "poblacion:";
            this.lbl_poblacion.Visible = false;
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(532, 99);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(63, 20);
            this.lbl_colonia.TabIndex = 27;
            this.lbl_colonia.Text = "colonia:";
            this.lbl_colonia.Visible = false;
            // 
            // txt_activo
            // 
            this.txt_activo.Enabled = false;
            this.txt_activo.Location = new System.Drawing.Point(684, 318);
            this.txt_activo.Name = "txt_activo";
            this.txt_activo.Size = new System.Drawing.Size(157, 26);
            this.txt_activo.TabIndex = 36;
            this.txt_activo.Visible = false;
            // 
            // lbl_activo
            // 
            this.lbl_activo.AutoSize = true;
            this.lbl_activo.Location = new System.Drawing.Point(532, 324);
            this.lbl_activo.Name = "lbl_activo";
            this.lbl_activo.Size = new System.Drawing.Size(56, 20);
            this.lbl_activo.TabIndex = 35;
            this.lbl_activo.Text = "Activo:";
            this.lbl_activo.Visible = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_limpiar.Location = new System.Drawing.Point(927, 298);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(132, 46);
            this.btn_limpiar.TabIndex = 37;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(927, 223);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(132, 46);
            this.btn_Eliminar.TabIndex = 38;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_regresar.Location = new System.Drawing.Point(927, 376);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(132, 46);
            this.btn_regresar.TabIndex = 39;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // ModificarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 630);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_activo);
            this.Controls.Add(this.lbl_activo);
            this.Controls.Add(this.txt_limite_Credito);
            this.Controls.Add(this.txt_codigo_Postal);
            this.Controls.Add(this.txt_poblacion);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(this.lbl_limite_Credito);
            this.Controls.Add(this.lbl_codigo_Postal);
            this.Controls.Add(this.lbl_poblacion);
            this.Controls.Add(this.lbl_colonia);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_numInt);
            this.Controls.Add(this.txt_numExt);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_numInt);
            this.Controls.Add(this.lbl_numExt);
            this.Controls.Add(this.lbl_calle);
            this.Controls.Add(this.lbl_rfc);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "ModificarForm";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numInt;
        private System.Windows.Forms.TextBox txt_numExt;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_numInt;
        private System.Windows.Forms.Label lbl_numExt;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_limite_Credito;
        private System.Windows.Forms.TextBox txt_codigo_Postal;
        private System.Windows.Forms.TextBox txt_poblacion;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.Label lbl_limite_Credito;
        private System.Windows.Forms.Label lbl_codigo_Postal;
        private System.Windows.Forms.Label lbl_poblacion;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.TextBox txt_activo;
        private System.Windows.Forms.Label lbl_activo;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_regresar;
    }
}