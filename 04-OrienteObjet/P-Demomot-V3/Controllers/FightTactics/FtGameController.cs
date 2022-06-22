using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot.Controllers.FightTactics
{
    public class FtGameController : MainController
    {
        // CONTROLLERS
        private MainController _mainController;         // Main controller

        // VIEWS
        private FtGameView _ftGameView;                 // Ft game view

        // MODELS
        private Team _team;                             // Team model
        private Power _power;                           // Power model
        private Chest _chest;                           // Chest model
        private Rank _rank;                             // Rank model

        private int _turn = 1;                           // Turn definer
        private int _attacker = 1;                       // Attacker definer

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }
        /// <summary>
        /// Public main controller
        /// </summary>
        public Team Team
        {
            get { return _team; }
            set {_team = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="ftGameView">ft game view</param>
        /// <param name="team">team model</param>
        public FtGameController(FtGameView ftGameView, Team team, Power power, Chest chest, Rank rank)
        {
            _ftGameView = ftGameView;
            _team = team;
            _power = power;
            _chest = chest;
            _rank = rank;
            _ftGameView.FtGameController = this;
            _team.FtGameController = this;
            _power.FtGameController= this;
            _chest.FtGameController = this;
            _rank.FtGameController = this;
        }

        /// <summary>
        /// Get the powers name
        /// </summary>
        /// /// <param name="characterName">character name</param>
        /// <returns>Return a dictionary of powers</returns>
        public Dictionary<string, string> GetPowersName(string characterName)
        {
            return _power.GetPowersNameByCharacterName(characterName);
        }

        /// <summary>
        /// Get the team
        /// </summary>
        /// <returns>Return a team</returns>
        public Team GetTeam(int teamNbr)
        {
            switch(teamNbr)
            {
                case 1:
                    return _team.Teams[0];
                    break;
                case 2:
                    return _team.Teams[1];
                    break;
                default:
                    return null;
                    break;
            }
        }
        
        /// <summary>
        /// Make the attack
        /// </summary>
        /// <param name="target"></param>
        public void Attack(int target)
        {
            // Check if the character is dead
            if (!IsCharacterDead())
            {
                // Check wich team can attack
                if (_turn % 2 == 1)
                {
                    if (target == 1 || target == 2 || target == 3)
                    {
                        // Nothing
                        MessageBox.Show("Impossible to attack your team");
                    }
                    else
                    {
                        // Set the turn
                        _ftGameView.SetTurn("Joueur2");
                        // Get power name
                        string powerName = _ftGameView.PowerNameUsed(_attacker);
                        MakeDamages(target, powerName);
                        MessageBox.Show(powerName);
                        _turn++;
                        _attacker++;
                    }
                }
                else
                {
                    if (target == 4 || target == 5 || target == 6)
                    {
                        // Nothing
                        MessageBox.Show("Impossible to attack your team");
                    }
                    else
                    {
                        // Set the turn
                        _ftGameView.SetTurn("Joueur1");
                        // Get power name
                        string powerName = _ftGameView.PowerNameUsed(_attacker);
                        MakeDamages(target, powerName);
                        MessageBox.Show(powerName);
                        _turn++;
                        _attacker++;
                    }
                }
            }
            else
            {
                // Character is dead
                MessageBox.Show("Your character is dead, the other team can play");
                _turn++;
                _attacker++;
            }

            // Reset attacker
            if(_attacker == 7)
            {
                _attacker = 1;
            }

            // Check all teams
            for (int i = 0; i < _team.Teams.Count(); i++)
            {
                // Check if a team is dead
                if (AreAllCharactersDead(_team.Teams[i]))
                {
                    // Show who won
                    MessageBox.Show($"Joueur{i} WINS");

                    // Get a chest
                    List<Chest> chests = _chest.GetAllChests();
                    Random random = new Random();
                    int chestNbr = random.Next(0, 501);

                    // Check which chest will be recieve
                    if(chestNbr < chests[0].ChanceNbr)
                    {
                        _chest.AddChest(chests[0].IdChest, _team.Teams[i].User.Id);
                    }
                    else if(chestNbr < chests[1].ChanceNbr)
                    {
                        _chest.AddChest(chests[1].IdChest, _team.Teams[i].User.Id);
                    }
                    else if (chestNbr < chests[2].ChanceNbr)
                    {
                        _chest.AddChest(chests[2].IdChest, _team.Teams[i].User.Id);
                    }
                    else if (chestNbr < chests[3].ChanceNbr)
                    {
                        _chest.AddChest(chests[3].IdChest, _team.Teams[i].User.Id);
                    }
                    else if (chestNbr < chests[4].ChanceNbr)
                    {
                        _chest.AddChest(chests[4].IdChest, _team.Teams[i].User.Id);
                    }
                    else if (chestNbr < chests[5].ChanceNbr)
                    {
                        _chest.AddChest(chests[5].IdChest, _team.Teams[i].User.Id);
                    }
                    else if (chestNbr < chests[6].ChanceNbr)
                    {
                        _chest.AddChest(chests[6].IdChest, _team.Teams[i].User.Id);

                    }

                    // Set the rank

                    // Reset
                    for(int y = 0; y < _team.Teams.Count; y++)
                    {
                        _team.Teams[y] = null;
                    }
                    
                    // Show the menu
                    _mainController.ShowView(Action.MAINMENU, _ftGameView);
                    break;
                }
            }
        }

        /// <summary>
        /// Make damages to the target
        /// </summary>
        /// <param name="target">target character</param>
        /// <param name="powername">Name of the powers</param>
        private void MakeDamages(int target, string powername)
        {
            // Set the damages
            string[] damages;
            switch(_attacker)
            {
                case 1:
                    damages = _team.Teams[0].CharactersList[0].Power[powername].Capacity.Split('=');
                    break;
                case 2:
                    damages = _team.Teams[1].CharactersList[0].Power[powername].Capacity.Split('=');
                    break;
                case 3:
                    damages = _team.Teams[0].CharactersList[1].Power[powername].Capacity.Split('=');
                    break;
                case 4:
                    damages = _team.Teams[1].CharactersList[1].Power[powername].Capacity.Split('=');
                    break;
                case 5:
                    damages = _team.Teams[0].CharactersList[2].Power[powername].Capacity.Split('=');
                    break;
                case 6:
                    damages = _team.Teams[1].CharactersList[2].Power[powername].Capacity.Split('=');
                    break;
                default:
                    damages = new string[0];
                    break;
            }

            // Get the target
            switch(target)
            {
                case 1:
                    _team.Teams[0].CharactersList[0].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(1, _team.Teams[0].CharactersList[0].Life);
                    break;
                case 2:
                    _team.Teams[0].CharactersList[1].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(2, _team.Teams[0].CharactersList[1].Life);
                    break;
                case 3:
                    _team.Teams[0].CharactersList[2].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(3, _team.Teams[0].CharactersList[2].Life);
                    break;
                case 4:
                    _team.Teams[1].CharactersList[0].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(4, _team.Teams[1].CharactersList[0].Life);
                    break;
                case 5:
                    _team.Teams[1].CharactersList[1].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(5, _team.Teams[1].CharactersList[1].Life);
                    break;
                case 6:
                    _team.Teams[1].CharactersList[2].Life -= Convert.ToInt32(damages[1]);
                    _ftGameView.MakeDamages(6, _team.Teams[1].CharactersList[2].Life);
                    break;
            }    
        }

        /// <summary>
        /// Check if the character is dead
        /// </summary>
        /// <returns>Return boolean</returns>
        private bool IsCharacterDead()
        {
            // Check which character is dead with the attacker variable
            switch (_attacker)
            {
                case 1:
                    if (_team.Teams[0].CharactersList[0].Life <= 0)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (_team.Teams[1].CharactersList[0].Life <= 0)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (_team.Teams[0].CharactersList[1].Life <= 0)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (_team.Teams[1].CharactersList[1].Life <= 0)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (_team.Teams[0].CharactersList[2].Life <= 0)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (_team.Teams[1].CharactersList[2].Life <= 0)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        /// <summary>
        /// Check if a team is dead (lose)
        /// </summary>
        /// <param name="team">Team to check</param>
        /// <returns>Return boolean</returns>
        private bool AreAllCharactersDead(Team team)
        {
            // Update a counter at every character dead
            int counter = 0;
            foreach(Fighter fighter in team.CharactersList)
            {
                if(fighter.Life <= 0)
                {
                    counter++;
                }
            }

            // Check how many are dead
            if(counter == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
