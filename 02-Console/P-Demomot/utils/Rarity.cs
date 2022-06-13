using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.utils
{
    public class Rarity
    {
        #region Properties
        /// <summary>
        /// INT
        /// </summary>
        private int _id;                            //Id of the rarity
        private int _lvl1UpgradePrice;              //Price to upgrade a character to level 2
        private int _lvl1CardsToUpgrade;            //Cards required to upgrade a character to level 2
        private int _lvl2UpgradePrice;              //Price to upgrade a character to level 3
        private int _lvl2CardsToUpgrade;            //Cards required to upgrade a character to level 3
        /// <summary>
        /// STRING
        /// </summary>
        private string _name;                       //Name of the rarity

        /// <summary>
        /// OBJECTS
        /// </summary>
        private ConsoleColor _consoleColor;
        #endregion

        #region Getters Setters
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
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
        public int Lvl1UpgradePrice
        {
            get { return _lvl1UpgradePrice; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Lvl1CardsToUpgrade
        {
            get { return _lvl1CardsToUpgrade; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Lvl2UpgradePrice
        {
            get { return _lvl2UpgradePrice; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Lvl2CardsToUpgrade
        {
            get { return _lvl2CardsToUpgrade; }
        }

        /// <summary>
        /// 
        /// </summary>
        public ConsoleColor CardColor
        {
            get { return _consoleColor; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default class constructor
        /// </summary>
        public Rarity()
        {

        }

        /// <summary>
        /// Rarity class constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="lvl1CardsToUpgrade"></param>
        /// <param name="lvl1UpgradePrice"></param>
        /// <param name="lvl2CardsToUpgrade"></param>
        /// <param name="lvl2UpgradePrice"></param>
        public Rarity(int id, string name, int lvl1CardsToUpgrade, int lvl1UpgradePrice, int lvl2CardsToUpgrade, int lvl2UpgradePrice, ConsoleColor consoleColor)
        {
            _name = name;
            _id = id;
            _lvl1CardsToUpgrade = lvl1CardsToUpgrade;
            _lvl1UpgradePrice = lvl1UpgradePrice;
            _lvl2CardsToUpgrade = lvl2CardsToUpgrade;
            _lvl2UpgradePrice = lvl2UpgradePrice;
            _consoleColor = consoleColor;
        }
        #endregion
    }
}
