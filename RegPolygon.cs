using System;

namespace AreaPerimeter_calculator_program
{
    internal class RegPolygon
    {
        //Declares private variables for each property of a regular polygon
        private int _numberOfSides;

        private int _regPolygonSide;
        private double _regPolygonArea;
        private double _regPolygonPerimeter;

        //Declare public variables for each property of a regular polygon
        public int NumberOfSides
        {
            get { return _numberOfSides; }
        }

        public int RegPolygonSide
        {
            get { return _regPolygonSide; }
        }

        public double RegPolgonArea
        {
            get { return _regPolygonArea; }
        }

        public double RegPolygonPerimeter
        {
            get { return _regPolygonPerimeter; }
        }

        //Method for getting the value for the number of sides of a regular polygon from the user
        public void GetNumberOfSides()
        {
            Console.WriteLine("How many sides does the regular polygon have?");
            try
            {
                _numberOfSides = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number!");
                this.GetNumberOfSides();
            }
            //Validation to check that the number of sides of a regular polygon is more than 2.
            if (_numberOfSides < 3)
            {
                Console.WriteLine("Please enter a number greater than 2!");
                this.GetNumberOfSides();
            }
        }

        //Method for getting the value of the length of the side of a regular polygon from the user
        public void GetSideLength()
        {
            Console.WriteLine("What is the length of one side?");
            Validate Validation1 = new Validate();
            _regPolygonSide = Validation1.ValidateInput();
        }

        //Method for calculating the value of the area of a regular polygon
        public void CalculateArea()
        {
            //The regular polygon is equal to...
            _regPolygonArea =
            //Rounds the number
            Math.Round((((
            //The apothem of a regular polygon is the shortest distance from the center point to one of the sides, creating a right angle.
            //The formula for calculating the length of the apothem is this: the length of the side (_regPolygonSide) divided by 2 times the tangent of 180 degrees divided by the number of sides (_numberOfSides).
            // * Math.PI/180 converts it to radians which is needed when using Math.Tan()
            _regPolygonSide / ((Math.Tan((180 / _numberOfSides) * Math.PI / 180)) * 2))
            //Area = (a x p)/2, where a is the length of the apothem (calculated in the last line) and p is the perimeter of the polygon (_regPolygonPerimeter).
            * _regPolygonPerimeter) / 2)
            //This defines how many decimal places the answer will be rounded to.
            , 2);
        }

        //Method for calculating the value of the perimeter of a regular polygon
        public void CalculatePerimeter()
        {
            _regPolygonPerimeter = _regPolygonSide * _numberOfSides;
        }

        //Method for outputing the values of a regular polygon
        public void OutputSize()
        {
            Console.WriteLine($"The regular polygon has {_numberOfSides} sides, a side length of {_regPolygonSide}, a perimeter of {_regPolygonPerimeter} and an area of {_regPolygonArea}");
            Console.ReadLine();
        }
    }
}