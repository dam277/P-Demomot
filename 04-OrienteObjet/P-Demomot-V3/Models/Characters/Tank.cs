using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Demomot.Models.Utils;

namespace P_Demomot.Models.Characters
{
    class Tank : Character
    {
        #region Variables
        private int _moves;             // Tank moves
        private Power _power;           // Tank power
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public tank moves
        /// </summary>
        public int Moves
        {
            get
            {
                return _moves;
            }
            set
            {
                _moves = value;
            }
        }

        /// <summary>
        /// Public tank power
        /// </summary>
        public Power Power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }

        /// <summary>
        /// Public list of tanks
        /// </summary>
        public List<Tank> TanksList
        {
            get
            {
                return _tanksList;
            }
            set
            {
                _tanksList = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id">Id of the character</param>
        /// <param name="model">Model of the character</param>
        /// <param name="name">name of the character</param>
        /// <param name="level">level of the character</param>
        /// <param name="rarity">rarity of the character</param>
        /// <param name="life">life of the character</param>
        /// <param name="moves">moves of the character</param>
        /// <param name="power">power of the character</param>
        public Tank(int id, string model, string name, int level, Rarity rarity, int life, int moves, Power power) : base(id, model, name, level, rarity, life)
        {
            _moves = moves;
            _power = power;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a tank to the list
        /// </summary>
        /// <param name="tank">tank to add</param>
        public void AddTank(Tank tank)
        {
            _tanksList.Add(tank);
        }
        #endregion
    }
}
