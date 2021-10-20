using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    class CircleInfo
    {
        //The job of this Circle Info list is to add all of the circles into it
        public List<Circle> Circles = new List<Circle>();

        public void CirclesList()
        {
            //try catch exception used for validation
            try
            {
                //This gets user input for Radius
                string input = UserInput("Welcome to the Circle Tester. Please enter a Radius: ");

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Sorry! That is an invalid input. Please try again!!");
                    return;
                }
                //Taking user input and converting it to a double then taking the double and make a circle out of it that then gets added to the Circle List
                double inputAsDouble = double.Parse(input);
                Circle inputCircle = new Circle(inputAsDouble);

                //Here calling the methods from the Circle object to display to the console the Circumference and Area of Circle and then adding it to the Circles list.
                Console.WriteLine("Circumference is : " + inputCircle.CalculateCircumference());
                Console.WriteLine("Area is : " + inputCircle.CalculateArea());
                Circles.Add(inputCircle);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Hey, that's bad input. Try again");
            }
        }

        public string UserInput(string Input)
        {
            Console.WriteLine(Input);
            string input = Console.ReadLine();

            return input;
        }
    }


}
