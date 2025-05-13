namespace ScannerApp
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            linkLabelLoadDvices = new LinkLabel();
            buttonScan = new Button();
            comboBoxDPI = new NumericUpDown();
            numericUpDownScannerPapperCont = new NumericUpDown();
            groupBox2 = new GroupBox();
            linkLabelOpenSaveFolder = new LinkLabel();
            linkLabelChangeSaveFolder = new LinkLabel();
            textBoxSaveFolder = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonWhiteAndBlack = new RadioButton();
            radioButtonColor = new RadioButton();
            pictureBox2 = new PictureBox();
            comboBoxPaperSize = new ComboBox();
            label4 = new Label();
            comboBoxDevices = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxShow = new PictureBox();
            buttonSaveImage = new Button();
            toolTip1 = new ToolTip(components);
            pictureBoxLoading = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDPI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScannerPapperCont).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabelLoadDvices);
            panel1.Controls.Add(buttonScan);
            panel1.Controls.Add(comboBoxDPI);
            panel1.Controls.Add(numericUpDownScannerPapperCont);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(comboBoxPaperSize);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxDevices);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // linkLabelLoadDvices
            // 
            resources.ApplyResources(linkLabelLoadDvices, "linkLabelLoadDvices");
            linkLabelLoadDvices.Name = "linkLabelLoadDvices";
            linkLabelLoadDvices.TabStop = true;
            toolTip1.SetToolTip(linkLabelLoadDvices, resources.GetString("linkLabelLoadDvices.ToolTip"));
            linkLabelLoadDvices.LinkClicked += linkLabelLoadDvices_LinkClicked;
            // 
            // buttonScan
            // 
            buttonScan.BackColor = Color.White;
            resources.ApplyResources(buttonScan, "buttonScan");
            buttonScan.Image = Properties.Resources.icons8_scanner_48;
            buttonScan.Name = "buttonScan";
            buttonScan.UseVisualStyleBackColor = false;
            buttonScan.Click += buttonScan_Click;
            // 
            // comboBoxDPI
            // 
            resources.ApplyResources(comboBoxDPI, "comboBoxDPI");
            comboBoxDPI.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            comboBoxDPI.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            comboBoxDPI.Name = "comboBoxDPI";
            toolTip1.SetToolTip(comboBoxDPI, resources.GetString("comboBoxDPI.ToolTip"));
            comboBoxDPI.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownScannerPapperCont
            // 
            resources.ApplyResources(numericUpDownScannerPapperCont, "numericUpDownScannerPapperCont");
            numericUpDownScannerPapperCont.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownScannerPapperCont.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownScannerPapperCont.Name = "numericUpDownScannerPapperCont";
            toolTip1.SetToolTip(numericUpDownScannerPapperCont, resources.GetString("numericUpDownScannerPapperCont.ToolTip"));
            numericUpDownScannerPapperCont.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabelOpenSaveFolder);
            groupBox2.Controls.Add(linkLabelChangeSaveFolder);
            groupBox2.Controls.Add(textBoxSaveFolder);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // linkLabelOpenSaveFolder
            // 
            resources.ApplyResources(linkLabelOpenSaveFolder, "linkLabelOpenSaveFolder");
            linkLabelOpenSaveFolder.Name = "linkLabelOpenSaveFolder";
            linkLabelOpenSaveFolder.TabStop = true;
            linkLabelOpenSaveFolder.LinkClicked += linkLabelOpenSaveFolder_LinkClicked;
            // 
            // linkLabelChangeSaveFolder
            // 
            resources.ApplyResources(linkLabelChangeSaveFolder, "linkLabelChangeSaveFolder");
            linkLabelChangeSaveFolder.Name = "linkLabelChangeSaveFolder";
            linkLabelChangeSaveFolder.TabStop = true;
            linkLabelChangeSaveFolder.LinkClicked += linkLabelChangeSaveFolder_LinkClicked;
            // 
            // textBoxSaveFolder
            // 
            resources.ApplyResources(textBoxSaveFolder, "textBoxSaveFolder");
            textBoxSaveFolder.Name = "textBoxSaveFolder";
            textBoxSaveFolder.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonWhiteAndBlack);
            groupBox1.Controls.Add(radioButtonColor);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // radioButtonWhiteAndBlack
            // 
            resources.ApplyResources(radioButtonWhiteAndBlack, "radioButtonWhiteAndBlack");
            radioButtonWhiteAndBlack.Name = "radioButtonWhiteAndBlack";
            radioButtonWhiteAndBlack.UseVisualStyleBackColor = true;
            // 
            // radioButtonColor
            // 
            resources.ApplyResources(radioButtonColor, "radioButtonColor");
            radioButtonColor.Checked = true;
            radioButtonColor.ForeColor = Color.Firebrick;
            radioButtonColor.Name = "radioButtonColor";
            radioButtonColor.TabStop = true;
            radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ScannerImage;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // comboBoxPaperSize
            // 
            comboBoxPaperSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaperSize.FormattingEnabled = true;
            comboBoxPaperSize.Items.AddRange(new object[] { resources.GetString("comboBoxPaperSize.Items"), resources.GetString("comboBoxPaperSize.Items1"), resources.GetString("comboBoxPaperSize.Items2") });
            resources.ApplyResources(comboBoxPaperSize, "comboBoxPaperSize");
            comboBoxPaperSize.Name = "comboBoxPaperSize";
            toolTip1.SetToolTip(comboBoxPaperSize, resources.GetString("comboBoxPaperSize.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBoxDevices
            // 
            comboBoxDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDevices.FormattingEnabled = true;
            resources.ApplyResources(comboBoxDevices, "comboBoxDevices");
            comboBoxDevices.Name = "comboBoxDevices";
            toolTip1.SetToolTip(comboBoxDevices, resources.GetString("comboBoxDevices.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BackColor = Color.White;
            resources.ApplyResources(pictureBoxShow, "pictureBoxShow");
            pictureBoxShow.Image = Properties.Resources.Scanner_doc_gif1;
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.TabStop = false;
            // 
            // buttonSaveImage
            // 
            resources.ApplyResources(buttonSaveImage, "buttonSaveImage");
            buttonSaveImage.BackColor = Color.White;
            buttonSaveImage.Image = Properties.Resources.icons8_save_32;
            buttonSaveImage.Name = "buttonSaveImage";
            toolTip1.SetToolTip(buttonSaveImage, resources.GetString("buttonSaveImage.ToolTip"));
            buttonSaveImage.UseVisualStyleBackColor = false;
            buttonSaveImage.Click += buttonSaveImage_Click;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxLoading, "pictureBoxLoading");
            pictureBoxLoading.Image = Properties.Resources.loading_gif_transpert;
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSaveImage);
            Controls.Add(pictureBoxLoading);
            Controls.Add(pictureBoxShow);
            Controls.Add(panel1);
            Name = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDPI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScannerPapperCont).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxShow;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox comboBoxDevices;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButtonWhiteAndBlack;
        private RadioButton radioButtonColor;
        private Label label3;
        private GroupBox groupBox2;
        private LinkLabel linkLabelChangeSaveFolder;
        private TextBox textBoxSaveFolder;
        private NumericUpDown numericUpDownScannerPapperCont;
        private Label label4;
        private Button buttonScan;
        private Button buttonSaveImage;
        private ToolTip toolTip1;
        private LinkLabel linkLabelOpenSaveFolder;
        private PictureBox pictureBoxLoading;
        private LinkLabel linkLabelLoadDvices;
        private ComboBox comboBoxPaperSize;
        private Label label5;
        private NumericUpDown comboBoxDPI;
    }
}
