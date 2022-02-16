using System.Collections.Generic;

namespace P_Demomot
{
    class User
    {
        #region Properties
        //Int
        private int _id;                         //Id of the user
        private int _money;                      //Money of the user
        //String
        private string _userName;                //Username of the user
        private string _email;                   //Email of the user
        //Objects
        private List<Character> _charactersList; //List of character who have the user
        #endregion

        #region Getters Setters
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get { return _userName; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get { return _email; }
        }

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
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Character> CharactersList
        {
            get { return _charactersList; }
            set { _charactersList = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="id"></param>
        public User(string userName, int id, string email)
        {
            _userName = userName;
            _id = id;
            _email = email;
            _charactersList = new List<Character>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add new character
        /// </summary>
        /// <param name="character"></param>
        public void AddCharacter(Character character)
        {
            _charactersList.Add(character);
        }
        #endregion
    }
}
