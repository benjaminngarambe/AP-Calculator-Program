using System;
using System.Threading;

namespace AreaPerimeter_calculator_program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Benjamin Ngarambe
            //Simple C# program that calulates the area and perimeter of shapes using the object oriented programming paradigm.
            Decision Decision1 = new Decision();
            Decision1.GetInput();
        }

        public class Decision
        {
            private int _userInput;

            public int UserInput
            {
                get { return _userInput; }
            }

            public void GetInput()
            {
                Console.WriteLine("Please enter what shape you would like to calculate\n1)Circle\n2)Rectangle\n3)Right-angled triangle\n4)Equilateral or isosceles traingle\n5)Regular Polygon ");
                try
                {
                    _userInput = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number!");
                    this.GetInput();
                }
                this.Decide();
            }

            public void Decide()
            {
                switch (_userInput)
                {
                    case 1:
                        Circle circ1 = new Circle();
                        circ1.SetRadius();
                        circ1.CalculateArea();
                        circ1.CalculatePerimeter();
                        circ1.OutputSize();
                        break;

                    case 2:
                        Rectangle rect1 = new Rectangle();
                        rect1.SetLength();
                        rect1.SetWidth();
                        rect1.CalculateArea();
                        rect1.CalculatePerimeter();
                        rect1.OutputSize();
                        break;

                    case 3:
                        RATriangle ratri1 = new RATriangle();
                        ratri1.SetBase();
                        ratri1.SetHeight();
                        ratri1.CalculateArea();
                        ratri1.CalulatePerimeter();
                        ratri1.OutputSize();
                        break;

                    case 4:
                        EQTriangle eqtri1 = new EQTriangle();
                        eqtri1.SetBase();
                        eqtri1.SetHeight();
                        eqtri1.CalculateArea();
                        eqtri1.CalulatePerimeter();
                        eqtri1.OutputSize();
                        break;

                    case 5:
                        RegPolygon regpolygon1 = new RegPolygon();
                        regpolygon1.GetNumberOfSides();
                        regpolygon1.GetSideLength();
                        regpolygon1.CalculatePerimeter();
                        regpolygon1.CalculateArea();
                        regpolygon1.OutputSize();
                        break;

                    default:
                        Console.WriteLine("********************************************\n********************************************\nPlease enter a number from 1 to 5!\n********************************************\n********************************************");
                        Thread.Sleep(1500);
                        Console.Clear();
                        this.GetInput();
                        break;
                }
            }
        }
    }
}