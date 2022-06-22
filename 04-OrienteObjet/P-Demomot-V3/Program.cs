using P_Demomot.Controllers;
using P_Demomot.Controllers.FightTactics;
using P_Demomot.Controllers.Game;
using P_Demomot.Controllers.Menus;
using P_Demomot.Controllers.TankBattle;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
using P_Demomot.Models.Databases;
using P_Demomot.Models.UserInfos;
using P_Demomot.Models.Utils;
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

            // Models creation
            Character character = new Character();
            Fighter fighter = new Fighter();
            Power power = new Power();
            Tank tank = new Tank();

            Database database = Database.GetInstance();

            Chest chest = new Chest();
            Rank rank = new Rank();
            Team team = new Team();
            User user = new User();

            Rarity rarity = new Rarity();

            // Views creation
            ChestsView chestsView = new ChestsView();
            FtCharactersChoice ftCharactersChoiceView = new FtCharactersChoice();
            FtCharactersChoiceInventory ftCharactersChoiceInventory = new FtCharactersChoiceInventory();
            FtGameView ftGameView = new FtGameView();
            InventoryView inventoryView = new InventoryView();
            LoginSignInView loginSignInView = new LoginSignInView();
            MainMenuView mainMenuView = new MainMenuView();
            PlayView playView = new PlayView();
            TbCharactersChoice tbCharactersChoiceView = new TbCharactersChoice();
            TbGameView tbGameView = new TbGameView();

            // Controllers creation
            FtCharactersChoiceController ftCharactersChoice = new FtCharactersChoiceController(ftCharactersChoiceView, ftCharactersChoiceInventory, user, team, fighter, power);
            FtGameController ftGame = new FtGameController(ftGameView, team, power, chest, rank);

            TbCharactersChoiceController tbCharactersChoice = new TbCharactersChoiceController();
            TbGameController tbGame = new TbGameController();

            PlayController playController = new PlayController(playView);

            MainMenuController mainMenu = new MainMenuController(mainMenuView, user);

            ChestsController chestsController = new ChestsController(chestsView, chest, user, rarity, fighter, power);
            InventoryController inventoryController = new InventoryController(inventoryView, user, fighter, power);
            LoginSignInController loginSignInController = new LoginSignInController(loginSignInView, user, rank, fighter, rarity, power);

            // Set the main controller
            MainController mainController = new MainController(loginSignInView, chestsView, ftCharactersChoiceView, ftGameView, inventoryView, mainMenuView, playView, tbCharactersChoiceView, tbGameView,
                    ftCharactersChoice, ftGame, playController, mainMenu, tbCharactersChoice, tbGame, chestsController, inventoryController, loginSignInController, ftCharactersChoiceInventory);

            // Run the login view
            Application.Run(loginSignInView);
        }
    }
}
