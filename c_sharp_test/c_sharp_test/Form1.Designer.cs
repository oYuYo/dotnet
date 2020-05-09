namespace c_sharp_test
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.split_text1 = new System.Windows.Forms.Label();
            this.split_text2 = new System.Windows.Forms.Label();
            this.split_text3 = new System.Windows.Forms.Label();
            this.split_text4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(236, 87);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "改行を入れた文字列を入力しろ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Split";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // split_text1
            // 
            this.split_text1.AutoSize = true;
            this.split_text1.Location = new System.Drawing.Point(40, 230);
            this.split_text1.Name = "split_text1";
            this.split_text1.Size = new System.Drawing.Size(35, 12);
            this.split_text1.TabIndex = 3;
            this.split_text1.Text = "label1";
            // 
            // split_text2
            // 
            this.split_text2.AutoSize = true;
            this.split_text2.Location = new System.Drawing.Point(40, 260);
            this.split_text2.Name = "split_text2";
            this.split_text2.Size = new System.Drawing.Size(35, 12);
            this.split_text2.TabIndex = 4;
            this.split_text2.Text = "label2";
            // 
            // split_text3
            // 
            this.split_text3.AutoSize = true;
            this.split_text3.Location = new System.Drawing.Point(40, 290);
            this.split_text3.Name = "split_text3";
            this.split_text3.Size = new System.Drawing.Size(35, 12);
            this.split_text3.TabIndex = 5;
            this.split_text3.Text = "label3";
            // 
            // split_text4
            // 
            this.split_text4.AutoSize = true;
            this.split_text4.Location = new System.Drawing.Point(40, 320);
            this.split_text4.Name = "split_text4";
            this.split_text4.Size = new System.Drawing.Size(35, 12);
            this.split_text4.TabIndex = 6;
            this.split_text4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.split_text4);
            this.Controls.Add(this.split_text3);
            this.Controls.Add(this.split_text2);
            this.Controls.Add(this.split_text1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label split_text1;
        private System.Windows.Forms.Label split_text2;
        private System.Windows.Forms.Label split_text3;
        private System.Windows.Forms.Label split_text4;
    }
}

