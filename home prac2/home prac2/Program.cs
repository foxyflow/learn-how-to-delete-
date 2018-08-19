using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Hello my teapot, I am interested in you");
            Console.WriteLine("What is your name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Hi there " + firstname);
            //yes -- massive achievement, finally understanding this
            Console.WriteLine("What's your age deary?");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Okay dearly whatever you say");
            Console.WriteLine("What is your gender sweetpea?");
            string gender = Console.ReadLine();

            Console.WriteLine("Okay this is what I know so far ");
            Console.WriteLine("Your name is " + firstname);
            Console.WriteLine("your age is apparently " + age);
            Console.WriteLine("And your gender is " + gender);

            //your next mission awaits (math)
            Console.WriteLine("Are you ready for you mission " + firstname);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("please enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter another number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
            Console.ReadLine();
            Console.WriteLine("now let's see what we get if we minus the same numbers");

            Console.WriteLine("{0} - {1} = {2}", number1, number2,(number1 - number2));
            Console.WriteLine("take a guess at mulitplying them ... is this what you got");
            Console.ReadLine();
            Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
            Console.ReadLine();
            Console.WriteLine(" this is what we get if we divide these numbers:");
            Console.ReadLine();
            Console.WriteLine("{0} / {1} = {2}", number1, number2, (number1 / number2));
            Console.ReadLine();
            Console.WriteLine("good old math. Let's do something else for your next mission");
            Console.ReadLine();

            Console.Clear(); //first and lastname together:

            Console.WriteLine("Okay, please write your first name (press enter) and then last name again if you want to continue");
            string fname = Console.ReadLine();
            string sname = Console.ReadLine();
            string fullName = fname + "  "  + sname;
            Console.WriteLine("hello " + fullName);

            //if statements
            {
                Console.WriteLine("please enter a number only");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                int num2 = int.Parse(Console.ReadLine());
                //use if and else to check which is the bigger number
                if (num1 == num2)
                    //$ allows me to use varibles inline
                    Console.WriteLine("the numbers are equal");
                else if (num1 > num2)
                    Console.WriteLine($"the first number entered, {num1}, is larger");
                else
                    Console.WriteLine($"the second number entered, {num2}, is larger");
                Console.WriteLine("you win; game over");
                Console.ReadLine();
                Console.Clear();
            }

            //if statements continued
            Console.WriteLine("Bonus Round");
            Console.ReadLine();
            Console.WriteLine("guess my number");
            int number = 7;
            Console.WriteLine("guess my number between 10");
            int guess = int.Parse(Console.ReadLine());
            if (guess == number)//the right answer
                Console.WriteLine("yay youre a winner");
            else if (guess > number)//sorry too high
                Console.WriteLine("sorry too high");
            else//guess was too low
                Console.WriteLine("loser, too low");
            Console.WriteLine("... let's move on ...");
            Console.ReadLine();
            Console.Clear();

            //if statements again -- practise -- 
            {
                Console.WriteLine("wax on wax off -- you need practise even if you got it right because I am a troll");
                Console.WriteLine("I will give you 2 more tries before I close and you have to start all over again becasue I forgot too loop");
                Console.ReadLine();
                int no = 7;
                Console.Write("what's my number");
                int guessme = int.Parse(Console.ReadLine());
                if (guessme == no)
                    Console.WriteLine("Finally youre right");
                else if (guessme > no)
                    Console.WriteLine("too high ... pot head");
                else
                    Console.WriteLine("tooooooo llloooooooooooowwwwwww");
                Console.WriteLine("one more time for good measure");
            }
            { Console.WriteLine("even if you got it right, we have to do this three times because I don't know loops yet");
                Console.ReadLine();

                Console.WriteLine("please enter another number between 0 and 10");
                int nummy = 7;
                int yourguess = int.Parse(Console.ReadLine());
                if (yourguess == nummy)
                    Console.WriteLine("youre right");
                else if (yourguess > nummy)
                    Console.WriteLine("too high");
                else 
                    Console.WriteLine("too low, let's move on, press enter");
                Console.ReadLine();
                Console.Clear();
                //grades 
                {
                    Console.WriteLine("Okay still with me?");
                    Console.WriteLine("now I will give you a grade based off a number you give me");
                    Console.WriteLine("do a decimal if you like, I can handle it");
                    float mark = float.Parse(Console.ReadLine());
                    if (mark >= 90 && mark <= 100)
                        Console.WriteLine("A+ for you");
                    else if (mark >= 80 && mark <= 89)
                        Console.WriteLine("A for effort");
                    else if (mark >= 70 && mark <= 79)
                        Console.WriteLine("B+ peooples");
                    else if (mark >= 60 && mark <= 69)
                        Console.WriteLine("Bs and Cs get degrees (you got a b");
                    else if (mark >= 50 && mark <= 59)
                        Console.WriteLine("you got a C");
                    else if (mark >= 0 && mark <= 49)
                        Console.WriteLine("you didn't do your homework -- hope that videogame was worth it because you have failed,, back to plastering");
                    else
                        Console.WriteLine("there was a problem with the mark you entered");
                    Console.WriteLine("you have made it to the end. goodbye");
                    Console.ReadLine();
                    Console.Clear();

                }


                   




            }
            


                





        



     
           














           

            
            
            

           
        
        



        }
    }
}
