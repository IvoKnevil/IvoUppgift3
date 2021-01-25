using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Utilities
{
    class Game
    {

        private bool keepPlaying = true;
        Random random = new Random();
        Player player = new Player();

        public void Startgame()
        {

            while (keepPlaying)
            {
                ProgramLayout();
                Welcome();
                InitializePlayer();


                //InitializeMonsters();
                //ShowGameMenu(player); //Calls method to show the main menu
                //GameActions(Menu.PlayerMenuChoice(player), player); //calls method that takes user menu choice. Sends the info to method PlayerMenuChoice in the class Menu.
            }

        }


        void InitializePlayer()
        {
            Console.Write("Please enter your name: ");
            player = new Player(Console.ReadLine(), 1);
            Console.Clear();

        }



        private void ProgramLayout()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "World of Turdcraft";
        }

        private void Welcome()
        {

            Console.WriteLine("\n      *****************************************");
            Console.WriteLine("      *   W E L C O M E  T O  T H E  G A M E  *");
            Console.WriteLine("      *****************************************\n");

        }

        private void ClearScreen()
        {
            Console.WriteLine("Tryck valfritt tangent för att fortsätta.");
            Console.ReadKey();
            Console.Clear();

        }


        public void ExitGame()
        {
            Console.WriteLine("Thanks for playing. See ya!");

        }


    }
}
