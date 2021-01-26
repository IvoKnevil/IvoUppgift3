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

                //Console.WriteLine(listOfMonsters[0].monsterLevel(player.Level));          

                ShowGameMenu(); //Calls method to show the main menu
                GameActions(Menu.PlayerMenuChoice(player)); //calls method that takes user menu choice. Sends the info to method PlayerMenuChoice in the class Menu.
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

            int i = listToShuffle.Count;
            while (i > 0)
            {
                i--;
                int listIndex = random.Next(i + 1);
                listOfMonsters.Add(listToShuffle[listIndex]);
                listToShuffle.RemoveAt(listIndex);
            }

        }


        private void ShowGameMenu()
        {
            Menu.GameMenu();
        }

        private void GameActions(object[] userMenuChoice)
        {


            Console.WriteLine($"You've chosen {userMenuChoice[1]}\n");
            switch (userMenuChoice[0])
            {
                //Character goes on adventure if user chooses the first option in the menu. 
                case 1:

                    ClearScreen();
                    GoAdventure();
                    break;

                case 2:
                    ShowCharacterDetalis();
                    ClearScreen();
                    break;

                case 3:
                    keepPlaying = false;  //End program
                    break;

                default:
                    ClearScreen();
                    break;

            }

        }

        private void GoAdventure()
        {
            int randomAdventure = random.Next(1, 10);

            if (randomAdventure == 1)
            {
                Console.WriteLine("What a boring day. You just waste time going round trying to find some people to beat up, \n" +
                    "but nothing exciting comes your way. You just rob some random kids for fun.");
                ClearScreen();
            }
            else
            {
                Battle();
            }

        }



        private void Battle()
        {

            int monsterHp = listOfMonsters[player.Level - 1].HealthPoints(player.Level);
            Console.WriteLine("Finally you see some punk that needs asskicking!");
            Console.WriteLine($"{listOfMonsters[player.Level-1]}({monsterHp} healthpoints) walks straight at you. You just cant take it and you pick a fight.");
            Console.WriteLine($"You are {player}, the baddest mofo on the planet! \n");
            ClearScreen();



            
            while (!monster.isDead())
            {

                Console.WriteLine("You hit the " + monster.getName() + " for " + p1.attack(monster) + " dmg");
                Console.WriteLine("Monsters hp is now: " + monster.getHp());
                if (monster.isDead())
                {
                    Console.WriteLine("The monster is dead and you gained " + monster.getExp() + " xp ");


                    monster.isDead();
                    if (player.level == 10)
                    {
                        Console.WriteLine("Gz you won the game bruh!");
                        wonGame = true;
                    }
                    return;
                }
                Console.ReadKey();
                int monsterdmg = monster.attack();
                Console.WriteLine("The monster hit you for " + monsterdmg);
                Console.WriteLine("The monster hit you for " + monsterdmg);
                p1.takeDamage(monsterdmg);
                Console.WriteLine("Your current hp is: " + p1.Hp);

                Console.ReadKey();

            }
        
            

        }



        private void ShowCharacterDetalis()
        {
            // TODO print player
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
