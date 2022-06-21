using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
using P_Demomot.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    public class Chest
    {
        #region Variables
        private MainController _mainController;             // Main controller
        private ChestsController _chestController;         //chest controller
        private string _name;                               // Chest name
        private int _idChest;                               // Chest Id
        private Rarity _rarity;                             // Chest rarity
        private int _chanceNbr;                             // Chest chanceNbr
                                                            // REQUEST VARIABLES
        private Dictionary<string, string> _binds;              // Dictionary of binds to the requests
        private List<string> _columns;                          // Columns searched in the request
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
        /// Public main controller
        /// </summary>
        public ChestsController ChestsController
        {
            get { return _chestController; }
            set { _chestController = value; }
        }

        /// <summary>
        /// Public chest name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Public chest id
        /// </summary>
        public int IdChest
        {
            get
            {
                return _idChest;
            }
        }

        /// <summary>
        /// Public chest rarity
        /// </summary>
        public Rarity Rarity
        {
            get
            {
                return _rarity;
            }
        }

        /// <summary>
        /// Public chest chance nbr
        /// </summary>
        public int ChanceNbr
        {
            get
            {
                return _chanceNbr;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Chest()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="rarity">Chest rarity</param>
        private Chest(Rarity rarity)
        {
            _rarity = rarity;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="idChest">Chest id</param>
        /// <param name="cheNbrChance">Chest number chance drop</param>
        /// <param name="cheName">Chest name</param>
        private Chest(int idChest, int cheNbrChance, string cheName)
        {
            _idChest = idChest;
            _chanceNbr = cheNbrChance;
            _name = cheName;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get a chest by his id
        /// </summary>
        /// <param name="idChest">Chest id</param>
        /// <returns>Return a specific chest</returns>
        public Chest GetChestsById(int idChest)
        {
            return null;
        }

        /// <summary>
        /// Get all the chests
        /// </summary>
        /// <returns>Return all the chests of the user</returns>
        public List<Chest> GetAllChests()
        {
            // Request
            string req = $"SELECT * FROM t_chest";

            //Columns name
            _columns = new List<string>();
            _columns.Add("idChest");
            _columns.Add("cheNbrChance");
            _columns.Add("cheName");
            _columns.Add("idRarity");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QuerySimpleExecute(req, _columns);

            //Create the characters
            List<Chest> chests = new List<Chest>();
            for (int i = 0; i < datas[0].Count(); i++)
            {
                Chest chest = new Chest(Convert.ToInt32(datas[0][i]), Convert.ToInt32(datas[1][i]), datas[2][i]);
                chests.Add(chest);
            }

            return chests;
        }
        #endregion
    }
}
