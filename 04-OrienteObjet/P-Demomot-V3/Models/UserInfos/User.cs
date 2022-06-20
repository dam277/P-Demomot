using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
using P_Demomot.Models.Databases;
using P_Demomot.Models.Utils;
using P_Demomot.Views;
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
        // CONTROLLERS
        private LoginSignInController _loginSignInController;   // Login signin controller
        private MainController _mainController;                 // Main controller
        private InventoryController _inventoryController;       // Inventory controller

        // CLASS VARIABLES
        private int _id;                                        // User ID
        private string _nickname;                               // User nickname
        private string _role;                                   // User role
        private DateTime _entryDate;                            // User entry date
        private Rank _rank;                                     // User rank
        private List<Fighter> _fighterList;                     // User fighter list
        private List<Tank> _tankList;                           // User tank list
        private Dictionary<Rarity, List<Chest>> _chests;        // User chest list

        // REQUEST VARIABLES
        private Dictionary<string, string> _binds;              // Dictionary of binds to the requests
        private List<string> _columns;                          // Columns searched in the request
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
        /// Public login sigin controller
        /// </summary>
        public LoginSignInController LoginSignInController
        {
            get { return _loginSignInController; }
            set { _loginSignInController = value; }
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
            set { _entryDate = value; }
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
            _chests = new Dictionary<Rarity, List<Chest>>();
            _fighterList = new List<Fighter>();
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
        /// Connect to an account
        /// </summary>
        /// <param name="nickname">user nickname entered</param>
        /// <param name="password">user password entered</param>
        /// <returns>Returns true if the user is connected</returns>
        public bool Connect(string nickname, string password)
        {
            // Request
            string req = $"SELECT * FROM t_user WHERE useNickname = @nickname";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@nickname", nickname);

            //Columns name
            _columns = new List<string>();
            _columns.Add("idUser");
            _columns.Add("useNickname");
            _columns.Add("usePasswordHash");
            _columns.Add("useEntryDate");
            _columns.Add("usePermLevel");
            _columns.Add("idRank");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Check the password
            for(int i = 0; i < datas[2].Count; i++)
            {
                // Set the datas to the user if the password is good
                if (BCrypt.Net.BCrypt.Verify(password, datas[2][i]))
                {
                    this._id = Convert.ToInt32(datas[0][i]);
                    this._nickname = datas[1][i];
                    this._entryDate = Convert.ToDateTime(datas[3][i]);
                    this._role = (datas[4][i].ToString() == "1") ? "Membre" : "Administrateur";
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Create an account
        /// </summary>
        /// <param name="nickname">Nickname entered</param>
        /// <param name="password">Password entered and verified</param>
        /// <returns>Returns true if the user is created</returns>
        public bool SignUp(string nickname, string password)
        {
            // Request to check if the nickname exists in database
            if(CheckUserExistsByNickname(nickname) == true)
            {
                CreateAccount();
                return true;
            }
            else
            {
                return false;
            }

            // Create the account in database
            void CreateAccount()
            {
                // Create a new user
                User tempUser = new User(nickname, "membre");
                tempUser._entryDate = DateTime.Now;
                tempUser._rank = _loginSignInController.GetRank(0);

                // Get the informations
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                int role = (tempUser._role == "membre") ? 1 : 2;

                // Request
                string req = $"INSERT INTO t_user (`idUser`, `useNickname`, `usePasswordHash`, `useEntryDate`, `usePermLevel`, `idRank`) " +
                    $"VALUES (NULL, @nickname, @passwordHash, @entryDate, @role, @rankId);";

                //Binds
                _binds = new Dictionary<string, string>();
                _binds.Add("@nickname", tempUser._nickname);
                _binds.Add("@passwordHash", passwordHash);
                _binds.Add("@entryDate", tempUser._entryDate.ToString("yyyy-MM-dd"));
                _binds.Add("@role", role.ToString());
                _binds.Add("@rankId", tempUser._rank.Id.ToString());

                //Columns name
                _columns = new List<string>();
                _columns.Add("idUser");
                _columns.Add("useNickname");
                _columns.Add("usePasswordHash");
                _columns.Add("useEntryDate");
                _columns.Add("usePermLevel");
                _columns.Add("idRank");

                // Get the datas by requesting the database
                Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

                // Set the actual user
                this._id = GetUserIdByName(tempUser.Nickname);
                this._nickname = tempUser.Nickname;
                this.EntryDate = tempUser.EntryDate;
                this.Role = tempUser.Role;
                this.Rank = tempUser.Rank;

                // Create the first Fighter
                _loginSignInController.CreateFirstCharacter();
            }
        }

        /// <summary>
        /// Check if a user exists with the nickname given
        /// </summary>
        /// <param name="nickname">Nickname given</param>
        /// <returns>Return true if the user exists</returns>
        private bool CheckUserExistsByNickname(string nickname)
        {
            // requestq
            string req = $"SELECT idUser FROM t_user WHERE useNickname = @nickname";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@nickname", nickname);

            //Columns name
            _columns = new List<string>();
            _columns.Add("idUser");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            return (datas[0].Count() == 0) ? true : false;
        }

        /// <summary>
        /// Get the user id by name
        /// </summary>
        /// <param name="nickname"></param>
        /// <returns></returns>
        public int GetUserIdByName(string nickname)
        {
            // Request
            string req = $"SELECT idUser FROM t_user WHERE useNickname = @nickname";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@nickname", nickname);

            //Columns name
            _columns = new List<string>();
            _columns.Add("idUser");

            // Get the datas by requesting the database
            return Convert.ToInt32(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]);
        }

        /// <summary>
        /// Get a user by an ID
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>Returns the user</returns>
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
