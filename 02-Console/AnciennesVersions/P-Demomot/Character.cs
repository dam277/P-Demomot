using P_Demomot.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot
{

    class Character
    {
        #region Properties
        //String
        private string _name;                                            //Name of the character
        private string _model;                                           //Model of the character
        //Int
        private int _level;                                              //Level of the character
        private int _life;                                               //Life of the character
        private int _damage;                                             //Damages of the character
        private int _id;                                                 //Damages of the character
        //Objects
        private Rarity _rarity;                                          //Rarity of the character
        private List<Character> _charactersList = new List<Character>(); //List of all the characters
        #endregion

        #region Getters Setters
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Rarity Rarity
        {
            get { return _rarity; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Character> CharactersList
        {
            get { return _charactersList; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default class constructor
        /// </summary>
        /// <param name="name"></param>
        public Character(string name)
        {

        }


        /// <summary>
        /// Character class constructor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="life"></param>
        /// <param name="damage"></param>
        /// <param name="rarity"></param>
        public Character(int id, string model, string name, int level, int life, int damage, Rarity rarity)
        {
            _model = model;
            _name = name;
            _level = level;
            _life = life;
            _damage = damage;
            _rarity = rarity;
        }

        
        #endregion

        #region Methods
        public void AddCharacter(Character character)
        {
            _charactersList.Add(character);
        }

        /// <summary>
        /// Display all the characters
        /// </summary>
        public void DisplayCharacters(User user)
        {
            Console.SetCursorPosition(0, 0);
            Console.SetWindowSize(200, 50);
            
            Console.Clear();
            int posX = 0;
            int posY = 0;
            int cardWidth = 25;
            int cardHeight = 15;

            Console.ResetColor();
            string title = "===| Inventaire |===*===| Pseudo : " + user.UserName + " |===*===| Argent : " + user.Money + " |===";
            Print.Line(title, Console.WindowWidth / 2 - title.Length / 2, 0);

            foreach (Character tempCharacter in user.CharactersList)
            {
                
                Console.ForegroundColor = tempCharacter.Rarity.CardColor;

                if (posX * cardWidth < 160)
                {
                }
                else
                {
                    posX = 0;
                    posY++;
                }

                
                //Display cards
                Print.OneLine("╔", posX * cardWidth + 1, posY * cardWidth + 1);
                Print.LoopText("═", cardWidth, false, false, posX * cardWidth + 2, posY * cardWidth + 1);
                Print.Line("╗", (posX + 1) * cardWidth, posY * cardWidth + 1);

                Print.LoopText("║", cardHeight, true, false, posX * cardWidth + 1, posY * cardWidth + 2);
                Print.LoopText("║", cardHeight, true, false, posX * cardWidth + cardWidth, posY * cardWidth + 2);

                Print.OneLine("╚", posX * cardWidth + 1, posY * cardWidth + cardHeight + 2);
                Print.LoopText("═", cardWidth, false, false, posX * cardWidth + 2, posY * cardWidth + cardHeight + 2);
                Print.OneLine("╝", posX * cardWidth + cardWidth, posY * cardWidth + cardHeight + 2);

                //Fill the cards
                Print.Line("Nom : " + tempCharacter.Name, posX * cardWidth + 2, posY * cardWidth + 2);
                Print.Line("Rareté : " + tempCharacter.Rarity.Name, posX * cardWidth + 2, posY * cardWidth + 3);
                Print.Line("Niveau : " + tempCharacter.Level.ToString(), posX * cardWidth + 2, posY * cardWidth + 4);
                Print.Line("Dégats : " + tempCharacter.Damage.ToString(), posX * cardWidth + 2, posY * cardWidth + 5);
                Print.Line("Vie : " + tempCharacter.Life.ToString(), posX * cardWidth + 2, posY * cardWidth + 6);
                    
                if(tempCharacter.Level == 1)
                {
                    Print.Line("Prix d'évolution : " + tempCharacter.Rarity.Lvl1UpgradePrice, posX * cardWidth + 2, posY * cardWidth + 6);
                    Print.Line("Cartes requises : " + tempCharacter.Rarity.Lvl2CardsToUpgrade, posX * cardWidth + 2, posY * cardWidth + 7);
                }
                else if (tempCharacter.Level == 2)
                {
                    Print.Line("Prix d'évolution : " + tempCharacter.Rarity.Lvl2UpgradePrice, posX * cardWidth + 2, posY * cardWidth + 6);
                    Print.Line("Cartes requises : " + tempCharacter.Rarity.Lvl2CardsToUpgrade, posX * cardWidth + 2, posY * cardWidth + 7);
                }
                else
                {
                    Print.Line("Prix d'évolution : ", posX * cardWidth + 2, posY * cardWidth + 6);
                    Print.Line("Cartes requises : ", posX * cardWidth + 2, posY * cardWidth + 7);
                }

                posX++;

                
            }
        }
        #endregion
    }
}
