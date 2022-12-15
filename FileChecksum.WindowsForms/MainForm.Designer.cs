namespace FileChecksum.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.algorithmComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.fileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.checksumHexLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.selectFileButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.historyPage = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.timeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.fileNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.checksumValueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.materialTabControl1.SuspendLayout();
            this.homePage.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.AutoResize = false;
            this.algorithmComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.algorithmComboBox.Depth = 0;
            this.algorithmComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.algorithmComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.algorithmComboBox.DropDownHeight = 174;
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.DropDownWidth = 121;
            this.algorithmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.algorithmComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Hint = "Select algorithm";
            this.algorithmComboBox.IntegralHeight = false;
            this.algorithmComboBox.ItemHeight = 43;
            this.algorithmComboBox.Items.AddRange(new object[] {
            "CRC-32-IEEE 802.3"});
            this.algorithmComboBox.Location = new System.Drawing.Point(3, 3);
            this.algorithmComboBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.algorithmComboBox.MaxDropDownItems = 4;
            this.algorithmComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.algorithmComboBox.Size = new System.Drawing.Size(725, 49);
            this.algorithmComboBox.StartIndex = 0;
            this.algorithmComboBox.TabIndex = 2;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Depth = 0;
            this.fileNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileNameLabel.Location = new System.Drawing.Point(6, 250);
            this.fileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(1, 0);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileNameLabel.UseAccent = true;
            // 
            // checksumHexLabel
            // 
            this.checksumHexLabel.Depth = 0;
            this.checksumHexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checksumHexLabel.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checksumHexLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.checksumHexLabel.Location = new System.Drawing.Point(3, 52);
            this.checksumHexLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.checksumHexLabel.Name = "checksumHexLabel";
            this.checksumHexLabel.Size = new System.Drawing.Size(725, 370);
            this.checksumHexLabel.TabIndex = 6;
            this.checksumHexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checksumHexLabel.UseAccent = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.materialTabControl1.Controls.Add(this.homePage);
            this.materialTabControl1.Controls.Add(this.historyPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(20, 55);
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 433);
            this.materialTabControl1.TabIndex = 7;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.White;
            this.homePage.Controls.Add(this.selectFileButton);
            this.homePage.Controls.Add(this.checksumHexLabel);
            this.homePage.Controls.Add(this.algorithmComboBox);
            this.homePage.ImageKey = "home_FILL0_wght400_GRAD0_opsz48.png";
            this.homePage.Location = new System.Drawing.Point(59, 4);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(731, 425);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Depth = 0;
            this.selectFileButton.Icon = ((System.Drawing.Image)(resources.GetObject("selectFileButton.Icon")));
            this.selectFileButton.ImageList = this.imageList1;
            this.selectFileButton.Location = new System.Drawing.Point(669, 363);
            this.selectFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.selectFileButton.Size = new System.Drawing.Size(56, 56);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectFileButton_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "history_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(1, "home_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(2, "add_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // historyPage
            // 
            this.historyPage.BackColor = System.Drawing.Color.White;
            this.historyPage.Controls.Add(this.materialListView1);
            this.historyPage.ImageKey = "history_FILL0_wght400_GRAD0_opsz48.png";
            this.historyPage.Location = new System.Drawing.Point(59, 4);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(731, 425);
            this.historyPage.TabIndex = 1;
            this.historyPage.Text = "History";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumnHeader,
            this.fileNameColumnHeader,
            this.checksumValueColumnHeader});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(3, 3);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(725, 419);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.Text = "Time";
            this.timeColumnHeader.Width = 200;
            // 
            // fileNameColumnHeader
            // 
            this.fileNameColumnHeader.Text = "File name";
            this.fileNameColumnHeader.Width = 429;
            // 
            // checksumValueColumnHeader
            // 
            this.checksumValueColumnHeader.Text = "Hex value";
            this.checksumValueColumnHeader.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.fileNameLabel);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.materialTabControl1.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.historyPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox algorithmComboBox;
        private MaterialSkin.Controls.MaterialLabel fileNameLabel;
        private MaterialSkin.Controls.MaterialLabel checksumHexLabel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage homePage;
        private TabPage historyPage;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader timeColumnHeader;
        private ColumnHeader fileNameColumnHeader;
        private ColumnHeader checksumValueColumnHeader;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialFloatingActionButton selectFileButton;
    }
}