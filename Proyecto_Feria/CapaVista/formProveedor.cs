using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }
    }
}
