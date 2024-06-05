using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_P_A
{
    public partial class Form1 : Form // 继承自Windows窗体
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name; // 图形名称
            if (radioButton_circle.Checked) // 如果圆形单选框被选中
            {
                name = radioButton_circle.Text; // 获取图形名称
                double radius = double.Parse(textBox1.Text); // 获取半径
                Circle c1 = new Circle(name, radius); // 创建圆形对象
                textBox_result.Text = "名称：" + c1.Name + "，面积=" + c1.GetArea() + "，" +
                    "周长=" + c1.GetPerimeter(); // 显示结果
            }

            if (radioButton_rect.Checked) // 如果长方形单选框被选中
            {
                name = radioButton_rect.Text; // 获取图形名称
                double length = double.Parse(textBox1.Text); // 获取长方形的长
                double width = double.Parse(textBox2.Text); // 获取长方形的宽
                Rectangle t1 = new Rectangle(name, length, width); // 创建长方形对象
                textBox_result.Text = "名称：" + t1.Name + "，面积=" + t1.GetArea() + "，" +
                    "周长=" + t1.GetPerimeter(); // 显示结果
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_circle.Checked = true; // 默认选中圆形单选框
            radioButton_rect.Checked = false;
            label2.Visible = false;
            label2.Text = "长方形的宽";
            label1.Visible = true;
            label1.Text = "圆半径";
            textBox1.Visible = true; textBox2.Visible = false;
        }

        private void radioButton_circle_Click(object sender, EventArgs e)
        {
            radioButton_circle.Checked = true; // 选中圆形单选框
            radioButton_rect.Checked = false;
            label2.Visible = false;
            label1.Text = "圆半径";
            textBox1.Visible = true; textBox2.Visible = false;
        }

        private void radioButton_rect_Click(object sender, EventArgs e)
        {
            radioButton_circle.Checked = false;
            radioButton_rect.Checked = true; // 选中长方形单选框
            label1.Text = "长方形的长";
            label2.Text = "长方形的宽";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true;
        }
    }
}
