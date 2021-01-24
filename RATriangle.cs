using System;

namespace AreaPerimeter_calculator_program
{
    internal class RATriangle
    {
        //Declares private variable for each property of a triangle
        private double _raTriArea;

        private int _raTriBase;
        private int _raTriHeight;
        private double _raTriPerimeter;

        //Declares public variables for the area and perimeter of a triangle
        public double raTriArea
        {
            get { return _raTriArea; }
        }

        public double raTriPerimeter
        {
            get { return _raTriPerimeter; }
        }

        //Method for getting the value for the base of the triangle from the user
        public void SetBase()
        {
            Console.WriteLine("Please enter the base of the triangle");
            Validate Validation1 = new Validate();
            _raTriBase = Validation1.ValidateInput();
        }

        //Method for getting the value for the height of the triangle from the user
        public void SetHeight()
        {
            Console.WriteLine("Please enter the height of the triangle");
            Validate Validation1 = new Validate();
            _raTriHeight = Validation1.ValidateInput();
        }

        //Method for calculating the area of a triangle
        public void CalculateArea()
        {
            _raTriArea = Math.Round(((_raTriBase * _raTriHeight) / 2.0), 2);
        }

        //Method for calculating the perimeter of a triangle
        public void CalulatePerimeter()
        {
            _raTriPerimeter = Math.Round((_raTriBase + _raTriHeight + (Math.Sqrt(Math.Pow(_raTriBase, 2) + (Math.Pow(_raTriHeight, 2))))), 2);
        }

        //Method for outputing the values of a triangle
        public void OutputSize()
        {
            Console.WriteLine($"The right-angled triangle has a base of {_raTriBase}, a height of {_raTriHeight}, an area of {_raTriArea} and a perimeter of {_raTriPerimeter}");
            Console.ReadLine();
        }
    }
}