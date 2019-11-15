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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblColorsCount = new System.Windows.Forms.Label();
            this.btnCategoryToHTML = new System.Windows.Forms.Button();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddColor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteColor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(579, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(150, 150);
            this.lblColor.TabIndex = 1;
            // 
            // lblHex
            // 
            this.lblHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHex.ContextMenuStrip = this.contextMenuStrip1;
            this.lblHex.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHex.Location = new System.Drawing.Point(579, 296);
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
            this.lblInt.Location = new System.Drawing.Point(579, 228);
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
            this.lblRGB.Location = new System.Drawing.Point(579, 274);
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
            this.lblHEXRGB.Location = new System.Drawing.Point(579, 318);
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
            this.lblInt2.Location = new System.Drawing.Point(579, 251);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(150, 20);
            this.lblInt2.TabIndex = 2;
            this.lblInt2.Text = "label1";
            this.lblInt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInt2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblInt2_MouseDown);
            // 
            // lstCategory
            // 
            this.lstCategory.ContextMenuStrip = this.contextMenuStrip2;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(12, 56);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(150, 368);
            this.lstCategory.TabIndex = 7;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.delToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(97, 48);
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
            this.chkAutoPixelColor.Location = new System.Drawing.Point(579, 12);
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
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Групи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кольори";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Колір";
            // 
            // colorListCTL1
            // 
            this.colorListCTL1.BackColor = System.Drawing.SystemColors.Window;
            this.colorListCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorListCTL1.ContextMenuStrip = this.contextMenuStrip3;
            this.colorListCTL1.Location = new System.Drawing.Point(168, 56);
            this.colorListCTL1.Name = "colorListCTL1";
            this.colorListCTL1.SelIndex = -1;
            this.colorListCTL1.Size = new System.Drawing.Size(402, 402);
            this.colorListCTL1.TabIndex = 12;
            this.colorListCTL1.ColorSelected += new System.Action<System.Drawing.Color>(this.colorListCTL1_ColorSelected);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddColor2,
            this.mnuDeleteColor2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(160, 48);
            // 
            // lblColorsCount
            // 
            this.lblColorsCount.Location = new System.Drawing.Point(435, 40);
            this.lblColorsCount.Name = "lblColorsCount";
            this.lblColorsCount.Size = new System.Drawing.Size(135, 13);
            this.lblColorsCount.TabIndex = 11;
            this.lblColorsCount.Text = "0 / 100";
            this.lblColorsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCategoryToHTML
            // 
            this.btnCategoryToHTML.Location = new System.Drawing.Point(15, 435);
            this.btnCategoryToHTML.Name = "btnCategoryToHTML";
            this.btnCategoryToHTML.Size = new System.Drawing.Size(147, 23);
            this.btnCategoryToHTML.TabIndex = 13;
            this.btnCategoryToHTML.Text = "button1";
            this.btnCategoryToHTML.UseVisualStyleBackColor = true;
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.delToolStripMenuItem.Text = "Del";
            // 
            // mnuAddColor2
            // 
            this.mnuAddColor2.Name = "mnuAddColor2";
            this.mnuAddColor2.Size = new System.Drawing.Size(159, 22);
            this.mnuAddColor2.Text = "Додати колір";
            // 
            // mnuDeleteColor2
            // 
            this.mnuDeleteColor2.Name = "mnuDeleteColor2";
            this.mnuDeleteColor2.Size = new System.Drawing.Size(159, 22);
            this.mnuDeleteColor2.Text = "Видалити колір";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 39);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FavColorApp1.res.to_html;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Зберегти вибрану групу в HTML";
            this.toolStripButton1.Click += new System.EventHandler(this.mnuSaveHTML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FavColorApp1.res.g_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Додати групу";
            this.toolStripButton2.Click += new System.EventHandler(this.mnuAddGroup_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::FavColorApp1.res.g_del;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Видалити вибрану групу";
            this.toolStripButton3.Click += new System.EventHandler(this.mnuDeleteGroup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::FavColorApp1.res.c_add;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Додати колір";
            this.toolStripButton4.Click += new System.EventHandler(this.mnuAddColor_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::FavColorApp1.res.c_del;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Видалити вибраний колір";
            this.toolStripButton5.Click += new System.EventHandler(this.mnuDeleteColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::FavColorApp1.res.abaut;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "?";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::FavColorApp1.res.exit;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton7.Text = "Вихід";
            this.toolStripButton7.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 467);
            this.Controls.Add(this.chkAutoPixelColor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCategoryToHTML);
            this.Controls.Add(this.colorListCTL1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblColorsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.lblInt2);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblHEXRGB);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кольори";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnCategoryToHTML;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddColor2;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteColor2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
    }
}

