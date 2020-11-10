using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FavColorApp1
{
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

        private void FormColor_Load(object sender, EventArgs e)
        {

        }

        private void FormColor_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
