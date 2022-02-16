namespace P_Demomot.Models.Characters.Specifications
{
    public class Rarity
    {
        /// <summary>
        /// INT
        /// </summary>
        private int _goldForLvlTwo;         //
        private int _goldFroLvlThree;       //
        private int _cardsForLvlTwo;        //
        private int _cardsForLvlThree;      //

        /// <summary>
        /// STRING
        /// </summary>
        private string _name;               //
        private string _description;        //
        private string _colorCode;          //

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
        public string Description
        {
            get { return _description; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int GoldForLvlTwo
        {
            get { return _goldForLvlTwo; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int GoldForLvlThree
        {
            get { return _goldFroLvlThree; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int CardsForLvlTwo
        {
            get { return _cardsForLvlTwo;}
        }

        /// <summary>
        /// 
        /// </summary>
        public int CardsForLvlThree
        {
            get { return _cardsForLvlThree;}
        }

        /// <summary>
        /// 
        /// </summary>
        public string ColorCode
        {
            get { return _colorCode; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="goldForLvlTwo"></param>
        /// <param name="goldFroLvlThree"></param>
        /// <param name="cardsForLvlTwo"></param>
        /// <param name="cardsForLvlThree"></param>
        /// <param name="colorCode"></param>
        public Rarity(string name, string description, int goldForLvlTwo, int goldFroLvlThree, int cardsForLvlTwo, int cardsForLvlThree, string colorCode)
        {
            _name = name;
            _description = description;
            _goldForLvlTwo = goldForLvlTwo;
            _cardsForLvlTwo = cardsForLvlTwo;
            _goldFroLvlThree = goldFroLvlThree;
            _cardsForLvlThree = cardsForLvlThree;
            _colorCode = colorCode;
        }
    }
}
