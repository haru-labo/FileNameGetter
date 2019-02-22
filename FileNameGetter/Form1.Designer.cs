﻿namespace FileNameGetter
{
    partial class FileNameGetter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileNameGetter));
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serchSetting = new System.Windows.Forms.Label();
            this.serchSubDir = new System.Windows.Forms.CheckBox();
            this.showSubDirName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(0, 156);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(414, 169);
            this.textBox.TabIndex = 0;
            this.textBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ここにファイルまたはフォルダをドラッグ＆ドロップしてください";
            // 
            // serchSetting
            // 
            this.serchSetting.AutoSize = true;
            this.serchSetting.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serchSetting.Location = new System.Drawing.Point(12, 9);
            this.serchSetting.Name = "serchSetting";
            this.serchSetting.Size = new System.Drawing.Size(80, 15);
            this.serchSetting.TabIndex = 2;
            this.serchSetting.Text = "検索設定：";
            // 
            // serchSubDir
            // 
            this.serchSubDir.AutoSize = true;
            this.serchSubDir.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.serchSubDir.Location = new System.Drawing.Point(98, 9);
            this.serchSubDir.Name = "serchSubDir";
            this.serchSubDir.Size = new System.Drawing.Size(133, 17);
            this.serchSubDir.TabIndex = 3;
            this.serchSubDir.Text = "サブフォルダ内を含める";
            this.serchSubDir.UseVisualStyleBackColor = true;
            // 
            // showSubDirName
            // 
            this.showSubDirName.AutoSize = true;
            this.showSubDirName.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.showSubDirName.Location = new System.Drawing.Point(237, 9);
            this.showSubDirName.Name = "showSubDirName";
            this.showSubDirName.Size = new System.Drawing.Size(126, 17);
            this.showSubDirName.TabIndex = 3;
            this.showSubDirName.Text = "サブフォルダ名を表示";
            this.showSubDirName.UseVisualStyleBackColor = true;
            // 
            // FileNameGetter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 326);
            this.Controls.Add(this.showSubDirName);
            this.Controls.Add(this.serchSubDir);
            this.Controls.Add(this.serchSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileNameGetter";
            this.Text = "FileNameGetter";
            this.Load += new System.EventHandler(this.FileNameGetter_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileNameGetter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileNameGetter_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serchSetting;
        private System.Windows.Forms.CheckBox serchSubDir;
        private System.Windows.Forms.CheckBox showSubDirName;
    }
}

