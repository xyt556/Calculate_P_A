﻿namespace Calculate_P_A
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_rect = new System.Windows.Forms.RadioButton();
            this.radioButton_circle = new System.Windows.Forms.RadioButton();
            this.label_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_rect);
            this.groupBox1.Controls.Add(this.radioButton_circle);
            this.groupBox1.Location = new System.Drawing.Point(37, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "形状类型选择";
            // 
            // radioButton_rect
            // 
            this.radioButton_rect.AutoSize = true;
            this.radioButton_rect.Location = new System.Drawing.Point(21, 67);
            this.radioButton_rect.Name = "radioButton_rect";
            this.radioButton_rect.Size = new System.Drawing.Size(59, 16);
            this.radioButton_rect.TabIndex = 1;
            this.radioButton_rect.Text = "长方形";
            this.radioButton_rect.UseVisualStyleBackColor = true;
            this.radioButton_rect.Click += new System.EventHandler(this.radioButton_rect_Click);
            // 
            // radioButton_circle
            // 
            this.radioButton_circle.AutoSize = true;
            this.radioButton_circle.Checked = true;
            this.radioButton_circle.Location = new System.Drawing.Point(21, 35);
            this.radioButton_circle.Name = "radioButton_circle";
            this.radioButton_circle.Size = new System.Drawing.Size(35, 16);
            this.radioButton_circle.TabIndex = 0;
            this.radioButton_circle.TabStop = true;
            this.radioButton_circle.Text = "圆";
            this.radioButton_circle.UseVisualStyleBackColor = true;
            this.radioButton_circle.Click += new System.EventHandler(this.radioButton_circle_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(28, 178);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(53, 12);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "计算结果";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "计算面积和周长";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(87, 175);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(298, 21);
            this.textBox_result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "圆半径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "长方形的宽";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 215);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "几何参数计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_rect;
        private System.Windows.Forms.RadioButton radioButton_circle;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

