using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
using P_Demomot.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    public class User
    {
        #region Variables 
        private MainController _mainController;                 // Main controller
        private InventoryController _inventoryController;       // Inventory controller
        private int _id;                                        // User ID
        private string _nickname;                               // User nickname
        private string _profileImage;                           // User profile image
        private string _role;                                   // User role
        private DateTime _entryDate;                            // User entry date
        private Rank _rank;                                     // User rank
        private List<Fighter> _fighterList;                     // User fighter list
        private List<Tank> _tankList;                           // User tank list
        private Dictionary<Rarity, List<Chest>> _chests;        // User chest list
        #endregion

        #region Getter Setter
        /// <summary>
        /// public Main controller
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
        /// Public User ID
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Public User nickname
        /// </summary>
        public string Nickname
        {
            get
            {
                return _nickname;
            }
            set
            {
                _nickname = value;
            }
        }

        /// <summary>
        /// Public User profile image
        /// </summary>
        public string ProfileImage
        {
            get
            {
                return _profileImage;
            }
            set
            {
                _profileImage = value;
            }
        }

        /// <summary>
        /// Public User role
        /// </summary>
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }

        /// <summary>
        /// Public User entry date
        /// </summary>
        public DateTime EntryDate
        {
            get
            {
                return _entryDate;
            }
        }

        /// <summary>
        /// Public User rank
        /// </summary>
        public Rank Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }

        /// <summary>
        /// Public User fighter list
        /// </summary>
        public List<Fighter> FighterList
        {
            get
            {
                return _fighterList;
            }
            set
            {
                _fighterList = value;
            }
        }

        /// <summary>
        /// Public User tank list
        /// </summary>
        public List<Tank> TankList
        {
            get
            {
                return _tankList;
            }
            set
            {
                _tankList = value;
            }
        }

        /// <summary>
        /// Public User chest list
        /// </summary>
        public Dictionary<Rarity, List<Chest>> Chests
        {
            get
            {
                return _chests;
            }
            set
            {
                _chests = value;
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="nickname">User nickname</param>
        /// <param name="password">User password</param>
        /// <param name="confirmPassword">User confirm password</param>
        private User(string nickname, string role)
        {
            _nickname = nickname;
            _role = role;
            _entryDate = DateTime.Now;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Create account
        /// </summary>
        public static void CreateAccount(string nickname, string password, string confirmPassword, string role = "membre")
        {
            if (nickname != null && password == confirmPassword)
            {
                User user = new User(nickname, role);
            }
        }

        /// <summary>
        /// Connect to an account
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="password"></param>
        public void Connect(string nickname, string password)
        {

        }

        /// <summary>
        /// Get a user by an ID
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns></returns>
        public User GetUserById(int userId)
        {
            return null;
        }

        /// <summary>
        /// Get a user by his nickname
        /// </summary>
        /// <param name="nickname">User nickname</param>
        /// <returns></returns>
        public User GetUserByNickname(string nickname)
        {
            return null;
        }

        /// <summary>
        /// Get the inventory of the user by the user id
        /// </summary>
        /// <param name="idUser">User id</param>
        /// <returns></returns>
        public List<Character> GetInventoryById(int idUser)
        {
            return null;
        }

        /// <summary>
        /// Add a character to a list
        /// </summary>
        /// <param name="character">Character to add</param>
        public void AddCharacter(Character character)
        {
            // Check what type of character is it
            if(character is Fighter)
            {
                _fighterList.Add(character as Fighter);
            }
            else if(character is Tank)
            {
                _tankList.Add(character as Tank);
            }
        }
        #endregion
    }
}
