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
            this.SuspendLayout();
            // 
            // Temp_Delete
            // 
            this.Temp_Delete.Location = new System.Drawing.Point(12, 12);
            this.Temp_Delete.Name = "Temp_Delete";
            this.Temp_Delete.Size = new System.Drawing.Size(132, 23);
            this.Temp_Delete.TabIndex = 0;
            this.Temp_Delete.Text = "Temp Delete";
            this.Temp_Delete.UseVisualStyleBackColor = true;
            this.Temp_Delete.Click += new System.EventHandler(this.Temp_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.Temp_Delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Temp_Delete;
    }
}

