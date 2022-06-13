using System;
using System.Collections.Generic;

namespace P_Demomot
{
    class Team
    {
        #region Properties
        //Int
        private int _id;                        //Id of the team
        //String
        private string _name;                   //Name of the team
        //objects
        private ConsoleColor _color;            //Color of the team
        private List<User> _users;              //List of user(s) in the team
        private List<Character> _characters;    //List of characters in the team
        #endregion

        #region Getters Setters
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public Team(int id, string name, ConsoleColor color)
        {
            _id = id;
            _name = name;
            _color = color;
            _users = new List<User>();
            _characters = new List<Character>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a user into the list
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        /// <summary>
        /// Add a character into the list
        /// </summary>
        /// <param name="character"></param>
        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }
        #endregion
    }
}
