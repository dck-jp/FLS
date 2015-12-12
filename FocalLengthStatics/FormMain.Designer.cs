namespace FocalLengthStatics
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearchDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectPicturesFolder = new System.Windows.Forms.Button();
            this.buttonCreateHeatMap = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonCreateCSVFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCSVFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxLensType = new System.Windows.Forms.ListBox();
            this.listBoxBody = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExtractInfo = new System.Windows.Forms.Button();
            this.numericUpDownFlEnd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFlBegin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxCreateHeatmap = new System.Windows.Forms.GroupBox();
            this.radioButtonByLensType = new System.Windows.Forms.RadioButton();
            this.radioButtonByModels = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxExtensions = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlBegin)).BeginInit();
            this.groupBoxCreateHeatmap.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchDirectory
            // 
            this.textBoxSearchDirectory.Location = new System.Drawing.Point(63, 28);
            this.textBoxSearchDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchDirectory.Name = "textBoxSearchDirectory";
            this.textBoxSearchDirectory.Size = new System.Drawing.Size(519, 22);
            this.textBoxSearchDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder:";
            // 
            // buttonSelectPicturesFolder
            // 
            this.buttonSelectPicturesFolder.Location = new System.Drawing.Point(591, 24);
            this.buttonSelectPicturesFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectPicturesFolder.Name = "buttonSelectPicturesFolder";
            this.buttonSelectPicturesFolder.Size = new System.Drawing.Size(165, 30);
            this.buttonSelectPicturesFolder.TabIndex = 2;
            this.buttonSelectPicturesFolder.Text = "Select Folder..";
            this.buttonSelectPicturesFolder.UseVisualStyleBackColor = true;
            this.buttonSelectPicturesFolder.Click += new System.EventHandler(this.buttonSelectPicturesFolder_Click);
            // 
            // buttonCreateHeatMap
            // 
            this.buttonCreateHeatMap.Location = new System.Drawing.Point(228, 484);
            this.buttonCreateHeatMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateHeatMap.Name = "buttonCreateHeatMap";
            this.buttonCreateHeatMap.Size = new System.Drawing.Size(293, 29);
            this.buttonCreateHeatMap.TabIndex = 2;
            this.buttonCreateHeatMap.Text = "Create HeatMap";
            this.buttonCreateHeatMap.UseVisualStyleBackColor = true;
            this.buttonCreateHeatMap.Click += new System.EventHandler(this.buttonCreateHeatMap_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 169);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(747, 12);
            this.progressBar.TabIndex = 4;
            // 
            // buttonCreateCSVFile
            // 
            this.buttonCreateCSVFile.Location = new System.Drawing.Point(228, 132);
            this.buttonCreateCSVFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateCSVFile.Name = "buttonCreateCSVFile";
            this.buttonCreateCSVFile.Size = new System.Drawing.Size(293, 29);
            this.buttonCreateCSVFile.TabIndex = 2;
            this.buttonCreateCSVFile.Text = "Create DB";
            this.buttonCreateCSVFile.UseVisualStyleBackColor = true;
            this.buttonCreateCSVFile.Click += new System.EventHandler(this.buttonCreateCSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB File:";
            // 
            // textBoxCSVFile
            // 
            this.textBoxCSVFile.Enabled = false;
            this.textBoxCSVFile.Location = new System.Drawing.Point(81, 40);
            this.textBoxCSVFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCSVFile.Name = "textBoxCSVFile";
            this.textBoxCSVFile.Size = new System.Drawing.Size(500, 22);
            this.textBoxCSVFile.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(588, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select DB File..";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxLensType
            // 
            this.listBoxLensType.Enabled = false;
            this.listBoxLensType.FormattingEnabled = true;
            this.listBoxLensType.ItemHeight = 15;
            this.listBoxLensType.Location = new System.Drawing.Point(393, 80);
            this.listBoxLensType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxLensType.Name = "listBoxLensType";
            this.listBoxLensType.Size = new System.Drawing.Size(359, 274);
            this.listBoxLensType.TabIndex = 5;
            // 
            // listBoxBody
            // 
            this.listBoxBody.FormattingEnabled = true;
            this.listBoxBody.ItemHeight = 15;
            this.listBoxBody.Location = new System.Drawing.Point(81, 80);
            this.listBoxBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBody.Name = "listBoxBody";
            this.listBoxBody.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxBody.Size = new System.Drawing.Size(303, 274);
            this.listBoxBody.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "LensType:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model:";
            // 
            // buttonExtractInfo
            // 
            this.buttonExtractInfo.Location = new System.Drawing.Point(228, 92);
            this.buttonExtractInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExtractInfo.Name = "buttonExtractInfo";
            this.buttonExtractInfo.Size = new System.Drawing.Size(293, 29);
            this.buttonExtractInfo.TabIndex = 2;
            this.buttonExtractInfo.Text = "Extract Body && Lens Info.";
            this.buttonExtractInfo.UseVisualStyleBackColor = true;
            this.buttonExtractInfo.Click += new System.EventHandler(this.buttonExtractInfo_Click);
            // 
            // numericUpDownFlEnd
            // 
            this.numericUpDownFlEnd.Location = new System.Drawing.Point(217, 378);
            this.numericUpDownFlEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownFlEnd.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownFlEnd.Name = "numericUpDownFlEnd";
            this.numericUpDownFlEnd.Size = new System.Drawing.Size(97, 22);
            this.numericUpDownFlEnd.TabIndex = 6;
            this.numericUpDownFlEnd.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Focal Length Range:";
            // 
            // numericUpDownFlBegin
            // 
            this.numericUpDownFlBegin.Enabled = false;
            this.numericUpDownFlBegin.Location = new System.Drawing.Point(81, 378);
            this.numericUpDownFlBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownFlBegin.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownFlBegin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFlBegin.Name = "numericUpDownFlBegin";
            this.numericUpDownFlBegin.Size = new System.Drawing.Size(97, 22);
            this.numericUpDownFlBegin.TabIndex = 6;
            this.numericUpDownFlBegin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(187, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(323, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "[mm] (35mm eq. )";
            // 
            // groupBoxCreateHeatmap
            // 
            this.groupBoxCreateHeatmap.Controls.Add(this.radioButtonByLensType);
            this.groupBoxCreateHeatmap.Controls.Add(this.radioButtonByModels);
            this.groupBoxCreateHeatmap.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxCreateHeatmap.Controls.Add(this.dateTimePickerBegin);
            this.groupBoxCreateHeatmap.Controls.Add(this.numericUpDownFlBegin);
            this.groupBoxCreateHeatmap.Controls.Add(this.buttonCreateHeatMap);
            this.groupBoxCreateHeatmap.Controls.Add(this.numericUpDownFlEnd);
            this.groupBoxCreateHeatmap.Controls.Add(this.listBoxBody);
            this.groupBoxCreateHeatmap.Controls.Add(this.listBoxLensType);
            this.groupBoxCreateHeatmap.Controls.Add(this.label15);
            this.groupBoxCreateHeatmap.Controls.Add(this.label6);
            this.groupBoxCreateHeatmap.Controls.Add(this.label7);
            this.groupBoxCreateHeatmap.Controls.Add(this.label16);
            this.groupBoxCreateHeatmap.Controls.Add(this.label5);
            this.groupBoxCreateHeatmap.Controls.Add(this.label14);
            this.groupBoxCreateHeatmap.Controls.Add(this.label4);
            this.groupBoxCreateHeatmap.Controls.Add(this.label3);
            this.groupBoxCreateHeatmap.Enabled = false;
            this.groupBoxCreateHeatmap.Location = new System.Drawing.Point(16, 352);
            this.groupBoxCreateHeatmap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCreateHeatmap.Name = "groupBoxCreateHeatmap";
            this.groupBoxCreateHeatmap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCreateHeatmap.Size = new System.Drawing.Size(784, 524);
            this.groupBoxCreateHeatmap.TabIndex = 7;
            this.groupBoxCreateHeatmap.TabStop = false;
            this.groupBoxCreateHeatmap.Text = "Create HeatMap";
            // 
            // radioButtonByLensType
            // 
            this.radioButtonByLensType.AutoSize = true;
            this.radioButtonByLensType.Location = new System.Drawing.Point(393, 32);
            this.radioButtonByLensType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonByLensType.Name = "radioButtonByLensType";
            this.radioButtonByLensType.Size = new System.Drawing.Size(158, 19);
            this.radioButtonByLensType.TabIndex = 9;
            this.radioButtonByLensType.Text = "Select By LensType";
            this.radioButtonByLensType.UseVisualStyleBackColor = true;
            this.radioButtonByLensType.CheckedChanged += new System.EventHandler(this.radioButtonByLensType_CheckedChanged);
            // 
            // radioButtonByModels
            // 
            this.radioButtonByModels.AutoSize = true;
            this.radioButtonByModels.Checked = true;
            this.radioButtonByModels.Location = new System.Drawing.Point(84, 32);
            this.radioButtonByModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonByModels.Name = "radioButtonByModels";
            this.radioButtonByModels.Size = new System.Drawing.Size(140, 19);
            this.radioButtonByModels.TabIndex = 9;
            this.radioButtonByModels.TabStop = true;
            this.radioButtonByModels.Text = "Select By Models";
            this.radioButtonByModels.UseVisualStyleBackColor = true;
            this.radioButtonByModels.CheckedChanged += new System.EventHandler(this.radioButtonByModels_CheckedChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy/MM";
            this.dateTimePickerEnd.Enabled = false;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(217, 424);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.CustomFormat = "yyyy/MM";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(81, 424);
            this.dateTimePickerBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerBegin.TabIndex = 7;
            this.dateTimePickerBegin.Value = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 430);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 405);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Select Date Range:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mode:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(180, 72);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "*.jpg";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(412, 72);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 19);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "*.PEF";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.textBoxExtensions);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBoxSearchDirectory);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.buttonSelectPicturesFolder);
            this.groupBox2.Controls.Add(this.buttonCreateCSVFile);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(784, 194);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create DataBase";
            // 
            // textBoxExtensions
            // 
            this.textBoxExtensions.Enabled = false;
            this.textBoxExtensions.Location = new System.Drawing.Point(572, 69);
            this.textBoxExtensions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxExtensions.Name = "textBoxExtensions";
            this.textBoxExtensions.Size = new System.Drawing.Size(180, 22);
            this.textBoxExtensions.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Target File Extensions:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(329, 72);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 19);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "*.DNG";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(491, 72);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 19);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "others";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(251, 72);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 19);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "*.jpeg";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxCSVFile);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonExtractInfo);
            this.groupBox3.Location = new System.Drawing.Point(16, 216);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(784, 129);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extract Parameters for Creating Heatmap ";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(329, 99);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 19);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "*.NEF";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(412, 99);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(70, 19);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "*.NRW";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(251, 99);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(70, 19);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "*.CRW";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(180, 99);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(67, 19);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "*.CR2";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(568, 99);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(68, 19);
            this.checkBox10.TabIndex = 14;
            this.checkBox10.Text = "*.ORF";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(651, 99);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(69, 19);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Text = "*.ARW";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(490, 99);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(66, 19);
            this.checkBox12.TabIndex = 16;
            this.checkBox12.Text = "*.RAF";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 896);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxCreateHeatmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FocalLengthStatics";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlBegin)).EndInit();
            this.groupBoxCreateHeatmap.ResumeLayout(false);
            this.groupBoxCreateHeatmap.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectPicturesFolder;
        private System.Windows.Forms.Button buttonCreateHeatMap;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonCreateCSVFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCSVFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxLensType;
        private System.Windows.Forms.ListBox listBoxBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExtractInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownFlEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFlBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxCreateHeatmap;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxExtensions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonByLensType;
        private System.Windows.Forms.RadioButton radioButtonByModels;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}

