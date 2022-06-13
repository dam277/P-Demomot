using P_Demomot.Controllers;
using P_Demomot.Models.Characters;
using P_Demomot.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    class User
    {
        #region Variables 
        private MainController _mainController;                 // Main controller
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
        #endregion

        #region Methods
        #endregion
    }
}
