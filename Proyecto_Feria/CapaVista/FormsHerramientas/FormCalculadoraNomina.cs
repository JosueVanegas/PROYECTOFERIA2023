using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaDatos;
using static iTextSharp.awt.geom.Point2D;

namespace CapaPresentacion.FormsHerramientas
{
    public partial class FormCalculadoraNomina : Form
    {

        public FormCalculadoraNomina()
        {
            InitializeComponent();
        }

        private void FormCalculadoraNomina_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }
        private void mostrarEmpleados()
        {
            cbxEmpleados.DataSource = new ControlUsuario().listarEmpleados();
        }

        private void cbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEmpleado emp = cbxEmpleados.SelectedItem as comboEmpleado;
            txtSalarioNeto.Text = emp.salario.ToString("0.00");
        }

        private void txtSalarioNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSalarioNeto != null && txtSalarioNeto.Text.Length >= 8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtSalarioNeto_TextChanged(object sender, EventArgs e)
        {
            calcularDeducciones();
        }
        private void calcularDeducciones()
        {
            if (txtSalarioNeto.Text != "")
            {
                decimal salario, INSS, IR, suma = 0, NETO, impuestoBase = 0, porcetajeAplicable = 0, sobreExceso = 0;
                salario = Convert.ToDecimal(txtSalarioNeto.Text);

                INSS = salario * Convert.ToDecimal(0.07);
                suma = salario - INSS;
                suma = suma * 12;

                if ((suma >= Convert.ToDecimal(0.01)) && (suma <= 100000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = 0;
                    sobreExceso = 0;
                }
                else if ((suma > 100000) && (suma <= 200000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = Convert.ToDecimal(0.15);
                    sobreExceso = 100000;
                }
                else if ((suma > 200000) && (suma <= 350000))
                {
                    impuestoBase = 15000;
                    porcetajeAplicable = Convert.ToDecimal(0.20);
                    sobreExceso = 200000;
                }
                else if ((suma > 350000) && (suma <= 500000))
                {
                    impuestoBase = 45000;
                    porcetajeAplicable = Convert.ToDecimal(0.25);
                    sobreExceso = 350000;
                }
                else if (suma > 500000)
                {
                    impuestoBase = 82500;
                    porcetajeAplicable = Convert.ToDecimal(0.30);
                    sobreExceso = 500000;
                }
                suma = suma - sobreExceso;
                suma = suma * porcetajeAplicable;
                suma = suma + impuestoBase;

                IR = suma / 12;
                NETO = salario - (INSS + IR);

                txtInss.Text = INSS.ToString("0.00");
                txtIr.Text = IR.ToString("0.00");
                txtNetoARecibir.Text = NETO.ToString("0.00");
            }
            else
            {
               txtInss.Text = "0.00";
                txtIr.Text = "0.00";
                txtNetoARecibir.Text = "0.00";
            }
        }
    }
}
