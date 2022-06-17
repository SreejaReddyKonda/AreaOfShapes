using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double l = 0;
            double w = 0;
            double h = 0;
            double b = 0;
            double r = 0;

        Choice:
            Console.WriteLine("For what shape you want to calculate the Area:\n1. Sqaure\n2. Rectangle\n3. Triangle\n4. Circle");
            Console.Write("Please Select the number from above options: ");
            int choice = int.Parse(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Console.Write("Please enter the side of square: ");
                    s = double.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Please enter the length of rectangle: ");
                    l = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the width of rectangle: ");
                    w = double.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Please enter the height of triangle: ");
                    h = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the base of triangle: ");
                    b = double.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Please enter the radius of circle: ");
                    r = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Incorrect Choice, please try again!");
                    goto Choice;
            }

            CalculateArea Sqa = new Square();
            CalculateArea Rec = new Rectangle();
            CalculateArea Tri = new Triangle();
            CalculateArea Cir = new Circle();
            if (choice == 1)
            {
                Sqa.Area(s);
                Sqa.ShowResult();
            }
            else if (choice == 2)
            {
                Rec.Area(l, w);
                Rec.ShowResult();
            }
            else if (choice == 3)
            {
                Tri.Area(h, b);
                Tri.ShowResult();
            }
            else
            {
                Cir.Area(r);
                Cir.ShowResult();
            }


        ChoiceOfAnotherCalculation:
            Console.Write("\nDo you want to calculate area of any other shape? Give input in Y or N: ");
            string choice1 = Console.ReadLine();

            switch (choice1.ToUpper())
            {
                case "Y":
                    goto Choice;
                case "N":
                    break;
                default:
                    Console.WriteLine("Incorrect Choice, please try again!");
                    goto ChoiceOfAnotherCalculation;
            }
        }
    }

 class CalculateArea
 {
        public double result;
        public virtual void Area(double s)
        {
        }
        public virtual void Area(double l, double w)
        {
        }
        public void ShowResult()
        {
            Console.WriteLine($"Your Result is {result}");
        }
 }
    class Square : CalculateArea
    {

        public override void Area(double s)
        {
            result = s * s;
        }

    }
    class Rectangle : CalculateArea
    {
        public override void Area(double l, double w)
        {
            result = l * w;
        }
    }
    class Triangle : CalculateArea
    {
        public override void Area(double b, double h)
        {
            result = (b * h) / 2;
        }
    }
    class Circle : CalculateArea
    {
        public override void Area(double r)
        {
            result = 3.14159 * r * r;
        }
    }
}

