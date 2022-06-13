using MySql.Data.MySqlClient;
using P_Demomot.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot.Models.Databases
{
    public class Database
    {
        private MainController _mainController;             // Main controller

        MySqlConnection _connection;                        // Database connection
        string _dbName = "db_demomot";                      // Database name
        string _userID = "root";                            // Database login
        string _password = "root";                          // Database password
        private static Database _instance;                  // Instance of the database

        /// <summary>
        /// Public main controller
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
        /// Private class contructor
        /// </summary>
        private Database()
        {
            Connection();
        }

        /// <summary>
        /// Get the database instance
        /// </summary>
        /// <returns></returns>
        public static Database GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }

        /// <summary>
        /// Prepare query and execute request
        /// </summary>
        /// <param name="req">Database request</param>
        /// <param name="args">Arguments for the request</param>
        /// <returns>Return an object of datas</returns>
        public object QueryPrepareExecutes(string req, List<string> args)
        {
            return null;
        }

        /// <summary>
        /// Execute request
        /// </summary>
        /// <param name="req">Database request</param>
        /// <returns>Return an object of datas</returns>
        public object QueryExecute(string req)
        {
            return null;
        }

        /// <summary>
        /// Connection of the database
        /// </summary>
        private void Connection()
        {
            //MySQL connection         
            string connectionString = "SERVER=localhost;" + "DATABASE=" + _dbName + ";" + "UID=" + _userID + ";" + "PASSWORD=" + _password + ";" + "SslMode = none";
            _connection = new MySqlConnection(connectionString);

            //if can't connect
            if (!OpenConnection())
            {
                MessageBox.Show("Connexion failed, retry");
                return;
            }
            else
            {
                MessageBox.Show("Connexion open");
            }

            bool OpenConnection()
            {
                //Connexion and error display
                try
                {
                    _connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        default:
                            MessageBox.Show("Error number : " + Convert.ToString(ex) + " (MySQL exeption)");
                            break;
                        case 0:
                            MessageBox.Show("Cannot connect to server, verify your database's name");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                        case 1042:
                            MessageBox.Show("Invalid server name");
                            break;
                    }
                    return false;
                }
            }
        }
    }
}
