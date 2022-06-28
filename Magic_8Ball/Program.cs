using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;
            FortuneTeller();

            Random randomObject = new Random();

            //While loop
            while (true)
            {
                string questionString = GetQuestionFromUSer();

                            

                if (questionString.Length == 0)
                {
                    Console.WriteLine("What is your question?");
                    continue;
                }
                 
                //to exit out program
                if ( questionString.ToLower() == "thanks")
                {
                    break;
                }
               
             
                //get a random #
                int randomNumber = randomObject.Next(7);

                //use random number to determine response
                Console.ForegroundColor = ConsoleColor.Red;
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes definitely");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Without a doubt.");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Most likely.");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" Signs point to yes.");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine(" Reply hazy, try againSigns point to yes.");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Better not tell you now.");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("  Don't count on it...");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(" My sources say no.");
                            break;
                        }
                }
            }//end of the loop
       
            //color will restore after closing application
            Console.ForegroundColor = oldColor;
        }
        //this will print the name of the program to the consoole
        static void FortuneTeller()
        {
            //change console text color back to original
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Magic 8 Ball");
        }
        static string GetQuestionFromUSer()
        {
            //this part willl ask user for the question and store question
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ask a question?:  ");
            Console.ForegroundColor = ConsoleColor.White;
            string questionString = Console.ReadLine();

            return questionString;
        }
                
    }
}
