using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cls_logica;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        logica log = new logica();
        public Form1()
        {
            InitializeComponent();
            txt_codigo.Text = "1";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_calle.Text == "" || txt_codigo_Postal.Text == "" || txt_colonia.Text == ""
                || txt_limite_Credito.Text == "" || txt_nombre.Text == "" || txt_numExt.Text == "" || txt_numInt.Text == ""
                || txt_poblacion.Text == "" || txt_rfc.Text == "")
            {
                MessageBox.Show("Error, faltan campos por llenar, Favor de llenar y volver a intentarlo");
            }
            else
            {
                string calle = "", colonia = "", nombre = "", poblacion = "", numExterior = "", numInterior = "", rfc = "", codigoPostal = "", fechaRegistro = "";
                int codigo = 0;
                int limiteCredito = 0, sumCodigo = 0;

                codigo = Convert.ToInt32(txt_codigo.Text);
                nombre = txt_nombre.Text;
                calle = txt_calle.Text;
                colonia = txt_colonia.Text;
                numExterior = txt_numExt.Text;
                numInterior = txt_numInt.Text;
                rfc = txt_rfc.Text;
                codigoPostal = txt_codigo_Postal.Text;
                poblacion = txt_poblacion.Text;
                limiteCredito = Convert.ToInt32(txt_limite_Credito.Text);
                fechaRegistro = "10/11/2020";
                sumCodigo = (codigo + 1);


                if (log.AgregarCliente(codigo, nombre, calle, colonia, numExterior, numInterior, rfc, codigoPostal, fechaRegistro, poblacion, limiteCredito))
                {
                    MessageBox.Show("Usuario Agregado con Exito");
                    sumCodigo = (codigo + 1);
                    txt_codigo.Text = sumCodigo.ToString();
                    txt_nombre.Clear();
                    txt_rfc.Clear();
                    txt_calle.Clear();
                    txt_numExt.Clear();
                    txt_numInt.Clear();
                    txt_colonia.Clear();
                    txt_poblacion.Clear();
                    txt_codigo_Postal.Clear();
                    txt_limite_Credito.Clear();
                    dgv_empleados.Rows.Clear();
                    obtenerEmpleados();
                }
                else
                { 
                    MessageBox.Show("Ocurrio Elgún Error al Intentar Agregar al Usuario");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ultimoCodigo = new DataSet();

            obtenerEmpleados();
            ultimoCodigo = log.ultimoCodigo();
            foreach (DataRow row in ultimoCodigo.Tables[0].Rows)
            {
                int codigo = Convert.ToInt16(row["codigo"]);
                txt_codigo.Text = (codigo + 1).ToString();
            }
            
        }

        public DataSet obtenerEmpleados()
        {
            DataSet datos = new DataSet();

            datos = log.obtenerClientes();
            foreach (DataRow row in datos.Tables[0].Rows)
            {
                dgv_empleados.Rows.Add(row["codigo"].ToString(),
                                         row["nombre"].ToString(),
                                         row["rfc"].ToString(),
                                         row["calle"].ToString(),
                                         row["numero_exterior"].ToString(),
                                         row["numero_interior"].ToString(),
                                         row["colonia"].ToString(),
                                         row["poblacion"].ToString(),
                                         row["codigo_postal"].ToString(),
                                         row["fecha_alta"].ToString(),
                                         row["limite_credito"].ToString(),
                                         row["activo"].ToString());
            }
            return datos;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarForm modificarForm = new ModificarForm();

            modificarForm.Show();
            this.Hide();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_rfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_numExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_numInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_poblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_codigo_Postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_limite_Credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}