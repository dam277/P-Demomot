using P_Demomot.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.characters
{
    public class Fighter : Character
    {
        private List<Power> _powers;            //List of all the power of a fighter

        /// <summary>
        /// 
        /// </summary>
        public List<Power> Powers
        {
            get { return _powers; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Fighter> FightersList
        {
            get { return _fightersList; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="life"></param>
        /// <param name="rarity"></param>
        public Fighter(int id, string model, string name, int level, int life, Rarity rarity) : base(id, model, name, level, life, rarity)
        {
           
        }

        /// <summary>
        /// Add a power to the character
        /// </summary>
        /// <param name="power"></param>
        public void AddPower(Power power)
        {
            _powers.Add(power);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fighter"></param>
        public void AddFighter(Fighter fighter)
        {
            _fightersList.Add(fighter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        public override void DisplayCharacters(object sender)
        {
            //Display title different as tanks

            //Display characters
            base.DisplayCharacters(this);
        }
    }
}
