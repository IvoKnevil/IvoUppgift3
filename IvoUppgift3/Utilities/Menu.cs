using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Utilities
{
    class Menu
    {

        private static List<string> gameMenu = new List<string>() { "Go adventuring", "Show detalis about your character", "Exit game" };
        private static int playerChoice;
        private static string userInputDescription;
        private static string inputText;
        private static object[] menuChoiceToReturn = new object[2];


        static public void GameMenu()  //Prints game menu

        {
            for (int i = 0; i < gameMenu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gameMenu[i]}");
            }
        }

        static public object[] PlayerMenuChoice(object player) //method reads users choice (choice=int, choice description=string), adds these to the array MenuChoiceToReturn. The array is sent back to the game. 
        {

            Console.Write($"What would you like to do {player}? ");
            inputText = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputText)) //Handles exceptions if player misses to make a choice in game menu
            {
                playerChoice = Convert.ToInt32(inputText);
            }
            else
            {
                ReturnErrorMsg(0);
            }
            

            Console.Clear();

            menuChoiceToReturn[0] = playerChoice;

            if (playerChoice > 0 && playerChoice <= gameMenu.Count) //if-else condition for error handling (user making choices out of menu range).
            {
                userInputDescription = gameMenu[playerChoice - 1];
            }
            else
            {
                userInputDescription = ReturnErrorMsg(playerChoice);
            }

            menuChoiceToReturn[1] = userInputDescription;

            return menuChoiceToReturn;

        }




        static public string ReturnErrorMsg(int userInput)
        {

            return $"choice nr {userInput} doesn't exist at the moment.\nSo you dont get dissapointed that you choice got you " +
                        $"nowhere, here is a website you should visit.\n\n ivonazlic.com";
        }






















    }
}
