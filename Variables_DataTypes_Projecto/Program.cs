using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes_Projecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            String yourCourse = Console.ReadLine();
            Console.WriteLine("The course you are on is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            String pageNumber = Console.ReadLine();
            Console.WriteLine("Glad to hear you're on page, " + pageNumber);
            Console.ReadLine();

            Console.WriteLine(" Do you need help with anything? Please answer “true” or “false”. ");
            Console.ReadLine();
            bool ifTrue = true;
            bool ifFalse = false;
            string needHelp = Convert.ToString(ifTrue);
            string doesntneedHelp = Convert.ToString(ifFalse);
            Console.WriteLine("Thank you");
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("Thanks again!");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            String studyHours = Console.ReadLine();
            Console.WriteLine( studyHours + " hours, Great job! ");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();





        }
    }
}
