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
        string BeginFile = "<html><head></head><body><center><table>" + Environment.NewLine;
        string s1 = "<tr><td bgcolor=#";
        string s2 = ">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>";
        string s3 = "</td></tr>" + Environment.NewLine;
        string EndFile = "</table></center></body></html>" + Environment.NewLine;
        string TextForCopy = "";

        
        List <Color> ColorList = new List<Color>();
        ColorDialog CD;
        //####################################################################################################################

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            GetGroupList();
            if (lstCategory.Items.Count > 0)
                lstCategory.SelectedIndex = 0;
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
            //if (colorListCTL1.SelIndex > -1)
            //    lblColorsCount.Text = "(" + colorListCTL1.SelIndex + ") " + ColorList.Count + " / 100";
            //else
                lblColorsCount.Text = "" + ColorList.Count + " / 100";

            colorListCTL1.ClearColors();


            
            foreach (Color c in ColorList)
            {
                colorListCTL1.AddColor(c);
            }



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


        private void btnMakeHTML_Click(object sender, EventArgs e)
        {
            string result = BeginFile;
            foreach (Color c in ColorList)
                result += s1 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s2 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s3;
            result += EndFile;
            File.WriteAllText(Application.StartupPath + "\\List.html", result);
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
            if (colorListCTL1.SelIndex < 0) return;
            if (MessageBox.Show("Видалити вибраний колір?", "Важливе питання", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ColorList.RemoveAt(colorListCTL1.SelIndex);
                //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                SaveColors();
                LoadColors();
                ShowColors();
            }
        }

        private void mnuSaveHTML_Click(object sender, EventArgs e)
        {
            string result = BeginFile;
            foreach (Color c in ColorList)
                result += s1 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s2 + Convert.ToString(c.ToArgb(), 16).Substring(2, 6) + s3;
            result += EndFile;
            File.WriteAllText(Application.StartupPath + "\\" + lstCategory.Items[lstCategory.SelectedIndex] + ".html", result);
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

        private void btnMoveColorDown_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMoveColorUp_Click(object sender, EventArgs e)
        {
            

        }

        private void lblHex_MouseDown(object sender, MouseEventArgs e)    { TextForCopy = lblHex.Text; }
        private void lblInt_MouseDown(object sender, MouseEventArgs e)    { TextForCopy = lblInt.Text; }
        private void lblInt2_MouseDown(object sender, MouseEventArgs e)   { TextForCopy = lblInt2.Text; }
        private void lblRGB_MouseDown(object sender, MouseEventArgs e)    { TextForCopy = lblRGB.Text; }
        private void lblHEXRGB_MouseDown(object sender, MouseEventArgs e) { TextForCopy = lblHEXRGB.Text; }

        private void chkAutoPixelColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ColorList.Add(lblColor.BackColor);
                ShowColors();
                SaveColors();
            }
        }

        private void listBox1_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void colorListCTL1_Load(object sender, EventArgs e)
        {

        }

        private void colorListCTL1_ColorSelected(Color obj)
        {
            if (colorListCTL1.SelIndex > -1)
                lblColorsCount.Text = "(" + (colorListCTL1.SelIndex + 1) + ") " + ColorList.Count + " / 100";
            else
                lblColorsCount.Text = "" + ColorList.Count + " / 100";
            Color c = obj;
            lblColor.BackColor = c;
            lblHex.Text = Convert.ToString(c.ToArgb(), 16).Substring(2, 6);

            Color tmp = Color.FromArgb(0, c.R, c.G, c.B);
            lblInt2.Text = tmp.ToArgb().ToString();

            lblInt.Text = c.ToArgb().ToString();

            lblRGB.Text = MakeRGBFromColor(c);
            lblHEXRGB.Text = "#" + Convert.ToString(c.ToArgb(), 16).Substring(2, 6);

            //lblColorName.Text = lblColor.BackColor.ToKnownColor().ToString();

            
        }

        private void Print()
        {
            string s = "Cost Bla  Bla Bla.....";
            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
