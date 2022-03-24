namespace Soft
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.Temp_Delete = new System.Windows.Forms.Button();
            this.Folder_Delete = new System.Windows.Forms.Button();
            this.Omikuji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temp_Delete
            // 
            this.Temp_Delete.Location = new System.Drawing.Point(12, 12);
            this.Temp_Delete.Name = "Temp_Delete";
            this.Temp_Delete.Size = new System.Drawing.Size(112, 23);
            this.Temp_Delete.TabIndex = 0;
            this.Temp_Delete.Text = "Temp Delete";
            this.Temp_Delete.UseVisualStyleBackColor = true;
            this.Temp_Delete.Click += new System.EventHandler(this.Temp_Delete_Click);
            // 
            // Folder_Delete
            // 
            this.Folder_Delete.Location = new System.Drawing.Point(130, 12);
            this.Folder_Delete.Name = "Folder_Delete";
            this.Folder_Delete.Size = new System.Drawing.Size(130, 23);
            this.Folder_Delete.TabIndex = 1;
            this.Folder_Delete.Text = "Directory Delete";
            this.Folder_Delete.UseVisualStyleBackColor = true;
            this.Folder_Delete.Click += new System.EventHandler(this.Folder_Delete_Click);
            // 
            // Omikuji
            // 
            this.Omikuji.Location = new System.Drawing.Point(267, 13);
            this.Omikuji.Name = "Omikuji";
            this.Omikuji.Size = new System.Drawing.Size(75, 23);
            this.Omikuji.TabIndex = 2;
            this.Omikuji.Text = "Omikuji";
            this.Omikuji.UseVisualStyleBackColor = true;
            this.Omikuji.Click += new System.EventHandler(this.Omikuji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.Omikuji);
            this.Controls.Add(this.Folder_Delete);
            this.Controls.Add(this.Temp_Delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Temp_Delete;
        private System.Windows.Forms.Button Folder_Delete;
        private System.Windows.Forms.Button Omikuji;
    }
}

