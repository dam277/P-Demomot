using P_Demomot.Controllers;
using P_Demomot.Controllers.FightTactics;
using P_Demomot.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    public class Team
    {
        #region Variables
        private FtCharactersChoiceController _ftCharactersChoiceController;  // character choice controller
        private FtGameController _ftGameController;  // ft game controller
        private MainController _mainController;     // Main controller

        private int _idTeam;                        // Team Id
        private User _user;                         // Team user
        private List<Fighter> _characters;        // List of the characters of the team
        private List<Team> _teams;                  // List of teams
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public Main controller
        /// </summary>
        public MainController MainController
        {
            get 
            {
                return _mainController; 
            }
            set 
            { 
                _mainController = value; 
            }
        }

        /// <summary>
        /// Public Team Id
        /// </summary>
        public int IdTeam
        {
            get 
            { 
                return _idTeam; 
            }
        }

        /// <summary>
        /// Public Team user
        /// </summary>
        public User User
        {
            get 
            { 
                return _user; 
            }
        }

        /// <summary>
        /// Public List of the characters of the team
        /// </summary>
        public List<Fighter> CharactersList
        {
            get 
            { 
                return _characters; 
            }
        }

        /// <summary>
        /// Public list of teams
        /// </summary>
        public List<Team> Teams
        {
            get
            {
                return _teams;
            }
            set
            {
                _teams = value;
            }
        }

        /// <summary>
        /// Public characters choice controller
        /// </summary>
        public FtCharactersChoiceController FtCharactersChoiceController
        {
            get { return _ftCharactersChoiceController; }
            set { _ftCharactersChoiceController = value; }
        }

        /// <summary>
        /// Public ft game controller
        /// </summary>
        public FtGameController FtGameController
        {
            get { return _ftGameController; }
            set { _ftGameController = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Team()
        {
            _teams = new List<Team>();
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="user">User name</param>
        public Team(User user)
        {
            _user = user;
            _characters = new List<Fighter>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a character to the team
        /// </summary>
        /// <param name="character">character to add</param>
        public void AddCharacter(Fighter character)
        {
            _characters.Add(character);
        }
        #endregion
    }
}
