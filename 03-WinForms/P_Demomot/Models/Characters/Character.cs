using P_Demomot.Models.Characters.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters
{
    public class Character
    {
        /// <summary>
        /// INT
        /// </summary>
        protected int _id;            //
        protected int _hp;            //
        protected int _level;         //

        /// <summary>
        /// STRING
        /// </summary>
        protected string _name;           //
        protected string _description;    //
        protected string _modelPath;      //

        /// <summary>
        /// OBJECTS
        /// </summary>
        protected List<Power> _powers;    //
        protected Types _type;            //
        protected Rarity _rarity;         //

        public Character(int id, int hp, int level, string name, string description, string modelPath)
        {
            _id = id;
            _hp = hp;
            _level = level;
            _name = name;
            _description = description;
            _modelPath = modelPath;
            _powers = new List<Power>();

        }
    }
}
