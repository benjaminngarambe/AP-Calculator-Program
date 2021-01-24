using System;

namespace AreaPerimeter_calculator_program
{
    internal class Circle
    {
        //Declares private variables for each of the properties of a circle
        private double _circArea;

        private int _circRadius;
        private double _circPerimeter;

        //Declares public variables for each of the properties of a circle
        public int circRadius
        {
            get { return _circRadius; }
        }

        public double circArea
        {
            get { return _circArea; }
        }

        public double circPerimeter
        {
            get { return _circPerimeter; }
        }

        //Method for getting the value of the radius of a circle from the user
        public void SetRadius()
        {
            Console.WriteLine("Please enter the radius of the circle:");
            Validate Validation1 = new Validate();
            _circRadius = Validation1.ValidateInput();
        }

        //Method for calculating the area of a circle
        public void CalculateArea()
        {
            _circArea = Math.Round(Math.PI * Math.Pow(_circRadius, 2), 2);
        }

        //Method for calculating the perimeter of a circle
        public void CalculatePerimeter()
        {
            _circPerimeter = Math.Round(Math.PI * (_circRadius * 2), 2);
        }

        //Method for outputing the values of a circle
        public void OutputSize()
        {
            Console.WriteLine($"The circle has a radius of {_circRadius}, an area of {_circArea} and a perimeter of {_circPerimeter}");
            Console.ReadLine();
        }
    }
}