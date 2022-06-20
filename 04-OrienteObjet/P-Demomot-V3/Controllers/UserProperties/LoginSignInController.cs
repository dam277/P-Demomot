using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Models.Utils;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.UserProperties
{
    public class LoginSignInController : MainController
    {
        #region Variables
        // REGEX
        Regex passwordRegex = new Regex(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}");

        // CONTROLLERS
        private MainController _mainController;                 // Main controller

        // VIEWS
        private LoginSignInView _signInView;                    // Login and signin view

        // MODELS
        private User _user;                                     // User model
        private Rank _rank;                                     // Rank model
        private Fighter _fighter;                               // Fighter model
        private Rarity _rarity;                                 // Rarity
        private Power _power;                                   // Power model
        #endregion

        #region Getter Setter
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
        /// Public rank model
        /// </summary>
        public Rank Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        /// <summary>
        /// Public rank model
        /// </summary>
        public Power Power
        {
            get { return _power; }
            set { _power = value; }
        }

        /// <summary>
        /// Public fighter model
        /// </summary>
        public Fighter Fighter
        {
            get { return _fighter; }
            set { _fighter = value; }
        }

        /// <summary>
        /// Public fighter model
        /// </summary>
        public Rarity Rarity
        {
            get { return _rarity; }
            set { _rarity = value; }
        }
        #endregion

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="signInView"></param>
        /// <param name="user"></param>
        public LoginSignInController(LoginSignInView signInView, User user, Rank rank, Fighter fighter, Rarity rarity, Power power)
        {
            _signInView = signInView;
            _user = user;
            _rank = rank;
            _fighter = fighter;
            _rarity = rarity;
            _power = power;
            _signInView.LoginSignInController = this;
            _user.LoginSignInController = this;
            _rank.LoginSignInController = this;
            _fighter.LoginSignInController = this;
            _rarity.LoginSignInController = this;
            _power.loginSignInController = this;
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
                _signInView.ShowConnectionErrors("Le mot de passe ou le nom d'utilisateur n'est pas correct");
            }            
        }

        /// <summary>
        /// Create a new account after checking the datas entered
        /// </summary>
        /// <param name="nickname">Nickname entered</param>
        /// <param name="password">Password entered</param>
        /// <param name="confirmPassword">Password confirm entered</param>
        public void CreateAccount(string nickname, string password, string confirmPassword)
        {
            string message = "";                // Error message

            // Check if the password is the same as the confirmed one
            if(password == confirmPassword)
            {
                // Match the password with the regex
                Match passwordMatch = passwordRegex.Match(password);
                if (passwordMatch.Success)
                {
                    // Check if the user exists and create him
                    if(_user.SignUp(nickname, password) == true)
                    {
                        _mainController.ShowView(Action.MAINMENU, _signInView);
                    }
                    else
                    {
                        message = "Le nom d'utilisateur existe déjà, veuillez en choisir un autre";
                    }
                }
                else
                {
                    message = "Le mot de passe ne respecte pas les conditions \n Rappel : Minimum 8 caractères, 1 caractère spécial, 1 chiffre, 1 majuscule";
                }
            }
            else
            {
                message = "Les mots de passes ne sont pas les mêmes";
            }

            _signInView.ShowInscriptionErrors(message);
        }

        /// <summary>
        /// Get the rank by points for the start
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public Rank GetRank(int points)
        {
            return _rank.GetRankByPoints(points);
        }

        /// <summary>
        /// Create the first character
        /// </summary>
        public void CreateFirstCharacter()
        {
            // Create the character
            Fighter recruit = _fighter.CreateFirstCharacter(_fighter.FightersList[0], "", 1, _user.Id, _fighter.FightersList[0].Rarity) as Fighter;
            
            // Get powers name
            Dictionary<string, string> powersName = _power.GetPowersNameByCharacterName(recruit.Name);

            // Create his powers
            Power kick = _power.CreatePower(recruit.Name, powersName["Power1"], recruit.Level);
            Power punch = _power.CreatePower(recruit.Name, powersName["Power2"], recruit.Level);
            recruit.AddPower(kick);
            recruit.AddPower(punch);

            // Add him into the list of character of the user
            _user.AddCharacter(recruit);
        }

        /// <summary>
        /// Get the character Id
        /// </summary>
        /// <param name="characterName">character name</param>
        /// <returns>Return the id of the character</returns>
        public int GetCharacterId(string characterName)
        {
            return _fighter.GetId(characterName, _user.Id);
        }

        /// <summary>
        /// Create all the character to do the model list of them
        /// </summary>
        public void CreateAllCharacters()
        {
            #region Creation of rarities
            // Create the rarities
            List<Rarity> rarities = _rarity.GetAllRarity();
            #endregion

            #region Creation of Fighters
            //-------------------------------------Basic-------------------------------------\\
            //Recruit
            Fighter recruit = new Fighter("Recruit", rarities[0]);
            Power punch = new Power("Kick");
            Power kick = new Power("Punch");
            recruit.AddPower(punch);
            recruit.AddPower(kick);
            //-------------------------------------Common-------------------------------------\\
            //InfantryMan
            Fighter infantryman = new Fighter("Infantryman", rarities[1]);
            Power hit = new Power("Hit");
            Power shoot = new Power("Shoot");
            Power uSnipe = new Power("USnipe");
            infantryman.AddPower(hit);
            infantryman.AddPower(shoot);
            infantryman.AddPower(uSnipe);
            //TrapInstaller
            Fighter trapInstaller = new Fighter("Trap Installer", rarities[1]);
            Power trap = new Power("Trap");
            Power slap = new Power("Slap");
            Power uTrapped = new Power("UTrapped");
            trapInstaller.AddPower(trap);
            trapInstaller.AddPower(slap);
            trapInstaller.AddPower(uTrapped);
            //Archer
            Fighter archer = new Fighter("Archer", rarities[1]);
            Power arrow = new Power("Arrow");
            Power fireArrow = new Power("FireArrow");
            Power uSleepyArrow = new Power("USleepyArrow");
            archer.AddPower(arrow);
            archer.AddPower(fireArrow);
            archer.AddPower(uSleepyArrow);
            //-------------------------------------Rare-------------------------------------\\
            //Knight
            Fighter knight = new Fighter("Knight", rarities[2]);
            Power swordHit = new Power("SwordHit");
            Power overHealed = new Power("OverHealed");
            Power uShield = new Power("UShield");
            knight.AddPower(swordHit);
            knight.AddPower(overHealed);
            knight.AddPower(uShield);
            //Shaman
            Fighter shaman = new Fighter("Shaman", rarities[2]);
            Power laser = new Power("Laser");
            Power heal = new Power("Heal");
            Power uResurection = new Power("UResurection");
            shaman.AddPower(laser);
            shaman.AddPower(heal);
            shaman.AddPower(uResurection);
            //HorseMan
            Fighter horseman = new Fighter("Horseman", rarities[2]);
            Power charge = new Power("Charge");
            Power boost = new Power("Boost");
            Power uImpale = new Power("UImpale");
            horseman.AddPower(charge);
            horseman.AddPower(boost);
            horseman.AddPower(uImpale);
            //-------------------------------------Super Rare-------------------------------------\\
            //Ram
            Fighter ram = new Fighter("Ram", rarities[3]);
            Power speedCharge = new Power("SpeedCharge");
            Power tank = new Power("Tank");
            Power uConcentration = new Power("UConcentration");
            ram.AddPower(speedCharge);
            ram.AddPower(tank);
            ram.AddPower(uConcentration);
            //BearTrainer
            Fighter bearTrainer = new Fighter("Bear trainer", rarities[3]);
            Power bearSlap = new Power("BearSlap");
            Power bleeding = new Power("Bleeding");
            Power uBearRage = new Power("UBearRage");
            bearTrainer.AddPower(bearSlap);
            bearTrainer.AddPower(bleeding);
            bearTrainer.AddPower(uBearRage);
            //Sorcerer
            Fighter sorcerer = new Fighter("Sorcerer", rarities[3]);
            Power fire = new Power("Fire");
            Power purify = new Power("Purify");
            Power uFreeze = new Power("UFREEZE");
            sorcerer.AddPower(fire);
            sorcerer.AddPower(purify);
            sorcerer.AddPower(uFreeze);
            //-------------------------------------Epic-------------------------------------\\
            //Skeleton
            Fighter skeleton = new Fighter("Skeleton", rarities[4]);
            Power helpingHand = new Power("HelpingHand");
            Power regeneration = new Power("Regeneration");
            Power uArmLaunch = new Power("UArmLaunch");
            skeleton.AddPower(helpingHand);
            skeleton.AddPower(regeneration);
            skeleton.AddPower(uArmLaunch);
            //Guard
            Fighter guard = new Fighter("Guard", rarities[4]);
            Power target = new Power("Target");
            Power interception = new Power("Interception");
            Power uPoison = new Power("Upoison");
            guard.AddPower(target);
            guard.AddPower(interception);
            guard.AddPower(uPoison);
            //Arquebusier
            Fighter arquebusier = new Fighter("Arquebusier", rarities[4]);
            Power powerShoot = new Power("PowerShoot");
            Power speedShoot = new Power("SpeedShoot");
            Power uPoisonBullet = new Power("UPoisonBullet");
            arquebusier.AddPower(powerShoot);
            arquebusier.AddPower(speedShoot);
            arquebusier.AddPower(uPoisonBullet);
            //-------------------------------------Legendary-------------------------------------\\
            //Lancer
            Fighter lancer = new Fighter("Lancer", rarities[5]);
            Power javelinThrow = new Power("JavelinThrow");
            Power javelinHit = new Power("JavelinHit");
            Power uDeflect = new Power("UDeflect");
            lancer.AddPower(javelinThrow);
            lancer.AddPower(javelinHit);
            lancer.AddPower(uDeflect);
            //TriggerFish
            Fighter triggerfish = new Fighter("Triggerfish", rarities[5]);
            Power rockThrow = new Power("RockThrow");
            Power rocketLauncher = new Power("RocketLauncher");
            Power uBleedingDizziness = new Power("UBleedingDizziness");
            triggerfish.AddPower(rockThrow);
            triggerfish.AddPower(rocketLauncher);
            triggerfish.AddPower(uBleedingDizziness);
            //Halberdier
            Fighter halberdier = new Fighter("Halberdier", rarities[5]);
            Power axeBlow = new Power("AxeBlow");
            Power powerAxe = new Power("PowerAxe");
            Power uDebuff = new Power("UDebuff");
            halberdier.AddPower(axeBlow);
            halberdier.AddPower(powerAxe);
            halberdier.AddPower(uDebuff);
            //-------------------------------------Mythic-------------------------------------\\
            //Witch
            Fighter witch = new Fighter("Witch", rarities[6]);
            Power poisonCloud = new Power("PoisonCloud");
            Power infection = new Power("Infection");
            Power uSbireInvoke = new Power("USbireInvoke");
            witch.AddPower(poisonCloud);
            witch.AddPower(infection);
            witch.AddPower(uSbireInvoke);
            //Cannon
            Fighter cannon = new Fighter("Cannon", rarities[6]);
            Power cannonball = new Power("Cannonball");
            Power explosiveCannonBall = new Power("ExplosiveCannonBall");
            Power uDoubleShot = new Power("UDoubleShot");
            cannon.AddPower(cannonball);
            cannon.AddPower(explosiveCannonBall);
            cannon.AddPower(uDoubleShot);
            //Catapult
            Fighter catapult = new Fighter("Catapult", rarities[6]);
            Power bombThrow = new Power("BombThrow");
            Power fortification = new Power("Fortification");
            Power uDamageBoost = new Power("UDamageBoost");
            catapult.AddPower(bombThrow);
            catapult.AddPower(fortification);
            catapult.AddPower(uDamageBoost);
            //-------------------------------------Misterious-------------------------------------\\
            //Dragon
            Fighter dragon = new Fighter("Dragon", rarities[7]);
            Power fireSpit = new Power("FireSpit");
            Power grab = new Power("Grab");
            Power uEat = new Power("UEat");
            dragon.AddPower(fireSpit);
            dragon.AddPower(grab);
            dragon.AddPower(uEat);
            //Ultimate knight
            Fighter ultimateKnight = new Fighter("Ultimate knight", rarities[7]);
            Power ultimateSword = new Power("UltimateSword");
            Power lightningPower = new Power("LightningPower");
            Power uCombo = new Power("UCombo");
            ultimateKnight.AddPower(ultimateSword);
            ultimateKnight.AddPower(lightningPower);
            ultimateKnight.AddPower(uCombo);
            //Lord
            Fighter Lord = new Fighter("Lord", rarities[7]);
            Power superSwordHit = new Power("SuperSwordHit");
            Power SuperStrike = new Power("SuperStrike");
            Power UCastle = new Power("UCastle");
            Lord.AddPower(superSwordHit);
            Lord.AddPower(SuperStrike);
            Lord.AddPower(UCastle);

            // Add the fighter into the list
            _fighter.AddFighter(recruit);
            _fighter.AddFighter(infantryman);
            _fighter.AddFighter(trapInstaller);
            _fighter.AddFighter(archer);
            _fighter.AddFighter(knight);
            _fighter.AddFighter(shaman);
            _fighter.AddFighter(horseman);
            _fighter.AddFighter(ram);
            _fighter.AddFighter(bearTrainer);
            _fighter.AddFighter(sorcerer);
            _fighter.AddFighter(skeleton);
            _fighter.AddFighter(guard);
            _fighter.AddFighter(arquebusier);
            _fighter.AddFighter(lancer);
            _fighter.AddFighter(triggerfish);
            _fighter.AddFighter(halberdier);
            _fighter.AddFighter(witch);
            _fighter.AddFighter(cannon);
            _fighter.AddFighter(catapult);
            _fighter.AddFighter(dragon);
            _fighter.AddFighter(ultimateKnight);
            _fighter.AddFighter(Lord);
            #endregion
        }
    }
}
