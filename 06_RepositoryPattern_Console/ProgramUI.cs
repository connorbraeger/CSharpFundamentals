﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        //Method that runs/starts the application
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            //Display our options to the user
            Console.WriteLine("Select a menu option:\n" +
                "1. Create New Content\n" +
                "2. View All Content\n" +
                "3. View Content By Title\n" +
                "4. Update Existing Content\n" +
                "5. Delete Existing Content\n" +
                "6. Exit");
            //Get the user's input
            string input = Console.ReadLine();
            //Evaluate the user's input and act accordingly
            switch (input)
            {
                case "1":
                    //Create new content
                    break;
                case "2":
                    //View All Content
                    break;
                case "3":
                    //View Content By title
                    break;
                case "4":
                    //Update Existing Content
                    break;
                case "5":
                    //Delete Existing Content
            }
        }
    }
}
