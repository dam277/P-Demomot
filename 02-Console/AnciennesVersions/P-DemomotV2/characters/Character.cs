using P_Demomot.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.characters
{
    public class Character
    {
        #region Properties
        //String
        protected string _name;                                            //Name of the character
        protected string _model;                                           //Model of the character
        //Int
        protected int _level;                                              //Level of the character
        protected int _life;                                               //Life of the character private int _damage;                                             //Damages of the character
        protected int _id;                                                 //Damages of the character
        //Objects
        protected Rarity _rarity;                                          //Rarity of the character
        protected ClassType _type;
        protected List<Fighter> _fightersList;
        protected List<Tank> _tanksList;
        protected List<Power> _debuffs;

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
        public string Model
        {
            get { return _model; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Rarity Rarity
        {
            get { return _rarity; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Tank> TanksList
        {
            get { return _tanksList; }
        }

        /// <summary>
        /// 
        /// </summary>
        public ClassType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Power> Debuffs
        {
            get { return _debuffs; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Character class constructor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="life"></param>
        /// <param name="damage"></param>
        /// <param name="rarity"></param>
        public Character(int id, string model, string name, int level, int life, Rarity rarity)
        {
            _model = model;
            _name = name;
            _level = level;
            _life = life;
            _rarity = rarity;
        }

        #endregion

        #region Methods
        public virtual void DisplayCharacters(object sender)
        {

        }

        #endregion
    }
}
