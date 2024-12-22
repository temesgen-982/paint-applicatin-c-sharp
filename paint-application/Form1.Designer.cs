namespace paint_application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lineButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.sizeFour = new System.Windows.Forms.Button();
            this.sizeTwo = new System.Windows.Forms.Button();
            this.sizeOne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.colorDialogButton = new System.Windows.Forms.Button();
            this.sizeThree = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.menuStrip3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 30);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(10, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(45, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openAnImageToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newFileToolStripMenuItem.Text = "Save";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // openAnImageToolStripMenuItem
            // 
            this.openAnImageToolStripMenuItem.Name = "openAnImageToolStripMenuItem";
            this.openAnImageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openAnImageToolStripMenuItem.Text = "New File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Open an image";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.openFile_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(55, 6);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(47, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(102, 6);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(52, 24);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 25;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.474691F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.03712F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.411698F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.524185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.374578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.75F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeFour, 13, 4);
            this.tableLayoutPanel1.Controls.Add(this.sizeTwo, 13, 2);
            this.tableLayoutPanel1.Controls.Add(this.sizeOne, 13, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 16, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 16, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 17, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 17, 2);
            this.tableLayoutPanel1.Controls.Add(this.button16, 16, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 17, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 18, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 19, 1);
            this.tableLayoutPanel1.Controls.Add(this.button18, 18, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 19, 2);
            this.tableLayoutPanel1.Controls.Add(this.button19, 18, 3);
            this.tableLayoutPanel1.Controls.Add(this.button17, 19, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 20, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 21, 1);
            this.tableLayoutPanel1.Controls.Add(this.button20, 20, 2);
            this.tableLayoutPanel1.Controls.Add(this.button21, 21, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 20, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 21, 3);
            this.tableLayoutPanel1.Controls.Add(this.colorDialogButton, 22, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeThree, 13, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.015038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.774436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 133);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 5);
            this.groupBox1.Controls.Add(this.lineButton);
            this.groupBox1.Controls.Add(this.triangleButton);
            this.groupBox1.Controls.Add(this.circleButton);
            this.groupBox1.Controls.Add(this.rectangleButton);
            this.groupBox1.Location = new System.Drawing.Point(249, 11);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(169, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Image = global::paint_application.Properties.Resources.line;
            this.lineButton.Location = new System.Drawing.Point(120, 14);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(35, 26);
            this.lineButton.TabIndex = 21;
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.triangleButton.FlatAppearance.BorderSize = 0;
            this.triangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleButton.Image = global::paint_application.Properties.Resources.triangle;
            this.triangleButton.Location = new System.Drawing.Point(-1, 14);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(34, 26);
            this.triangleButton.TabIndex = 20;
            this.triangleButton.UseVisualStyleBackColor = false;
            this.triangleButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.circleButton.FlatAppearance.BorderSize = 0;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Image = global::paint_application.Properties.Resources.circle;
            this.circleButton.Location = new System.Drawing.Point(39, 14);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(34, 26);
            this.circleButton.TabIndex = 19;
            this.circleButton.UseVisualStyleBackColor = false;
            this.circleButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Image = global::paint_application.Properties.Resources.rectangle;
            this.rectangleButton.Location = new System.Drawing.Point(79, 14);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(35, 26);
            this.rectangleButton.TabIndex = 18;
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 4);
            this.groupBox2.Controls.Add(this.fillButton);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.eraseButton);
            this.groupBox2.Controls.Add(this.penButton);
            this.groupBox2.Location = new System.Drawing.Point(52, 11);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(174, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // fillButton
            // 
            this.fillButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fillButton.FlatAppearance.BorderSize = 0;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Image = global::paint_application.Properties.Resources.fill;
            this.fillButton.Location = new System.Drawing.Point(129, 13);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(39, 30);
            this.fillButton.TabIndex = 21;
            this.fillButton.UseVisualStyleBackColor = false;
            this.fillButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Image = global::paint_application.Properties.Resources.broom;
            this.clearButton.Location = new System.Drawing.Point(84, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(39, 30);
            this.clearButton.TabIndex = 20;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eraseButton.FlatAppearance.BorderSize = 0;
            this.eraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseButton.Image = global::paint_application.Properties.Resources.eraser;
            this.eraseButton.Location = new System.Drawing.Point(0, 12);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(34, 29);
            this.eraseButton.TabIndex = 19;
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // penButton
            // 
            this.penButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.penButton.FlatAppearance.BorderSize = 0;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penButton.Image = global::paint_application.Properties.Resources.pen;
            this.penButton.Location = new System.Drawing.Point(41, 13);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(37, 29);
            this.penButton.TabIndex = 18;
            this.penButton.UseVisualStyleBackColor = false;
            this.penButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // sizeFour
            // 
            this.sizeFour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.sizeFour, 2);
            this.sizeFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeFour.Location = new System.Drawing.Point(459, 92);
            this.sizeFour.Name = "sizeFour";
            this.sizeFour.Size = new System.Drawing.Size(62, 21);
            this.sizeFour.TabIndex = 26;
            this.sizeFour.Text = "Size 4";
            this.sizeFour.UseVisualStyleBackColor = false;
            this.sizeFour.Click += new System.EventHandler(this.penSizeBtn_Click);
            // 
            // sizeTwo
            // 
            this.sizeTwo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.sizeTwo, 2);
            this.sizeTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTwo.Location = new System.Drawing.Point(459, 38);
            this.sizeTwo.Name = "sizeTwo";
            this.sizeTwo.Size = new System.Drawing.Size(62, 21);
            this.sizeTwo.TabIndex = 24;
            this.sizeTwo.Text = "Size 2";
            this.sizeTwo.UseVisualStyleBackColor = false;
            this.sizeTwo.Click += new System.EventHandler(this.penSizeBtn_Click);
            // 
            // sizeOne
            // 
            this.sizeOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.sizeOne, 2);
            this.sizeOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeOne.Location = new System.Drawing.Point(459, 11);
            this.sizeOne.Name = "sizeOne";
            this.sizeOne.Size = new System.Drawing.Size(62, 21);
            this.sizeOne.TabIndex = 23;
            this.sizeOne.Text = "Size 1";
            this.sizeOne.UseVisualStyleBackColor = false;
            this.sizeOne.Click += new System.EventHandler(this.penSizeBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(564, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 19);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(564, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 19);
            this.button7.TabIndex = 29;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(599, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 19);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(599, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 19);
            this.button8.TabIndex = 30;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightCoral;
            this.button16.Location = new System.Drawing.Point(564, 65);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(21, 19);
            this.button16.TabIndex = 31;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Sienna;
            this.button9.Location = new System.Drawing.Point(599, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 19);
            this.button9.TabIndex = 33;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(634, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 19);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(669, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 19);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Crimson;
            this.button18.Location = new System.Drawing.Point(634, 38);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(23, 19);
            this.button18.TabIndex = 34;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Fuchsia;
            this.button10.Location = new System.Drawing.Point(669, 38);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(24, 19);
            this.button10.TabIndex = 37;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Lime;
            this.button19.Location = new System.Drawing.Point(634, 65);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(23, 19);
            this.button19.TabIndex = 35;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Green;
            this.button17.Location = new System.Drawing.Point(669, 65);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(22, 19);
            this.button17.TabIndex = 38;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Location = new System.Drawing.Point(704, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 19);
            this.button5.TabIndex = 39;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(739, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 19);
            this.button6.TabIndex = 42;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button20.Location = new System.Drawing.Point(704, 38);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(22, 19);
            this.button20.TabIndex = 41;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DarkViolet;
            this.button21.Location = new System.Drawing.Point(739, 38);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(22, 19);
            this.button21.TabIndex = 44;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(704, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(22, 19);
            this.button11.TabIndex = 40;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Khaki;
            this.button12.Location = new System.Drawing.Point(739, 65);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(23, 19);
            this.button12.TabIndex = 43;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // colorDialogButton
            // 
            this.colorDialogButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.colorDialogButton, 2);
            this.colorDialogButton.Image = global::paint_application.Properties.Resources.color;
            this.colorDialogButton.Location = new System.Drawing.Point(774, 11);
            this.colorDialogButton.Name = "colorDialogButton";
            this.tableLayoutPanel1.SetRowSpan(this.colorDialogButton, 2);
            this.colorDialogButton.Size = new System.Drawing.Size(43, 44);
            this.colorDialogButton.TabIndex = 45;
            this.colorDialogButton.UseVisualStyleBackColor = false;
            this.colorDialogButton.Click += new System.EventHandler(this.colorDialogBtn_Click);
            // 
            // sizeThree
            // 
            this.sizeThree.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.sizeThree, 2);
            this.sizeThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeThree.Location = new System.Drawing.Point(459, 65);
            this.sizeThree.Name = "sizeThree";
            this.sizeThree.Size = new System.Drawing.Size(62, 21);
            this.sizeThree.TabIndex = 25;
            this.sizeThree.Text = "Size 3";
            this.sizeThree.UseVisualStyleBackColor = false;
            this.sizeThree.Click += new System.EventHandler(this.penSizeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.picture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 333);
            this.panel2.TabIndex = 2;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture.Location = new System.Drawing.Point(10, 10);
            this.picture.Margin = new System.Windows.Forms.Padding(10);
            this.picture.MinimumSize = new System.Drawing.Size(500, 100);
            this.picture.Name = "picture";
            this.picture.Padding = new System.Windows.Forms.Padding(10);
            this.picture.Size = new System.Drawing.Size(860, 304);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button sizeFour;
        private System.Windows.Forms.Button sizeThree;
        private System.Windows.Forms.Button sizeTwo;
        private System.Windows.Forms.Button sizeOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button colorDialogButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAnImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.Button fillButton;
    }
}

