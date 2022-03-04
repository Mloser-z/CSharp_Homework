using System;

namespace Homework03
{
    public interface IGetSize
    {
        double GetSize();
    }

    public interface IIsShape
    {
        bool IsShape();
    }

    public abstract class Shape : IGetSize, IIsShape
    {
        public abstract double GetSize();
        public abstract bool IsShape();
    }

    public class Rectangle :Shape
    {
        private double _height;
        private double _width;

        public double HEIGHT
        {
            get => _height;
            set => _height = value;
        }

        public double WIDTH
        {
            get => _width;
            set => _width = value;
        }

        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }

        public override double GetSize()
        {
            return _height * _width;
        }

        public override bool IsShape()
        {
            if (_height <= 0 || _width <= 0)
            {
                return false;
            }
            return true;
        }
    }

    public class Square : Rectangle
    {
        private double _side;

        public double SIDE
        {
            get => _side;
            set => _side = value;
        }

        public Square(double side) : base(side, side)
        {
            this._side = side;
        }
        
    }

    public class Triangle: Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public double SIDE1
        {
            get => _side1;
            set => _side1 = value;
        }

        public double SIDE2
        {
            get => _side2;
            set => _side2 = value;
        }

        public double SIDE3
        {
            get => _side3;
            set => _side3 = value;
        }

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override bool IsShape()
        {
            if (_side1 <= 0 || _side2 <= 0 || _side3 <= 0 || _side1 + _side2 <= _side3 || _side1 + _side3 <= _side2 || _side2 + _side3 <= _side1)
            {
                return false;
            }

            return true;
        }

        public override double GetSize()
        {
            double halfLength = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(halfLength * (halfLength - _side1) * (halfLength - _side2) * (halfLength - _side3));
        }
        
    }
    
    // 工厂设计模式
    public class ShapeFactory
    {
        public static Shape GetShapeFactory(params double[] sides)
        {
            switch (sides.Length)
            {
                case 1: 
                    return new Square(sides[0]);
                case 2: 
                    return new Rectangle(sides[0], sides[1]);
                case 3: 
                    return new Triangle(sides[0], sides[1], sides[2]);
                default:
                    throw new ArgumentException("参数错误");
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();         // 随机数声明在循环外，防止重复
            for (int i = 1; i <= 10; i++)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        Shape s = ShapeFactory.GetShapeFactory(rand.NextDouble());
                        if (s.IsShape())
                        {
                            Console.WriteLine("第" + i + "个图形为正方形，面积为" + s.GetSize());
                        }
                        else
                        {
                            Console.WriteLine("第" + i + "图形不为正方形");
                        }
                        break;
                    case 1:
                        Shape t = ShapeFactory.GetShapeFactory(rand.NextDouble(), rand.NextDouble());
                        if (t.IsShape())
                        {
                            Console.WriteLine("第" + i + "图形为长方形，面积为" + t.GetSize());
                        }
                        else
                        {
                            Console.WriteLine("第" + i + "图形不为正方形");
                        }
                        break;
                    case 2:
                        Shape q = ShapeFactory.GetShapeFactory(rand.NextDouble(), rand.NextDouble(), rand.NextDouble());
                        if (q.IsShape())
                        {
                            Console.WriteLine("第" + i + "图形为三角形，面积为" + q.GetSize());
                        }
                        else
                        {
                            Console.WriteLine("第" + i + "图形不为正方形");
                        }
                        break;
                }
            }
        }
    }
}