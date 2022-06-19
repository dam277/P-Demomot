﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.FightTactics
{
    public class FtGameController : MainController
    {
        private MainController _mainController;         // Main controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }
    }
}
