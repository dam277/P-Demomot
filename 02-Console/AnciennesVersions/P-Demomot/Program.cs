using System;
using System.Collections.Generic;
using P_Demomot.util;
using System.Threading;

namespace P_Demomot
{
    class Program
    {
                                static List<string>[] menuButtonsList;          //Menu button list
                                static List<User> users = new List<User>();     //List of all users
                                static int counter = 1;                         //counter
                                static User user;                               //Actual user
                                static Character characters;                    //list of characters

                                //Creation of rarity
                                static Rarity basic = new Rarity(1, "basique", 150, 300, 300, 600, ConsoleColor.Gray);
                                static Rarity common = new Rarity(1, "commun", 100, 450, 250, 950, ConsoleColor.DarkGray);
                                static Rarity rare = new Rarity(2, "rare", 80, 600, 220, 120, ConsoleColor.DarkYellow);
                                static Rarity superRare = new Rarity(3, "super rare", 70, 700, 190, 1500, ConsoleColor.Yellow);
                                static Rarity epic = new Rarity(4, "épique", 40, 800, 140, 1800, ConsoleColor.Magenta);
                                static Rarity legendary = new Rarity(5, "legendaire", 30, 1050, 85, 2000, ConsoleColor.Cyan);
                                static Rarity mythic = new Rarity(5, "mythique", 10, 1300, 40, 2250, ConsoleColor.Red);
                                static Rarity mysterious = new Rarity(5, "mistérieux", 5, 1550, 25, 2550, ConsoleColor.DarkMagenta);

                                static string createAccount = "Créer un compte";

                                /// <summary>
                                /// Principal program
                                /// </summary>
                                /// <param name="args"></param>
                                static void Main(string[] args)
                                {
                                    Console.CursorVisible = false;

                                    //First menu of the game
                                    menuButtonsList = new List<string>[2];

                                    for (int i = 0; i < menuButtonsList.Length; i++)
                                    {
                                        menuButtonsList[i] = new List<string>();
                                    }

                                    menuButtonsList[0].Add(createAccount);
                                    menuButtonsList[1].Add("Jouer");
                                    menuButtonsList[1].Add("Options");
                                    menuButtonsList[1].Add("Personnages");
                                    menuButtonsList[1].Add("Coffres");
                                    menuButtonsList[1].Add("Quitter");

                                    bool choiceConfirmed = false;
                                    int currentVerticalChoice = 0;
                                    int currentHorizontalChoice = 0;

                                    Console.Clear();
            
                                    do
                                    {
                                        do
                                        {
                                            Clear.ListLine(4, 2, menuButtonsList[1]);

                                            if (currentVerticalChoice == 0)
                                            {
                                                Clear.OneLine(0, 0, Console.WindowWidth);
                                                Print.Line("< ", 0, 0);
                                                Print.MenuButtonsTwoAxes(menuButtonsList, menuButtonsList[1].Count + 1, true, 2, 0, 1, currentVerticalChoice, currentHorizontalChoice);
                                                Print.Line("> ", menuButtonsList[0][currentHorizontalChoice].Length + 3, 0);
                                            }
                                            else
                            {
                                Clear.OneLine(0, 0, 1);
                                Print.MenuButtonsTwoAxes(menuButtonsList, menuButtonsList[1].Count + 1, true, 2, 0, 1, currentVerticalChoice, currentHorizontalChoice);
                                Clear.OneLine(menuButtonsList[0][currentHorizontalChoice].Length + 3, 0, 1);
                            }
                    

                            ConsoleKey consoleKey = Console.ReadKey(true).Key;

                            if (consoleKey == ConsoleKey.DownArrow && currentVerticalChoice < menuButtonsList[1].Count)//Down
                            {
                                currentVerticalChoice++;
                            }
                            else if (consoleKey == ConsoleKey.UpArrow && currentVerticalChoice > 0)//Up
                            {
                                currentVerticalChoice--;
                            }
                            else if (consoleKey == ConsoleKey.RightArrow && currentHorizontalChoice < users.Count && currentVerticalChoice == 0)//Right
                            {
                                currentHorizontalChoice++;
                            }
                            else if (consoleKey == ConsoleKey.LeftArrow && currentHorizontalChoice > 0 && currentVerticalChoice == 0)//Left
                            {
                                currentHorizontalChoice--;
                            }
                            else if (consoleKey == ConsoleKey.Enter)//Enter
                            {
                        
                                if(currentVerticalChoice == menuButtonsList[1].Count)//Quit button
                                {
                                    choiceConfirmed = true;
                                }
                                else if(currentHorizontalChoice == 0 && currentVerticalChoice == 0)//Choice user button
                                {
                                    Console.Clear(); 
                                    CreateUser();
                                }
                                else if(currentHorizontalChoice != 0 && currentVerticalChoice != 0)//Other buttons without the first
                                {
                                    choiceConfirmed = true;
                                    user = users[currentHorizontalChoice - 1];
                                }
                            }

                        } while (choiceConfirmed == false);

                        //Define what is the selected button
                        switch (menuButtonsList[1][currentVerticalChoice - 1])
                        {
                        case "Jouer":
                            Play();
                            break;
                        case "Options":
                            break;
                        case "Personnages":
                            characters.DisplayCharacters(user);
                            currentVerticalChoice = 0;
                            break;
                        case "Quitter":
                            Environment.Exit(0);
                            break;
                    }

                    choiceConfirmed = false;
                    Console.ReadLine();
                    Console.Clear();

            } while (true);
        }

