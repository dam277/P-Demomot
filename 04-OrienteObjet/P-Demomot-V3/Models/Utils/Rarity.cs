using P_Demomot.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Utils
{
    public class Rarity
    {
        private MainController _mainController;
        private Dictionary<int, Tuple<int, int>> _upgrades;
        private string _name;

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

        public Dictionary<int, Tuple<int, int>> Upgrades
        {
            get
            {
                return _upgrades;
            }
            set
            {
                _upgrades = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Rarity()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lvl1UpCards"></param>
        /// <param name="lvl1UpPrice"></param>
        /// <param name="lvl2UpCards"></param>
        /// <param name="lvl2UpPrice"></param>
        public Rarity(string name, int lvl1UpCards, int lvl1UpPrice, int lvl2UpCards, int lvl2UpPrice)
        {
            _name = name;
            _upgrades.Add(1, new Tuple<int, int>(lvl1UpCards, lvl1UpPrice));
            _upgrades.Add(2, new Tuple<int, int>(lvl2UpCards, lvl2UpPrice));
        }


        public Rarity GetRarityByName(string name)
        {
            return null;
        }
    }
}
