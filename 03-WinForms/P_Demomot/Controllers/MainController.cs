using P_Demomot.Models;
using P_Demomot.Views;
using System;
using System.Resources;
using P_Demomot.Resources;

namespace P_Demomot.Controllers
{
    public class MainController
    {
        private LoginView _loginView;           //
        private GameOneView _gameOneView;       //
        private GameTwoView _gameTwoView;       //

        private AccountModel _accountModel;     //

        private ResourceManager _resourceManager;   //
            
        /// <summary>
        /// 
        /// </summary>
        public ResourceManager ResourceManager
        {
            get { return _resourceManager; }
            set { _resourceManager = value; }
        }

        public enum Lang
        {
            FR,
            EN,
            IT,
            DE
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginView"></param>
        /// <param name="gameOneView"></param>
        /// <param name="gameTwoView"></param>
        /// <param name="accountModel"></param>
        public MainController(LoginView loginView, GameOneView gameOneView, GameTwoView gameTwoView, AccountModel accountModel)
        {
            _loginView = loginView;
            _gameOneView = gameOneView;
            _gameTwoView = gameTwoView;
            _accountModel = accountModel;

            _loginView.MainController = this;
            _gameOneView.MainController = this;
            _gameTwoView.MainController = this;
            _accountModel.MainController = this;
        }

        /// <summary>
        /// Change the language of the page
        /// </summary>
        /// <param name="langIndex"></param>
        /// <returns></returns>
        public void ChangeLanguage(int langIndex)
        {
            // Détermine la langue courante
            Type type;
            switch (langIndex)
            {
                case (int)Lang.EN:
                    type = typeof(Resources.EN);
                    break;
                case (int)Lang.FR:
                    type = typeof(Resources.FR);
                    break;
                case (int)Lang.IT:
                    type = typeof(Resources.IT);
                    break;
                case (int)Lang.DE:
                    type = typeof(Resources.DE);
                    break;
                default:
                    type = typeof(Resources.FR);
                    break;
            }

            // Instancie le ressourceManager en fonction de la langue active
            _resourceManager = new ResourceManager(type);

            _loginView.UpdateLanguage();
        }


    }
}
