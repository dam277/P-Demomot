using P_Demomot.Controllers;
using P_Demomot.Models;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creation of views
            LoginView loginView = new LoginView();
            GameOneView gameOneView = new GameOneView();
            GameTwoView gameTwoView = new GameTwoView();

            //Creation of models
            AccountModel accountModel = new AccountModel();

            //Creation of controllers
            MainController mainController = new MainController(loginView, gameOneView, gameTwoView, accountModel);


            Application.Run(loginView);
        }
    }
}
