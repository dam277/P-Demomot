using P_Demomot.Controllers;
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
        private MainController _mainController;     // Main controller
        private int _idTeam;                        // Team Id
        private User _user;                         // Team user
        private List<Character> _characters;        // List of the characters of the team
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
        private List<Character> _charactersList
        {
            get 
            { 
                return _characters; 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Team()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="user"></param>
        public Team(User user)
        {
            _user = user;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a character to the team
        /// </summary>
        /// <param name="character"></param>
        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }
        #endregion
    }
}
