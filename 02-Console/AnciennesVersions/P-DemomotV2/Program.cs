using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using P_Demomot.utils;
using P_Demomot.characters;
using P_Demomot.datas;

namespace game
{
    class Program
    {
        static List<string>[] menuButtonsList;          //Menu button list
        static List<User> users = new List<User>();     //List of all users
        static int counter = 1;                         //counter
        static User user;                               //Actual user

        #region Creation of rarity
        //Creation of rarity
        static Rarity basic = new Rarity(1, "basique", 150, 300, 300, 600, ConsoleColor.Gray);
        static Rarity common = new Rarity(1, "commun", 100, 450, 250, 950, ConsoleColor.DarkGray);
        static Rarity rare = new Rarity(2, "rare", 80, 600, 220, 120, ConsoleColor.DarkYellow);
        static Rarity superRare = new Rarity(3, "super rare", 70, 700, 190, 1500, ConsoleColor.Yellow);
        static Rarity epic = new Rarity(4, "épique", 40, 800, 140, 1800, ConsoleColor.Magenta);
        static Rarity legendary = new Rarity(5, "legendaire", 30, 1050, 85, 2000, ConsoleColor.Cyan);
        static Rarity mythic = new Rarity(5, "mythique", 10, 1300, 40, 2250, ConsoleColor.Red);
        static Rarity mysterious = new Rarity(5, "mistérieux", 5, 1550, 25, 2550, ConsoleColor.DarkMagenta);
        #endregion
        #region Creation of powers

        #region Fighters
        //static Power heal = new Power("Régénération", "Pouvoir défensif pouvant être envoyé à un allié pour régénérer ses points de vie", 4, 2);
        #endregion

        #region Tanks
        #endregion

        #endregion

        /// <summary>
        /// Principal program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string createAccount = "Créer un compte";   //Variable of create account button
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
                    Out.ClearListLine(4, 2, menuButtonsList[1]);

                    if (currentVerticalChoice == 0)
                    {
                        Out.ClearOneLine(0, 0, Console.WindowWidth);
                        Out.WriteLine("< ", 0, 0);
                        Out.WriteMenuButtonsTwoAxes(menuButtonsList, menuButtonsList[1].Count + 1, true, 2, 0, 1, currentVerticalChoice, currentHorizontalChoice);
                        Out.WriteLine("> ", menuButtonsList[0][currentHorizontalChoice].Length + 3, 0);
                    }
                    else
                    {
                        Out.ClearOneLine(0, 0, 1);
                        Out.WriteMenuButtonsTwoAxes(menuButtonsList, menuButtonsList[1].Count + 1, true, 2, 0, 1, currentVerticalChoice, currentHorizontalChoice);
                        Out.ClearOneLine(menuButtonsList[0][currentHorizontalChoice].Length + 3, 0, 1);
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

                        if (currentVerticalChoice == menuButtonsList[1].Count)//Quit button
                        {
                            choiceConfirmed = true;
                        }
                        else if (currentHorizontalChoice == 0 && currentVerticalChoice == 0)//Choice user button
                        {
                            Console.Clear();
                            CreateUser();
                        }
                        else if (currentHorizontalChoice != 0 && currentVerticalChoice != 0)//Other buttons without the first
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
                        currentVerticalChoice = 0;
                        break;
                    case "Quitter":
                        Environment.Exit(0);
                        break;
                }

                choiceConfirmed = false;
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

            #region Creation of Tanks

            #endregion

