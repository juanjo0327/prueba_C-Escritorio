namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_exterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_interior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_numExt = new System.Windows.Forms.Label();
            this.lbl_numInt = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_numExt = new System.Windows.Forms.TextBox();
            this.txt_numInt = new System.Windows.Forms.TextBox();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.lbl_poblacion = new System.Windows.Forms.Label();
            this.lbl_codigo_Postal = new System.Windows.Forms.Label();
            this.lbl_limite_Credito = new System.Windows.Forms.Label();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_poblacion = new System.Windows.Forms.TextBox();
            this.txt_codigo_Postal = new System.Windows.Forms.TextBox();
            this.txt_limite_Credito = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.rfc,
            this.calle,
            this.numero_exterior,
            this.numero_interior,
            this.colonia,
            this.poblacion,
            this.codigo_postal,
            this.fecha_alta,
            this.limite_credito,
            this.activo});
            this.dgv_empleados.Location = new System.Drawing.Point(158, 420);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowTemplate.Height = 28;
            this.dgv_empleados.Size = new System.Drawing.Size(1247, 276);
            this.dgv_empleados.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // rfc
            // 
            this.rfc.HeaderText = "rfc";
            this.rfc.Name = "rfc";
            // 
            // calle
            // 
            this.calle.HeaderText = "calle";
            this.calle.Name = "calle";
            // 
            // numero_exterior
            // 
            this.numero_exterior.HeaderText = "numero_exterior";
            this.numero_exterior.Name = "numero_exterior";
            // 
            // numero_interior
            // 
            this.numero_interior.HeaderText = "numero_interior";
            this.numero_interior.Name = "numero_interior";
            // 
            // colonia
            // 
            this.colonia.HeaderText = "colonia";
            this.colonia.Name = "colonia";
            // 
            // poblacion
            // 
            this.poblacion.HeaderText = "poblacion";
            this.poblacion.Name = "poblacion";
            // 
            // codigo_postal
            // 
            this.codigo_postal.HeaderText = "codigo_postal";
            this.codigo_postal.Name = "codigo_postal";
            // 
            // fecha_alta
            // 
            this.fecha_alta.HeaderText = "fecha_alta";
            this.fecha_alta.Name = "fecha_alta";
            // 
            // limite_credito
            // 
            this.limite_credito.HeaderText = "limite_credito";
            this.limite_credito.Name = "limite_credito";
            // 
            // activo
            // 
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(154, 90);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(60, 20);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "codigo:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(324, 84);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(183, 26);
            this.txt_codigo.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(154, 141);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "nombre:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(154, 204);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(31, 20);
            this.lbl_rfc.TabIndex = 4;
            this.lbl_rfc.Text = "rfc:";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(154, 256);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(45, 20);
            this.lbl_calle.TabIndex = 5;
            this.lbl_calle.Text = "calle:";
            // 
            // lbl_numExt
            // 
            this.lbl_numExt.AutoSize = true;
            this.lbl_numExt.Location = new System.Drawing.Point(154, 313);
            this.lbl_numExt.Name = "lbl_numExt";
            this.lbl_numExt.Size = new System.Drawing.Size(130, 20);
            this.lbl_numExt.TabIndex = 6;
            this.lbl_numExt.Text = "numero_Exterior:";
            // 
            // lbl_numInt
            // 
            this.lbl_numInt.AutoSize = true;
            this.lbl_numInt.Location = new System.Drawing.Point(154, 366);
            this.lbl_numInt.Name = "lbl_numInt";
            this.lbl_numInt.Size = new System.Drawing.Size(126, 20);
            this.lbl_numInt.TabIndex = 7;
            this.lbl_numInt.Text = "numero_Interior:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(324, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(183, 26);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(324, 198);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(183, 26);
            this.txt_rfc.TabIndex = 9;
            this.txt_rfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rfc_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(324, 250);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(183, 26);
            this.txt_calle.TabIndex = 10;
            this.txt_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // txt_numExt
            // 
            this.txt_numExt.Location = new System.Drawing.Point(324, 307);
            this.txt_numExt.Name = "txt_numExt";
            this.txt_numExt.Size = new System.Drawing.Size(183, 26);
            this.txt_numExt.TabIndex = 11;
            this.txt_numExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numExt_KeyPress);
            // 
            // txt_numInt
            // 
            this.txt_numInt.Location = new System.Drawing.Point(324, 360);
            this.txt_numInt.Name = "txt_numInt";
            this.txt_numInt.Size = new System.Drawing.Size(183, 26);
            this.txt_numInt.TabIndex = 12;
            this.txt_numInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numInt_KeyPress);
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(699, 90);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(63, 20);
            this.lbl_colonia.TabIndex = 13;
            this.lbl_colonia.Text = "colonia:";
            // 
            // lbl_poblacion
            // 
            this.lbl_poblacion.AutoSize = true;
            this.lbl_poblacion.Location = new System.Drawing.Point(699, 141);
            this.lbl_poblacion.Name = "lbl_poblacion";
            this.lbl_poblacion.Size = new System.Drawing.Size(81, 20);
            this.lbl_poblacion.TabIndex = 14;
            this.lbl_poblacion.Text = "poblacion:";
            // 
            // lbl_codigo_Postal
            // 
            this.lbl_codigo_Postal.AutoSize = true;
            this.lbl_codigo_Postal.Location = new System.Drawing.Point(699, 204);
            this.lbl_codigo_Postal.Name = "lbl_codigo_Postal";
            this.lbl_codigo_Postal.Size = new System.Drawing.Size(113, 20);
            this.lbl_codigo_Postal.TabIndex = 15;
            this.lbl_codigo_Postal.Text = "codigo_Postal:";
            // 
            // lbl_limite_Credito
            // 
            this.lbl_limite_Credito.AutoSize = true;
            this.lbl_limite_Credito.Location = new System.Drawing.Point(699, 256);
            this.lbl_limite_Credito.Name = "lbl_limite_Credito";
            this.lbl_limite_Credito.Size = new System.Drawing.Size(109, 20);
            this.lbl_limite_Credito.TabIndex = 16;
            this.lbl_limite_Credito.Text = "limite_Credito:";
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(851, 84);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(157, 26);
            this.txt_colonia.TabIndex = 18;
            this.txt_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_colonia_KeyPress);
            // 
            // txt_poblacion
            // 
            this.txt_poblacion.Location = new System.Drawing.Point(851, 135);
            this.txt_poblacion.Name = "txt_poblacion";
            this.txt_poblacion.Size = new System.Drawing.Size(157, 26);
            this.txt_poblacion.TabIndex = 19;
            this.txt_poblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poblacion_KeyPress);
            // 
            // txt_codigo_Postal
            // 
            this.txt_codigo_Postal.Location = new System.Drawing.Point(851, 198);
            this.txt_codigo_Postal.Name = "txt_codigo_Postal";
            this.txt_codigo_Postal.Size = new System.Drawing.Size(157, 26);
            this.txt_codigo_Postal.TabIndex = 20;
            this.txt_codigo_Postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_Postal_KeyPress);
            // 
            // txt_limite_Credito
            // 
            this.txt_limite_Credito.Location = new System.Drawing.Point(851, 250);
            this.txt_limite_Credito.Name = "txt_limite_Credito";
            this.txt_limite_Credito.Size = new System.Drawing.Size(157, 26);
            this.txt_limite_Credito.TabIndex = 21;
            this.txt_limite_Credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limite_Credito_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar.Location = new System.Drawing.Point(1103, 90);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(122, 47);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_modificar.Location = new System.Drawing.Point(1103, 204);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(122, 60);
            this.btn_modificar.TabIndex = 24;
            this.btn_modificar.Text = "Modificar o Eliminar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 837);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_limite_Credito);
            this.Controls.Add(this.txt_codigo_Postal);
            this.Controls.Add(this.txt_poblacion);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(this.lbl_limite_Credito);
            this.Controls.Add(this.lbl_codigo_Postal);
            this.Controls.Add(this.lbl_poblacion);
            this.Controls.Add(this.lbl_colonia);
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
            this.Controls.Add(this.dgv_empleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_exterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_interior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_numExt;
        private System.Windows.Forms.Label lbl_numInt;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_numExt;
        private System.Windows.Forms.TextBox txt_numInt;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.Label lbl_poblacion;
        private System.Windows.Forms.Label lbl_codigo_Postal;
        private System.Windows.Forms.Label lbl_limite_Credito;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_poblacion;
        private System.Windows.Forms.TextBox txt_codigo_Postal;
        private System.Windows.Forms.TextBox txt_limite_Credito;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
    }
}

