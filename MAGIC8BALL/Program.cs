using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MAGIC8BALL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            //DEFAULT TEXT COLOR
            ConsoleColor oldColor = Console.ForegroundColor;

            NameOfTheGame();    //CALLING THE FUNCTION

            //CREATE A RANDOM OBJECT
            Random randomObject = new Random();




            while (true)
            {

                string questionString=GetQuestFromUser();


                //THIS MAKES THE PC PAUSE BETWEEN 1 AND 4 Sec BE4 GIVING THE ANSWER
                int numOfSecToSleep=randomObject.Next(5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PC THINKING....");
                Thread.Sleep(numOfSecToSleep * 1000);
                //EPI 1000 GIATI TA THELEI SE milliSeconds

                //Console.WriteLine("{0}", randomObject.Next(11));
                //DHL TYXAIOYS ARITHMOYS AP'TO 0-10


                //continue MEANS START OVER AT THE BEGINING OF THE Loop
                //AYTO THA GINEI AN DE GRAPSW TPT SAN ERWTHSH K APLA PATISW ENTER
                if (questionString.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("U NEED TO ASK A QUESTION!");
                    continue;
                }

                //IF THE USER TYPES QUIT THEN CLOSE THE APP
                //break MEANS GET OUT OF THE LOOP
                if (questionString.ToUpper() == "QUIT")
                {
                    break;
                }


                //IF THE USER INSULTS WITH YOU SUCK THEN ANSWER THEM
                //AS DESERVED AND CLOSE THE APP
                if (questionString.ToUpper() == "YOU SUCK")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("YOU SUCK MORE! BYE BYE!!");
                    break;
                }


                //GETTING A RANDOM NUMBER
                int randNumber = randomObject.Next(5);

                //EVERY PC ANSWER WILL HAVE A RANDOM COLOR
                //BUT EVERY ANSWER IS THE SAME COLOR
                //Console.ForegroundColor = (ConsoleColor)randNumber;

                //OR

                //EVERY PC ANSWER WILL HAVE A RANDOM COLOR
                //BUT NOW EVERY ANSWER IS A DIFFERENT COLOR
                Console.ForegroundColor=(ConsoleColor)randomObject.Next(15);

                //USING THE RANDOM NUMBER TO DETERMINE RESPONSE
                switch (randNumber)
                {
                    case 0:
                        Console.WriteLine("YES!");
                        break;
                    case 1:
                        Console.WriteLine("HELL YES!");
                        break;
                    case 2:
                        Console.WriteLine("NO!");
                        break;
                    case 3:
                        Console.WriteLine("HELL NO!");
                        break;
                    case 4:
                        Console.WriteLine("MAYBE!");
                        break;

                }

            }    //END OF THE while LOOP



            //CLEAN UP THE CHANGED COLOR
            Console.ForegroundColor = oldColor;


            Console.ReadLine();
        }
        /// <summary>
        /// CREATING A FUNCTION JUST TO DISPLAY THE NAME OF THE GAME
        /// </summary>
        static void NameOfTheGame()
        {
            //CHANGE TEXT COLOR
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("MAGIC");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("8  BALL  GAME!");
        }

        static string GetQuestFromUser()
        {
            //ASKS THE USER A QUESTION AND STORES THE
            //QUESTION IN questionString VARIABLE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("ASK A QUESTION: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
