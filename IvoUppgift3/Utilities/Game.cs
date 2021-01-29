using IvoUppgift3.Enemies;
using IvoUppgift3.Enemies.Monsters;
using IvoUppgift3.Shop;
using IvoUppgift3.Shop.Trinkets;
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
        List<Monster> listOfKilledMonsters = new List<Monster>();
        List<Monster> listOfSpecialMonsters = new List<Monster>();
        List<Items> listOfAmmulets = new List<Items>();
        List<Items> listOfRings = new List<Items>();
        List<Items> listOfTrinkets = new List<Items>();

        Store store = new Store();
        private bool lostGame, wonGame;
        private bool visitStore = true;

        public void Startgame()
        {
            //start game by creating the layout
            //and initializing player and monsters
            ProgramLayout();
            Welcome();
            InitializePlayer();
            InitializeMonsters();
            InitializeItems();

            while (keepPlaying && !lostGame && !wonGame)
            {
                ShowGameMenu();
                GameActions(Menu.PlayerMenuChoice(player)); //calls method that takes user menu choice. Sends the info to method PlayerMenuChoice in the class Menu.
            }

        }


        private void InitializePlayer()  //initializes a player
        {
            Console.Write("Yo mofo enter your badass name: ");
            player = new Player(Console.ReadLine(), 1, 100, 0, 0, 0, 0);

            if (player.Name == "Robin")
            {
                GodMode();
            }

            Console.Clear();

        }

        private void GodMode()
        {
            player.Hp = 200;
            player.HpCoef = 200;
            player.Gold = 2000;
            Console.Clear();
            Console.WriteLine("\n      **************************************************************");
            Console.WriteLine("      *   W O A H   H O M I E   G O D M O D E   A C T I V A T E D  *");
            Console.WriteLine("      *                                                            *");
            Console.WriteLine("      *              G O   K I C K   A S S                         *");
            Console.WriteLine("      **************************************************************\n");
            ClearScreen();
        }

        private void InitializeMonsters() //initializes monsters and adds them to a list
        {

            NiceOldLady niceOldLady = new NiceOldLady();
            Greta greta = new Greta();
            Ghandi ghandi = new Ghandi();
            MLK mLK = new MLK();
            ObiWan obiWan = new ObiWan();
            Superman superman = new Superman();
            Frodo frodo = new Frodo();
            Batman batman = new Batman();
            McFly mcFly = new McFly();
            HarryPotter harryPotter = new HarryPotter();
            TrashMob trashMob = new TrashMob();

            listOfSpecialMonsters.AddRange(new Monster[]
            {
                greta, niceOldLady, ghandi, mLK, obiWan, superman, frodo, batman, mcFly, harryPotter
            });

            List<Monster> listToShuffle = new List<Monster>() { greta, niceOldLady, ghandi, mLK, obiWan, superman, frodo, batman, mcFly, harryPotter };

            //randomizes monsters to a new list so that the player doesnt always meet them in the same order
            int i = listToShuffle.Count;
            while (i > 0)
            {
                if (random.Next(10) <= 7)
                {
                    listOfMonsters.Add(trashMob);
                }
                else
                {
                    i--;
                    int listIndex = random.Next(i + 1);
                    listOfMonsters.Add(listToShuffle[listIndex]);
                    listToShuffle.RemoveAt(listIndex);
                }
            }

        }

        private void InitializeItems() //initializes items for the shop
        {

            Ammulet whiteTrashNecklace = new Ammulet("White trash necklace", random.Next(170, 250), 2);
            Ammulet leatherBracelet = new Ammulet("Leather bracelet", random.Next(189, 250), 2);
            Ammulet sunglasses = new Ammulet("Sunglasses", random.Next(209, 259), 2);
            Ammulet badassBoots = new Ammulet("Badass boots", random.Next(199, 249), 2);
            Ring fakeSilver = new Ring("Fake silver ring", random.Next(250, 350),2);
            Ring tattoedRing = new Ring("Tattoed ring", random.Next(280, 350),2);
            Ring oldFatGuyRing = new Ring("Old fatguy goldring", random.Next(320, 350),2);
            Trinket knife = new Trinket("Knife", random.Next(320, 350),3);
            Trinket bat = new Trinket("Baseball bat", random.Next(350, 380),3);
            Trinket beerBottle = new Trinket("Beer bottle", random.Next(400, 420),3);
            Trinket wifeBeater = new Trinket("Wife beater", random.Next(280, 420),3);

            List<Items> listOfItems = new List<Items>() { whiteTrashNecklace, leatherBracelet, sunglasses, badassBoots, fakeSilver, tattoedRing, oldFatGuyRing, knife, bat, beerBottle, wifeBeater };

            //loop to randomize what items will be available for purchase in the shop
            int i = listOfItems.Count;
            while (i > 0)
            {

                i--;
                int listIndex = random.Next(i + 1);

                if (listOfItems[listIndex] is Ammulet)
                {
                    listOfAmmulets.Add(listOfItems[listIndex]);
                }
                else if (listOfItems[listIndex] is Ring)
                {
                    listOfRings.Add(listOfItems[listIndex]);
                }
                else if (listOfItems[listIndex] is Trinket)
                {
                    listOfTrinkets.Add(listOfItems[listIndex]);
                }

                listOfItems.RemoveAt(listIndex);

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

                //the player choses to look at character details.
                case 2:
                    ShowCharacterDetalis();
                    ClearScreen();
                    break;

                case 3:
                    visitStore = true;
                    EnterShop();  //To buy items to make char more powerful
                    ClearScreen();
                    break;


                case 4:
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

            if (randomAdventure == 1) //10% chance of nothing happening
            {
                Console.WriteLine("What a boring day. You just waste time going round trying to find some people to beat up, \n" +
                    "but nothing exciting comes your way. You just rob some random kids for fun.");
                ClearScreen();
            }
            else
            {
                Battle(); // 90% chance player meets monster                     
            }

        }


        private void Battle()
        {

            var battleMonster = listOfMonsters[player.Level - 1];    //variable battlemonster to single out the monster to fight and keep code cleaner
            int monsterHp = battleMonster.HealthPoints(player.Level); //variable monsterHo to single out the health points of the monster to fight and keep code cleaner

            BattleIntro(battleMonster, monsterHp);

            while (!battleMonster.IsDead() && !player.IsDead())
            {
                //throws some attacks for random damage
                Console.WriteLine($"{player.UseUniqueMoves()} {battleMonster} for {player.Attack(battleMonster)} damage");
                Console.WriteLine($"{battleMonster}s hp is now: {battleMonster.GetHp()}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------\n");

                if (battleMonster.IsDead())
                {
                    player.HealthPoints(player.Level);
                    if (listOfSpecialMonsters.Contains(battleMonster))
                    {
                        listOfKilledMonsters.Add(battleMonster);
                    }

                    int lootGold = battleMonster.DropGold();
                    int receiveXp = battleMonster.GiveXp();
                    Console.WriteLine($"BOOOOOOOM. That irritating hideous {battleMonster} is dead!\n");
                    Console.WriteLine($"{battleMonster} drops {lootGold} gold");
                    Console.WriteLine($"You have: {player.GetGold(lootGold)} gold\n");
                    Console.WriteLine($"You receive {receiveXp} xp");
                    Console.WriteLine($"You have: {player.GainXp(receiveXp)} xp");

                    if (player.Xp >= 100)
                    {
                        Console.WriteLine("\n      **************************************************************");
                        Console.WriteLine("      *   W O A H   W O A H     W O A H       W O A H   W O A H    *");
                        Console.WriteLine("      *                                                            *");
                        Console.WriteLine("      *              G A I N E D   L E V E L                       *");
                        Console.WriteLine("      **************************************************************\n");
                        player.Level++;
                        player.ResetXp();
                        player.HealthPoints(player.Level);
                        Console.WriteLine($"You stand tall and proud after your performace. \nYou take a steroid shot and gain a whole new level of awesome! (level {player.Level})\n");

                    }
                    listOfMonsters.RemoveAt(0);
                    ClearScreen();
                    battleMonster.IsDead();

                    if (player.Level == 10)
                    {
                        wonGame = true;
                    }
                    return;
                }

                Console.ReadKey();

                //receives random attacks
                int monsterdmg = (battleMonster.Attack(player.Level)) - player.Toughness;
                Console.WriteLine($"{battleMonster} {battleMonster.UseUniqueMoves()}. You endure {monsterdmg} damage");
                player.TakeDamage(monsterdmg);
                Console.WriteLine($"Your current hp is: {player.GetHp()}\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------\n");

                if (player.IsDead())
                {
                    lostGame = true;
                }

                ClearScreen();

            }

        }

        private void BattleIntro(Monster battleMonster, int monsterHp)
        {
            Console.WriteLine("Finally you see some punk that needs asskicking!");
            Console.WriteLine($"{battleMonster}({monsterHp} healthpoints) walks straight at you. You just cant take it and you pick a fight.\n");
            Console.WriteLine($"Afterall, you are {player}, the baddest mofo on the planet! \n");
            ClearScreen();
        }

        private void ShowCharacterDetalis()
        {
            Console.WriteLine("___________________________________\n");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Exp: {player.Xp}/100");
            Console.WriteLine($"Hp: {player.HealthPoints(player.Level)} points");
            Console.WriteLine($"Strenght: {player.Strenght}");
            Console.WriteLine($"Toughness: {player.Toughness}");
            Console.WriteLine($"Crit increase: {player.CritChance}");
            Console.WriteLine("Monsters killed: " + (String.Join(", ", listOfKilledMonsters) + "\n"));
            Console.WriteLine("___________________________________\n");

        }

        private void EnterShop()
        {

            Console.WriteLine("You enter a somewhat dark and smelly place...");
            Console.WriteLine("You feel at home...\n");

            Console.WriteLine($"Behind the counter is your buddy {store.StoreClerk()}\n");
            ClearScreen();

            while (visitStore)
            {
                Console.WriteLine("Whatcha need bro?");
                Menu.StoreMenu();

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        InspectAmmulets();
                        break;
                    case 2:
                        InspectRings();
                        break;
                    case 3:
                        InspectTrinkets();
                        break;
                    case 4:
                        ExitStore();
                        break;

                }
            }
        }

        private void ExitStore()
        {
            Console.Clear();
            Console.WriteLine("Sod off!\n");
            visitStore = false;
        }

        private void InspectTrinkets()
        {
            Console.Clear();
            if (listOfTrinkets.Count > 1)
            {
                Console.WriteLine($"I have {listOfTrinkets[0]} for sale\n");
                ClearScreen();
                listOfTrinkets[0].ShowDetalis();

                Items trinket = listOfTrinkets[0];


                if (player.Gold >= trinket.Price)
                {
                    Console.Write($"Would you like to buy the {listOfTrinkets[0]}?");
                    string answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                    {
                        player.EquipItems(trinket); //Adds the purchased items power to character
                        int goldToPay = player.GiveGold(trinket.Price);
                        store.TakeGold(goldToPay);
                        Console.WriteLine($"You bought {trinket}. You feel so badass.\n");
                        Console.WriteLine($"You have {player.Gold} gold\n");
                        listOfTrinkets.Clear();
                        ClearScreen();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("maybe later bro\n");
                        ClearScreen();
                    }
                }

                else
                {
                    Console.WriteLine("Bah, too expensive for me\n");
                    ClearScreen();
                }

            }
            else
            {
                Console.WriteLine("Sorry bro, got nothing man\n");
                ClearScreen();
            }


        }

        private void InspectRings()
        {
            Console.Clear();
            if (listOfRings.Count > 1)
            {
                Console.WriteLine($"I have {listOfRings[0]} for sale\n");
                ClearScreen();
                listOfRings[0].ShowDetalis();

                Items ring = listOfRings[0];


                if (player.Gold >= ring.Price)
                {
                    Console.Write($"Would you like to buy the {listOfRings[0]}?");
                    string answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                    {
                        player.EquipItems(ring); //Adds the purchased items power to character
                        int goldToPay = player.GiveGold(ring.Price);
                        store.TakeGold(goldToPay);
                        Console.WriteLine($"You bought {ring}. You feel so badass.\n");
                        Console.WriteLine($"You have {player.Gold} gold\n");
                        listOfRings.Clear();
                        ClearScreen();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("maybe later bro\n");
                        ClearScreen();
                    }
                }

                else
                {
                    Console.WriteLine("Bah, too expensive for me\n");
                    ClearScreen();
                }

            }
            else
            {
                Console.WriteLine("Sorry bro, got nothing man\n");
                ClearScreen();
            }
        }

        private void InspectAmmulets()
        {

            Console.Clear();
            if (listOfAmmulets.Count > 1)
            {
                Console.WriteLine($"I have {listOfAmmulets[0]} for sale\n");
                ClearScreen();
                listOfAmmulets[0].ShowDetalis();

                Items ammulet = listOfAmmulets[0];


                if (player.Gold >= ammulet.Price)
                {
                    Console.Write($"Would you like to buy the {listOfAmmulets[0]}?");
                    string answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                    {
                        player.EquipItems(ammulet); //Adds the purchased items power to character
                        int goldToPay = player.GiveGold(ammulet.Price);
                        store.TakeGold(goldToPay);
                        Console.WriteLine($"You bought {ammulet}. You feel so badass.\n");
                        Console.WriteLine($"You have {player.Gold} gold\n");
                        listOfAmmulets.Clear();
                        ClearScreen();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("maybe later bro\n");
                        ClearScreen();
                    }
                }

                else
                {
                    Console.WriteLine("Bah, too expensive for me\n");
                    ClearScreen();
                }

            }
            else
            {
                Console.WriteLine("Sorry bro, got nothing man\n");
                ClearScreen();
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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }

        public void ExitGame()
        {
            if (!keepPlaying)
            {
                Console.WriteLine("Go die in a fire for quitting the game!");
            }

            else if (lostGame)
            {

                Console.WriteLine("\n      *****************************************");
                Console.WriteLine("      *      Y O U   A R E   D E A D !!!     *");
                Console.WriteLine("      *****************************************\n");
                Console.WriteLine("You are such a f-upped loser!");
                Console.WriteLine("Get lost!");
            }
            else if (wonGame)
            {
                Console.WriteLine("Gz you won the game bruh!");
                Console.WriteLine("Im sure your mum would be proud");
                Console.WriteLine("Now get lost you stupid c*nt");
            }
        }



    }
}
