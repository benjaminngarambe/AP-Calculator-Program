using System;

namespace AreaPerimeter_calculator_program
{
    internal class EQTriangle
    {
        //Declares private variable for each property of a triangle
        private double _eqTriArea;

        private int _eqTriBase;
        private int _eqTriHeight;
        private double _eqTriPerimeter;

        //Declares public variables for the area and perimeter of a triangle
        public double eqTriArea
        {
            get { return _eqTriArea; }
        }

        public double eqTriPerimeter
        {
            get { return _eqTriPerimeter; }
        }

        public int eqTriBase
        {
            get { return _eqTriBase; }
        }

        public int eqTriHeight
        {
            get { return _eqTriHeight; }
        }

        //Method for getting the value for the base of the triangle from the user
        public void SetBase()
        {
            Console.WriteLine("Please enter the base of the triangle");
            Validate Validation1 = new Validate();
            _eqTriBase = Validation1.ValidateInput();
        }

        //Method for getting the value for the height of the triangle from the user
        public void SetHeight()
        {
            Console.WriteLine("Please enter the height of the triangle");
            Validate Validation1 = new Validate();
            _eqTriHeight = Validation1.ValidateInput();
        }

        //Method for calculating the area of a triangle
        public void CalculateArea()
        {
            _eqTriArea = Math.Round(((_eqTriBase * _eqTriHeight) / 2.0), 2);
        }

        //Method for calculating the perimeter of a triangle
        public void CalulatePerimeter()
        {
            _eqTriPerimeter = Math.Round(_eqTriBase + ((Math.Sqrt((Math.Pow(_eqTriBase, 2) + 4 * (Math.Pow(_eqTriHeight, 2)))))), 2);
        }

        //Method for outputing the values of a triangle
        public void OutputSize()
        {
            Console.WriteLine($"The triangle has a base of {_eqTriBase}, a height of {_eqTriHeight}, an area of {_eqTriArea} and a perimeter of {_eqTriPerimeter}");
            Console.ReadLine();
        }
    }
}