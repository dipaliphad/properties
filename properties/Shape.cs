using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    abstract public class Shape
    {
        public abstract void Area();
    
    }
    //public class Circle : Shape
    //{
    //    private int radius;
    //    private double result;

    //    public Circle(int radius)
    //    {
    //        this.radius = radius;
    //    }
    //    public override void Area()
    //    {
    //        result = 3.14 * radius * radius;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Area of Circle is {result}";
    //    }
        public class Rectangle : Shape
        {
            private int l, b;
            private double result;
            public Rectangle(int l, int b)
            {
                this.l = l;
                this.b = b;
            }
            public override void Area()
            {
                result = 2 * (l * b);
            }
            public override string ToString()
            {
                return $"Area of Rectangle is {result}";
            }
        }
    
    
}
