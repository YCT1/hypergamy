﻿namespace HyperGamy
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMen)).BeginInit();
            this.SuspendLayout();
            // 
            // Yarat
            // 
            this.Yarat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Yarat.AutoSize = true;
            this.Yarat.Location = new System.Drawing.Point(12, 492);
            this.Yarat.Name = "Yarat";
            this.Yarat.Size = new System.Drawing.Size(266, 45);
            this.Yarat.TabIndex = 0;
            this.Yarat.Text = "Yarat";
            this.Yarat.UseVisualStyleBackColor = true;
            this.Yarat.Click += new System.EventHandler(this.hesaplama_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 12);
            this.listbox.Margin = new System.Windows.Forms.Padding(15);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(281, 433);
            this.listbox.TabIndex = 1;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(284, 492);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(301, 45);
            this.Group.TabIndex = 3;
            this.Group.Text = "Grubla";
            this.Group.UseVisualStyleBackColor = true;
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(311, 12);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(766, 433);
            this.groupList.TabIndex = 4;
            // 
            // showSMV
            // 
            this.showSMV.Location = new System.Drawing.Point(591, 492);
            this.showSMV.Name = "showSMV";
            this.showSMV.Size = new System.Drawing.Size(277, 45);
            this.showSMV.TabIndex = 5;
            this.showSMV.Text = "Show SMV";
            this.showSMV.UseVisualStyleBackColor = true;
            this.showSMV.Click += new System.EventHandler(this.showSMV_Click);
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(874, 492);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(202, 45);
            this.topla.TabIndex = 6;
            this.topla.Text = "Toplam";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 463);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(281, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numMen
            // 
            this.numMen.Location = new System.Drawing.Point(311, 462);
            this.numMen.Name = "numMen";
            this.numMen.Size = new System.Drawing.Size(274, 20);
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
            this.clearAll.Location = new System.Drawing.Point(592, 462);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(485, 23);
            this.clearAll.TabIndex = 9;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 549);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.numMen);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.showSMV);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Yarat);
            this.Name = "Form1";
            this.Text = "Hypergamy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMen)).EndInit();
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
    }
}

