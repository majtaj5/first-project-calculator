﻿using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MainMenuOutPut.ShowMenuOptions();
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case ("0"):
                    ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.Blue,
              "Type the equation you want to calculate.\n" +
              "You can add, subtract, multiply, divide two numbers.\n" +
              "\n" +
              "For example:\n" +
              "2+2\n" +
              "2*2\n"
              );
                    Calculator.Calculate();
                    break;
                case ("1"):
                    Console.WriteLine("menu-SimpleAlgoritms");
                    break;
                case ("2"):
                    Console.WriteLine("menu-working with text");
                    break;
            }
        }
    }
}
