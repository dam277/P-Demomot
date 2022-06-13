using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Demomot.Models.Utils;

namespace P_Demomot.Models.Characters
{
    class Fighter : Character
    {
        #region Variables
        private Dictionary<string, Power> _powers;          // Powers of a fighter
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public Dictionary of powers
        /// </summary>
        public Dictionary<string, Power> Power
        {
            get
            {
                return _powers;
            }
            set
            {
                _powers = value;
            }
        }

        /// <summary>
        /// Public list of fighters
        /// </summary>
        public List<Fighter> FightersList
        {
            get
            {
                return _fightersList;
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
        public Fighter(int id, string model, string name, int level, Rarity rarity, int life) : base(id, model, name, level, rarity, life)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a power to the list
        /// </summary>
        /// <param name="power">Power to add</param>
        public void AddPower(Power power)
        {
            _powers.Add(power.Name, power);
        }

        /// <summary>
        /// Add a fighter to the list
        /// </summary>
        /// <param name="fighter">Fighter ro add</param>
        public void AddFighter(Fighter fighter)
        {
            _fightersList.Add(fighter);
        }
        #endregion
    }
}
