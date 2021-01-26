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
        private bool lostGame, wonGame;

        public void Startgame()
        {
            ProgramLayout();
            Welcome();
            InitializePlayer();
            InitializeMonsters();

            while (keepPlaying)
            {
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
            var battleMonster = listOfMonsters[player.Level - 1];
            int monsterHp = battleMonster.HealthPoints(player.Level);
            Console.WriteLine("Finally you see some punk that needs asskicking!");
            Console.WriteLine($"{battleMonster}({monsterHp} healthpoints) walks straight at you. You just cant take it and you pick a fight.");
            Console.WriteLine($"You are {player}, the baddest mofo on the planet! \n");
            ClearScreen();


            while (!battleMonster.isDead() && !player.isDead())
            {

                Console.WriteLine($"{player.UseUniqueMoves()} {battleMonster} for {player.attack(battleMonster)} damage");
                Console.WriteLine($"{battleMonster}s hp is now: {battleMonster.getHp()}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------\n");
                if (battleMonster.isDead())
                {
                    player.Level++;
                    Console.WriteLine($"BOOOOOOOM. That irritating hideous {battleMonster} is dead.\n");
                    Console.WriteLine($"You stand tall and proud after your performace. You take a steroid shot and gain a whole new level of awesome! (level {player.Level})\n");
                    ClearScreen();

                    //battleMonster.isDead();
                    if (player.Level == 10)
                    {
                        Console.WriteLine("Gz you won the game bruh!");
                        wonGame = true;
                    }
                    return;
                }
                Console.ReadKey();
                int monsterdmg = battleMonster.attack(player.Level);
                Console.WriteLine($"{battleMonster} {battleMonster.UseUniqueMoves()}. You endure {monsterdmg} damage");
                player.takeDamage(monsterdmg);
                Console.WriteLine($"Your current hp is: {player.Hp}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------\n");
                if (player.isDead())
                {
                    Console.WriteLine("Bummer you died bro");
                }
                
                ClearScreen();

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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }


        public void ExitGame()
        {
            Console.WriteLine("Go die in a fire for quitting the game!");

        }


    }
}
