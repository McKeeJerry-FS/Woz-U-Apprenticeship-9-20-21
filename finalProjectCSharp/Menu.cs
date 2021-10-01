using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Jerry McKee Jr.
10/01/2021
Woz-U Apprenticeship Training
Final Project for C# Core
*/ 


namespace finalProjectCSharp
{
    /*
    This class is used strictly to build menus that will be
    used within the different programs within this application
    */ 
     
    public class Menu
    {

        //Fields
        private string _title;
        private List<string> _menuItems;

        // This method sets the fields "_title" and "_menuItems"
        public void Init(string title, List<string> menuItems)
        {
            _title = title;
            _menuItems = menuItems;

            Display(1);
        }
        // end Init()

        // This method displays the menu options available to the user
        private void Display(int menuOption)
        {
            UI.Animation("Loading");
            Console.Clear();
            UI.Header(_title);
            // for() loop to cycle through each of the lists
            foreach (string item in _menuItems)
            {

                Console.WriteLine($"[{menuOption}] {item}");
                menuOption++;
            }
            Console.WriteLine();
            Console.WriteLine("[0] Exit");
        }
        // end Display()
    }
}
