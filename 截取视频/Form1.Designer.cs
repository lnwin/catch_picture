namespace 截取视频
{
    partial class 视频逐帧截图
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(94, 215);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(146, 20);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "选择并开始";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPath.ForeColor = System.Drawing.Color.Gray;
            this.txtPath.Location = new System.Drawing.Point(26, 179);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(295, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "选择视频文件夹并作为图片保存路径";
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFrame
            // 
            this.txtFrame.ForeColor = System.Drawing.Color.Gray;
            this.txtFrame.Location = new System.Drawing.Point(94, 113);
            this.txtFrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(76, 21);
            this.txtFrame.TabIndex = 2;
            this.txtFrame.Text = "输入帧数";
            this.txtFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFrame_MouseClick);
            // 
            // txtStart
            // 
            this.txtStart.ForeColor = System.Drawing.Color.Gray;
            this.txtStart.Location = new System.Drawing.Point(94, 60);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(76, 21);
            this.txtStart.TabIndex = 3;
            this.txtStart.Text = "输入第几秒";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStart_MouseClick);
            // 
            // txtEnd
            // 
            this.txtEnd.ForeColor = System.Drawing.Color.Gray;
            this.txtEnd.Location = new System.Drawing.Point(245, 60);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(76, 21);
            this.txtEnd.TabIndex = 4;
            this.txtEnd.Text = "输入第几秒";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnd_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "结束时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "帧数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "尺寸：";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(245, 116);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(32, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "×";
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(304, 116);
            this.txtHigh.Margin = new System.Windows.Forms.Padding(2);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(32, 21);
            this.txtHigh.TabIndex = 11;
            this.txtHigh.Text = "0";
            this.txtHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 视频逐帧截图
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 256);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtFrame);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "视频逐帧截图";
            this.Text = "视频逐帧截图";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFrame;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHigh;
    }
}

