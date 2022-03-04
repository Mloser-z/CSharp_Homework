using System.Runtime.InteropServices;

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

    public class Rectangle : IGetSize, IIsShape
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

        public double GetSize()
        {
            return _height * _width;
        }

        public bool IsShape()
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

    public class Triangle : IGetSize, IIsShape
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

        public bool IsShape()
        {
            if (_side1 <= 0 || _side2 <= 0 || _side3 <= 0 || _side1 + _side2 <= _side3 || _side1 + _side3 <= _side2 || _side2 + _side3 <= _side1)
            {
                return false;
            }

            return true;
        }

        public double GetSize()
        {
            double halfLength = (_side1 + _side2 + _side3) / 2;
            return System.Math.Sqrt(halfLength * (halfLength - _side1) * (halfLength - _side2) * (halfLength - _side3));
        }
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}