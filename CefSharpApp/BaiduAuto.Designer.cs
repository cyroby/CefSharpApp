﻿namespace CefSharpApp
{
    partial class BaiduAuto
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scUD = new System.Windows.Forms.SplitContainer();
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ofKeyWord = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.scUD)).BeginInit();
            this.scUD.Panel2.SuspendLayout();
            this.scUD.SuspendLayout();
            this.gbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // scUD
            // 
            this.scUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scUD.Location = new System.Drawing.Point(0, 0);
            this.scUD.Name = "scUD";
            this.scUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scUD.Panel2
            // 
            this.scUD.Panel2.BackColor = System.Drawing.Color.White;
            this.scUD.Panel2.Controls.Add(this.gbShow);
            this.scUD.Panel2.Controls.Add(this.button5);
            this.scUD.Size = new System.Drawing.Size(497, 724);
            this.scUD.SplitterDistance = 652;
            this.scUD.TabIndex = 0;
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.button1);
            this.gbShow.Controls.Add(this.button2);
            this.gbShow.Controls.Add(this.button4);
            this.gbShow.Controls.Add(this.button3);
            this.gbShow.Location = new System.Drawing.Point(365, 28);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(317, 45);
            this.gbShow.TabIndex = 4;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "功能";
            this.gbShow.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "F12";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "LoadHtml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "打开百度";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "执行JS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(130, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "开始自动搜索关键字";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ofKeyWord
            // 
            this.ofKeyWord.FileName = "keyword.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 724);
            this.Controls.Add(this.scUD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度关键字自动搜索";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.scUD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scUD)).EndInit();
            this.scUD.ResumeLayout(false);
            this.gbShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.OpenFileDialog ofKeyWord;
    }
}

