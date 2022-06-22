using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.FightTactics
{
    public class FtCharactersChoiceController : MainController
    {
        private MainController _mainController;                                 // Main controller
        private FtCharactersChoice _ftCharactersChoice1;                     // character choice view
        private FtCharactersChoiceInventory _ftCharactersChoiceInventory1;       // character choice imventory view

        private User _user;                                                     // user model
        private Team _team = new Team();                                        // team model
        private Fighter _fighter;                                               // team model
        private Power _power;                                                   // power model

        private Team _team1;                            // Team 1
        private Team _team2;                            // Team 2

        private int _teamNbr;                           // Team number

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public FtCharactersChoice FtCharactersChoice
        {
            get { return _ftCharactersChoice1; }
            set { _ftCharactersChoice1 = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public FtCharactersChoiceInventory FtCharactersChoiceInventory
        {
            get { return _ftCharactersChoiceInventory1; }
            set { _ftCharactersChoiceInventory1 = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public Team Team
        {
            get { return _team; }
            set { _team = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public Fighter Fighter
        {
            get { return _fighter; }
            set { _fighter = value; }
        }

        /// <summary>
        /// Public character choice view
        /// </summary>
        public Power Power
        {
            get { return _power; }
            set { _power = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ftCharactersChoice">ft character choice view</param>
        /// <param name="ftCharactersChoiceInventory">ft character choice inventory view</param>
        public FtCharactersChoiceController(FtCharactersChoice ftCharactersChoice, FtCharactersChoiceInventory ftCharactersChoiceInventory, User user, Team team, Fighter fighter, Power power)
        {
            _ftCharactersChoice1 = ftCharactersChoice;
            _ftCharactersChoiceInventory1 = ftCharactersChoiceInventory;
            _team = team;
            _user = user;
            _fighter = fighter;
            _power = power;
            _ftCharactersChoice1.FtCharactersChoiceController = this;
            _ftCharactersChoiceInventory1.FtCharactersChoiceController = this;
            _team.FtCharactersChoiceController = this;
            _user.FtCharactersChoiceController = this;
            _fighter.FtCharactersChoiceController = this;
            _power.FtCharactersChoiceController = this;
        }

        /// <summary>
        /// Chose a character
        /// </summary>
        public void ChoseCharacter(int team)
        {
            _teamNbr = team;
            _ftCharactersChoiceInventory1.Show();
        }

        /// <summary>
        /// Get the user name
        /// </summary>
        /// <returns>Return user name</returns>
        public string GetUserName()
        {
            return _user.Nickname;
        }

        /// <summary>
        /// Display fighters
        /// </summary>
        public void DisplayFighters()
        {
            _ftCharactersChoiceInventory1.DisplayFighters(_user.FighterList);
        }

        /// <summary>
        /// Add a fighter to the list
        /// </summary>
        /// <param name="name">fighter name</param>
        public void AddFighterToTeam(string name)
        {
            // Get fighter by name
            Fighter fighter = _fighter.GetFighterByName(name, _user.Id);

            // Get his powers
            List<Power> powers = _power.GetPowers(fighter.IdCharacter);

            // Add the powers to the fighter
            foreach (Power power in powers)
            {
                fighter.AddPower(power);
            }

            // Add the fighter to the teams
            if(_teamNbr == 1)
            {
                // Set team 1
                if (_team1.CharactersList.Count() != 3)
                {
                    _team1.AddCharacter(fighter);
                    switch (_team1.CharactersList.Count())
                    {
                        case 1:
                            _ftCharactersChoice1.DisplayText(1, fighter);
                            break;
                        case 2:
                            _ftCharactersChoice1.DisplayText(2, fighter);
                            break;
                        case 3:
                            _ftCharactersChoice1.DisplayText(3, fighter);
                            break;
                    }
                }
            }
            else
            {
                // Set team 2
                if (_team2.CharactersList.Count() != 3)
                {
                    _team2.AddCharacter(fighter);
                    switch (_team2.CharactersList.Count())
                    {
                        case 1:
                            _ftCharactersChoice1.DisplayText(4, fighter);
                            break;
                        case 2:
                            _ftCharactersChoice1.DisplayText(5, fighter);
                            break;
                        case 3:
                            _ftCharactersChoice1.DisplayText(6, fighter);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Show the game view
        /// </summary>
        public void ShowGame()
        {
            _team.Teams = new List<Team>();
            // Check if the team are completed
            if (_team1.CharactersList.Count() == 3 && _team2.CharactersList.Count() == 3)
            {
                // Add the teams
                _team.Teams.Add(_team1);
                _team.Teams.Add(_team2);

                // Show the main controller
                _mainController.ShowView(Action.FTGAME, _ftCharactersChoice1);
            }
        }

        /// <summary>
        /// Create teams
        /// </summary>
        public void CreateTeams()
        {
            _team1 = null;
            _team2 = null;
            _team1 = new Team(_user);
            _team2 = new Team(_user);
        }
    }
}
