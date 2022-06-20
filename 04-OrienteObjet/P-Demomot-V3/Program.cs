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
            FtGameView ftGameView = new FtGameView();
            GameTypeView gameTypeView = new GameTypeView();
            InventoryView inventoryView = new InventoryView();
            LoginSignInView loginSignInView = new LoginSignInView();
            MainMenuView mainMenuView = new MainMenuView();
            OptionsView optionsView = new OptionsView();
            PlayView playView = new PlayView();
            TbCharactersChoice tbCharactersChoiceView = new TbCharactersChoice();
            TbGameView tbGameView = new TbGameView();

            // Controllers creation
            FtCharactersChoiceController ftCharactersChoice = new FtCharactersChoiceController();
            FtGameController ftGame = new FtGameController();

            TbCharactersChoiceController tbCharactersChoice = new TbCharactersChoiceController();
            TbGameController tbGame = new TbGameController();

            GameTypeController gameTypeController = new GameTypeController();
            PlayController playController = new PlayController();

            MainMenuController mainMenu = new MainMenuController();
            OptionsController options = new OptionsController();

            ChestsController chestsController = new ChestsController();
            InventoryController inventoryController = new InventoryController();
            LoginSignInController loginSignInController = new LoginSignInController(loginSignInView, user, rank, fighter, rarity, power);

            // Set the main controller
            MainController mainController = new MainController(loginSignInView, chestsView, ftCharactersChoiceView, ftGameView, gameTypeView, inventoryView, mainMenuView, optionsView, playView, tbCharactersChoiceView, tbGameView,
                ftCharactersChoice, ftGame, gameTypeController, playController, mainMenu, options, tbCharactersChoice, tbGame, chestsController, inventoryController, loginSignInController);

            // Run the login view
            Application.Run(loginSignInView);
        }
    }
}
