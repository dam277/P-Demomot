using P_Demomot.Models.UserInfos;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.UserProperties
{
    public class LoginSignInController : MainController
    {
        // CONTROLLERS
        private MainController _mainController;                 // Main controller

        // VIEWS
        private LoginSignInView _signInView;                    // Login and signin view

        // MODELS
        private User _user;                                     // User model

        // PUBLIC CONTROLLERS
        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        // PUBLIC VIEWS
        /// <summary>
        /// Public signin view
        /// </summary>
        public LoginSignInView SignInView
        {
            get { return _signInView; }
            set { _signInView = value; }
        }

        // PUBLIC MODELS
        /// <summary>
        /// Public user model
        /// </summary>
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }


        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="signInView"></param>
        /// <param name="user"></param>
        public LoginSignInController(LoginSignInView signInView, User user)
        {
            _signInView = signInView;
            _user = user;
            _signInView.LoginSignInController = this;
            _user.LoginSignInController = this;
        }

        /// <summary>
        /// Connect to a user by searching into database
        /// </summary>
        /// <param name="nickname">Nickname of the user</param>
        /// <param name="password">Password of the user</param>
        public void ConnectToUser(string nickname, string password)
        {
            if(_user.Connect(nickname, password) == true)
            {
                _mainController.ShowView(Action.MAINMENU, _signInView);
            }
            else
            {
                _signInView.ShowConnectionErros("Le mot de passe ou le nom d'utilisateur n'est pas correct");
            }            
        }
    }
}
