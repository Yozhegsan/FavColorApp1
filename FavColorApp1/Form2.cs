using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FavColorApp1
{
    public partial class Form2 : Form
    {
        public string GroupName = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + "\\" + txtGroup.Text + ".cgr";

            FileInfo f = new FileInfo(fn);
            if (!f.Exists)
            {
                GroupName = fn;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Група " + txtGroup.Text + " вже існує");
            }
        }
    }
}
