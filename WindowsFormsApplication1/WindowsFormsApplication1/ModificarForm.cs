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
    public partial class ModificarForm : Form
    {
        logica log = new logica();
        Form1 formInicio = new Form1();
        public ModificarForm()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            int codigo = 0;

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Error, debes proporcionar un codigo");
            }
            else
            {
                codigo = Convert.ToInt16(txt_codigo.Text);

                datos = log.BuscarCliente(codigo);
                Console.WriteLine(datos.Tables[0].Rows.Count);
                if (datos.Tables[0].Rows.Count == 1)
                {
                    txt_nombre.Show();
                    txt_rfc.Show();
                    txt_calle.Show();
                    txt_numExt.Show();
                    txt_numInt.Show();
                    txt_colonia.Show();
                    txt_poblacion.Show();
                    txt_codigo_Postal.Show();
                    txt_limite_Credito.Show();
                    txt_activo.Show();

                    lbl_nombre.Show();
                    lbl_rfc.Show();
                    lbl_calle.Show();
                    lbl_numExt.Show();
                    lbl_numInt.Show();
                    lbl_colonia.Show();
                    lbl_poblacion.Show();
                    lbl_codigo_Postal.Show();
                    lbl_limite_Credito.Show();
                    lbl_activo.Show();

                    btn_buscar.Enabled = false;
                    btn_modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    btn_limpiar.Enabled = true;
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        txt_nombre.Text = row["nombre"].ToString();
                        txt_rfc.Text = row["rfc"].ToString();
                        txt_calle.Text = row["calle"].ToString();
                        txt_numExt.Text = row["numero_exterior"].ToString();
                        txt_numInt.Text = row["numero_interior"].ToString();
                        txt_colonia.Text = row["colonia"].ToString();
                        txt_poblacion.Text = row["poblacion"].ToString();
                        txt_codigo_Postal.Text = row["codigo_postal"].ToString();
                        txt_limite_Credito.Text = row["limite_credito"].ToString();
                        if (row["activo"].ToString() == "True")
                        {
                            txt_activo.Text = "1";
                        }
                        else
                        {
                            txt_activo.Text = "0";
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Error, el cliente no existe");
                    txt_codigo.Clear();
                    txt_codigo.Focus();
                }
                
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Hide();
            txt_rfc.Hide();
            txt_calle.Hide();
            txt_numExt.Hide();
            txt_numInt.Hide();
            txt_colonia.Hide();
            txt_poblacion.Hide();
            txt_codigo_Postal.Hide();
            txt_limite_Credito.Hide();
            txt_activo.Hide();

            lbl_nombre.Hide();
            lbl_rfc.Hide();
            lbl_calle.Hide();
            lbl_numExt.Hide();
            lbl_numInt.Hide();
            lbl_colonia.Hide();
            lbl_poblacion.Hide();
            lbl_codigo_Postal.Hide();
            lbl_limite_Credito.Hide();
            lbl_activo.Hide();

            txt_nombre.Clear();
            txt_rfc.Clear();
            txt_calle.Clear();
            txt_numExt.Clear();
            txt_numInt.Clear();
            txt_colonia.Clear();
            txt_poblacion.Clear();
            txt_codigo_Postal.Clear();
            txt_limite_Credito.Clear();
            txt_activo.Clear();
            txt_codigo.Clear();

            txt_codigo.Enabled = true;
            btn_buscar.Enabled = true;
            btn_modificar.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string calle = "", colonia = "", nombre = "", poblacion = "", numExterior = "", numInterior = "", rfc = "", codigoPostal = "";
            int codigo = 0;
            double limiteCredito = 0;

            codigo = Convert.ToInt32(txt_codigo.Text);
            nombre = txt_nombre.Text;
            calle = txt_calle.Text;
            colonia = txt_colonia.Text;
            numExterior = txt_numExt.Text;
            numInterior = txt_numInt.Text;
            rfc = txt_rfc.Text;
            codigoPostal = txt_codigo_Postal.Text;
            poblacion = txt_poblacion.Text;
            limiteCredito = Convert.ToDouble(txt_limite_Credito.Text);

            if(log.ModificarCliente(codigo, nombre, calle, colonia, numExterior, numInterior, rfc, codigoPostal, poblacion, limiteCredito))
            {
                Form1 formInicio = new Form1();
                MessageBox.Show("Se modifico el cliente");
                this.Close();
                formInicio.Show();
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Error, debes proporcionar un codigo");
            }
            else
            {
                codigo = Convert.ToInt32(txt_codigo.Text);
                if (log.eliminarCliente(codigo))
                {
                    
                    MessageBox.Show("Se elimino el cliente");
                    this.Close();
                    formInicio.Show();
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el cliente");
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
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