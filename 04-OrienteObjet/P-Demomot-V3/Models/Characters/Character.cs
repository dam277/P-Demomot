﻿using P_Demomot.Controllers;
using P_Demomot.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters
{
    class Character
    {
        #region Variables   
        protected MainController _mainController;       // Main controller
        protected int _idCharacter;                     // Id of the character
        protected string _name;                         // name of the character
        protected string _model;                        // Model of the character
        protected int _level;                           // level of the character
        protected int _life;                            // life of the character
        protected Rarity _rarity;                       // rarity of the character
        protected List<Fighter> _fightersList;           // List of fighters
        protected List<Tank> _tanksList;                 // List of tanks
        #endregion

        #region getter setter
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
        /// Public Character ID
        /// </summary>
        public int IdCharacter
        {
            get
            {
                return _idCharacter;
            }
        }

        /// <summary>
        /// Public Character Name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Public character model
        /// </summary>
        public string Model
        {
            get
            {
                return _model;
            }
        }

        /// <summary>
        /// Public Character level
        /// </summary>
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        /// <summary>
        /// Public Character Life
        /// </summary>
        public int Life
        {
            get
            {
                return _life;
            }
            set
            {
                _life = value;
            }
        }

        /// <summary>
        /// Pubic character rarity
        /// </summary>
        public Rarity Rarity
        {
            get
            {
                return _rarity;
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
        public Character(int id, string model, string name, int level, Rarity rarity, int life)
        {
            _idCharacter = id;
            _model = model;
            _name = name;
            _level = level;
            _rarity = rarity;
            _life = life;
        }
        #endregion

        #region Methods
        #endregion
    }
}
