namespace COMP123_S2019_Assignment5_301040475.Views
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ModelTextLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextLabel = new System.Windows.Forms.Label();
            this.PlatformTextLabel = new System.Windows.Forms.Label();
            this.ConditionTextLabel = new System.Windows.Forms.Label();
            this.TechSpecsPanel = new System.Windows.Forms.Panel();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.WebCamDataLabel = new System.Windows.Forms.Label();
            this.GPUDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SperateLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextLabel = new System.Windows.Forms.Label();
            this.TaxTextLabel = new System.Windows.Forms.Label();
            this.PriceTextLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.OrderPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.TechSpecsPanel.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(774, 39);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 35);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(323, 38);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(320, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(323, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(323, 38);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 3;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 4;
            this.TotalLine.X2 = 335;
            this.TotalLine.Y1 = 112;
            this.TotalLine.Y2 = 112;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(462, 470);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(134, 49);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 470);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 49);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(628, 470);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(134, 49);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelTextLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerTextLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformTextLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionTextLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.TechSpecsPanel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer2);
            this.SystemComponentsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemComponentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(5, 43);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(414, 421);
            this.SystemComponentsGroupBox.TabIndex = 5;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(13, 126);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(151, 37);
            this.LCDSizeLabel.TabIndex = 31;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTextLabel
            // 
            this.ModelTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelTextLabel.BackColor = System.Drawing.Color.White;
            this.ModelTextLabel.Location = new System.Drawing.Point(293, 72);
            this.ModelTextLabel.Name = "ModelTextLabel";
            this.ModelTextLabel.Size = new System.Drawing.Size(83, 37);
            this.ModelTextLabel.TabIndex = 30;
            this.ModelTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerTextLabel
            // 
            this.ManufacturerTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerTextLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextLabel.Location = new System.Drawing.Point(116, 72);
            this.ManufacturerTextLabel.Name = "ManufacturerTextLabel";
            this.ManufacturerTextLabel.Size = new System.Drawing.Size(83, 37);
            this.ManufacturerTextLabel.TabIndex = 29;
            this.ManufacturerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformTextLabel
            // 
            this.PlatformTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformTextLabel.BackColor = System.Drawing.Color.White;
            this.PlatformTextLabel.Location = new System.Drawing.Point(293, 25);
            this.PlatformTextLabel.Name = "PlatformTextLabel";
            this.PlatformTextLabel.Size = new System.Drawing.Size(83, 37);
            this.PlatformTextLabel.TabIndex = 28;
            this.PlatformTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionTextLabel
            // 
            this.ConditionTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionTextLabel.BackColor = System.Drawing.Color.White;
            this.ConditionTextLabel.Location = new System.Drawing.Point(116, 25);
            this.ConditionTextLabel.Name = "ConditionTextLabel";
            this.ConditionTextLabel.Size = new System.Drawing.Size(83, 37);
            this.ConditionTextLabel.TabIndex = 16;
            this.ConditionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TechSpecsPanel
            // 
            this.TechSpecsPanel.BackColor = System.Drawing.Color.White;
            this.TechSpecsPanel.Controls.Add(this.OSDataLabel);
            this.TechSpecsPanel.Controls.Add(this.WebCamDataLabel);
            this.TechSpecsPanel.Controls.Add(this.GPUDataLabel);
            this.TechSpecsPanel.Controls.Add(this.HDDDataLabel);
            this.TechSpecsPanel.Controls.Add(this.CPUSpeedDataLabel);
            this.TechSpecsPanel.Controls.Add(this.CPUNumberDataLabel);
            this.TechSpecsPanel.Controls.Add(this.CPUTypeDataLabel);
            this.TechSpecsPanel.Controls.Add(this.CPUBrandDataLabel);
            this.TechSpecsPanel.Controls.Add(this.MemoryDataLabel);
            this.TechSpecsPanel.Controls.Add(this.LCDSizeDataLabel);
            this.TechSpecsPanel.Location = new System.Drawing.Point(150, 120);
            this.TechSpecsPanel.Name = "TechSpecsPanel";
            this.TechSpecsPanel.Size = new System.Drawing.Size(252, 295);
            this.TechSpecsPanel.TabIndex = 27;
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSDataLabel.AutoSize = true;
            this.OSDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSDataLabel.Location = new System.Drawing.Point(9, 270);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(0, 37);
            this.OSDataLabel.TabIndex = 41;
            this.OSDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamDataLabel
            // 
            this.WebCamDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebCamDataLabel.AutoSize = true;
            this.WebCamDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebCamDataLabel.Location = new System.Drawing.Point(10, 242);
            this.WebCamDataLabel.Name = "WebCamDataLabel";
            this.WebCamDataLabel.Size = new System.Drawing.Size(0, 37);
            this.WebCamDataLabel.TabIndex = 40;
            this.WebCamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUDataLabel
            // 
            this.GPUDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUDataLabel.AutoSize = true;
            this.GPUDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUDataLabel.Location = new System.Drawing.Point(10, 214);
            this.GPUDataLabel.Name = "GPUDataLabel";
            this.GPUDataLabel.Size = new System.Drawing.Size(0, 37);
            this.GPUDataLabel.TabIndex = 39;
            this.GPUDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDDataLabel.AutoSize = true;
            this.HDDDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDDataLabel.Location = new System.Drawing.Point(10, 187);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(0, 37);
            this.HDDDataLabel.TabIndex = 38;
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedDataLabel.AutoSize = true;
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(10, 157);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(0, 37);
            this.CPUSpeedDataLabel.TabIndex = 37;
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberDataLabel.AutoSize = true;
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(10, 125);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(0, 37);
            this.CPUNumberDataLabel.TabIndex = 36;
            this.CPUNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeDataLabel.AutoSize = true;
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(10, 93);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(0, 37);
            this.CPUTypeDataLabel.TabIndex = 35;
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandDataLabel.AutoSize = true;
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(10, 65);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(0, 37);
            this.CPUBrandDataLabel.TabIndex = 34;
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryDataLabel.AutoSize = true;
            this.MemoryDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryDataLabel.Location = new System.Drawing.Point(10, 35);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(0, 37);
            this.MemoryDataLabel.TabIndex = 33;
            this.MemoryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeDataLabel.AutoSize = true;
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(10, 7);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(0, 37);
            this.LCDSizeDataLabel.TabIndex = 32;
            this.LCDSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(13, 364);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(151, 37);
            this.WebCamLabel.TabIndex = 26;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(13, 334);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(165, 37);
            this.GPUTypeLabel.TabIndex = 25;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(13, 304);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(86, 37);
            this.HDDLabel.TabIndex = 24;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(13, 274);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(184, 37);
            this.CPUSpeedLabel.TabIndex = 23;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(13, 244);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(208, 37);
            this.CPUNumberLabel.TabIndex = 22;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(13, 214);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(163, 37);
            this.CPUTypeLabel.TabIndex = 19;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(13, 184);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(179, 37);
            this.CPUBrandLabel.TabIndex = 18;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(13, 154);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(131, 37);
            this.MemoryLabel.TabIndex = 17;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(13, 394);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(63, 37);
            this.OSLabel.TabIndex = 20;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(217, 30);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(137, 37);
            this.PlatformLabel.TabIndex = 10;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(217, 77);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(103, 37);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 77);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(206, 37);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(8, 30);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(153, 37);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 40);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SperateLine});
            this.shapeContainer2.Size = new System.Drawing.Size(408, 378);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // SperateLine
            // 
            this.SperateLine.BorderColor = System.Drawing.Color.White;
            this.SperateLine.BorderWidth = 3;
            this.SperateLine.Name = "SperateLine";
            this.SperateLine.X1 = 4;
            this.SperateLine.X2 = 398;
            this.SperateLine.Y1 = 92;
            this.SperateLine.Y2 = 92;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextLabel);
            this.PriceGroupBox.Controls.Add(this.TaxTextLabel);
            this.PriceGroupBox.Controls.Add(this.PriceTextLabel);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.TaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer3);
            this.PriceGroupBox.Location = new System.Drawing.Point(425, 248);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(343, 213);
            this.PriceGroupBox.TabIndex = 6;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.BackColor = System.Drawing.Color.White;
            this.TotalTextLabel.Location = new System.Drawing.Point(156, 150);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(165, 37);
            this.TotalTextLabel.TabIndex = 6;
            this.TotalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxTextLabel
            // 
            this.TaxTextLabel.BackColor = System.Drawing.Color.White;
            this.TaxTextLabel.Location = new System.Drawing.Point(157, 85);
            this.TaxTextLabel.Name = "TaxTextLabel";
            this.TaxTextLabel.Size = new System.Drawing.Size(165, 37);
            this.TaxTextLabel.TabIndex = 5;
            this.TaxTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceTextLabel
            // 
            this.PriceTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextLabel.BackColor = System.Drawing.Color.White;
            this.PriceTextLabel.Location = new System.Drawing.Point(157, 33);
            this.PriceTextLabel.Name = "PriceTextLabel";
            this.PriceTextLabel.Size = new System.Drawing.Size(165, 37);
            this.PriceTextLabel.TabIndex = 4;
            this.PriceTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(13, 155);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(89, 37);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(13, 90);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(251, 37);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Sales Tax (13%)";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(13, 38);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(89, 37);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 40);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer3.Size = new System.Drawing.Size(337, 170);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // OrderPictureBox
            // 
            this.OrderPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("OrderPictureBox.Image")));
            this.OrderPictureBox.Location = new System.Drawing.Point(462, 54);
            this.OrderPictureBox.Name = "OrderPictureBox";
            this.OrderPictureBox.Size = new System.Drawing.Size(283, 188);
            this.OrderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrderPictureBox.TabIndex = 7;
            this.OrderPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 531);
            this.ControlBox = false;
            this.Controls.Add(this.OrderPictureBox);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.TechSpecsPanel.ResumeLayout(false);
            this.TechSpecsPanel.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape SperateLine;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Panel TechSpecsPanel;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label PriceTextLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Label TotalTextLabel;
        private System.Windows.Forms.Label TaxTextLabel;
        private System.Windows.Forms.Label ConditionTextLabel;
        private System.Windows.Forms.Label PlatformTextLabel;
        private System.Windows.Forms.Label ManufacturerTextLabel;
        private System.Windows.Forms.Label ModelTextLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label WebCamDataLabel;
        private System.Windows.Forms.Label GPUDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.PictureBox OrderPictureBox;
    }
}