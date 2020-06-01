using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class frmListas : Form
       
    
    {
        public frmListas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (this.txtNombre.Text.Length > 0)
                {
                    this.lstNombres.Items.Add(this.txtNombre.Text);
                    this.txtNombre.Text = " ";
                }
            }

        }
    }
}