        public static void Play()
        {
            
        }

        /// <summary>
        /// Creation of new user
        /// </summary>
        /// <param name="characters">List of characters</param>
        public static void CreateUser()
        {
            #region Creation of characters
            //Creation of characters
            characters = new Character("Default");
            //basic
            Character recruit = new Character(0, "", "recrue", 1, 3, 2, basic);
            //common
            Character infantryman = new Character(1, "", "fantassin", 0, 6, 4, common);
            Character TrapInstaller = new Character(2, "", "poseur de piège", 0, 5, 3, common);
            Character archer = new Character(3, "", "fantassin", 0, 4, 5, common);
            //rare
            Character knight = new Character(4, "", "chevalier", 0, 8, 3, rare);
            Character shaman = new Character(5, "", "chaman", 0, 5, 3, rare);
            Character horseman = new Character(6, "", "cavalier", 0, 8, 3, rare);
            //super rare
            Character ram = new Character(7, "", "Bélier", 0, 14, 3, superRare);
            Character bearTrainer = new Character(8, "", "dresseur d'ours", 0, 12, 3, superRare);
            Character sorcerer = new Character(9, "", "mage", 0, 6, 3, superRare);
            //epic
            Character skeleton = new Character(10, "", "squelette", 0, 9, 4, epic);
            Character guard = new Character(11, "", "garde", 0, 17, 1, epic);
            Character arquebusier = new Character(12, "", "arquebusier", 0, 5, 6, epic);
            //legendary
            Character lancer = new Character(13, "==", "lancier", 0, 5, 5, legendary);
            Character triggerfish = new Character(14, "=0=", "baliste", 0, 5, 6, legendary);
            Character halberdier = new Character(15, "=[0]=", "hallebardier", 0, 10, 4, legendary);
            //mythic
            Character witch = new Character(15, "", "sorcière", 0, 5, 3, mythic);
            Character cannon = new Character(16, "", "canon", 0, 4, 6, mythic);
            Character catapult = new Character(17, "", "catapulte", 0, 3, 7, mythic);
            //misterious
            Character dragon = new Character(18, "", "dragon", 0, 15, 5, mysterious);
            Character ultimateKnight = new Character(19, "", "chevalier ultime", 0, 20, 3, mysterious);
            Character Lord = new Character(20, "", "seigneur", 0, 13, 7, mysterious);

            characters.AddCharacter(recruit);
            characters.AddCharacter(infantryman);
            characters.AddCharacter(TrapInstaller);
            characters.AddCharacter(archer);
            characters.AddCharacter(knight);
            characters.AddCharacter(shaman);
            characters.AddCharacter(horseman);
            characters.AddCharacter(ram);
            characters.AddCharacter(bearTrainer);
            characters.AddCharacter(sorcerer);
            characters.AddCharacter(skeleton);
            characters.AddCharacter(guard);
            characters.AddCharacter(arquebusier);
            characters.AddCharacter(lancer);
            characters.AddCharacter(triggerfish);
            characters.AddCharacter(halberdier);
            characters.AddCharacter(witch);
            characters.AddCharacter(cannon);
            characters.AddCharacter(catapult);
            characters.AddCharacter(dragon);
            characters.AddCharacter(ultimateKnight);
            characters.AddCharacter(Lord);

            #endregion

            Console.ForegroundColor = ConsoleColor.Cyan;

            //Creation of user
            Console.WriteLine("---[Nouvel utilisateur]---\n");
            Console.Write("Entrez votre pseudo : ");
            string userName = Console.ReadLine();
            Console.Write("Entrez votre email : ");
            string email = Console.ReadLine();
            user = new User(userName, counter, email);

            //Display new user
            Console.WriteLine();
            Console.WriteLine("{Pseudo}--[" + user.UserName + "]---");
            Console.WriteLine("{Identifiant}--[" + user.Id + "]---");
            Console.WriteLine("{Email}--[" + user.Email + "]---");

            foreach(Character tempCharacter in characters.CharactersList)
            {
                user.AddCharacter(tempCharacter);
            }

            users.Add(user);
            menuButtonsList[0].Add(user.UserName);
            counter++;

            users[0].CharactersList[5].Level = 10000;

            Console.ReadLine();
            Console.Clear();
        }
    }
}
