using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;
using CapaVista.FormVentas;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Windows.Forms;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        public static decimal Monto;
        ControlProducto controlProducto = new ControlProducto();
        ControlVenta controlVenta = new ControlVenta();
        public formVentas(bool Mod)
        {
            InitializeComponent();
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
            }
        }
        private void formVentas_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
        }
        private void mostrarClientes()
        {
            //hay que crear la entidad cliente
        }
        private void mostrarProductosDisponible()
        {
            List<Producto> lista = controlProducto.listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Producto p in lista)
            {
                Image img = null;
                using (MemoryStream memoryStream = new MemoryStream(p.imagen))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    img = imagen;

                }

                tbBusqueda.Rows.Add(img, "", p.id, p.codigo, p.nombre, p.PrecioVenta, p.cantidad);
            }
        }
        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDescuento.Checked)
            {
                txtDescuento.Enabled = true;
            }
            if (!checkDescuento.Checked)
            {
                txtDescuento.Enabled = false;
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

            Monto = 20;
            //Monto = float.Parse(txtTotal.Text);
            FormPagar form = new FormPagar(formConfiguraciones.Mod);
            form.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                string currentText = txtDescuento.Text;
                string newText = currentText + e.KeyChar;
                if (int.TryParse(newText, out int number))
                {
                    if (number >= 1 && number <= 100)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddPercentageSign(object sender, EventArgs e)
        {
            string currentText = txtDescuento.Text;
            if (!currentText.EndsWith("%"))
            {
                txtDescuento.Text = currentText + "%";
            }
        }
        private void AddNumeralSign(object sender, EventArgs e)
        {
            string currentText = txtCodigoProducto.Text;
            if (!currentText.StartsWith("#"))
            {
                txtCodigoProducto.Text = "#" + currentText;
            }
        }
        private void añadirProducto(int id, string codigo)
        {
            // tiene los valores de 
            tbResumen.Rows.Add();
        }
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
            panelDetalleVenta.SendToBack();
        }
        private void btnCerrarBusqueda_Click_1(object sender, EventArgs e)
        {
            panelBusqueda.SendToBack();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = cbxBuscar.SelectedItem.ToString();
            string columna = "";
            if (nombre == "Nombre")
            {
                columna = "NombreP";
            }
            if (nombre == "Codigo")
            {
                columna = "CodigoP";
            }
            if (nombre == "Precio")
            {
                columna = "PrecioP";
            }

            if (tbBusqueda.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbBusqueda.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }

        private void tbBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbBusqueda.Columns[e.ColumnIndex].Name == "Añadir")
            {
                if (indice >= 0)
                {
                    txtCodigoProducto.Text = tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                    pktProducto.Image = (Image)tbBusqueda.Rows[indice].Cells["Img"].Value;
                }
            }
        }

        private void tbBusqueda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.pen_circle.Width;
                var h = Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

    }
}
