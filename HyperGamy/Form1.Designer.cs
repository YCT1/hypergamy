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
            this.SuspendLayout();
            // 
            // Yarat
            // 
            this.Yarat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Yarat.AutoSize = true;
            this.Yarat.Location = new System.Drawing.Point(12, 460);
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
            this.Group.Location = new System.Drawing.Point(284, 460);
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
            this.showSMV.Location = new System.Drawing.Point(591, 460);
            this.showSMV.Name = "showSMV";
            this.showSMV.Size = new System.Drawing.Size(338, 45);
            this.showSMV.TabIndex = 5;
            this.showSMV.Text = "Show SMV";
            this.showSMV.UseVisualStyleBackColor = true;
            this.showSMV.Click += new System.EventHandler(this.showSMV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 517);
            this.Controls.Add(this.showSMV);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Yarat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yarat;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button Group;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.Button showSMV;
    }
}

