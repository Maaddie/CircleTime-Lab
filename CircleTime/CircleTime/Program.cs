using System;

namespace CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //here taking the CircleInfo Object and passing it to the Continue method
            CircleInfo circleInfo  = new CircleInfo();
            bool goOn = true;
            while (goOn == true)
            {
                circleInfo.CirclesList();

                goOn = Continue(circleInfo);
            }
        }

        //This is a continue method, basically if the user would like to continue entering circle Radius and returning the variable circle that is passed through the second object
        public static bool Continue(CircleInfo circle)
        {
            string input = GetUserInput("Would you like to continue ? y/n"); //Asking user if they would like to continue

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                //Here, saying Goodbye if the user chooses not to continue and taking the circle variable that is passed through the CircleInfo Object that contains the Circles list
                //and we count the objects (not sure if this is correct logic like "counting the objects")
                Console.WriteLine("Goodbye, you created " + circle.Circles.Count + " Circle Object(s).");

                //this foreach loop prints a list with all the info.
                foreach(Circle c in circle.Circles)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Radius is: " + c.Radius);
                    Console.WriteLine("Circumference is: " + c.CalculateCircumference());
                    Console.WriteLine("Area is: " + c.CalculateArea());
                    Console.WriteLine("");

                }
                return false;
            }
            else
            {
                Console.WriteLine("I am sorry! I don't understand that!");
                return Continue(circle);
            }
        }

        //Method taking in the user answer, and then assigns it to the continue method to then do its job 
        private static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userAnswer = Console.ReadLine().ToLower();

            return userAnswer;
        }
    }
}
