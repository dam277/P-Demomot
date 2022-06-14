using P_Demomot.Controllers;
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
        private string _name;                               // Chest name
        private int _idChest;                               // Chest Id
        private Rarity _rarity;                             // Chest rarity
        private Dictionary<Rarity, uint> _chanceNbr;        // Chest chanceNbr
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
        public Dictionary<Rarity, uint> ChanceNbr
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
        public Dictionary<Rarity, List<Chest>> GetAllChests()
        {
            return null;
        }
        #endregion
    }
}
