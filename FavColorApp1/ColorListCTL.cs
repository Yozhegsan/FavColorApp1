using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FavColorApp1
{
    public partial class ColorListCTL : UserControl
    {
        private const int MAIN_SIZE = 40;
        List<Label> lblList = new List<Label>();
        public int ColorCount { get { return lblList.Count; }}
        public int SelIndex { get; set; } = -1;
        public event Action<Color> ColorSelected;
        //################################################################################################################

        public ColorListCTL()
        {
            InitializeComponent();
        }

        private void ColorListCTL_Load(object sender, EventArgs e)
        {
            
        }

        public void AddColor(Color c)
        {
            Label lbl = new Label();
            lbl.MouseDown += Lbl_MouseDown;
            lbl.MouseEnter += Lbl_MouseEnter;
            lbl.Tag = lblList.Count;
            lbl.Height = MAIN_SIZE - 4;
            lbl.Width = MAIN_SIZE-4;
            lbl.Top = (lblList.Count / 10) * MAIN_SIZE+2;
            lbl.Left = (lblList.Count % 10)*MAIN_SIZE+2;
            lbl.Text = "";
            lbl.BackColor = c;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lblList.Add(lbl);
            lbl = null;
            ShowColors();
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (SelIndex > -1)
            {
                lblList[SelIndex].Left += 2;
                lblList[SelIndex].Top += 2;
                lblList[SelIndex].Width -= 4;
                lblList[SelIndex].Height -= 4;
            }
        
            SelIndex = Convert.ToInt32(((Label)sender).Tag);
            //ShowColors();
            ShowSelected();
            ColorSelected(((Label)sender).BackColor);
        }

        private void ShowColors()
        {
            this.Controls.Clear();
            for(int i = 0; i < lblList.Count; i++)
                this.Controls.Add(lblList[i]);
            
        }

        private void ShowSelected()
        {
            if (SelIndex > -1)
            {
                lblList[SelIndex].Left -= 2;
                lblList[SelIndex].Top -= 2;
                lblList[SelIndex].Width += 4;
                lblList[SelIndex].Height += 4;
            }
            this.AutoScroll = false;

            this.AutoScroll = true;
        }

        public void ClearColors()
        {
            SelIndex = -1;
            lblList.Clear();
            this.Controls.Clear();
        }

        private void ColorListCTL_Resize(object sender, EventArgs e)
        {
            this.Width = 402;
            this.Height = 402;
        }
    }
}
