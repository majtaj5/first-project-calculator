﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class MainMenuOutPut
    {
        public static void ShowMenuOptions()
        {
            string menuOptions= ("What would you like to do?\n"+
                "0-simple calculator\n" +
                "1-advenced calculator\n" +
                "2-workinig withthe text files\n" 
                );

            ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkGreen, menuOptions);
        }
    }
}


       
