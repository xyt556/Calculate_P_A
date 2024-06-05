using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_P_A
{
    //定义形状接口
    interface Shape
    {
        string Name { get; set; }  //名称属性
        double GetArea();          //计算面积方法
        double GetPerimeter();     //计算周长方法
    }

    //实现圆类
    class Circle : Shape
    {
        private string name;    //圆的名称
        private double radius;  //圆的半径

        public Circle(string name, double radius)
        {
            this.name = name;
            this.radius = radius;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //计算圆的面积
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        //计算圆的周长
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    //实现长方形类
    class Rectangle : Shape
    {
        private string name;    //长方形的名称
        private double length;  //长方形的长度
        private double width;   //长方形的宽度

        public Rectangle(string name, double length, double width)
        {
            this.name = name;
            this.length = length;
            this.width = width;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //计算长方形的面积
        public double GetArea()
        {
            return length * width;
        }

        //计算长方形的周长
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
}