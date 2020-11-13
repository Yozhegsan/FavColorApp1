using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FavColorApp1
{
    public partial class Form1 : Form
    {
        string ColorDataFN = "";
        string TextForCopy = "";
        List<Color> ColorList = new List<Color>();
        ColorDialog CD;

        Bitmap bmp = new Bitmap(400, 400);
        Graphics gfx;

        int SelectedColorIndex = -1;

        //####################################################################################################################

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = Graphics.FromImage(bmp);

            GetGroupList();
            //if (lstCategory.Items.Count > 0)
            //    lstCategory.SelectedIndex = 0;
        }

        private void GetGroupList()
        {
            lstCategory.Items.Clear();
            var dir = new DirectoryInfo(Application.StartupPath); // папка с файлами 
            foreach (FileInfo file in dir.GetFiles("*.cgr"))
                lstCategory.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
        }

        private void LoadColors()
        {
            var lines = File.ReadLines(ColorDataFN);
            ColorList.Clear();
            foreach (string r in lines)
                ColorList.Add(Color.FromArgb(int.Parse(r)));
        }

        private void ShowColors()
        {
            lblColorsCount.Text = "" + ColorList.Count + " / 100";
            int t = 0, l = 0, n = 0;
            gfx.Clear(Color.Transparent);
            foreach (Color c in ColorList)
            {
                if (l == 400) { l = 0; t += 40; }
                gfx.FillEllipse(new SolidBrush(c), l + 2, t + 2, 36, 36);
                gfx.DrawEllipse(new Pen(Color.Black, 1), l + 2, t + 2, 36, 36);

                if (SelectedColorIndex > -1 && n == SelectedColorIndex)
                {
                    gfx.DrawRectangle(new Pen(Color.Black, 1), l, t, 40, 40);
                }

                l += 40;
                n++;
            }
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            picPalitra.Image = bmp;
        }

        private string MakeRGBFromColor(Color c)
        {
            return "" + c.R + "," + c.G + "," + c.B;
        }

        private void SaveColors()
        {
            string result = "";
            foreach (Color c in ColorList)
                result += c.ToArgb().ToString() + Environment.NewLine;
            File.WriteAllText(ColorDataFN, result);
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(TextForCopy);
        }

        private void mnuAddColor_Click(object sender, EventArgs e)
        {
            CD = new ColorDialog();
            CD.FullOpen = true;
            if (CD.ShowDialog() == DialogResult.OK)
            {
                ColorList.Add(CD.Color);
                ShowColors();
                SaveColors();
            }
            CD.Dispose();
        }

        private void mnuDeleteColor_Click(object sender, EventArgs e)
        {
            if (SelectedColorIndex < 0) return;
            if (MessageBox.Show("Видалити вибраний колір?", "Важливе питання", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ColorList.RemoveAt(SelectedColorIndex);
                SaveColors();
                LoadColors();
                ShowColors();
            }
        }

        private void mnuSaveHTML_Click(object sender, EventArgs e)
        {
            string BeginFile = "<html><head></head><body><center><table>" + Environment.NewLine;
            string s1 = "<tr><td bgcolor=#";
            string s2 = ">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>";
            string s3 = "</td></tr>" + Environment.NewLine;
            string EndFile = "</table></center></body></html>" + Environment.NewLine;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML|*.html";
            sfd.FileName = lstCategory.Items[lstCategory.SelectedIndex].ToString();
            sfd.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE") + "\\documents";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string result = BeginFile;
                foreach (Color c in ColorList)
                    result += s1 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s2 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s3;
                result += EndFile;
                File.WriteAllText(sfd.FileName, result);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAddGroup_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            DialogResult dr2 = frm2.ShowDialog();
            if (dr2 == DialogResult.OK)
            {
                File.WriteAllText(frm2.GroupName, "");
                GetGroupList();
            }
            if (dr2 == DialogResult.Cancel) { }
        }

        private void mnuDeleteGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити вибрану групу?", "Важливе питання", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(ColorDataFN);
                GetGroupList();
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedIndex >= 0)
            {
                ClearData();
                ColorDataFN = Application.StartupPath + "\\" + lstCategory.Items[lstCategory.SelectedIndex] + ".cgr";
                LoadColors();
                ShowColors();
            }
        }

        private void ClearData()
        {
            lblColorsCount.Text = "0 / 100";
            lblColor.BackColor = Color.FromName("Control");
            lblHex.Text = "";
            lblHEXRGB.Text = "";
            lblInt.Text = "";
            lblRGB.Text = "";
            lblInt2.Text = "";
            lblARGB.Text = "";
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        static extern bool DeleteDC([In] IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);
        private void chkAutoPixelColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoPixelColor.Checked) tmrPixelColor.Enabled = true;
        }
        private void tmrPixelColor_Tick(object sender, EventArgs e)
        {
            if (chkAutoPixelColor.Checked)
            {
                this.Text = "Режим перегляду пікселя під курсором миші";
                Point p = new Point();
                GetCursorPos(out p);
                IntPtr hdc = CreateDC("DISPLAY", "", "", (IntPtr)0);
                Color c = Color.FromArgb((int)GetPixel(hdc, p.X, p.Y));
                DeleteDC(hdc);
                Color cc = Color.FromArgb(255, c.B, c.G, c.R);
                ShowPixelInfo(cc);
            }
            else
            {
                tmrPixelColor.Enabled = false;
                this.Text = "Кольори";
                //listBox1_SelectedIndexChanged(null, null);
            }
        }

        private void ShowPixelInfo(Color c)
        {
            lblColor.BackColor = c;
            lblHex.Text = Convert.ToString(c.ToArgb(), 16).Substring(2, 6);
            Color tmp = Color.FromArgb(0, c.R, c.G, c.B);
            lblInt2.Text = tmp.ToArgb().ToString();
            lblInt.Text = c.ToArgb().ToString();
            lblRGB.Text = MakeRGBFromColor(c);
            lblHEXRGB.Text = "#" + Convert.ToString(c.ToArgb(), 16).Substring(2, 6);
        }

        private void lblHex_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblHex.Text; }
        private void lblInt_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblInt.Text; }
        private void lblInt2_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblInt2.Text; }
        private void lblRGB_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblRGB.Text; }
        private void lblHEXRGB_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblHEXRGB.Text; }
        private void lblARGB_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblARGB.Text; }
        private void chkAutoPixelColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ColorList.Add(lblColor.BackColor);
                ShowColors();
                SaveColors();
            }
        }


        private void ColorSelected()
        {

        }

        private void lblColor_DoubleClick(object sender, EventArgs e)
        {
            FormColor frm = new FormColor();
            frm.BackColor = lblColor.BackColor;
            frm.ShowDialog();

        }

        private void picPalitra_MouseDown(object sender, MouseEventArgs e)
        {
            int i = LocationToIndex(e.Location);
            if (i > ColorList.Count - 1)
            {
                ClearData();
                SelectedColorIndex = -1;
                ShowColors();
                lblColorsCount.Text = "" + ColorList.Count + " / 100";
                if (e.Button == MouseButtons.Right)
                {
                    // Show conext menu
                }
                return;
            }
            SelectedColorIndex = i;
            ShowColors();
            lblColorsCount.Text = "(" + (i + 1) + ") " + ColorList.Count + " / 100";
            Color c = ColorList[i];
            lblColor.BackColor = c;
            lblHex.Text = Convert.ToString(c.ToArgb(), 16).Substring(2, 6);
            Color tmp = Color.FromArgb(0, c.R, c.G, c.B);
            lblInt2.Text = tmp.ToArgb().ToString();
            lblInt.Text = c.ToArgb().ToString();
            lblRGB.Text = MakeRGBFromColor(c);
            lblHEXRGB.Text = "#" + Convert.ToString(c.ToArgb(), 16).Substring(2, 6);
            lblARGB.Text = "Color.FromArgb(255," + MakeRGBFromColor(c) + ");";
            if (e.Button == MouseButtons.Right)
            {
                // Show conext menu
            }
        }

        int LocationToIndex(Point l)
        {
            return (l.X / 10 / 4) + (l.Y / 10 / 4 * 10);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (lstCategory.Items.Count > 0)
                lstCategory.SelectedIndex = 0;
        }
    }
}
