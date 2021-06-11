﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userInput;
            do
            {
                 
                 
                Console.WriteLine("-----Calculation Menu-----");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("0 - Exit the program!");

                userInput = menuSelection();
                Console.Clear();

                switch (userInput)
                {
                    case 1:
                        addition();
                        
                        break;

                    case 2:
                        subtraction();
                        break;

                    case 3:
                        multiplication();
                        break;

                    case 4:
                        divison();
                        break;

                    case 0:
                        Console.WriteLine("Press any key to quit!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Not valid, Try again:");
                        break;


                }   
            } while (userInput != 0);
               
            
                
           
        }

        static double addition()
        {
            double num1 = numberInput();
            double num2 = numberInput();

            double sum = num1 + num2;

            Console.WriteLine("\n\n" + num1 + "+" + num2 + " = " + sum + "\n\n");
            return 0;
            
        }

        static double subtraction()
        {

            double num1 = numberInput();
            double num2 = numberInput();

            double sum = num1 - num2;
            Console.WriteLine("\n\n" + num1 + "-" + num2 + " = " + sum + "\n\n");
            return 0;

        }
        static double multiplication()
        {
            double num1 = numberInput();
            double num2 = numberInput();

            double sum = num1 * num2;
            Console.WriteLine("\n\n" + num1 + "*" + num2 + " = " + sum + "\n\n");
            return 0;
        }

        static double divison()
        {
            double num1 = numberInput();
            double num2 = numberInput();
            double sum = num1/num2;

             while(num2 == 0)
            {
                Console.WriteLine("Sorry, you cant divide by 0!");
                num1 = numberInput();
                num2 = numberInput();
               sum = num1 / num2;
            }
            Console.WriteLine("\n\n" + num1 + "/" + num2 + " = " + sum + "\n\n");
            return sum;
        }

        static int menuSelection()
        {

            int number;
            String inputFromUser = Console.ReadLine();
            int.TryParse(inputFromUser, out number);

            while (!int.TryParse(inputFromUser, out number))
            {
                Console.WriteLine("Sorry, Wrong input! Try again.");
                inputFromUser = Console.ReadLine();
                int.TryParse(inputFromUser, out number);
            }
            return number;

        }

        static double numberInput()
        {
           
                Console.WriteLine("Enter First number:");
                string userUserInputNum = Console.ReadLine();
                double num;
                double.TryParse(userUserInputNum, out num);

            while (!double.TryParse(userUserInputNum, out num))
            {
                Console.WriteLine("Wrong input; try again");
                userUserInputNum = Console.ReadLine();

                double.TryParse(userUserInputNum, out num);

            }

            return num;
         
        }
  
    }

}
