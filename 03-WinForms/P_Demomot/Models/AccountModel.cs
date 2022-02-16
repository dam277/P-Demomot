using P_Demomot.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models
{
    public class AccountModel
    {
        private MainController _mainController;

        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        private List<UserModel> _users;

        public List<UserModel> Users
        {
            get { return _users; }
        }

        public AccountModel()
        {
            _users = new List<UserModel>();
        }

        public void CreateUser(string name, string email, string password)
        {
            UserModel user = new UserModel(name, email, password);
        }


    }
}
