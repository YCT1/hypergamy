namespace HyperGamy
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Yarat = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.Group = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.ListBox();
            this.showSMV = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numMen = new System.Windows.Forms.NumericUpDown();
            this.clearAll = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.csvfile = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFirstListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lockofnumericvalues = new System.Windows.Forms.CheckBox();
            this.doAll = new System.Windows.Forms.Button();
            this.cmdLine = new System.Windows.Forms.TextBox();
            this.enterCMD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Yarat
            // 
            this.Yarat.AutoSize = true;
            this.Yarat.Location = new System.Drawing.Point(12, 492);
            this.Yarat.Name = "Yarat";
            this.Yarat.Size = new System.Drawing.Size(54, 45);
            this.Yarat.TabIndex = 0;
            this.Yarat.Text = "Yarat";
            this.Yarat.UseVisualStyleBackColor = true;
            this.Yarat.Click += new System.EventHandler(this.hesaplama_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 38);
            this.listbox.Margin = new System.Windows.Forms.Padding(15);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(266, 407);
            this.listbox.TabIndex = 1;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(72, 493);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(61, 45);
            this.Group.TabIndex = 3;
            this.Group.Text = "Grubla";
            this.Group.UseVisualStyleBackColor = true;
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(284, 38);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(793, 407);
            this.groupList.TabIndex = 4;
            // 
            // showSMV
            // 
            this.showSMV.Location = new System.Drawing.Point(136, 493);
            this.showSMV.Name = "showSMV";
            this.showSMV.Size = new System.Drawing.Size(47, 45);
            this.showSMV.TabIndex = 5;
            this.showSMV.Text = "Show SMV";
            this.showSMV.UseVisualStyleBackColor = true;
            this.showSMV.Click += new System.EventHandler(this.showSMV_Click);
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(189, 492);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(89, 45);
            this.topla.TabIndex = 6;
            this.topla.Text = "Toplam";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleDescription = "Test";
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown1.Location = new System.Drawing.Point(72, 463);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numMen
            // 
            this.numMen.Location = new System.Drawing.Point(284, 462);
            this.numMen.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numMen.Name = "numMen";
            this.numMen.Size = new System.Drawing.Size(301, 20);
            this.numMen.TabIndex = 8;
            this.numMen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMen.ValueChanged += new System.EventHandler(this.numMen_ValueChanged);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(716, 463);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(361, 23);
            this.clearAll.TabIndex = 9;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 544);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1063, 35);
            this.progressBar1.TabIndex = 10;
            // 
            // csvfile
            // 
            this.csvfile.AutoSize = true;
            this.csvfile.Location = new System.Drawing.Point(591, 464);
            this.csvfile.Name = "csvfile";
            this.csvfile.Size = new System.Drawing.Size(119, 17);
            this.csvfile.TabIndex = 11;
            this.csvfile.Text = "CSV File for Toplam";
            this.csvfile.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainSettingToolStripMenuItem,
            this.copyFirstListBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainSettingToolStripMenuItem
            // 
            this.mainSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussCreationToolStripMenuItem});
            this.mainSettingToolStripMenuItem.Name = "mainSettingToolStripMenuItem";
            this.mainSettingToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.mainSettingToolStripMenuItem.Text = "Main Setting";
            // 
            // gaussCreationToolStripMenuItem
            // 
            this.gaussCreationToolStripMenuItem.Name = "gaussCreationToolStripMenuItem";
            this.gaussCreationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gaussCreationToolStripMenuItem.Text = "Gauss Creation";
            this.gaussCreationToolStripMenuItem.Click += new System.EventHandler(this.gaussCreationToolStripMenuItem_Click);
            // 
            // copyFirstListBoxToolStripMenuItem
            // 
            this.copyFirstListBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstOneToolStripMenuItem,
            this.secondOneToolStripMenuItem});
            this.copyFirstListBoxToolStripMenuItem.Name = "copyFirstListBoxToolStripMenuItem";
            this.copyFirstListBoxToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyFirstListBoxToolStripMenuItem.Text = "Copy";
            // 
            // firstOneToolStripMenuItem
            // 
            this.firstOneToolStripMenuItem.Name = "firstOneToolStripMenuItem";
            this.firstOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firstOneToolStripMenuItem.Text = "First One";
            this.firstOneToolStripMenuItem.Click += new System.EventHandler(this.firstOneToolStripMenuItem_Click);
            // 
            // secondOneToolStripMenuItem
            // 
            this.secondOneToolStripMenuItem.Name = "secondOneToolStripMenuItem";
            this.secondOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondOneToolStripMenuItem.Text = "Second One";
            this.secondOneToolStripMenuItem.Click += new System.EventHandler(this.secondOneToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "How much man must compete for a women";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Man and Women";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(15, 463);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lockofnumericvalues
            // 
            this.lockofnumericvalues.AutoSize = true;
            this.lockofnumericvalues.Location = new System.Drawing.Point(136, 464);
            this.lockofnumericvalues.Name = "lockofnumericvalues";
            this.lockofnumericvalues.Size = new System.Drawing.Size(50, 17);
            this.lockofnumericvalues.TabIndex = 16;
            this.lockofnumericvalues.Text = "Lock";
            this.lockofnumericvalues.UseVisualStyleBackColor = true;
            // 
            // doAll
            // 
            this.doAll.Location = new System.Drawing.Point(952, 492);
            this.doAll.Name = "doAll";
            this.doAll.Size = new System.Drawing.Size(124, 46);
            this.doAll.TabIndex = 17;
            this.doAll.Text = "Do All of Them";
            this.doAll.UseVisualStyleBackColor = true;
            this.doAll.Click += new System.EventHandler(this.doAll_Click);
            // 
            // cmdLine
            // 
            this.cmdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdLine.Location = new System.Drawing.Point(284, 511);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(310, 26);
            this.cmdLine.TabIndex = 18;
            this.cmdLine.TextChanged += new System.EventHandler(this.cmdLine_TextChanged);
            // 
            // enterCMD
            // 
            this.enterCMD.Location = new System.Drawing.Point(600, 512);
            this.enterCMD.Name = "enterCMD";
            this.enterCMD.Size = new System.Drawing.Size(62, 26);
            this.enterCMD.TabIndex = 19;
            this.enterCMD.Text = "Enter";
            this.enterCMD.UseVisualStyleBackColor = true;
            this.enterCMD.Click += new System.EventHandler(this.enterCMD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 591);
            this.Controls.Add(this.enterCMD);
            this.Controls.Add(this.cmdLine);
            this.Controls.Add(this.doAll);
            this.Controls.Add(this.lockofnumericvalues);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csvfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.numMen);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.showSMV);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Yarat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hypergamy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yarat;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button Group;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.Button showSMV;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numMen;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox csvfile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussCreationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem copyFirstListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondOneToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox lockofnumericvalues;
        private System.Windows.Forms.Button doAll;
        private System.Windows.Forms.TextBox cmdLine;
        private System.Windows.Forms.Button enterCMD;
    }
}

