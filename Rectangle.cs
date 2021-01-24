using System;

namespace AreaPerimeter_calculator_program
{
    internal class Rectangle
    {
        //Declares private variables for each of the properties of a rectangle
        private int _rectArea;

        private int _rectLength;
        private int _rectWidth;
        private int _rectPerimeter;

        //Declares public variables for each of the properites of a rectangle
        public int RectWidth
        {
            get { return _rectWidth; }
        }

        public int RectLength
        {
            get { return _rectLength; }
        }

        public int RectArea
        {
            get { return _rectArea; }
        }

        public int RectPerimeter
        {
            get { return _rectPerimeter; }
        }

        //Method for getting the value of the length of a rectangle from the user
        public void SetLength()
        {
            Console.WriteLine("Please enter the length of the rectangle:");
            Validate Validation1 = new Validate();
            _rectLength = Validation1.ValidateInput();
        }

        //Method for getting the value of the width of a rectangle from the user
        public void SetWidth()
        {
            Console.WriteLine("Please enter the width of the rectangle:");
            Validate Validation1 = new Validate();
            _rectWidth = Validation1.ValidateInput();
        }

        //Method for calculating the perimeter of a rectangle
        public void CalculatePerimeter()
        {
            _rectPerimeter = (_rectLength * 2) + (_rectWidth * 2);
        }

        //Method for calculating the area of a rectangle
        public void CalculateArea()
        {
            _rectArea = _rectLength * _rectWidth;
        }

        //Method for outputing the values of a rectangle
        public void OutputSize()
        {
            Console.WriteLine($"The rectangle has a width of {_rectWidth} and a length of {_rectLength}, an area of {_rectArea} and a perimeter of {_rectPerimeter}.");
            Console.ReadLine();
        }
    }
}