            #region Creation of Fighters
            //-------------------------------------Basic-------------------------------------\\
            //Recruit
            Fighter recruit = new Fighter(1, "", "Recrue", 1, 5, basic);
            Power punch = new Power("Coup de poing", "Attaque basique générant un coup de poing sur la cible", 2, 0, 1);
            Power kick = new Power("Coup de pied", "Attaque basique générant un coup de pied sur la cible", 3, 1, 1);
            recruit.AddPower(punch);
            recruit.AddPower(kick);
            //-------------------------------------Common-------------------------------------\\
            //InfantryMan
            Fighter infantryman = new Fighter(1, "", "fantassin", 0, 9, common);
            Power hit = new Power("Frappe", "Attaque basique générant un coup sur la cible", 2, 0, 1);
            Power shoot = new Power("Tir", "Tir de fusil", 3, 2, 1);
            Power uSnipe = new Power("Ultime - Snipe", "Pouvoir ultime se rechargant lentement dans la partie", 4, 30, 40, 1);
            infantryman.AddPower(hit);
            infantryman.AddPower(shoot);
            infantryman.AddPower(uSnipe);
            //TrapInstaller
            Fighter TrapInstaller = new Fighter(2, "", "poseur de piège", 0, 10, common);
            Power trap = new Power("Piège", "Piège mettant la cible dans l'incapabilité d'attaquer pendant 2 tours", 0, 5, 2);
            Power slap = new Power("Fermeture", "Envoi d'un piège rapide infligeant des dégats", 1, 0, 1);
            Power uTrapped = new Power("Ultime - Piégés", "Pouvoir ultime piégeant tous les adversaires qui prendront des dégats pendant 2 tours", 3, 30, 40, 2);
            TrapInstaller.AddPower(trap);
            TrapInstaller.AddPower(slap);
            TrapInstaller.AddPower(uTrapped);
            //Archer
            Fighter archer = new Fighter(3, "", "fantassin", 0, 9, common);
            Power arrow = new Power("Flèche", "Tir une flèche contre la cible, lui infligeant des dégats", 2, 0, 1);
            Power fireArrow = new Power("Flèche de feu", "Tir une flèche contre la cible qui lui infigera des dégats de feu pendant 3 tours", 1, 6, 3);
            Power uSleepyArrow = new Power("Ultime - Flèche tranquilisante", "Flèche réduisant les dégats de la cible par 2 pendant 3 tours", 2, 20, 40, 2);
            archer.AddPower(arrow);
            archer.AddPower(fireArrow);
            archer.AddPower(uSleepyArrow);
            //-------------------------------------Rare-------------------------------------\\
            //Knight
            Fighter knight = new Fighter(4, "", "chevalier", 0, 13, rare);
            Power arrow = new Power("", "", 2, 0, 1);
            Power fireArrow = new Power("", "", 1, 6, 3);
            Power uSleepyArrow = new Power("", 2, 20, 40, 2);
            archer.AddPower(arrow);
            archer.AddPower(fireArrow);
            archer.AddPower(uSleepyArrow);
            //Shaman
            Fighter shaman = new Fighter(5, "", "chaman", 0, 10, rare);
            //HorseMan
            Fighter horseman = new Fighter(6, "", "cavalier", 0, 13, rare);
            //-------------------------------------Super Rare-------------------------------------\\
            //Ram
            Fighter ram = new Fighter(7, "", "Bélier", 0, 19, superRare);
            //BearTrainer
            Fighter bearTrainer = new Fighter(8, "", "dresseur d'ours", 0, 17, superRare);
            //Sorcerer
            Fighter sorcerer = new Fighter(9, "", "mage", 0, 11, superRare);
            //-------------------------------------Epic-------------------------------------\\
            //Skeleton
            Fighter skeleton = new Fighter(10, "", "squelette", 0, 14, epic);
            //Guard
            Fighter guard = new Fighter(11, "", "garde", 0, 19, epic);
            //Arquebusier
            Fighter arquebusier = new Fighter(12, "", "arquebusier", 0, 10, epic);
            //-------------------------------------Legendary-------------------------------------\\
            //Lancer
            Fighter lancer = new Fighter(13, "==", "lancier", 0, 10, legendary);
            //TriggerFish
            Fighter triggerfish = new Fighter(14, "=0=", "baliste", 0, 10, legendary);
            //Halberdier
            Fighter halberdier = new Fighter(15, "=[0]=", "hallebardier", 0, 15, legendary);
            //-------------------------------------Mythic-------------------------------------\\
            //Witch
            Fighter witch = new Fighter(15, "", "sorcière", 0, 10, mythic);
            //Cannon
            Fighter cannon = new Fighter(16, "", "canon", 0, 9, mythic);
            //Catapult
            Fighter catapult = new Fighter(17, "", "catapulte", 0, 8, mythic);
            //-------------------------------------Misterious-------------------------------------\\
            //Dragon
            Fighter dragon = new Fighter(18, "", "dragon", 0, 20, mysterious);
            //Ultimate knight
            Fighter ultimateKnight = new Fighter(19, "", "chevalier ultime", 0, 25, mysterious);
            //Lord
            Fighter Lord = new Fighter(20, "", "seigneur", 0, 18, mysterious);
            #endregion

            #endregion

            Console.ForegroundColor = ConsoleColor.Cyan;

            //Creation of user
            Console.WriteLine("---[Nouvel utilisateur]---\n");
            Console.Write("Entrez votre pseudo : ");
            string userName = Console.ReadLine();
            user = new User(userName, counter);

            //Display new user
            Console.WriteLine();
            Console.WriteLine("{Pseudo}--[" + user.UserName + "]---");
            Console.WriteLine("{Identifiant}--[" + user.Id + "]---");

            //foreach (Fighter tempCharacter in characters.CharactersList)
            //{
            //    user.AddCharacter(tempCharacter);
            //}

            users.Add(user);
            menuButtonsList[0].Add(user.UserName);
            counter++;

            //users[0].CharactersList[5].Level = 10000;

            Console.ReadLine();
            Console.Clear();
        }
    }
}
