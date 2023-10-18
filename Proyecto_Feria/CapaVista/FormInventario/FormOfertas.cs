using CapaControlador;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormInventario
{
    public partial class FormOfertas : Form
    {
        ControlOferta cOfertas = new ControlOferta();
        bool estado = true;
        public FormOfertas()
        {
            InitializeComponent();
        }
        private void FormOfertas_Load(object sender, EventArgs e)
        {
            mostrarOfertas();
            mostrarProductos();
            dtInicio.Value = DateTime.Now;
            dtFinal.MinDate = dtInicio.Value;
        }
        private void mostrarProductos()
        {
            cbxProductos.DataSource = new ControlProducto().listarProductos();
        }
        private void mostrarOfertas()
        {
            List<Modelos.Ofertas> lista = cOfertas.listarOfertas();
            tbOfertas.Rows.Clear();
            foreach (Modelos.Ofertas i in lista)
            {
                tbOfertas.Rows.Add("", "", i.DESCRIPCION, i.ID, i.PRODUCTO.NOMBRE, i.CANTIDAD, i.PORCENTAJE_DESCUENTO,
                    i.ESTADO, i.FECHA_INICIO, i.FECHA_FIN, i.FECHA_REGISTRO);
            }
        }

        private void limpiarCampos()
        {

        }
        private void eliminarOferta(int id)
        {

            if (MessageBox.Show("esta seguro de eliminar la oferta seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cOfertas.eliminar(id));
                limpiarCampos();
                mostrarOfertas();
            }
        }
        private void ckActiva_CheckedChanged(object sender, EventArgs e)
        {
            if (ckActiva.Checked)
            {
                ckInactiva.Checked = false;
            }
            else
            {
                ckInactiva.Checked = true;
            }
        }

        private void ckInactiva_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInactiva.Checked)
            {
                ckActiva.Checked = false;
            }
            else
            {
                ckActiva.Checked = true;
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFinal.MinDate = dtInicio.Value;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    if (ckInactiva.Checked == true && ckActiva.Checked == false)
                    {
                        estado = false;
                    }
                    else if (ckActiva.Checked == true && ckInactiva.Checked == false)
                    {
                        estado = true;
                    }
                    Modelos.Ofertas oferta = new Modelos.Ofertas
                    {
                        ID = Convert.ToInt32(txtIdOferta.Text),
                        DESCRIPCION = txtDescripcion.Text,
                        PRODUCTO = cbxProductos.SelectedItem as Modelos.Producto,
                        CANTIDAD = Convert.ToInt32(nbCantidad.ValueNumber),
                        PORCENTAJE_DESCUENTO = Convert.ToInt32(nbDescuento.ValueNumber),
                        ESTADO = estado,
                        FECHA_INICIO = dtInicio.Value,
                        FECHA_FIN = dtFinal.Value
                    };
                    MessageBox.Show(cOfertas.registrar(oferta));
                    mostrarOfertas();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Primero ingrese todos los datos de la oferta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validarCampos()
        {
            if (txtDescripcion.Text != "" && Producto != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void tbOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbOfertas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (indice >= 0)
                {
                    txtIdOferta.Text = tbOfertas.Rows[indice].Cells["Id"].Value.ToString();
                    txtDescripcion.Text = tbOfertas.Rows[indice].Cells["Descripcion"].Value.ToString();
                    string producto = tbOfertas.Rows[indice].Cells["Producto"].Value.ToString();
                    for (int i = 0; i < cbxProductos.Items.Count; i++)
                    {
                        Modelos.Producto combo = cbxProductos.Items[i] as Modelos.Producto;
                        if (combo != null && combo.NOMBRE == producto)
                        {
                            cbxProductos.SelectedIndex = i;
                            break;
                        }
                    }
                    dtInicio.Value = Convert.ToDateTime(tbOfertas.Rows[indice].Cells["Inicio"].Value.ToString());
                    dtFinal.Value = Convert.ToDateTime(tbOfertas.Rows[indice].Cells["Final"].Value.ToString());
                    nbCantidad.ValueNumber = Convert.ToInt32(tbOfertas.Rows[indice].Cells["Cantidad"].Value.ToString());
                    nbDescuento.ValueNumber = Convert.ToInt32(tbOfertas.Rows[indice].Cells["Descuento"].Value.ToString());
                    estado = Convert.ToBoolean(tbOfertas.Rows[indice].Cells["Estado"].Value);
                    if (estado)
                        ckActiva.Checked = true;
                    else
                        ckActiva.Checked = false;
                }
            }
            if (tbOfertas.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbOfertas.Rows[indice].Cells["id"].Value.ToString();
                    eliminarOferta(Convert.ToInt32(valor));
                }
            }
        }
        private void tbOfertas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen.Height;
                var w = CapaPresentacion.Properties.Resources.pen.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.delete.Width;
                var h = CapaPresentacion.Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.SelectedItem.ToString();
            if (tbOfertas.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbOfertas.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
    }
}
