namespace FavColorApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblColor = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblHEXRGB = new System.Windows.Forms.Label();
            this.lblInt2 = new System.Windows.Forms.Label();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAutoPixelColor = new System.Windows.Forms.CheckBox();
            this.tmrPixelColor = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorListCTL1 = new FavColorApp1.ColorListCTL();
            this.lblColorsCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(579, 40);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(150, 150);
            this.lblColor.TabIndex = 1;
            // 
            // lblHex
            // 
            this.lblHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHex.ContextMenuStrip = this.contextMenuStrip1;
            this.lblHex.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHex.Location = new System.Drawing.Point(579, 280);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(150, 20);
            this.lblHex.TabIndex = 2;
            this.lblHex.Text = "label1";
            this.lblHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHex_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(102, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // lblInt
            // 
            this.lblInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInt.ContextMenuStrip = this.contextMenuStrip1;
            this.lblInt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInt.Location = new System.Drawing.Point(579, 212);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(150, 20);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "label1";
            this.lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblInt_MouseDown);
            // 
            // lblRGB
            // 
            this.lblRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRGB.ContextMenuStrip = this.contextMenuStrip1;
            this.lblRGB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRGB.Location = new System.Drawing.Point(579, 258);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(150, 20);
            this.lblRGB.TabIndex = 2;
            this.lblRGB.Text = "label1";
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRGB_MouseDown);
            // 
            // lblHEXRGB
            // 
            this.lblHEXRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHEXRGB.ContextMenuStrip = this.contextMenuStrip1;
            this.lblHEXRGB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHEXRGB.Location = new System.Drawing.Point(579, 302);
            this.lblHEXRGB.Name = "lblHEXRGB";
            this.lblHEXRGB.Size = new System.Drawing.Size(150, 20);
            this.lblHEXRGB.TabIndex = 2;
            this.lblHEXRGB.Text = "label1";
            this.lblHEXRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHEXRGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHEXRGB_MouseDown);
            // 
            // lblInt2
            // 
            this.lblInt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInt2.ContextMenuStrip = this.contextMenuStrip1;
            this.lblInt2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInt2.Location = new System.Drawing.Point(579, 235);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(150, 20);
            this.lblInt2.TabIndex = 2;
            this.lblInt2.Text = "label1";
            this.lblInt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInt2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblInt2_MouseDown);
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(12, 40);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(150, 407);
            this.lstCategory.TabIndex = 7;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveHTML,
            this.toolStripMenuItem2,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // mnuSaveHTML
            // 
            this.mnuSaveHTML.Name = "mnuSaveHTML";
            this.mnuSaveHTML.Size = new System.Drawing.Size(160, 22);
            this.mnuSaveHTML.Text = "Зберегти HTML";
            this.mnuSaveHTML.Click += new System.EventHandler(this.mnuSaveHTML_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(160, 22);
            this.mnuExit.Text = "Вихід";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddGroup,
            this.mnuDeleteGroup});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupsToolStripMenuItem.Text = "Групи";
            // 
            // mnuAddGroup
            // 
            this.mnuAddGroup.Name = "mnuAddGroup";
            this.mnuAddGroup.Size = new System.Drawing.Size(160, 22);
            this.mnuAddGroup.Text = "Додати групу";
            this.mnuAddGroup.Click += new System.EventHandler(this.mnuAddGroup_Click);
            // 
            // mnuDeleteGroup
            // 
            this.mnuDeleteGroup.Name = "mnuDeleteGroup";
            this.mnuDeleteGroup.Size = new System.Drawing.Size(160, 22);
            this.mnuDeleteGroup.Text = "Видалити групу";
            this.mnuDeleteGroup.Click += new System.EventHandler(this.mnuDeleteGroup_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.colorsToolStripMenuItem.Text = "Кольори";
            // 
            // mnuAddColor
            // 
            this.mnuAddColor.Name = "mnuAddColor";
            this.mnuAddColor.Size = new System.Drawing.Size(180, 22);
            this.mnuAddColor.Text = "Додати колір";
            this.mnuAddColor.Click += new System.EventHandler(this.mnuAddColor_Click);
            // 
            // mnuDeleteColor
            // 
            this.mnuDeleteColor.Name = "mnuDeleteColor";
            this.mnuDeleteColor.Size = new System.Drawing.Size(180, 22);
            this.mnuDeleteColor.Text = "Видалити колір";
            this.mnuDeleteColor.Click += new System.EventHandler(this.mnuDeleteColor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(154, 22);
            this.mnuAbout.Text = "Про програму";
            // 
            // chkAutoPixelColor
            // 
            this.chkAutoPixelColor.Location = new System.Drawing.Point(576, 422);
            this.chkAutoPixelColor.Name = "chkAutoPixelColor";
            this.chkAutoPixelColor.Size = new System.Drawing.Size(150, 20);
            this.chkAutoPixelColor.TabIndex = 9;
            this.chkAutoPixelColor.Text = "Піксель під курсором";
            this.chkAutoPixelColor.UseVisualStyleBackColor = true;
            this.chkAutoPixelColor.CheckedChanged += new System.EventHandler(this.chkAutoPixelColor_CheckedChanged);
            this.chkAutoPixelColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAutoPixelColor_KeyDown);
            // 
            // tmrPixelColor
            // 
            this.tmrPixelColor.Interval = 200;
            this.tmrPixelColor.Tick += new System.EventHandler(this.tmrPixelColor_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Групи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кольори";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Колір";
            // 
            // colorListCTL1
            // 
            this.colorListCTL1.BackColor = System.Drawing.SystemColors.Window;
            this.colorListCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorListCTL1.Location = new System.Drawing.Point(168, 40);
            this.colorListCTL1.Name = "colorListCTL1";
            this.colorListCTL1.SelIndex = -1;
            this.colorListCTL1.Size = new System.Drawing.Size(402, 402);
            this.colorListCTL1.TabIndex = 12;
            this.colorListCTL1.ColorSelected += new System.Action<System.Drawing.Color>(this.colorListCTL1_ColorSelected);
            // 
            // lblColorsCount
            // 
            this.lblColorsCount.Location = new System.Drawing.Point(435, 24);
            this.lblColorsCount.Name = "lblColorsCount";
            this.lblColorsCount.Size = new System.Drawing.Size(135, 13);
            this.lblColorsCount.TabIndex = 11;
            this.lblColorsCount.Text = "0 / 100";
            this.lblColorsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(525, 98);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print on default printer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorListCTL1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblColorsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAutoPixelColor);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblInt2);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblHEXRGB);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кольори";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblHEXRGB;
        private System.Windows.Forms.Label lblInt2;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddGroup;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuAddColor;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.CheckBox chkAutoPixelColor;
        private System.Windows.Forms.Timer tmrPixelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ColorListCTL colorListCTL1;
        private System.Windows.Forms.Label lblColorsCount;
        private System.Windows.Forms.Button button1;
    }
}

