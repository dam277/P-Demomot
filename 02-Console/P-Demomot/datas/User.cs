using P_Demomot.characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.datas
{
    public class User
    {
        #region Properties
        //Int
        private int _id;                         //Id of the user
        private int _money;                      //Money of the user
        //String
        private string _userName;                //Username of the user
        //Objects
        private List<Fighter> _fightersList;    //List of character who have the user
        private List<Tank> _tankList;           //List of character who have the user
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
        public List<Fighter> FightersList
        {
            get { return _fightersList; }
            set { _fightersList = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Tank> TankList
        {
            get { return _tankList; }
            set { _tankList = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="id"></param>
        public User(string userName, int id)
        {
            _userName = userName;
            _id = id;
            _fightersList = new List<Fighter>();
            _tankList = new List<Tank>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add new fighter
        /// </summary>
        /// <param name="character"></param>
        public void AddFighter(Fighter character)
        {
            _fightersList.Add(character);
        }

        /// <summary>
        /// Add new tank    
        /// </summary>
        /// <param name="character"></param>
        public void AddTank(Tank character)
        {
            _tankList.Add(character);
        }
        #endregion
    }
}
