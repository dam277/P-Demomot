using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Models.Utils;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.UserProperties
{
    public class ChestsController : MainController
    {
        #region Variables
        private MainController _mainController;         // Main controller
        private ChestsView _chestsView;                 // Chest view
        private Chest _chest;                           // Chest model
        private User _user;                             // User model
        private Rarity _rarity;                         // User model
        private Fighter _fighter;                         // User model
        private Power _power;                         // User model
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public chest view
        /// </summary>
        public ChestsView ChestsView
        {
            get { return _chestsView; }
            set { _chestsView = value; }
        }

        /// <summary>
        /// Public chest model
        /// </summary>
        public Chest Chest
        {
            get { return _chest; }
            set { _chest = value; }
        }

        /// <summary>
        /// Public chest model
        /// </summary>
        public Rarity Rarity
        {
            get { return _rarity; }
            set { _rarity = value; }
        }

        /// <summary>
        /// Public user model
        /// </summary>
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        /// <summary>
        /// Public power model
        /// </summary>
        public Power Power
        {
            get { return _power; }
            set { _power = value; }
        }

        /// <summary>
        /// Public figter model
        /// </summary>
        public Fighter Fighter
        {
            get { return _fighter; }
            set { _fighter = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="chestsView">chest view</param>
        /// <param name="chest">chest model</param>
        public ChestsController(ChestsView chestsView, Chest chest, User user, Rarity rarity, Fighter fighter, Power power)
        {
            _chest = chest;
            _chestsView = chestsView;
            _user = user;
            _rarity = rarity;
            _fighter = fighter;
            _power = power;
            _chest.ChestsController = this;
            _chestsView.ChestsController = this;
            _user.ChestsController = this;
            _rarity.ChestsController = this;
            _fighter.ChestsController = this;
            _power.ChestsController = this;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all the chests
        /// </summary>
        /// <returns>Return a list of chests</returns>
        public List<Chest> GetAllChests()
        {
            return _chest.GetAllChests();
        }

        /// <summary>
        /// Show the main menu
        /// </summary>
        public void ShowMainMenu()
        {
            _mainController.ShowView(Action.MAINMENU, _chestsView);
        }

        /// <summary>
        /// Open a chest
        /// </summary>
        /// <param name="chestName">chest name</param>
        public void OpenChest(string chestName)
        {
            // Get chest nbr chance
            int maxRarity = _chest.GetChestNbrChance(chestName);

            // Set a random
            Random random = new Random();
            int drop = random.Next(0, maxRarity);

            // Get the rarites
            List<Rarity> rarities = _rarity.GetAllRarity();
            Rarity rarity = new Rarity();

            // Check whitch rarity is selected
            for(int i = 0; i < rarities.Count; i++)
            {
                // Check whitch rarity
                if(i == 0)
                {
                    if (drop < rarities[i].DropChance)
                    {
                        rarity = rarities[i];
                    }
                }
                else
                {
                    if (drop < rarities[i].DropChance && drop > rarities[i - 1].DropChance)
                    {
                        rarity = rarities[i];
                    }
                }
            }

            // Check if the rarity is null
            if(rarity == null)
            {
                rarity = rarities[0];
            }

            // List of fighters
            List<Fighter> fighters = new List<Fighter>();

            // Get the fighters with the rarity assigned
            foreach(Fighter fighter in _fighter.FightersList)
            {
                if(fighter.Rarity.Name == rarity.Name)
                {
                    fighters.Add(fighter);
                }    
            }

            // Get the fighter
            Random figterDropChance = new Random();
            int figterDrop = figterDropChance.Next(0, 1000);

            // Figter
            Fighter newFighter = new Fighter();

            // Bool to define if the character is unlocked
            bool isCharacterUnlocked = false;

            // Name of the recieved character
            string characterRecievedName = "";

            // Check what is the rarity
            if (rarity.Name == "Basic")
            {
                newFighter = _user.FighterList[0];
                characterRecievedName = newFighter.Name;
                isCharacterUnlocked = true;
            }
            else
            {
                // Check which fighter is unlocked
                if (figterDrop <= 333)
                {
                    foreach (Fighter fighter in _user.FighterList)
                    {
                        // Check if a character exists with his name
                        if (fighter.Name == fighters[0].Name)
                        {
                            characterRecievedName = fighter.Name;
                            isCharacterUnlocked = true;
                            break;
                        }
                    }

                    // Check if the character is ulocked
                    if (isCharacterUnlocked == false)
                    {
                        newFighter = _fighter.CreateCharacter(fighters[0], "", 1, _user.Id, rarity);
                        CreateCharacterPowers(newFighter);
                        // Show the card recieved
                        _chestsView.ShowCharacter(newFighter);
                    }
                }
                else if (figterDrop <= 666)
                {
                    foreach (Fighter fighter in _user.FighterList)
                    {
                        // Check if a character exists with his name
                        if (fighter.Name == fighters[1].Name)
                        {
                            characterRecievedName = fighter.Name;
                            isCharacterUnlocked = true;
                            break;
                        }
                    }

                    // Check if the character is ulocked
                    if (isCharacterUnlocked == false)
                    {
                        newFighter = _fighter.CreateCharacter(fighters[1], "", 1, _user.Id, rarity);
                        CreateCharacterPowers(newFighter);
                        // Show the card recieved
                        _chestsView.ShowCharacter(newFighter);
                    }
                }
                else if (figterDrop <= 999)
                {
                    foreach (Fighter fighter in _user.FighterList)
                    {
                        // Check if a character exists with his name
                        if (fighter.Name == fighters[2].Name)
                        {
                            characterRecievedName = fighter.Name;
                            isCharacterUnlocked = true;
                            break;
                        }
                    }

                    // Check if the character is ulocked
                    if (isCharacterUnlocked == false)
                    {
                        newFighter = _fighter.CreateCharacter(fighters[2], "", 1, _user.Id, rarity);
                        CreateCharacterPowers(newFighter);
                        // Show the card recieved
                        _chestsView.ShowCharacter(newFighter);
                    }
                }
            }

            // Update the character if he is unlocked
            if (isCharacterUnlocked)
            {
                // Update the fighter
                for (int i = 0; i < _user.FighterList.Count(); i++)
                {
                    // Check which character is recieved
                    if (_user.FighterList[i].Name == characterRecievedName)
                    {
                        // Check if the character is lower than level 3
                        if (_user.FighterList[i].Level < 3)
                        {
                            // Create a fighter to upgrade the other
                            Fighter fighter = _fighter.UpgradeFighter(_user.FighterList[i], _user.Id, rarity);
                            _user.FighterList[i] = fighter;
                            // Show the card recieved
                            _chestsView.ShowCharacter(fighter);
                        }
                    }
                }
            }

            
            // Delete a chest
            _chest.DeleteChest(_chest.GetChestIdByName(chestName));
        }


        /// <summary>
        /// Create the powers of the character
        /// </summary>
        /// <param name="fighter">fighter</param>
        public void CreateCharacterPowers(Fighter fighter)
        {
            // Get powers name
            Dictionary<string, string> powersName = _power.GetPowersNameByCharacterName(fighter.Name);

            // Create his powers
            Power power1 = _power.CreatePower(fighter.Name, powersName["Power1"], fighter.Level);
            Power power2 = _power.CreatePower(fighter.Name, powersName["Power2"], fighter.Level);
            Power Ultime = _power.CreateUltime(fighter.Name, powersName["Power3"], fighter.Level);
            fighter.AddPower(power1);
            fighter.AddPower(power2);
            fighter.AddPower(Ultime);

            // Add him into the list of character of the user
            _user.AddCharacter(fighter);
        }

        /// <summary>
        /// Get the powers name
        /// </summary>
        /// <param name="fighterName">Fighter name</param>
        /// <returns>Return dictionary of powers name</returns>
        public Dictionary<string, string> GetPowersName(string fighterName)
        {
            // Get powers name
            return _power.GetPowersNameByCharacterName(fighterName);
        }

        /// <summary>
        /// Get the powers name
        /// </summary>
        /// <param name="fighterName">Fighter name</param>
        /// <returns>Return dictionary of powers name</returns>
        public List<Power> GetPowers(int fighterId)
        {
            // Get powers name
            return _power.GetPowers(fighterId);
        }

        /// <summary>
        /// Get the character Id
        /// </summary>
        /// <param name="characterName">character name</param>
        /// <returns>Return the id of the character</returns>
        public int GetCharacterId(string characterName)
        {
            return _fighter.GetId(characterName, _user.Id);
        }

        /// <summary>
        /// Get all the chest of the user
        /// </summary>
        public Dictionary<string, List<Chest>> GetAllUserChests()
        {
            return _chest.GetAllUserChests(_user.Id);
        }
        #endregion
    }
}
