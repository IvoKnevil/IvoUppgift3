using IvoUppgift3.Enemies;
using IvoUppgift3.Enemies.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvoUppgift3.Utilities
{
    class Game
    {

        private bool keepPlaying = true;
        Random random = new Random();
        Player player = new Player();
        List<Monster> listOfMonsters = new List<Monster>();

        public void Startgame()
        {

            while (keepPlaying)
            {
                ProgramLayout();
                Welcome();
                InitializePlayer();
                InitializeMonsters();


                Console.WriteLine(listOfMonsters[0].monsterLevel(player.Level));
                Console.WriteLine();
                ClearScreen();
            
                

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

         void InitializeMonsters()
        {

            NiceOldLady niceOldLady = new NiceOldLady();
            Greta greta = new Greta();
            List<Monster> listToShuffle = new List<Monster>() { greta, niceOldLady };

            Console.WriteLine("List to shuffle");
            foreach (Monster item in listToShuffle)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List after shuffle");
            int i = listToShuffle.Count;
            while (i > 0)
            {
                i--;
                int listIndex = random.Next(i + 1);
                listOfMonsters.Add(listToShuffle[listIndex]);
                listToShuffle.RemoveAt(listIndex);

            }

            foreach (Monster item in listOfMonsters)
            {
                Console.WriteLine(item);
            }

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
