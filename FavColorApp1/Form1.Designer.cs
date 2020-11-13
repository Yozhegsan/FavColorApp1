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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddColor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteColor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblColorsCount = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblARGB = new System.Windows.Forms.Label();
            this.picPalitra = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPalitra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(6, 16);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(149, 149);
            this.lblColor.TabIndex = 1;
            this.lblColor.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblHex
            // 
            this.lblHex.BackColor = System.Drawing.SystemColors.Window;
            this.lblHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHex.ContextMenuStrip = this.contextMenuStrip1;
            this.lblHex.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHex.Location = new System.Drawing.Point(6, 265);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(149, 20);
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
            this.lblInt.BackColor = System.Drawing.SystemColors.Window;
            this.lblInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInt.ContextMenuStrip = this.contextMenuStrip1;
            this.lblInt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInt.Location = new System.Drawing.Point(6, 197);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(149, 20);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "label1";
            this.lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblInt_MouseDown);
            // 
            // lblRGB
            // 
            this.lblRGB.BackColor = System.Drawing.SystemColors.Window;
            this.lblRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRGB.ContextMenuStrip = this.contextMenuStrip1;
            this.lblRGB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRGB.Location = new System.Drawing.Point(6, 243);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(149, 20);
            this.lblRGB.TabIndex = 2;
            this.lblRGB.Text = "label1";
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRGB_MouseDown);
            // 
            // lblHEXRGB
            // 
            this.lblHEXRGB.BackColor = System.Drawing.SystemColors.Window;
            this.lblHEXRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHEXRGB.ContextMenuStrip = this.contextMenuStrip1;
            this.lblHEXRGB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHEXRGB.Location = new System.Drawing.Point(6, 287);
            this.lblHEXRGB.Name = "lblHEXRGB";
            this.lblHEXRGB.Size = new System.Drawing.Size(149, 20);
            this.lblHEXRGB.TabIndex = 2;
            this.lblHEXRGB.Text = "label1";
            this.lblHEXRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHEXRGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHEXRGB_MouseDown);
            // 
            // lblInt2
            // 
            this.lblInt2.BackColor = System.Drawing.SystemColors.Window;
            this.lblInt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInt2.ContextMenuStrip = this.contextMenuStrip1;
            this.lblInt2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInt2.Location = new System.Drawing.Point(6, 220);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(149, 20);
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
            this.lstCategory.Size = new System.Drawing.Size(150, 381);
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
            this.mnuSaveHTML.Size = new System.Drawing.Size(159, 22);
            this.mnuSaveHTML.Text = "Зберегти HTML";
            this.mnuSaveHTML.Click += new System.EventHandler(this.mnuSaveHTML_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(159, 22);
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
            this.chkAutoPixelColor.Location = new System.Drawing.Point(15, 438);
            this.chkAutoPixelColor.Name = "chkAutoPixelColor";
            this.chkAutoPixelColor.Size = new System.Drawing.Size(147, 20);
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
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddColor2,
            this.mnuDeleteColor2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 70);
            // 
            // mnuAddColor2
            // 
            this.mnuAddColor2.Name = "mnuAddColor2";
            this.mnuAddColor2.Size = new System.Drawing.Size(180, 22);
            this.mnuAddColor2.Text = "Додати колір";
            // 
            // mnuDeleteColor2
            // 
            this.mnuDeleteColor2.Name = "mnuDeleteColor2";
            this.mnuDeleteColor2.Size = new System.Drawing.Size(180, 22);
            this.mnuDeleteColor2.Text = "Видалити колір";
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImage = global::FavColorApp1.res.bg4;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 39);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FavColorApp1.res.to_html;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Зберегти вибрану групу в HTML";
            this.toolStripButton1.Click += new System.EventHandler(this.mnuSaveHTML_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FavColorApp1.res.g_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::FavColorApp1.res.c_add3;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Додати колір";
            this.toolStripButton4.Click += new System.EventHandler(this.mnuAddColor_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::FavColorApp1.res.c_de3;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Видалити вибраний колір";
            this.toolStripButton5.Click += new System.EventHandler(this.mnuDeleteColor_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::FavColorApp1.res.abaut;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblInt);
            this.groupBox1.Controls.Add(this.lblHex);
            this.groupBox1.Controls.Add(this.lblARGB);
            this.groupBox1.Controls.Add(this.lblHEXRGB);
            this.groupBox1.Controls.Add(this.lblRGB);
            this.groupBox1.Controls.Add(this.lblInt2);
            this.groupBox1.Location = new System.Drawing.Point(576, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 415);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Колір";
            // 
            // lblARGB
            // 
            this.lblARGB.BackColor = System.Drawing.SystemColors.Window;
            this.lblARGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblARGB.ContextMenuStrip = this.contextMenuStrip1;
            this.lblARGB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblARGB.Location = new System.Drawing.Point(6, 310);
            this.lblARGB.Name = "lblARGB";
            this.lblARGB.Size = new System.Drawing.Size(149, 48);
            this.lblARGB.TabIndex = 2;
            this.lblARGB.Text = "label1";
            this.lblARGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblARGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblARGB_MouseDown);
            // 
            // picPalitra
            // 
            this.picPalitra.BackColor = System.Drawing.Color.White;
            this.picPalitra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPalitra.Location = new System.Drawing.Point(168, 56);
            this.picPalitra.Name = "picPalitra";
            this.picPalitra.Size = new System.Drawing.Size(402, 402);
            this.picPalitra.TabIndex = 16;
            this.picPalitra.TabStop = false;
            this.picPalitra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPalitra_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 467);
            this.Controls.Add(this.picPalitra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAutoPixelColor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblColorsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кольори";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPalitra)).EndInit();
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
        private System.Windows.Forms.Label lblColorsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddColor2;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteColor2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblARGB;
        private System.Windows.Forms.PictureBox picPalitra;
    }
}

