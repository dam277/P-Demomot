/*******************
 * Nom : Loup
 * Prénom : Damien
 * -----
 * Etablissement : ETML
 * Ville : Lausanne
 * -----
 * Nom du projet : P-DEMOMOT
 * -----
 * Description : Ceci est le projet DEMOMOT, c'est un jeu en tour par tour en local, chaque personnages a ses propres caractèristiques. 
 * Nous pouvons jouer sur le même pc et choisir les cartes que l'on veut jouer selon si elles sont débloquées ou non
 *******************/


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace P_Demomot_Winforms_Damloup
{
    public partial class Form1 : Form
    {
        //variables

        //personnages communs ----------------------------|
        string common = "commun";
        const short MAXCARDCN1 = 100;
        const short MAXCARDCN2 = 250;
        const short PRICECN1 = 450;
        const short PRICECN2 = 950;
        //premier personnage commun ------------|
        string common1 = "()";
        string nameC1 = "fantassin";
        string statusC1 = "verrouillé";
        //puissance -------------------|
        short lifeC1 = 6;
        short damageC1 = 4;
        short levelC1 = 1;
        static short cardC1 = 1000;
        //deuxième personnage commun ------------|
        string common2 = "(o)";
        string nameC2 = "Poseur de piège";
        string statusC2 = "verrouillé";
        //puissance -------------------|
        short lifeC2 = 5;
        short damageC2 = 3;
        short levelC2 = 1;
        static short cardC2 = 0;
        //troisième personnage commun -----------|
        string common3 = "(O)";
        string nameC3 = "Archer";
        string statusC3 = "verrouillé";
        //puissance -------------------|
        short lifeC3 = 6;
        short damageC3 = 5;
        short levelC3 = 1;
        static short cardC3 = 0;
        //--------------------------------------------------|

        //personnages rares --------------------------------|
        string rare = "rare";
        const short MAXCARDRN1 = 80;
        const short MAXCARDRN2 = 220;
        const short PRICERN1 = 600;
        const short PRICERN2 = 1200;
        //premier personnage rare --------------|
        string rare1 = "{}";
        string nameR1 = "Chevalier";
        string statusR1 = "verrouillé";
        //puissance ----------------|
        short lifeR1 = 8;
        short damageR1 = 3;
        short levelR1 = 1;
        static short cardR1 = 0;
        //deuxième personnage rare -------------|
        string rare2 = "{o}";
        string nameR2 = "Chaman";
        string statusR2 = "verrouillé";
        //puissance ----------------|
        short lifeR2 = 5;
        short damageR2 = 3;
        short levelR2 = 1;
        static short cardR2 = 0;
        //troisième personnage rare ------------|
        string rare3 = "{O}";
        string nameR3 = "Cavalier";
        string statusR3 = "verrouillé";
        //puissance ----------------|
        short lifeR3 = 12;
        short damageR3 = 2;
        short levelR3 = 1;
        static short cardR3 = 0;
        //-------------------------------------------------|    

        //personnages super rares -------------------------|
        string superrare = "superrare";
        const short MAXCARDSRN1 = 70;
        const short MAXCARDSRN2 = 190;
        const short PRICESRN1 = 700;
        const short PRICESRN2 = 1500;
        //premier personnage super rare -----------|
        string superare1 = "[]";
        string nameSR1 = "Bélier";
        string statusSR1 = "verrouillé";
        //puissance ------------|
        short lifeSR1 = 14;
        short damageSR1 = 3;
        short levelSR1 = 1;
        static short cardSR1 = 0;
        //deuxième personnage super rare ----------|
        string superare2 = "[o]";
        string nameSR2 = "Dresseur d'ours";
        string statusSR2 = "verrouillé";
        //puisance -------------|
        short lifeSR2 = 12;
        short damageSR2 = 3;
        short levelSR2 = 1;
        static short cardSR2 = 0;
        //troisième personnage super rare ---------|
        string superare3 = "[O]";
        string nameSR3 = "Mage";
        string statusSR3 = "verrouillé";
        //puissance -------------|
        short lifeSR3 = 6;
        short damageSR3 = 3;
        short levelSR3 = 1;
        static short cardSR3 = 0;
        //--------------------------------------------------|

        //personnages épiques ------------------------------|
        string epic = "épique";
        const short MAXCARDEN1 = 40;
        const short MAXCARDEN2 = 140;
        const short PRICEEN1 = 800;
        const short PRICEEN2 = 1800;
        //premier personnage épique ------------|
        string epic1 = "//";
        string nameE1 = "Squelette";
        string statusE1 = "verrouillé";
        //puissance ------------|
        short lifeE1 = 9;
        short damageE1 = 4;
        short levelE1 = 1;
        static short cardE1 = 0;
        //deuxième personnage épique -----------|
        string epic2 = "/o/";
        string nameE2 = "Garde";
        string statusE2 = "verrouillé";
        //puissance ------------|
        short lifeE2 = 17;
        short damageE2 = 1;
        short levelE2 = 1;
        static short cardE2 = 0;
        //troisième personnage épique ----------|
        string epic3 = "/O/";
        string nameE3 = "Arquebusier";
        string statusE3 = "verrouillé";
        //puissance ------------|
        short lifeE3 = 5;
        short damageE3 = 6;
        short levelE3 = 1;
        static short cardE3 = 0;
        //--------------------------------------------------|

        //personnages légendaires --------------------------|
        string legendary = "Légendaire";
        const short MAXCARDLN1 = 30;
        const short MAXCARDLN2 = 85;
        const short PRICELN1 = 1050;
        const short PRICELN2 = 2000;
        //premier personnage légendaire ----------------|
        string legendary1 = "==";
        string nameL1 = "Lancier";
        string statusL1 = "verrouillé";
        //puissance --------------------|
        short lifeL1 = 5;
        short damageL1 = 5;
        short levelL1 = 1;
        static short cardL1 = 0;
        //deuxième personnage légendaire ---------------|
        string legendary2 = "=o=";
        string nameL2 = "baliste";
        string statusL2 = "verrouillé";
        //puissance -------------------|
        short lifeL2 = 5;
        short damageL2 = 6;
        short levelL2 = 1;
        static short cardL2 = 0;
        //troisième personnage légendaire --------------|
        string legendary3 = "=O=";
        string nameL3 = "Hallebardier";
        string statusL3 = "verrouillé";
        //puissance -------------------|
        short lifeL3 = 10;
        short damageL3 = 4;
        short levelL3 = 1;
        static short cardL3 = 0;
        //---------------------------------------------------|


        //personnages mytiques-------------------------------|
        string mythical = "mythique";
        const short MAXCARDMN1 = 10;
        const short MAXCARDMN2 = 40;
        const short PRICEMN1 = 1300;
        const short PRICEMN2 = 2250;
        //premier personnage mytique --------|
        string mythical1 = "||";
        string nameM1 = "Sorcière";
        string statusM1 = "verrouillé";
        //puisssance -------------------|
        short lifeM1 = 5;
        short damageM1 = 3;
        short levelM1 = 1;
        static short cardM1 = 0;
        //deuxième personnage mytique --------|
        string mythical2 = "|o|";
        string nameM2 = "canon";
        string statusM2 = "verrouillé";
        //puissance -------------------|
        short lifeM2 = 4;
        short damageM2 = 6;
        short levelM2 = 1;
        static short cardM2 = 0;
        //troisième personnage mytique --------|
        string mythical3 = "|O|";
        string nameM3 = "Catapulte";
        string statusM3 = "verrouillé";
        //puissance -------------------|
        short lifeM3 = 3;
        short damageM3 = 7;
        short levelM3 = 1;
        static short cardM3 = 0;
        //---------------------------------------------------|

        //personnages mistérieux-----------------------------|
        string mysterious = "mistèrieuse";
        const short MAXCARDMSN1 = 5;
        const short MAXCARDMSN2 = 25;
        const short PRICEMSN1 = 1550;
        const short PRICEMSN2 = 2550;
        //premier personnage misterieux --------|
        string mysterious1 = "<>";
        string nameMS1 = "Dragon";
        string statusMS1 = "verrouillé";
        //puissance -------------------|
        short lifeMS1 = 15;
        short damageMS1 = 5;
        short levelMS1 = 1;
        static short cardMS1 = 0;
        //deuxième personnage misterieux --------|
        string mysterious2 = "<o>";
        string nameMS2 = "Chevalier ultime";
        string statusMS2 = "verrouillé";
        //puissance -------------------| 
        short lifeMS2 = 20;
        short damageMS2 = 4;
        short levelMS2 = 1;
        static short cardMS2 = 0;
        //troisième personnage misterieux --------|
        string mysterious3 = "<O>";
        string nameMS3 = "Seigneur";
        string statusMS3 = "verrouillé";
        //puissance -------------------|
        short lifeMS3 = 13;
        short damageMS3 = 7;
        short levelMS3 = 1;
        static short cardMS3 = 0;
        //---------------------------------------------------|
        //long
        private long totalGold;

        //int
        private int pnlchestHeight;
        private int pnlchestWidth;

        //short
        private short count = 0;
        private ushort page = 1;

        //byte
        private byte count2 = 0;
        private byte count3 = 0;
        private byte nbrOut;
        private byte round = 0;
        private byte blueAddCount = 0;
        private byte blueDelCount = 0;
        private byte redAddCount = 0;
        private byte redDelCount = 0;
        private byte readyCounter = 0;

        private short lifeBlueOne = 0;
        private short lifeBlueTwo = 0;
        private short lifeBlueThree = 0;
        private short lifeRedOne = 0;
        private short lifeRedTwo = 0;
        private short lifeRedThree = 0;

        private short damageBlueOne = 0;
        private short damageBlueTwo = 0;
        private short damageBlueThree = 0;
        private short damageRedOne = 0;
        private short damageRedTwo = 0;
        private short damageRedThree = 0;

        //bool
        private bool GeneratedPage = true;
        private bool freeRotationTab = true;
        private bool buttonCardName = true;
        private bool reload;
        private bool nicknameDisplay = false;

        //string
        private string chestNbr;
        private string nickname = "joueur ";
        private string nicknamePlayerOne;
        private string nicknamePlayerTwo;

        //const
        const byte MAXPROPERTIES = 8;
        const byte MAXCHARACTERS = 21;
        const byte MAXLOOTPROPERTIES = 5;
        

        Label lblNbrChest;

        //images
        Image nextChestimg = Image.FromFile("../../inCodeImages/nextChest.jpg");
        Image backChestimg = Image.FromFile("../../inCodeImages/backChest.jpg");

        Image oldChest = Image.FromFile("../../inCodeImages/oldChest.png");
        Image reinforcedChest = Image.FromFile("../../inCodeImages/reinforcedChest.png");
        Image brightChest = Image.FromFile("../../inCodeImages/brightChest.png");
        Image royalChest = Image.FromFile("../../inCodeImages/royalChest.png");
        Image diamondChest = Image.FromFile("../../inCodeImages/diamondChest.png");
        Image magicalChest = Image.FromFile("../../inCodeImages/magicChest.png");

        //button
        Button btnUpgrade;

        //textbox
        

        //tableaux
        //string

        string[,] charactersPropertiesLevelOne;

        string[,] charactersPropertiesLevelTwo;

        string[,] charactersPropertiesLevelThree;

        string[,] charactersProperties;

        string[] charactersPropertiesName = new string[MAXPROPERTIES]
        {
             "Nom : ", "Modèle : ", "Rareté : ", "Statut : ", "Vie : ", "Dégats : ", "Niveau : ", "Cartes : "
        };

        string[] chestLootsName = new string[MAXLOOTPROPERTIES]
        {
            "Nom : ", "Modèle :", "Rareté : ", "Cartes reçues : ", "Or reçu : "
        };

        string[] chestLoots = new string[MAXLOOTPROPERTIES];

        string[,] ChestNames = new string[2, 6]
        {
            {"1","2","3","4","5","6" },
            { "Vieux coffret", "Coffre renforcé", "Coffre lumineux", "Coffre royal", "Coffre en diamant", "Coffre magique" }
        };


        string[] choosedCharacterBlue = new string[3];

        string[] choosedCharacterRed = new string[3];


        //short
        short[,] ChestNumbers = new short[2, 6]
        {
            { 1 ,2 ,3 ,4 ,5 ,6 },
            { 1 ,0 ,0 ,0 ,0 ,0 }
        };

        short[] blueLifes;
        short[] blueDamages;
        short[] redLifes;
        short[] redDamages;

        short[,] charactersUpgrades;

        short[,] nbrCardsUpgrades;

        //byte
        byte[] rotationValues = new byte[6]
        {
            6, 1, 2, 3, 4, 5
        };


        //Initialisation ----------------------
        public Form1()
        {
            InitializeComponent();


            charactersProperties = new string[MAXCHARACTERS, MAXPROPERTIES];

            blueLifes = new short[3]
            {
                lifeBlueOne, lifeBlueTwo, lifeBlueThree
            };
            blueDamages = new short[3]
            {
                damageBlueOne, damageBlueTwo, damageBlueThree
            };

            redLifes = new short[3]
            {
                lifeRedOne, lifeRedTwo, lifeRedThree
            };
            redDamages = new short[3]
            {
                damageRedOne, damageRedTwo, damageRedThree
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialisation des tableaux
            //+
            //actualisation des valeur des tableaux

            charactersPropertiesLevelOne = new string[MAXCHARACTERS, MAXPROPERTIES]
            {               
                //propriétés de chaque personnage du jeu
                {nameC1, common1, common.ToString(), statusC1, lifeC1.ToString(), damageC1.ToString(), levelC1.ToString(), cardC1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC2, common2, common.ToString(), statusC2, lifeC2.ToString(), damageC2.ToString(), levelC2.ToString(), cardC2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC3, common3, common.ToString(), statusC3, lifeC3.ToString(), damageC3.ToString(), levelC3.ToString(), cardC3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameR1, rare1, rare.ToString(), statusR1, lifeR1.ToString(), damageR1.ToString(), levelR1.ToString(), cardR1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR2, rare2, rare.ToString(), statusR2, lifeR2.ToString(), damageR2.ToString(), levelR2.ToString(), cardR2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR3, rare3, rare.ToString(), statusR3, lifeR3.ToString(), damageR3.ToString(), levelR3.ToString(), cardR3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameSR1, superare1, superrare.ToString(), statusSR1, lifeSR1.ToString(), damageSR1.ToString(), levelSR1.ToString(), cardSR1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR2, superare2, superrare.ToString(), statusSR2, lifeSR2.ToString(), damageSR2.ToString(), levelSR2.ToString(), cardSR2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR3, superare3, superrare.ToString(), statusSR3, lifeSR3.ToString(), damageSR3.ToString(), levelSR3.ToString(), cardSR3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameE1, epic1, epic.ToString(), statusE1, lifeE1.ToString(), damageE1.ToString(), levelE1.ToString(), cardE1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE2, epic2, epic.ToString(), statusE2, lifeE2.ToString(), damageE2.ToString(), levelE2.ToString(), cardE2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE3, epic3, epic.ToString(), statusE3, lifeE3.ToString(), damageE3.ToString(), levelE3.ToString(), cardE3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameL1, legendary1, legendary.ToString(), statusL1, lifeL1.ToString(), damageL1.ToString(), levelL1.ToString(), cardL1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL2, legendary2, legendary.ToString(), statusL2, lifeL2.ToString(), damageL2.ToString(), levelL2.ToString(), cardL2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL3, legendary3, legendary.ToString(), statusL3, lifeL3.ToString(), damageL3.ToString(), levelL3.ToString(), cardL3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameM1, mythical1, mythical.ToString(), statusM1, lifeM1.ToString(), damageM1.ToString(), levelM1.ToString(), cardM1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM2, mythical2, mythical.ToString(), statusM2, lifeM2.ToString(), damageM2.ToString(), levelM2.ToString(), cardM2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM3, mythical3, mythical.ToString(), statusM3, lifeM3.ToString(), damageM3.ToString(), levelM3.ToString(), cardM3.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameMS1, mysterious1, mysterious.ToString(), statusMS1, lifeMS1.ToString(), damageMS1.ToString(), levelMS1.ToString(), cardMS1.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS2, mysterious2, mysterious.ToString(), statusMS2, lifeMS2.ToString(), damageMS2.ToString(), levelMS2.ToString(), cardMS2.ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS3, mysterious3, mysterious.ToString(), statusMS3, lifeMS3.ToString(), damageMS3.ToString(), levelMS3.ToString(), cardMS3.ToString() } // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
            };

            charactersPropertiesLevelTwo = new string[MAXCHARACTERS, MAXPROPERTIES]
            {
                //propriétés de chaque personnage du jeu                        //                         //                        //                                //                     //  ''   ...     ''      ''    ...   ...     ...       ...
                {nameC1, "(" + common1 + ")", common.ToString(), statusC1,(lifeC1 + 5).ToString(), (damageC1 + 4).ToString() , (levelC1 + 1).ToString() , (cardC1 - MAXCARDCN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC2, "(" + common2 + ")", common.ToString(), statusC2, (lifeC2 + 3).ToString() , (damageC2 + 6).ToString() , (levelC2 + 1).ToString(), (cardC2 - MAXCARDCN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC3, "(" + common3 + ")", common.ToString(), statusC3, (lifeC3 + 7).ToString() , (damageC3 + 2).ToString() , (levelC3 + 1).ToString(), (cardC3 - MAXCARDCN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameR1, "{" + rare1 + "}", rare.ToString(), statusR1, (lifeR1 + 3).ToString(), (damageR1 + 5).ToString(), (levelR1 + 1).ToString(), (cardR1 - MAXCARDRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR2, "{" + rare2 + "}", rare.ToString(), statusR2, (lifeR2 + 6).ToString(), (damageR2 + 3).ToString(), (levelR2 + 1).ToString(), (cardR2 - MAXCARDRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR3, "{" + rare3 + "}", rare.ToString(), statusR3, (lifeR3 + 4).ToString(), (damageR3 + 4).ToString(), (levelR3 + 1).ToString(), (cardR3 - MAXCARDRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameSR1, "[" + superare1 + "]", superrare.ToString(), statusSR1, (lifeSR1 + 4).ToString(), (damageSR1 + 3).ToString(), (levelSR1 + 1).ToString(), (cardSR1 - MAXCARDSRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR2, "[" + superare2 + "]", superrare.ToString(), statusSR2, (lifeSR2 + 3).ToString(), (damageSR2 + 4).ToString(), (levelSR2 + 1).ToString(), (cardSR2 - MAXCARDSRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR3, "[" + superare3 + "]", superrare.ToString(), statusSR3, (lifeSR3 + 1).ToString(), (damageSR3 + 2).ToString(), (levelSR3 + 1).ToString(), (cardSR3 - MAXCARDSRN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameE1, "/" + epic1 + "/", epic.ToString(), statusE1, (lifeE1 + 5).ToString(), (damageE1 + 3).ToString(), (levelE1 + 1).ToString(), (cardE1 - MAXCARDEN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE2, "/" + epic2 + "/", epic.ToString(), statusE2, (lifeE2 + 2).ToString(), (damageE2 + 1).ToString(), (levelE2 + 1).ToString(), (cardE2 - MAXCARDEN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE3, "/" + epic3 + "/", epic.ToString(), statusE3, (lifeE3 + 4).ToString(), (damageE3 + 5).ToString(), (levelE3 + 1).ToString(), (cardE3 - MAXCARDEN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameL1, "=" + legendary1 + "=", legendary.ToString(), statusL1, (lifeL1 + 3).ToString(), (damageL1 + 5).ToString(), (levelL1 + 1).ToString(), (cardL1 - MAXCARDLN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL2, "=" + legendary2 + "=", legendary.ToString(), statusL2, (lifeL2 + 3).ToString(), (damageL2 + 1).ToString(), (levelL2 + 1).ToString(), (cardL2 - MAXCARDLN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL3, "=" + legendary3 + "=", legendary.ToString(), statusL3, (lifeL3 + 2).ToString(), (damageL3 + 3).ToString(), (levelL3 + 1).ToString(), (cardL3 - MAXCARDLN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameM1, "|" + mythical1 + "|", mythical.ToString(), statusM1, (lifeM1 + 6).ToString(), (damageM1 + 3).ToString(), (levelM1 + 1).ToString(), (cardM1 - MAXCARDMN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM2, "|" + mythical2 + "|", mythical.ToString(), statusM2, (lifeM2 + 7).ToString(), (damageM2 + 5).ToString(), (levelM2 + 1).ToString(), (cardM2 - MAXCARDMN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM3, "|" + mythical3 + "|", mythical.ToString(), statusM3, (lifeM3 + 4).ToString(), (damageM3 + 2).ToString(), (levelM3 + 1).ToString(), (cardM3 - MAXCARDMN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameMS1, "<" + mysterious1 + ">", mysterious.ToString(), statusMS1, (lifeMS1 + 5).ToString(), (damageMS1 + 4).ToString(), (levelMS1 + 1).ToString(), (cardMS1 - MAXCARDMSN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS2, "<" + mysterious2 + ">", mysterious.ToString(), statusMS2, (lifeMS2 + 3).ToString(), (damageMS2 + 3).ToString(), (levelMS2 + 1).ToString(), (cardMS2 - MAXCARDMSN1).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS3, "<" + mysterious3 + ">", mysterious.ToString(), statusMS3, (lifeMS3 + 4).ToString(), (damageMS3 + 2).ToString(), (levelMS3 + 1).ToString(), (cardMS3 - MAXCARDMSN1).ToString() } // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
            };

            charactersPropertiesLevelThree = new string[MAXCHARACTERS, MAXPROPERTIES]
            {
                //propriétés de chaque personnage du jeu                        //                         //                        //                                //                     //  ''   ...     ''      ''    ...   ...     ...       ...
                {nameC1, "(-" + common1 + "-)", common.ToString(), statusC1,(lifeC1 + 8).ToString(), (damageC1 + 7).ToString() , (levelC1 + 2).ToString() , (cardC1 - (MAXCARDCN1 + MAXCARDCN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC2, "(-" + common2 + "-)", common.ToString(), statusC2, (lifeC2 + 6).ToString() , (damageC2 + 7).ToString() , (levelC2 + 2).ToString(), (cardC2 - (MAXCARDCN1 + MAXCARDCN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameC3, "(-" + common3 + "-)", common.ToString(), statusC3, (lifeC3 + 9).ToString() , (damageC3 + 8).ToString() , (levelC3 + 2).ToString(), (cardC3 - (MAXCARDCN1 + MAXCARDCN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameR1, "{-" + rare1 + "-}", rare.ToString(), statusR1, (lifeR1 + 6).ToString(), (damageR1 + 9).ToString(), (levelR1 + 2).ToString(), (cardR1 - (MAXCARDRN1 + MAXCARDRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR2, "{-" + rare2 + "-}", rare.ToString(), statusR2, (lifeR2 + 7).ToString(), (damageR2 + 6).ToString(), (levelR2 + 2).ToString(), (cardR2 - (MAXCARDRN1 + MAXCARDRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameR3, "{-" + rare3 + "-}", rare.ToString(), statusR3, (lifeR3 + 8).ToString(), (damageR3 + 7).ToString(), (levelR3 + 2).ToString(), (cardR3 - (MAXCARDRN1 + MAXCARDRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameSR1, "[-" + superare1 + "-]", superrare.ToString(), statusSR1, (lifeSR1 + 9).ToString(), (damageSR1 + 6).ToString(), (levelSR1 + 2).ToString(), (cardSR1 - (MAXCARDSRN1 + MAXCARDSRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR2, "[-" + superare2 + "-]", superrare.ToString(), statusSR2, (lifeSR2 + 6).ToString(), (damageSR2 + 7).ToString(), (levelSR2 + 2).ToString(), (cardSR2 - (MAXCARDSRN1 + MAXCARDSRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameSR3, "[-" + superare3 + "-]", superrare.ToString(), statusSR3, (lifeSR3 + 3).ToString(), (damageSR3 + 4).ToString(), (levelSR3 + 2).ToString(), (cardSR3 - (MAXCARDSRN1 + MAXCARDSRN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameE1, "/-" + epic1 + "-/", epic.ToString(), statusE1, (lifeE1 + 6).ToString(), (damageE1 + 3).ToString(), (levelE1 + 2).ToString(), (cardE1 - (MAXCARDEN1 + MAXCARDEN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE2, "/-" + epic2 + "-/", epic.ToString(), statusE2, (lifeE2 + 3).ToString(), (damageE2 + 6).ToString(), (levelE2 + 2).ToString(), (cardE2 - (MAXCARDEN1 + MAXCARDEN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameE3, "/-" + epic3 + "-/", epic.ToString(), statusE3, (lifeE3 + 7).ToString(), (damageE3 + 5).ToString(), (levelE3 + 2).ToString(), (cardE3 - (MAXCARDEN1 + MAXCARDEN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameL1, "=-" + legendary1 + "-=", legendary.ToString(), statusL1, (lifeL1 + 8).ToString(), (damageL1 + 7).ToString(), (levelL1 + 2).ToString(), (cardL1 - (MAXCARDLN1 + MAXCARDLN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL2, "=-" + legendary2 + "-=", legendary.ToString(), statusL2, (lifeL2 + 8).ToString(), (damageL2 + 3).ToString(), (levelL2 + 2).ToString(), (cardL2 - (MAXCARDLN1 + MAXCARDLN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameL3, "=-" + legendary3 + "-=", legendary.ToString(), statusL3, (lifeL3 + 7).ToString(), (damageL3 + 5).ToString(), (levelL3 + 2).ToString(), (cardL3 - (MAXCARDLN1 + MAXCARDLN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameM1, "|-" + mythical1 + "-|", mythical.ToString(), statusM1, (lifeM1 + 9).ToString(), (damageM1 + 4).ToString(), (levelM1 + 2).ToString(), (cardM1 - (MAXCARDMN1 + MAXCARDMN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM2, "|-" + mythical2 + "-|", mythical.ToString(), statusM2, (lifeM2 + 11).ToString(), (damageM2 + 7).ToString(), (levelM2 + 2).ToString(), (cardM2 - (MAXCARDMN1 + MAXCARDMN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameM3, "|-" + mythical3 + "-|", mythical.ToString(), statusM3, (lifeM3 + 7).ToString(), (damageM3 + 3).ToString(), (levelM3 + 2).ToString(), (cardM3 - (MAXCARDMN1 + MAXCARDMN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 

                {nameMS1, "<-" + mysterious1 + "->", mysterious.ToString(), statusMS1, (lifeMS1 + 9).ToString(), (damageMS1 + 5).ToString(), (levelMS1 + 2).ToString(), (cardMS1 - (MAXCARDMSN1 + MAXCARDMSN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS2, "<-" + mysterious2 + "->", mysterious.ToString(), statusMS2, (lifeMS2 + 6).ToString(), (damageMS2 + 6).ToString(), (levelMS2 + 2).ToString(), (cardMS2 - (MAXCARDMSN1 + MAXCARDMSN2)).ToString() }, // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
                {nameMS3, "<-" + mysterious3 + "->", mysterious.ToString(), statusMS3, (lifeMS3 + 8).ToString(), (damageMS3 + 4).ToString(), (levelMS3 + 2).ToString(), (cardMS3 - (MAXCARDMSN1 + MAXCARDMSN2)).ToString() } // {NOM, FORME, RARETE, STATUT, VIE, DEGATS, NIVEAU, NBCARTES} 
            };


            lblGold.Text = totalGold.ToString();


            charactersUpgrades = new short[4, 7]
            {
            {MAXCARDCN1, MAXCARDRN1, MAXCARDSRN1, MAXCARDEN1, MAXCARDLN1, MAXCARDMN1, MAXCARDMSN1},
            {MAXCARDCN2, MAXCARDRN2, MAXCARDSRN2, MAXCARDEN2, MAXCARDLN2, MAXCARDMN2, MAXCARDMSN2},
            {PRICECN1, PRICERN1, PRICESRN1, PRICEEN1, PRICELN1, PRICEMN1, PRICEMSN1},
            {PRICECN2, PRICERN2, PRICESRN2, PRICEEN2, PRICELN2, PRICEMN2, PRICEMSN2},
            };

            nbrCardsUpgrades = new short[3, 7]
            {
            {cardC1, cardR1, cardSR1, cardE1, cardL1, cardM1, cardMS1},
            {cardC2, cardR2, cardSR2, cardE2, cardL2, cardM2, cardMS2},
            {cardC3, cardR3, cardSR3, cardE3, cardL3, cardM3, cardMS3},
            };



            if (round == 0)
            { 
                charactersProperties = charactersPropertiesLevelOne;
                round = 1;
            }
                
        }

        //-------------------------------------------------------------------------------------Jouer|
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            

            pnlBorder.Controls.Clear();
            lblPage.Visible = false;
            pnlBorderPage.Visible = false;
            pnlBorder.BackColor = Color.FromArgb(17, 67, 128);

            //bouton de commencement du jeu
            Button btnReadyToFight = new Button();
            btnReadyToFight.Text = "Commencer la bataille";
            btnReadyToFight.Width = pnlBorder.Width;
            btnReadyToFight.Height = pnlBorder.Height / 10;
            btnReadyToFight.Top = pnlBorder.Height - btnReadyToFight.Height;
            btnReadyToFight.Left = pnlBorder.Width / 2 - btnReadyToFight.Width / 2;
            btnReadyToFight.BackColor = Color.RoyalBlue;
            btnReadyToFight.Click += new System.EventHandler(this.btnReadyToFight_Click);

            if (readyCounter >= 0)
                pnlBorder.Controls.Add(btnReadyToFight);


            //affichage des 2 panels pour les "équipes" bleue et rouge
            for (int i = 1; i < 3; i++)
            {
                Panel pnlTeams = new Panel();
                pnlTeams.Width = pnlBorder.Width / 2 + pnlTeams.Width / 2;
                pnlTeams.Height = pnlBorder.Height / 5;
                pnlTeams.Left = pnlBorder.Width / 2 - pnlTeams.Width / 2;
                pnlTeams.Top = 45 * i * i * i - 50;
                pnlTeams.BorderStyle = BorderStyle.FixedSingle;

                //label définissant les pseudos des joueurs
                Label lblNickname = new Label();
                lblNickname.Width = pnlTeams.Width / 3;
                lblNickname.Height = pnlTeams.Height / 5;

                //bouton de confirmation du pseudo 
                Button btnNicknameConfirm = new Button();
                btnNicknameConfirm.Width = pnlTeams.Width / 3;
                btnNicknameConfirm.Height = pnlTeams.Height / 5;
                btnNicknameConfirm.Text = "Confirmer le pseudo";                
                btnNicknameConfirm.Name = i.ToString();

                //bouton de choix des personnages (ouvre un autre panel en dessous du premier)
                Button btnCharacterChoice = new Button();
                btnCharacterChoice.Width = pnlTeams.Width / 5;
                btnCharacterChoice.Height = pnlTeams.Height / 2;
                btnCharacterChoice.Left = pnlTeams.Width - btnCharacterChoice.Width;
                btnCharacterChoice.Text = "Ajouter des personnages";
                btnCharacterChoice.Name = i.ToString();


                //tests permettants de faire en sorte qu'il y ait toujours d'affiché un pseudo, quelquonque qu'il soit
                if (nicknameDisplay == true)
                {
                    if (i == 1)
                    {
                        lblNickname.Text = nicknamePlayerOne; //afficher le pseudo du 1er joueur

                        if (nicknamePlayerOne == null || nicknamePlayerOne == "") //afficher le pseudo de base si il n'y a rien d'écrit dans le textbox
                        {
                            lblNickname.Text = nickname + " " + i;
                        }
                    }
                    else
                    {
                        lblNickname.Text = nicknamePlayerTwo; //afficher le pseudo du 2ème joueur

                        if (nicknamePlayerTwo == null || nicknamePlayerTwo == "") //afficher le pseudo de base si il n'y a rien d'écrit dans le textbox
                        {
                            lblNickname.Text = nickname + " " + i;
                        }
                    }
                }
                else if (nicknameDisplay == false)//afficher : "joueur *i* "
                {
                    lblNickname.Text = nickname + " " + i;
                    if(i == 2)//si les 2 personnages ont obtenu le nom de base, reset de la variable
                        nicknameDisplay = true;
                }


                  
                //test pour savoir quel panel de quelle équipe afficher avec quels objets dedans
                if (i == 1)
                {
                    pnlTeams.BackColor = Color.SkyBlue;
                    btnNicknameConfirm.Top = 50 * i * i + lblNickname.Height;
                    btnNicknameConfirm.BackColor = Color.DodgerBlue;
                    btnCharacterChoice.BackColor = Color.DodgerBlue;
                    btnCharacterChoice.Top = 50 * i * i;
                    lblNickname.Top = 50 * i * i;
                }
                else if(i == 2)
                {
                    pnlTeams.BackColor = Color.DarkRed;
                    btnNicknameConfirm.Top = pnlTeams.Height / 3 + lblNickname.Height;
                    btnCharacterChoice.Top = pnlTeams.Height / 3;
                    btnNicknameConfirm.BackColor = Color.OrangeRed;
                    btnCharacterChoice.BackColor = Color.OrangeRed;
                    lblNickname.Top = pnlTeams.Height / 3;
                }

                //ajout d'événements et d'affichages
                btnNicknameConfirm.Click += new System.EventHandler(this.btnNicknameConfirm_Click);
                btnCharacterChoice.Click += new System.EventHandler(this.btnCharacterChoice_Click);

                pnlBorder.Controls.Add(pnlTeams);
                pnlTeams.Controls.Add(lblNickname);
                pnlTeams.Controls.Add(btnNicknameConfirm);
                pnlTeams.Controls.Add(btnCharacterChoice);
            }

            //nombre aléatoire générant un coffre aléatoire selon sa rareté
            Random randomChest = new Random();
            int coffre = randomChest.Next(1, 2001);

            if (coffre < 750)
            {
                ChestNumbers[1, 0]++;
            }
            else if (coffre < 1300)
            {
                ChestNumbers[1, 1]++;
            }
            else if (coffre < 1750)
            {
                ChestNumbers[1, 2]++;
            }
            else if (coffre < 1900)
            {
                ChestNumbers[1, 3]++;
            }
            else if (coffre < 1980)
            {
                ChestNumbers[1, 4]++;
            }
            else if (coffre < 2001)
            {
                ChestNumbers[1, 5]++;
            }
        }

        //bouton de confirmation pour le pseudo du joueur bleu
        private void btnNicknameConfirm_Click(object sender, EventArgs e)
        {
            //test qui permet de savoir sur quel bouton l'utilisateur à cliqué (savoir quelle équipe c'est)
            //et remplacer le nom par défaut du panel par le pseudo écrit dans le textbox correspondant
            if ((sender as Button).Name == "1")
            {
                nicknamePlayerOne = txbNicknameOne.Text;
            }
            else if ((sender as Button).Name == "2")
            {
                nicknamePlayerTwo = txbNicknameTwo.Text;
            }

            BtnPlay_Click(sender, e);//appel de la méthode jouer
        }

        //Bouton d'affichage du panel de choix des 3 personnages des joueurs
        private void btnCharacterChoice_Click(object sender, EventArgs e)
        {
            //boucle permettant de placer les 3 panels servants à contenir le personnage choisis dans chaqun des 2 panels d'équipes ainsi que les boutons et autres textes présents
            for (int i = 1; i < 3; i++)
            {
                Panel pnlAddCharacter = new Panel();
                pnlAddCharacter.Width = pnlBorder.Width / 2 + pnlAddCharacter.Width / 2;
                pnlAddCharacter.Height = pnlBorder.Height / 5;
                pnlAddCharacter.Left = pnlBorder.Width / 2 - pnlAddCharacter.Width / 2;
                pnlAddCharacter.BorderStyle = BorderStyle.FixedSingle;

                //test permettant de savoir sur quel bouton l'utilisateur à cliqué pour savoir quel panel d'ajout de personnages ouvrir
                if ((sender as Button).Name == "1" && i == 1)
                {
                    pnlAddCharacter.BackColor = Color.SkyBlue;
                    pnlAddCharacter.Top = 50 * i * i + pnlAddCharacter.Height / 2 + 20;

                    //for permettant de placer les 3 panels qui contiendront les personnages
                    for (int j = 0; j < 3; j++)
                    {
                        Panel pnlAddedCharacterBlue = new Panel();
                        pnlAddedCharacterBlue.Width = pnlAddCharacter.Width / 4;
                        pnlAddedCharacterBlue.Height = pnlAddCharacter.Height - 20;
                        pnlAddedCharacterBlue.Left = 150 * j + 12;
                        pnlAddedCharacterBlue.Top = 1;
                        pnlAddedCharacterBlue.Name = (j + 1).ToString();

                        //test qui permet de savoir quel panel va être affecté lors du choix du personnage
                        if ((blueAddCount + 1).ToString() == pnlAddedCharacterBlue.Name)
                        {
                            pnlAddedCharacterBlue.BackColor = Color.Blue;
                        }
                        else
                        {
                            pnlAddedCharacterBlue.BackColor = Color.DodgerBlue;
                        }

                        pnlAddedCharacterBlue.BorderStyle = BorderStyle.FixedSingle;                                              
                        pnlAddedCharacterBlue.Click += new System.EventHandler(this.pnlAddedCharacterBlue_Click);
                        pnlAddCharacter.Controls.Add(pnlAddedCharacterBlue);

                        //label affichant les cartes choisies dans les panels affectés
                        Label lblChoosedBlueCharacterShow = new Label();
                        lblChoosedBlueCharacterShow.Text = choosedCharacterBlue[j];
                        pnlAddedCharacterBlue.Controls.Add(lblChoosedBlueCharacterShow);

                        //test pour savoir si toutes les cases bleues ont été remplies
                        if (lblChoosedBlueCharacterShow.Text != "")
                        {
                            readyCounter++;
                        }
                        else if(readyCounter < 3)
                        {
                            readyCounter = 1;
                        }


                        //bouton d'annulation du choix (permet d'enlever les personnages choisis et de recommencer à choisir
                        Button btnBlueCancel = new Button();
                        btnBlueCancel.Text = "annuler";
                        btnBlueCancel.Width = pnlAddCharacter.Width;
                        btnBlueCancel.Height = 21;
                        btnBlueCancel.Top = pnlAddCharacter.Height - btnBlueCancel.Height;
                        btnBlueCancel.BackColor = Color.Blue;
                        btnBlueCancel.ForeColor = Color.White;
                        btnBlueCancel.Click += new System.EventHandler(this.btnBlueCancel_Click);
                        pnlAddCharacter.Controls.Add(btnBlueCancel);
                        
                    }
                }//test permettant de savoir sur quel bouton l'utilisateur à cliqué pour savoir quel panel d'ajout de personnages ouvrir
                else if ((sender as Button).Name == "2" && i == 2)
                {
                    //for permettant de placer les 3 panels qui contiendront les personnages
                    for (int j = 0; j < 3; j++)
                    {
                        Panel pnlAddedCharacterRed = new Panel();
                        pnlAddedCharacterRed.Width = pnlAddCharacter.Width / 4;
                        pnlAddedCharacterRed.Height = pnlAddCharacter.Height - 20;
                        pnlAddedCharacterRed.Left = 150 * j + 12;
                        pnlAddedCharacterRed.Top = 1;
                        pnlAddedCharacterRed.Name = (j + 1).ToString();

                        //test permettant de savoir sur quel bouton l'utilisateur à cliqué pour savoir quel panel d'ajout de personnages ouvrir
                        if ((redAddCount + 1).ToString() == pnlAddedCharacterRed.Name)
                        {
                            pnlAddedCharacterRed.BackColor = Color.IndianRed;
                        }
                        else
                        {
                            pnlAddedCharacterRed.BackColor = Color.OrangeRed;
                        }

                        pnlAddedCharacterRed.BorderStyle = BorderStyle.FixedSingle;

                        pnlAddedCharacterRed.Click += new System.EventHandler(this.pnlAddedCharacterRed_Click);
                        pnlAddCharacter.Controls.Add(pnlAddedCharacterRed);

                        //label affichant les cartes choisies dans les panels affectés
                        Label lblChoosedRedCharacterShow = new Label();
                        lblChoosedRedCharacterShow.Text = choosedCharacterRed[j];
                        pnlAddedCharacterRed.Controls.Add(lblChoosedRedCharacterShow);

                        //test pour savoir si toutes les cases rouges ont été remplies
                        if (lblChoosedRedCharacterShow.Text != "")
                        {
                            readyCounter++;
                        }
                        else if (readyCounter < 3)
                        {
                            readyCounter = 1;
                        }

                        //bouton d'annulation du choix (permet d'enlever les personnages choisis et de recommencer à choisir
                        Button btnRedCancel = new Button();
                        btnRedCancel.Text = "annuler";
                        btnRedCancel.Width = pnlAddCharacter.Width;
                        btnRedCancel.Height = 21;
                        btnRedCancel.Top = pnlAddCharacter.Height - btnRedCancel.Height;
                        btnRedCancel.BackColor = Color.Red;
                        btnRedCancel.ForeColor = Color.White;
                        btnRedCancel.Click += new System.EventHandler(this.btnRedCancel_Click);
                        pnlAddCharacter.Controls.Add(btnRedCancel);

                    }

                    pnlAddCharacter.BackColor = Color.DarkRed;
                    pnlAddCharacter.Top = 45 * i * i * i + pnlAddCharacter.Height / 2 + 20;
                }

                pnlBorder.Controls.Add(pnlAddCharacter);//ajout du panel ayant les personnages choisis
            }
        }

        //Bleu

        //panel d'ajout de cartes pour le joueur bleu 
        private void pnlAddedCharacterBlue_Click(object sender, EventArgs e)
        {
 

            byte blueCount = 0;

            pnlBorder.Controls.Clear();
            pnlBorder.BackColor = Color.SkyBlue;

            const byte MAXPOSITIONX = 5;
            const byte MAXPOSITIONY = 5;

            for (int y = 0; y < MAXPOSITIONY; y++)//boucles permettants d'afficher les cartes dans chaque page (5x5)
            {

                for (int x = 0; x < MAXPOSITIONX; x++)
                {
                    

                    //création des cartes
                    Panel pnlCardBlue = new Panel();
                    pnlCardBlue.Height = pnlBorder.Height /7;
                    pnlCardBlue.Width = pnlBorder.Width / 7;

                    pnlCardBlue.Top = pnlCardBlue.Height * y + 15 + (y * 40);
                    pnlCardBlue.Left = pnlCardBlue.Width * x + 15 + (x * 40);

                    pnlCardBlue.BackColor = Color.FromArgb(41, 118, 219);
                    pnlCardBlue.BorderStyle = BorderStyle.FixedSingle;


                    pnlBorder.Controls.Add(pnlCardBlue);//ajout des cartes au panel

                    //bouton qui permet de choisir la carte que l'on veut pour jouer
                    Button btnBlueCardChoosing = new Button();

                    btnBlueCardChoosing.Height = pnlCardBlue.Height / 3;
                    btnBlueCardChoosing.Width = pnlCardBlue.Width;
                    btnBlueCardChoosing.Top = pnlCardBlue.Height - btnBlueCardChoosing.Height;
                    btnBlueCardChoosing.Click += new System.EventHandler(this.btnBlueCardChoosing_Click);

                    //test qui permet de savoir de quelle rareté est chaque carte affichée pour leur donner à chaqune leur couleur de rareté
                    if (blueCount < 21)
                    {
                        btnBlueCardChoosing.Text = charactersPropertiesLevelOne[blueCount, 0];
                        if (charactersPropertiesLevelOne[blueCount, 2] == "commun")
                        {
                            pnlCardBlue.BackColor = Color.Gray;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "rare")
                        {
                            pnlCardBlue.BackColor = Color.DarkRed;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "superrare")
                        {
                            pnlCardBlue.BackColor = Color.Green;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "épique")
                        {
                            pnlCardBlue.BackColor = Color.Yellow;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "légendaire")
                        {
                            pnlCardBlue.BackColor = Color.Cyan;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "mythique")
                        {
                            pnlCardBlue.BackColor = Color.Purple;
                        }
                        else if (charactersPropertiesLevelOne[blueCount, 2] == "mistèrieuse")
                        {
                            pnlCardBlue.BackColor = Color.Red;

                        }
                    }
                    pnlCardBlue.Controls.Add(btnBlueCardChoosing); //ajout des boutons dans les cartes

                    //boucle permettant de trouver sur quel bouton (de choix du personnage) l'utilisateur à cliqué
                    for (int c = 0; c < MAXCHARACTERS; c++)
                    {
                        if (charactersProperties[c, 0] == btnBlueCardChoosing.Text)
                        {
                            //tests permettants de savoir le personnage est déjà débloqué ou non 
                            if (charactersPropertiesLevelOne[c, 3] == "verrouillé")//si non, on ne peut pas l'utiliser pour combattre
                            {
                                btnBlueCardChoosing.Enabled = false;
                                btnBlueCardChoosing.BackColor = Color.LightGray;
                                btnBlueCardChoosing.ForeColor = Color.Black;
                            }
                            else//si oui on peut l'utiliser
                            {
                                btnBlueCardChoosing.Enabled = true;
                                btnBlueCardChoosing.BackColor = Color.Black;
                                btnBlueCardChoosing.ForeColor = Color.White;
                            }
                        }
                    }

                    blueCount++;

                }
            }
            blueCount = 0;
        }

        //choix des cartes à prendre pour le joueur bleu
        private void btnBlueCardChoosing_Click(object sender, EventArgs e)
        {
            //test permettant de savoir si la variable à dépassé les limites du tableau permettant d'écrire le nom du personnage choisir dans un des 3 panel de l'équipe bleue
            if (blueAddCount == 3)
            {
                blueAddCount = 0;
            }


            if ((sender as Button).Text == "")//si le bouton n'a aucune valeur (les bouton à la toute fin de la page de choix)
            {
            }
            else//si il à une valeur texte, ajout dans le tableau de choix le personnage choisi
            {
                choosedCharacterBlue[blueAddCount] = (sender as Button).Text;
                blueAddCount++;
            }

            
            BtnPlay_Click(sender, e);
        }

        //annulation de prise des 3 cartes pour le joueur bleu
        private void btnBlueCancel_Click(object sender, EventArgs e)
        {
            //test permettant de savoir si la variable à dépassé les limites du tableau permettant de retirer les nom des personnages choisis dans les 3 panels de l'équipe bleue
            if (blueDelCount == 3)
            {
                blueDelCount = 0;
            }

            if ((sender as Button).Text == "")//si le bouton n'a aucune valeur
            {
            }
            else//si il à une valeur texte, retirer dans le tableau de choix les personnages choisis
            {
                for (int i = 0; i < 3; i++)
                {
                    choosedCharacterBlue[blueDelCount] = null;
                    blueDelCount++;
                    blueAddCount = 0;
                    readyCounter -= 3;
                }
            }


            BtnPlay_Click(sender, e);
        }

        //Rouge

        //panel d'ajout de cartes pour le joueur rouge ----
        private void pnlAddedCharacterRed_Click(object sender, EventArgs e)
        {
            byte redCount = 0;

            pnlBorder.Controls.Clear();
            pnlBorder.BackColor = Color.DarkRed;

            byte maxPositionX = 5;
            const byte MAXPOSITIONY = 5;

            for (int y = 0; y < MAXPOSITIONY; y++)//boucles permettants d'afficher les cartes dans chaque page (5x5)
            {

                for (int x = 0; x < maxPositionX; x++)
                {


                    //création des cartes
                    Panel pnlCardRed = new Panel();
                    pnlCardRed.Height = pnlBorder.Height / 7;
                    pnlCardRed.Width = pnlBorder.Width / 7;

                    pnlCardRed.Top = pnlCardRed.Height * y + 15 + (y * 40);
                    pnlCardRed.Left = pnlCardRed.Width * x + 15 + (x * 40);

                    pnlCardRed.BackColor = Color.FromArgb(41, 118, 219);
                    pnlCardRed.BorderStyle = BorderStyle.FixedSingle;


                    pnlBorder.Controls.Add(pnlCardRed);//ajout des cartes au panel

                    //bouton qui permet de choisir la carte que l'on veut pour jouer
                    Button btnRedCardChoosing = new Button();

                    btnRedCardChoosing.Height = pnlCardRed.Height / 3;
                    btnRedCardChoosing.Width = pnlCardRed.Width;
                    btnRedCardChoosing.Top = pnlCardRed.Height - btnRedCardChoosing.Height;
                    btnRedCardChoosing.Click += new System.EventHandler(this.btnRedCardChoosing_Click);

                    //test qui permet de savoir de quelle rareté est chaque carte affichée pour leur donner à chaqune leur couleur de rareté
                    if (redCount < 21)
                    {
                        btnRedCardChoosing.Text = charactersPropertiesLevelOne[redCount, 0];
                        if (charactersPropertiesLevelOne[redCount, 2] == "commun")
                        {
                            pnlCardRed.BackColor = Color.Gray;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "rare")
                        {
                            pnlCardRed.BackColor = Color.DarkRed;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "superrare")
                        {
                            pnlCardRed.BackColor = Color.Green;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "épique")
                        {
                            pnlCardRed.BackColor = Color.Yellow;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "légendaire")
                        {
                            pnlCardRed.BackColor = Color.Cyan;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "mythique")
                        {
                            pnlCardRed.BackColor = Color.Purple;
                        }
                        else if (charactersPropertiesLevelOne[redCount, 2] == "mistèrieuse")
                        {
                            pnlCardRed.BackColor = Color.Red;

                        }
                    }
                    pnlCardRed.Controls.Add(btnRedCardChoosing); //ajout des boutons dans les cartes

                    //boucle permettant de trouver sur quel bouton (de choix du personnage) l'utilisateur à cliqué

                    for (int c = 0; c < MAXCHARACTERS; c++)
                    {
                        
                        if (charactersProperties[c, 0] == btnRedCardChoosing.Text)
                        {
                            //tests permettants de savoir le personnage est déjà débloqué ou non 
                            if (charactersPropertiesLevelOne[c, 3] == "verrouillé")//si non, on ne peut pas l'utiliser pour combattre
                            {
                                btnRedCardChoosing.Enabled = false;
                                btnRedCardChoosing.BackColor = Color.LightGray;
                                btnRedCardChoosing.ForeColor = Color.Black;
                            }
                            else//si oui on peut l'utiliser
                            {
                                btnRedCardChoosing.Enabled = true;
                                btnRedCardChoosing.BackColor = Color.Black;
                                btnRedCardChoosing.ForeColor = Color.White;
                            }
                        }
                    }

                    redCount++;

                }
            }
            redCount = 0;
        }

        //choix des cartes à prendre pour le joueur rouge
        private void btnRedCardChoosing_Click(object sender, EventArgs e)
        {
            //test permettant de savoir si la variable à dépassé les limites du tableau permettant d'écrire le nom du personnage choisir dans un des 3 panel de l'équipe rouge

            if (redAddCount == 3)
            {
                redAddCount = 0;
            }


            if ((sender as Button).Text == "")//si le bouton n'a aucune valeur (les bouton à la toute fin de la page de choix)
            {
            }
            else//si il à une valeur texte, ajout dans le tableau de choix le personnage choisi
            {
                choosedCharacterRed[redAddCount] = (sender as Button).Text;
                redAddCount++;
            }


            BtnPlay_Click(sender, e);
        }

        //annulation de prise des 3 cartes pour le joueur bleu
        private void btnRedCancel_Click(object sender, EventArgs e)
        {
            //test permettant de savoir si la variable à dépassé les limites du tableau permettant de retirer les nom des personnages choisis dans les 3 panels de l'équipe bleue
            if (redDelCount == 3)
            {
                redDelCount = 0;
            }

            if ((sender as Button).Text == "")//si le bouton n'a aucune valeur
            {
            }
            else//si il à une valeur texte, retirer dans le tableau de choix les personnages choisis
            {
                for (int i = 0; i < 3; i++)
                {
                    choosedCharacterRed[redDelCount] = null;
                    redDelCount++;
                    redAddCount = 0;
                    readyCounter -= 3;
                }
            }


            BtnPlay_Click(sender, e);
        }

        //Combats
        private void btnReadyToFight_Click(object sender, EventArgs e)
        {
            pnlBorder.Controls.Clear();
            count2 = 0;
            count3 = 0;
            for (int i = 0; i < 3; i++)
            {
                Panel pnlBlueFightingCharacters = new Panel();
                pnlBlueFightingCharacters.Height = pnlBorder.Height / 3 ;
                pnlBlueFightingCharacters.Width = pnlBorder.Width / 3;
                pnlBlueFightingCharacters.Top = 220 * i;
                pnlBlueFightingCharacters.Left = 10;
                pnlBlueFightingCharacters.BorderStyle = BorderStyle.FixedSingle;
                pnlBlueFightingCharacters.BackColor = Color.SkyBlue;
                pnlBorder.Controls.Add(pnlBlueFightingCharacters);

                for(int c = 0; c < MAXCHARACTERS; c++)
                {
                    if(choosedCharacterBlue[i] == charactersProperties[c, 0])
                    {
                        blueLifes[count2] = Convert.ToInt16(charactersProperties[c, 4]);
                        blueDamages[count2] = Convert.ToInt16(charactersProperties[c, 5]);

                        count2++;

                        for (int y = 0; y < MAXPROPERTIES; y++)
                        {
                            Label lblBlueFightingPropertiesShow = new Label();
                            if (charactersProperties[c, y] == "verrouillé" || y == 7)
                            {

                            }
                            else
                            {
                                lblBlueFightingPropertiesShow.Text = charactersProperties[c, y];
                                if (y < 3)
                                {
                                    lblBlueFightingPropertiesShow.Top = 25 * y;
                                }
                                else
                                {
                                    lblBlueFightingPropertiesShow.Top = 25 * (y - 1);
                                }

                                lblBlueFightingPropertiesShow.Width = pnlBlueFightingCharacters.Width;
                                lblBlueFightingPropertiesShow.Height = pnlBlueFightingCharacters.Height / 8;
                                lblBlueFightingPropertiesShow.Font = new Font("none", 15);
                                lblBlueFightingPropertiesShow.Left = 10;
                                pnlBlueFightingCharacters.Controls.Add(lblBlueFightingPropertiesShow);


                                   
                                }
                        }
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Panel pnlRedFightingCharacters = new Panel();
                pnlRedFightingCharacters.Height = pnlBorder.Height / 3;
                pnlRedFightingCharacters.Width = pnlBorder.Width / 3;
                pnlRedFightingCharacters.Top = 220 * i;
                pnlRedFightingCharacters.Left = pnlBorder.Width - pnlRedFightingCharacters.Width; 
                pnlRedFightingCharacters.BorderStyle = BorderStyle.FixedSingle;
                pnlRedFightingCharacters.BackColor = Color.DarkRed;
                pnlBorder.Controls.Add(pnlRedFightingCharacters);

                for (int c = 0; c < MAXCHARACTERS; c++)
                {
                    if (choosedCharacterRed[i] == charactersProperties[c, 0])
                    {
                        redLifes[count2] = Convert.ToInt16(charactersProperties[c, 4]);
                        redDamages[count2] = Convert.ToInt16(charactersProperties[c, 5]);

                        count3++;
                        for (int y = 0; y < MAXPROPERTIES; y++)
                        {
                            Label lblRedFightingPropertiesShow = new Label();
                            if (charactersProperties[c, y] == "verrouillé" || y == 7)
                            {

                            }
                            else
                            {
                                lblRedFightingPropertiesShow.Text = charactersProperties[c, y];
                                if (y < 3)
                                {
                                    lblRedFightingPropertiesShow.Top = 25 * y;
                                }
                                else
                                {
                                    lblRedFightingPropertiesShow.Top = 25 * (y - 1);
                                }

                                lblRedFightingPropertiesShow.Width = pnlRedFightingCharacters.Width;
                                lblRedFightingPropertiesShow.Height = pnlRedFightingCharacters.Height / 8;
                                lblRedFightingPropertiesShow.Font = new Font("none", 15);
                                lblRedFightingPropertiesShow.Left = 10;
                                pnlRedFightingCharacters.Controls.Add(lblRedFightingPropertiesShow);


                            }
                        }
                    }
                }
            }






        }

        //---------------------------------------------------------------------------------Fin Jouer|

        //--------------------------------------------------------------------------------Inventaire|
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            //clear du panel et affichage des boutons pour changer de page
            pnlBorder.Controls.Clear();
            lblPage.Visible = true;
            btnBackPage.Name = "inventoryBack";
            btnNextPage.Name = "inventoryNext";
            pnlBorder.BackColor = Color.FromArgb(17, 67, 128);

            pnlBorderPage.Visible = true;

            for (int y = 0; y < 3; y++)//boucles permettants d'afficher les cartes dans chaque page (3x3)
            {

                for (int x = 0; x < 3; x++)
                {
                    //création des cartes
                    Panel pnlCards = new Panel();
                    pnlCards.Height = pnlBorder.Height / 4;
                    pnlCards.Width = pnlBorder.Width / 4;

                    pnlCards.Top = pnlCards.Height * y + 15 + (y * 60);
                    pnlCards.Left = pnlCards.Width * x + 15 + (x * 60);

                    pnlCards.BackColor = Color.FromArgb(41, 118, 219);
                    pnlCards.BorderStyle = BorderStyle.FixedSingle;


                    pnlBorder.Controls.Add(pnlCards);//ajout des cartes au panel

                    //création des boutons pour acceder aux caractèristiques des personnages
                    Button btnCardProperty = new Button();

                    btnCardProperty.Height = pnlCards.Height / 3;
                    btnCardProperty.Width = pnlCards.Width;
                    btnCardProperty.Top = pnlCards.Height - btnCardProperty.Height;
                    btnCardProperty.Click += new System.EventHandler(this.btnCardProperty_Click); //ajout d'un evenement de click sur ces boutons

                    if (page == 1) //test pour savoir sur quelle page on se trouve / page 1
                    {
                        btnCardProperty.Text = charactersPropertiesLevelOne[count, 0]; //nom du bouton selon la position du tableau
                        lblPage.Text = "Page : " + page.ToString(); //affichage du numéro de page acutelle sur l'écran

                        //test pour savoir de quelle rareté est la carte 
                        //si une condition est vraie, on change la couleur de fond de la carte
                        if (charactersPropertiesLevelOne[count, 2] == "commun")
                        {
                            pnlCards.BackColor = Color.Gray;
                        }
                        else if (charactersPropertiesLevelOne[count, 2] == "rare")
                        {
                            pnlCards.BackColor = Color.DarkRed;
                        }
                        else if (charactersPropertiesLevelOne[count, 2] == "superrare")
                        {
                            pnlCards.BackColor = Color.Green;
                        }

                        if (count < 9) //du moment que nous somme en dessous de la limite de carte d'une page, on incrémente le compteur
                        {
                            count++;
                            pnlCards.Controls.Add(btnCardProperty); //ajout des boutons dans les cartes
                        }


                    }
                    else if (page == 2) //page 2
                    {
                        //test qui permet au premier passage de remmettre le compteur à la position de la page suivante (ici : 2)
                        //Cela permet de ne pas remettre 9 à chaque passage et afficher la même carte sur toute la page
                        if (GeneratedPage == true)
                        {
                            count = 9;
                            GeneratedPage = false;
                        }

                        btnCardProperty.Text = charactersPropertiesLevelOne[count, 0]; //nom du bouton selon la position du tableau
                        lblPage.Text = "Page : " + page.ToString(); //affichage du numéro de page acutelle sur l'écran

                        //test pour savoir de quelle rareté est la carte  
                        //si une condition est vraie, on change la couleur de fond de la carte
                        if (charactersPropertiesLevelOne[count, 2] == "épique")
                        {
                            pnlCards.BackColor = Color.Yellow;
                        }
                        else if (charactersPropertiesLevelOne[count, 2] == "légendaire")
                        {
                            pnlCards.BackColor = Color.Cyan;
                        }
                        else if (charactersPropertiesLevelOne[count, 2] == "mythique")
                        {
                            pnlCards.BackColor = Color.Purple;
                        }

                        if (count > 8 && count < 18) //tant que le compteur est entre les nombres qui permettent de générer la 2ème page, on l'incrémente
                        {
                            count++;
                            pnlCards.Controls.Add(btnCardProperty); //ajout des boutons dans les cartes
                        }
                    }
                    else if (page == 3) //page 3
                    {
                        //test qui permet au premier passage de remmettre le compteur à la position de la page suivante (ici : 3)
                        if (GeneratedPage == true)
                        {
                            count = 18;
                            GeneratedPage = false;
                        }
                        //test pour savoir si le compteur est allé aux limites du nombre de cartes
                        //en l'ccurence, le tableau au nombres de cartes différentes
                        if (count == 21)
                        {
                            //remise à 0 du compteur
                            count = 0;

                            //variable permettant de faire en sorte que lorsqu'on dépasse la 
                            //limite du nombre de personnage en tout, que les cartes n'aies plus de noms attribués
                            buttonCardName = false;
                        }

                        //test pour savoir de quelle rareté est la carte  
                        //si une condition est vraie, on change la couleur de fond de la carte
                        if (charactersPropertiesLevelOne[count, 2] == "mistèrieuse")
                        {
                            pnlCards.BackColor = Color.Red;

                        }

                        //test qui sert à définir les derniers noms des boutons
                        if (buttonCardName == true)//si on n'a pas dépassé la limite de personnages
                        {
                            btnCardProperty.Text = charactersPropertiesLevelOne[count, 0];
                        }
                        else
                            btnCardProperty.Text = "---";

                        lblPage.Text = "Page : " + page.ToString();




                        if (count > 17 && count < 21) //tant que le compteur est entre les nombres qui permettent de générer la 3ème page, on l'incrémente
                        {
                            count++;
                            pnlCards.Controls.Add(btnCardProperty); //ajout des boutons dans les cartes
                        }

                    }


                    

                }
            }
            //remise à 0 des variables
            buttonCardName = true;
            GeneratedPage = true;
            count = 0;
        }

        //page suivante
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            
            if((sender as Button).Name == "inventoryNext")
            {
                //test qui permet de faire en sorte qu'on ne puisse pas aller plus loin que la dernière page
                if (page == 3)
                {

                }
                else
                {
                    page++;
                }
                BtnInventory_Click(sender, e);
            }  
        }

        //page antérieure
        private void BtnBackPage_Click(object sender, EventArgs e)
        {

            if ((sender as Button).Name == "inventoryBack")
            {
                //test qui permet de faire en sorte qu'on ne puisse pas aller plus loin que la dernière page
                if (page == 1)
                {

                }
                else
                {
                    page--;
                }
                BtnInventory_Click(sender, e);
            }
        }

        //propriétés des personnages
        private void btnCardProperty_Click(object sender, EventArgs e)
        {
            pnlBorder.Controls.Clear();//clear du panel

            btnUpgrade = new Button();
            btnUpgrade.Height = pnlBorder.Height / 10;
            btnUpgrade.Width = pnlBorder.Width / 5;
            btnUpgrade.Top = pnlBorder.Height - btnUpgrade.Height;
            btnUpgrade.Left = pnlBorder.Width - btnUpgrade.Width;
            btnUpgrade.Font = new Font("Arial", 11, FontStyle.Bold);
            btnUpgrade.BackColor = Color.DarkCyan;
            btnUpgrade.ForeColor = Color.White;
            btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);

            pnlBorder.Controls.Add(btnUpgrade);

            for (int x = 0; x < MAXCHARACTERS; x++)
            {
                //test permettant de savoir sur quel bouton on à cliqué 
                if (charactersPropertiesLevelOne[x, 0] == (sender as Button).Text || charactersPropertiesLevelOne[x, 0] == (sender as Button).Name)
                {
                    btnUpgrade.Name = (sender as Button).Text;

                    if(reload == true)
                    {
                        btnUpgrade.Visible = false;
                        reload = false;
                    }
                    else
                    {
                        btnUpgrade.Text = "Améliorer " + (sender as Button).Text;
                    }
                    
                    for (int c = 0; c < MAXPROPERTIES; c++)
                    {
                        string character = "";

                        Label lblProperties = new Label();
                        lblProperties.ForeColor = Color.White;

                        Label lblProperties2 = new Label();
                        lblProperties2.ForeColor = Color.White;


                        /*variable recevant le types de caractèristique des personnages (nom, dégats, niveau, ...)
                         * +
                         les caractèristique elles-même*/

                        character = charactersPropertiesName[c];

                        if (charactersProperties[x, 6] == "1")
                        {
                            if (charactersPropertiesName[c] == "Cartes : ")
                            {
                                character += charactersPropertiesLevelOne[x, c] + " / " + charactersUpgrades[0, x / 3];
                            }
                            else
                                character += charactersPropertiesLevelOne[x, c];
                        }   
                        else if (charactersProperties[x, 6] == "2")
                        {
                            if (charactersPropertiesName[c] == "Cartes : ")
                            {
                                character += charactersProperties[x, c] + " / " + charactersUpgrades[1, x / 3];
                            }
                            else
                                character += charactersProperties[x, c];
                        }
                        else if(charactersProperties[x, 6] == "3")
                        {
                            if (charactersPropertiesName[c] == "Cartes : ")
                            {
                                character += charactersProperties[x, c] + " / ∞";
                            }
                            else
                                character += charactersProperties[x, c];
                        }



                        lblProperties.Height = pnlBorder.Height / 8;
                        lblProperties.Width = pnlBorder.Width / 2;
                        lblProperties.Top = pnlBorder.Height - pnlBorder.Height + 88 * c;

                        lblProperties.Font = new Font("Arial", 24, FontStyle.Bold);


                        lblProperties.Text = character;

                        //

                        lblProperties2.Height = pnlBorder.Height / 8;
                        lblProperties2.Width = pnlBorder.Width / 2;
                        lblProperties2.Top = pnlBorder.Height - pnlBorder.Height + 88 * c;

                        lblProperties2.Font = new Font("Arial", 24, FontStyle.Bold);
                        lblProperties2.Text = character;


                        Label lblGoldForUpgrades = new Label();
                        lblGoldForUpgrades.ForeColor = Color.White;
                        lblGoldForUpgrades.Height = pnlBorder.Height / 10;
                        lblGoldForUpgrades.Width = pnlBorder.Width /4;
                        lblGoldForUpgrades.Left = pnlBorder.Width - lblGoldForUpgrades.Width;
                        lblGoldForUpgrades.Top = pnlBorder.Height / 2 - lblGoldForUpgrades.Height;
                        lblGoldForUpgrades.Font = new Font("Arial", 15, FontStyle.Bold);
                        lblGoldForUpgrades.Text = "Argent nécessaire";
                        lblGoldForUpgrades.BorderStyle = BorderStyle.FixedSingle;

                        byte nbrCount = 0;
                        for (int a = 0; a < 7; a++)
                        {
                            for (int b = 0; b < 3; b++)
                            {

                                long totalGold = Convert.ToInt64(lblGold.Text);

                                if (charactersPropertiesLevelOne[nbrCount, 0] == btnUpgrade.Name)
                                {
                                    if (charactersProperties[x, 6] == "1")
                                    {
                                        lblGoldForUpgrades.Visible = true;

                                        if (nbrCardsUpgrades[b, a] < charactersUpgrades[0, a] && charactersPropertiesName[c] == "Cartes : ")
                                        {
                                            lblProperties2.ForeColor = Color.Red;
                                            btnUpgrade.Visible = false;
                                        }
                                        else if (nbrCardsUpgrades[b, a] >= charactersUpgrades[0, a] && charactersPropertiesName[c] == "Cartes : ")
                                        {
                                            lblProperties2.ForeColor = Color.Green;
                                            btnUpgrade.Visible = true;
                                        }


                                        if (totalGold < charactersUpgrades[2, a])
                                        {
                                            lblGoldForUpgrades.ForeColor = Color.Red;
                                            btnUpgrade.BackColor = Color.Red;
                                            btnUpgrade.Enabled = false;
                                        }
                                        else if (totalGold >= charactersUpgrades[2, a])
                                        {
                                            lblGoldForUpgrades.ForeColor = Color.Green;
                                            btnUpgrade.BackColor = Color.DarkCyan;
                                            btnUpgrade.Enabled = true;
                                        }

                                        lblGoldForUpgrades.Text = "Or requis pour améliorer : " + charactersUpgrades[2, a].ToString();
                                    }
                                    if (charactersProperties[x, 6] == "2")
                                    {
                                        lblGoldForUpgrades.Visible = true;

                                        if (nbrCardsUpgrades[b, a] < charactersUpgrades[1, a] && charactersPropertiesName[c] == "Cartes : ")
                                        {
                                            lblProperties2.ForeColor = Color.Red;
                                            btnUpgrade.Visible = false;
                                        }
                                        else if (nbrCardsUpgrades[b, a] >= charactersUpgrades[1, a] && charactersPropertiesName[c] == "Cartes : ")
                                        {
                                            lblProperties2.ForeColor = Color.Green;
                                            btnUpgrade.Visible = true;
                                        }

                                        if (totalGold < charactersUpgrades[3, a])
                                        {
                                            lblGoldForUpgrades.ForeColor = Color.Red;
                                            btnUpgrade.BackColor = Color.Red;
                                            btnUpgrade.Enabled = false;
                                        }
                                        else if (totalGold >= charactersUpgrades[3, a])
                                        {
                                            lblGoldForUpgrades.ForeColor = Color.Green;
                                            btnUpgrade.BackColor = Color.DarkCyan;
                                            btnUpgrade.Enabled = true;
                                        }

                                        lblGoldForUpgrades.Text = "Or requis pour améliorer : " + charactersUpgrades[3, a].ToString();
                                    }
                                    if (charactersProperties[x, 6] == "3")
                                    {
                                        lblGoldForUpgrades.Visible = false;
                                    }

                                        pnlBorder.Controls.Add(lblGoldForUpgrades);

                                }
                                nbrCount++;
                            }
                        }
                        

                        if (lblProperties2.ForeColor == Color.Red || lblProperties2.ForeColor == Color.Green)
                        {
                            pnlBorder.Controls.Add(lblProperties2);//ajout des labels au panel principal
                        }
                        else
                        {                            
                            pnlBorder.Controls.Add(lblProperties);//ajout des labels au panel principal
                        }

                        Button btnReturn = new Button();
                        btnReturn.Width = pnlBorder.Width / 5;
                        btnReturn.Height = pnlBorder.Height / 10;
                        //
                        btnReturn.Left = pnlBorder.Width - btnReturn.Width;
                        //
                        btnReturn.Font = new Font("Arial", 11, FontStyle.Bold);
                        btnReturn.BackColor = Color.DarkCyan;
                        btnReturn.ForeColor = Color.White;
                        //
                        btnReturn.Name = "InventoryBack";
                        btnReturn.Text = "Retour";
                        //

                        pnlBorder.Controls.Add(btnReturn);
                        btnReturn.Click += new System.EventHandler(this.btnReturn_Click);



                    }
                }
            }
        }
        //amélioration des personnages
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
            byte nbrCountUpgrades = 0;
            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                   

                    if (charactersPropertiesLevelOne[nbrCountUpgrades, 0] == (sender as Button).Name && charactersProperties[nbrCountUpgrades, 6] == "1")
                    {
                        for (byte c = 0; c < 8; c++)
                            charactersProperties[nbrCountUpgrades, c] = charactersPropertiesLevelTwo[nbrCountUpgrades, c];

                        totalGold -= charactersUpgrades[2, nbrCountUpgrades / 3];

                        reload = true;
                             btnCardProperty_Click(sender, e);
                        
                    }
                    else if (charactersProperties[nbrCountUpgrades, 0] == (sender as Button).Name && charactersProperties[nbrCountUpgrades, 6] == "2")
                    {
                        for (byte c = 0; c < 8; c++)
                            charactersProperties[nbrCountUpgrades, c] = charactersPropertiesLevelThree[nbrCountUpgrades, c];

                        totalGold -= charactersUpgrades[3, nbrCountUpgrades / 3];

                        reload = true;
                        btnCardProperty_Click(sender, e);

                    }

                    nbrCountUpgrades++;
                }
            }
            Form1_Load(sender, e);

        }
        //----------------------------------------------------------------------------Fin Inventaire|

        //-----------------------------------------------------------------------------------magasin|
        private void BtnShop_Click(object sender, EventArgs e)
        {
            pnlBorder.BackColor = Color.FromArgb(17, 67, 128);
            pnlBorder.Controls.Clear();
            lblPage.Visible = true;
            pnlBorderPage.Visible = true;
        } 
        //-------------------------------------------------------------------------------Fin magasin|

        //-----------------------------------------------------------------------------------coffres|
        private void BtnChest_Click(object sender, EventArgs e)
        {
            pnlBorder.BackColor = Color.FromArgb(17, 67, 128);
            pnlBorder.Controls.Clear();
            //boutons des pages enlevés
            lblPage.Visible = false;
            pnlBorderPage.Visible = false;

            //création d'un style de texte
            Font chestNbrLblFont = new Font("Times New Roman", 12.0f, FontStyle.Bold);

            //boucle permettant de générer les coffres
            for (int x = 0; x < 6; x++)
            {
                //panel servant aux coffres
                Panel pnlChest = new Panel();
                pnlChest.Height = pnlBorder.Height / 3;
                pnlChest.Width = pnlBorder.Width / 3;

                pnlchestHeight = pnlChest.Height;
                pnlchestWidth = pnlChest.Width;

                pnlChest.Top = pnlBorder.Height / 2 - pnlChest.Height / 2;

                //tableau donnant le nom de chaque panel, (le tableau commence par 6, ce qui veut dire : le dernier coffre)
                pnlChest.Name = rotationValues[x].ToString();

                //test qui détérmine quel panel va être posé où 
                if (x == 0)
                {
                    //panel de gauche
                    pnlChest.Left -= pnlChest.Width / 2;
                }
                else if (x == 1)
                {
                    //panel central
                    pnlChest.Left = pnlBorder.Width / 2 - pnlChest.Width / 2;

                    //test qui permet d'afficher le nombre de coffre disponible par rareté de ceux-ci
                    if (pnlChest.Name == "1")
                        chestNbr = ChestNumbers[1, 0].ToString();
                    else if (pnlChest.Name == "2")
                        chestNbr = ChestNumbers[1, 1].ToString();
                    else if (pnlChest.Name == "3")
                        chestNbr = ChestNumbers[1, 2].ToString();
                    else if (pnlChest.Name == "4")
                        chestNbr = ChestNumbers[1, 3].ToString();
                    else if (pnlChest.Name == "5")
                        chestNbr = ChestNumbers[1, 4].ToString();
                    else if (pnlChest.Name == "6")
                        chestNbr = ChestNumbers[1, 5].ToString();
                }
                else if (x == 2)
                {
                    //panel de droite
                    pnlChest.Left = pnlBorder.Width - pnlChest.Width / 2;
                }
                else
                {
                    //les autres panels qu'on ne voit pas
                    pnlChest.Left = pnlBorder.Width;
                }

                //test très utile au début pour ne passer que par ici la première fois
                //cela sert à placer les coffres normalement et dans le bon ordre directement
                if (freeRotationTab == true)
                {
                    //tests qui permettent de détérminer sur quel coffre on est situé (de gauche à droite)
                    if (pnlChest.Name == "1")
                    {
                        //changement des paramètres du panel des coffres selon la rareté
                        pnlChest.BackColor = Color.Gray;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = oldChest;

                    }
                    else if (pnlChest.Name == "2")
                    {
                        pnlChest.BackColor = Color.DarkRed;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = reinforcedChest;
                    }
                    else if (pnlChest.Name == "3")
                    {
                        pnlChest.BackColor = Color.Green;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = brightChest;
                    }
                    else if (pnlChest.Name == "4")
                    {
                        pnlChest.BackColor = Color.Yellow;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = royalChest;
                    }
                    else if (pnlChest.Name == "5")
                    {
                        pnlChest.BackColor = Color.Blue;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = diamondChest;
                    }
                    else
                    {
                        pnlChest.BackColor = Color.Purple;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = magicalChest;
                    }
                }
                else
                {
                    //tests permettants de savoir (de gauche à droite) quel panel doit être affiché en fonction du tableau qui fait tourner les chiffres en fonction de la rareté
                    if (rotationValues[x] == 1)
                    {
                        //changement des paramètres du panel des coffres selon la rareté
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = oldChest;
                        pnlChest.BackColor = Color.Gray;
                    }
                    else if (rotationValues[x] == 2)
                    {
                        pnlChest.BackColor = Color.DarkRed;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = reinforcedChest;
                    }
                    else if (rotationValues[x] == 3)
                    {
                        pnlChest.BackColor = Color.Green;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = brightChest;
                    }
                    else if (rotationValues[x] == 4)
                    {
                        pnlChest.BackColor = Color.Yellow;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = royalChest;
                    }
                    else if (rotationValues[x] == 5)
                    {
                        pnlChest.BackColor = Color.Blue;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = diamondChest;
                    }
                    else
                    {
                        pnlChest.BackColor = Color.Purple;
                        pnlChest.BackgroundImageLayout = ImageLayout.Zoom;
                        pnlChest.BackgroundImage = magicalChest;
                    }

                }
                pnlChest.BorderStyle = BorderStyle.FixedSingle;
                pnlBorder.Controls.Add(pnlChest); //ajout du panel au panel principal

                //Nouveau nouton pour se déplacer entre les différents coffres de la page
                Button btnChestChoice = new Button();

                btnChestChoice.Height = pnlBorder.Height / 9;
                btnChestChoice.Width = pnlBorder.Width / 9;
                btnChestChoice.Top = pnlBorder.Height / 2 - btnChestChoice.Height / 2;

                //test permettant de savoir quel des 2 bouton doit être affiché
                if (x == 0)
                {
                    //se déplacer à gauche
                    btnChestChoice.Name = "Back";
                    btnChestChoice.Left = pnlBorder.Width / 2 - pnlChest.Width + 20;
                    btnChestChoice.Image = backChestimg;
                    pnlBorder.Controls.Add(btnChestChoice);
                }
                else if (x == 1)
                {
                    //se déplacer à droite
                    btnChestChoice.Name = "Next";
                    btnChestChoice.Left = pnlBorder.Width / 2 + pnlChest.Width - (btnChestChoice.Width + 20);
                    btnChestChoice.Image = nextChestimg;
                    pnlBorder.Controls.Add(btnChestChoice);
                }
                //création de nouveaux événements pour les panels de coffre et les boutons de choix des coffres
                btnChestChoice.Click += new System.EventHandler(this.btnChestChoice_Click);
                pnlChest.Click += new System.EventHandler(this.pnlChest_Click);
            }
            //label montrant le nombres de coffres disponibles
            lblNbrChest = new Label();
            lblNbrChest.Top = pnlBorder.Height / 2 - pnlchestHeight / 2 - lblNbrChest.Height;
            lblNbrChest.Left = pnlBorder.Width / 2 - pnlchestWidth / 2 + 15;

            //dimensions du label
            lblNbrChest.Height = 20;
            lblNbrChest.Width = pnlchestWidth - 30;
            //Texte du label
            lblNbrChest.Font = chestNbrLblFont;
            lblNbrChest.ForeColor = Color.White;
            lblNbrChest.Text = "Nombres de coffres : " + chestNbr;
            //Bordure du label
            lblNbrChest.BorderStyle = BorderStyle.FixedSingle;

            pnlBorder.Controls.Add(lblNbrChest);

            //changement de la variable de rotation libre pour faire en sort de pouvoir changer de coffre avec les boutons de choix.
            freeRotationTab = false;

        }
        //click du bouton de choix des coffres
        private void btnChestChoice_Click(object sender, EventArgs e)
        {
            //test qui cherche sur quel bouton l'utilisateur à cliqué
            if ((sender as Button).Name == "Next")
            {
                //nombre qui sort du tableau lors de la rotation, ce qui permet de le r'afficher en première place (à gauche) 
                nbrOut = rotationValues[0];
                //boucle qui change la position des valeurs du tableau de rotation
                for (byte i = 0; i < rotationValues.Length; i++)
                {
                    if (i < 5)
                    {
                        rotationValues[i] = rotationValues[i + 1];
                    }
                    else
                    {
                        rotationValues[i] = nbrOut;
                    }
                }
                //simulation du click du bouton de coffres
                BtnChest_Click(sender, e);
            }
            else
            {
                //nombre qui sort du tableau lors de la rotation, ce qui permet de le mettre en dernière position du tableau 
                nbrOut = rotationValues[5];
                for (byte i = 5; i >= 0; i--)
                {
                    //test permettant de savoir si on dépasse les valeur du tableau, car il n'y a pas de limite dans la boucle au dessus
                    if (i > rotationValues.Length)
                    {
                        break; //On sort de la boucle
                    }

                    if (i > 0)
                    {
                        rotationValues[i] = rotationValues[i - 1];
                    }
                    else
                    {
                        rotationValues[i] = nbrOut;
                    }
                }
                //simulation du click du bouton de coffres
                BtnChest_Click(sender, e);
            }

        }

        //au click du panel contenant le coffre
        private void pnlChest_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 6; x++)
            {
                if ((sender as Panel).Name == ChestNumbers[0, x].ToString())
                {
                    if (ChestNumbers[1, x] > 0)
                    {
                        Random randomNumber = new Random();
                        short card = Convert.ToInt16(randomNumber.Next(1, 1001));
                        short loot = Convert.ToInt16(randomNumber.Next(0, 999));

                        //argent généré par les différents types de coffre (selon rareté)
                        short goldOC = Convert.ToInt16(randomNumber.Next(112, 303)); //argent généré par le vieux coffret
                        short goldRC = Convert.ToInt16(randomNumber.Next(268, 541)); //argent généré par le coffre renforcé
                        short goldBC = Convert.ToInt16(randomNumber.Next(500, 763)); //argent généré par le coffre lumineux
                        short goldRC2 = Convert.ToInt16(randomNumber.Next(688, 923)); //argent généré par le coffre royal
                        short goldDC = Convert.ToInt16(randomNumber.Next(811, 1001)); //argent généré par le coffre en diamant
                        short goldMC = Convert.ToInt16(randomNumber.Next(946, 1159)); //argent généré par le coffre magique


                        //nombre de cartes générées par les différents coffres (selon rareté)
                        short nbCardC = Convert.ToInt16(randomNumber.Next(8, 45));
                        short nbCardR = Convert.ToInt16(randomNumber.Next(5, 34));
                        short nbCardSR = Convert.ToInt16(randomNumber.Next(4, 27));
                        short nbCardE = Convert.ToInt16(randomNumber.Next(3, 15));
                        short nbCardL = Convert.ToInt16(randomNumber.Next(2, 7));
                        short nbCardM = Convert.ToInt16(randomNumber.Next(1, 2));
                        short nbCardMS = Convert.ToInt16(randomNumber.Next(1, 1));


                        pnlBorder.Controls.Clear();

                        Panel pnlActualChest = new Panel();
                        pnlActualChest.Height = 70;
                        pnlActualChest.Width = 70;

                        pnlActualChest.Top = 10;
                        pnlActualChest.Left = 10;

                        //Choix de la carte reçue

                        if ((sender as Panel).Name == "1")
                        {

                            pnlActualChest.BackgroundImage = oldChest;
                            totalGold += goldOC;

                            
                            chestLoots[4] = goldOC.ToString();

                            if (card <= 700) //cartes communes 
                            {
                                chestLoots[3] = nbCardC.ToString();
                                
                                //loot----------
                                if (loot <= 333) //1ère carte
                                {
                                    cardC1 += nbCardC;
                                    statusC1 = "Dévérouillé";
                                    for(int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[0, i];
                                    }
                                }
                                else if (loot <= 666) //2ème carte
                                {
                                    statusC2 = "Dévérouillé";
                                    cardC2 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[1, i];
                                    }
                                }
                                else if (loot <= 999) //3ème carte
                                {
                                    statusC3 = "Dévérouillé";
                                    cardC3 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[2, i];
                                    }
                                }
                            }
                            else if (card <= 950) //cartes rares
                            {
                                chestLoots[3] = nbCardR.ToString();
                                //loot----------
                                if (loot <= 333) //1ère carte
                                {
                                    statusR1 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[3, i];
                                    }
                                }
                                else if (loot <= 666) //2ème carte
                                {
                                    statusR2 = "Dévérouillé";
                                    cardR2 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[4, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusR3 = "Dévérouillé";
                                    cardR3 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[5, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes super rares
                            {
                                chestLoots[3] = nbCardSR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusSR1 = "Dévérouillé";
                                    cardSR1 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[6, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusSR2 = "Dévérouillé";
                                    cardSR2 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[7, i];
                                    }
                                }
                                else if (loot <= 999)//2ème carte
                                {
                                    statusSR3 = "Dévérouillé";
                                    cardSR3 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[8, i];
                                    }
                                }
                            }
                        }
                        else if ((sender as Panel).Name == "2")
                        {
                            pnlActualChest.BackgroundImage = reinforcedChest;
                            totalGold += goldRC;

                            chestLoots[4] = goldRC.ToString();

                            if (card <= 550) //cartes communes
                            {
                                chestLoots[3] = nbCardC.ToString();
                                //loot----------
                                if (loot <= 333) //1ère carte
                                {
                                    statusC1 = "Dévérouillé";
                                    cardC1 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[0, i];
                                    }
                                }
                                else if (loot <= 666) //2ème carte
                                {
                                    statusC2 = "Dévérouillé";
                                    cardC2 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[1, i];
                                    }
                                }
                                else if (loot <= 999) //3ème carte
                                {
                                    statusC3 = "Dévérouillé";
                                    cardC3 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[2, i];
                                    }
                                }
                            }
                            else if (card <= 850) //cartes rares
                            {
                                chestLoots[3] = nbCardR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusR1 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[3, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusR2 = "Dévérouillé";
                                    cardR2 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[4, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusR3 = "Dévérouillé";
                                    cardR3 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[5, i];
                                    }
                                }
                            }
                            else if (card <= 950) //cartes super rares
                            {
                                chestLoots[3] = nbCardSR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusSR1 = "Dévérouillé";
                                    cardSR1 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[6, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusSR2 = "Dévérouillé";
                                    cardSR2 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[7, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusSR3 = "Dévérouillé";
                                    cardSR3 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[8, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes épiques
                            {
                                chestLoots[3] = nbCardE.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusE1 = "Dévérouillé";
                                    cardE1 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[9, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusE2 = "Dévérouillé";
                                    cardE2 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[10, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusE3 = "Dévérouillé";
                                    cardE3 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[11, i];
                                    }
                                }
                            }
                        }
                        else if ((sender as Panel).Name == "3")
                        {
                            pnlActualChest.BackgroundImage = brightChest;
                            totalGold += goldBC;

                            chestLoots[4] = goldBC.ToString();

                            if (card <= 400) //cartes communes
                            {
                                chestLoots[3] = nbCardC.ToString();
                                //loot----------
                                if (loot <= 333) //1ère carte
                                {
                                    statusC1 = "Dévérouillé";
                                    cardC1 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[0, i];
                                    }
                                }
                                else if (loot <= 666) //2ème carte
                                {
                                    statusC2 = "Dévérouillé";
                                    cardC2 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[1, i];
                                    }
                                }
                                else if (loot <= 999) //3ème carte
                                {
                                    statusC3 = "Dévérouillé";
                                    cardC3 += nbCardC;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[2, i];
                                    }
                                }
                            }
                            else if (card <= 600) //cartes rares
                            {
                                chestLoots[3] = nbCardR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusR1 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[3, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusR2 = "Dévérouillé";
                                    cardR2 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[4, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusR3 = "Dévérouillé";
                                    cardR3 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[5, i];
                                    }
                                }
                            }
                            else if (card <= 800) //cartes super rares
                            {
                                chestLoots[3] = nbCardSR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusSR1 = "Dévérouillé";
                                    cardSR1 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[6, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusSR2 = "Dévérouillé";
                                    cardSR2 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[7, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusSR3 = "Dévérouillé";
                                    cardSR3 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[8, i];
                                    }
                                }
                            }
                            else if (card <= 950) //cartes épiques
                            {
                                chestLoots[3] = nbCardE.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusE1 = "Dévérouillé";
                                    cardE1 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[9, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusE2 = "Dévérouillé";
                                    cardE2 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[10, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusE3 = "Dévérouillé";
                                    cardE3 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[11, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes légendaires
                            {
                                chestLoots[3] = nbCardL.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusL1 = "Dévérouillé";
                                    cardL1 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[12, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusL2 = "Dévérouillé";
                                    cardL2 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[13, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusL3 = "Dévérouillé";
                                    cardL3 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[14, i];
                                    }
                                }
                            }
                        }
                        else if ((sender as Panel).Name == "4")
                        {
                            pnlActualChest.BackgroundImage = royalChest;
                            totalGold += goldRC2;

                            chestLoots[4] = goldRC2.ToString();

                            if (card <= 300) //cartes rares
                            {
                                chestLoots[3] = nbCardR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusR1 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[3, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusR2 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[4, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusR3 = "Dévérouillé";
                                    cardR1 += nbCardR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[5, i];
                                    }
                                }
                            }
                            else if (card <= 550) //cartes super rares
                            {
                                chestLoots[3] = nbCardSR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusSR1 = "Dévérouillé";
                                    cardSR1 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[6, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusSR2 = "Dévérouillé";
                                    cardSR2 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[7, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusSR3 = "Dévérouillé";
                                    cardSR3 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[8, i];
                                    }
                                }
                            }
                            else if (card <= 850) //cartes épiques
                            {
                                chestLoots[3] = nbCardE.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusE1 = "Dévérouillé";
                                    cardE1 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[9, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusE2 = "Dévérouillé";
                                    cardE2 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[10, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusE3 = "Dévérouillé";
                                    cardE3 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[11, i];
                                    }
                                }
                            }
                            else if (card <= 970) //cartes légendaires
                            {
                                chestLoots[3] = nbCardL.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusL1 = "Dévérouillé";
                                    cardL1 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[12, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusL2 = "Dévérouillé";
                                    cardL2 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[13, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusL3 = "Dévérouillé";
                                    cardL3 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[14, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes mythiques
                            {
                                chestLoots[3] = nbCardM.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusM1 = "Dévérouillé";
                                    cardM1 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[15, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusM2 = "Dévérouillé";
                                    cardM2 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[16, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusM3 = "Dévérouillé";
                                    cardM3 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[17, i];
                                    }
                                }
                            }
                        }
                        else if ((sender as Panel).Name == "5")
                        {
                            pnlActualChest.BackgroundImage = diamondChest;
                            totalGold += goldDC;

                            chestLoots[4] = goldDC.ToString();

                            if (card <= 300) //cartes super rares
                            {
                                chestLoots[3] = nbCardSR.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusSR1 = "Dévérouillé";
                                    cardSR1 += nbCardSR;
                                    for (int i = 0; i < 3; i++) 
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[6, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusSR2 = "Dévérouillé";
                                    cardSR2 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[7, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusSR3 = "Dévérouillé";
                                    cardSR3 += nbCardSR;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[8, i];
                                    }
                                }
                            }
                            else if (card <= 450) //cartes épiques
                            {
                                chestLoots[3] = nbCardE.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusE1 = "Dévérouillé";
                                    cardE1 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[9, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusE2 = "Dévérouillé";
                                    cardE2 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[10, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusE3 = "Dévérouillé";
                                    cardE3 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[11, i];
                                    }
                                }
                            }
                            else if (card <= 900) //cartes légendaires
                            {
                                chestLoots[3] = nbCardL.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusL1 = "Dévérouillé";
                                    cardL1 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[12, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusL2 = "Dévérouillé";
                                    cardL2 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[13, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusL3 = "Dévérouillé";
                                    cardL3 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[14, i];
                                    }
                                }
                            }
                            else if (card <= 990) //cartes mythiques
                            {
                                chestLoots[3] = nbCardM.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusM1 = "Dévérouillé";
                                    cardM1 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[15, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusM2 = "Dévérouillé";
                                    cardM2 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[16, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusM3 = "Dévérouillé";
                                    cardM3 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[17, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes mistèrieuses
                            {
                                chestLoots[3] = nbCardMS.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusMS1 = "Dévérouillé";
                                    cardMS1 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[18, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusMS2 = "Dévérouillé";
                                    cardMS2 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[19, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusMS3 = "Dévérouillé";
                                    cardMS3 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[20, i];
                                    }
                                }
                            }
                        }
                        else if ((sender as Panel).Name == "6")
                        {
                            pnlActualChest.BackgroundImage = magicalChest;
                            totalGold += goldMC;

                            chestLoots[4] = goldMC.ToString();
                            
                            if (card <= 300) //cartes épiques
                            {
                                chestLoots[3] = nbCardE.ToString();
                                //loot---------- 
                                if (loot <= 333)//1ère carte
                                {
                                    statusE1 = "Dévérouillé";
                                    cardE1 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[9, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusE2 = "Dévérouillé";
                                    cardE2 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[10, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusE3 = "Dévérouillé";
                                    cardE3 += nbCardE;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[11, i];
                                    }
                                }
                            }
                            else if (card <= 625) //cartes légendaires
                            {
                                chestLoots[3] = nbCardL.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusL1 = "Dévérouillé";
                                    cardL1 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[12, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusL2 = "Dévérouillé";
                                    cardL2 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[13, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusL3 = "Dévérouillé";
                                    cardL3 += nbCardL;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[14, i];
                                    }
                                }
                            }
                            else if (card <= 925) //cartes mythiques
                            {
                                chestLoots[3] = nbCardM.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusM1 = "Dévérouillé";
                                    cardM1 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[15, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusM2 = "Dévérouillé";
                                    cardM2 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[16, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusM3 = "Dévérouillé";
                                    cardM3 += nbCardM;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[17, i];
                                    }
                                }
                            }
                            else if (card <= 1000) //cartes mistèrieuses
                            {
                                chestLoots[3] = nbCardMS.ToString();
                                //loot----------
                                if (loot <= 333)//1ère carte
                                {
                                    statusMS1 = "Dévérouillé";
                                    cardMS1 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[18, i];
                                    }
                                }
                                else if (loot <= 666)//2ème carte
                                {
                                    statusMS2 = "Dévérouillé";
                                    cardMS2 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[19, i];
                                    }
                                }
                                else if (loot <= 999)//3ème carte
                                {
                                    statusMS3 = "Dévérouillé";
                                    cardMS3 += nbCardMS;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        chestLoots[i] = charactersPropertiesLevelOne[20, i];
                                    }
                                }
                            }
                        }


                        pnlBorder.Controls.Add(pnlActualChest);


                        for (int c = 0; c < MAXLOOTPROPERTIES; c++)
                        {
                            string wonStuff;

                            /*variable recevant le types de caractèristique des personnages (nom, dégats, niveau, ...)
                                * +
                                les caractèristique elles-même*/

                            wonStuff = chestLootsName[c];
                            wonStuff += chestLoots[c];

                            //création des labels affichants les caractèristiques
                            Label lblChestContent = new Label();
                            lblChestContent.Height = pnlBorder.Height / 8;
                            lblChestContent.Width = pnlBorder.Width / 2;
                            lblChestContent.Top = pnlBorder.Height - pnlBorder.Height + 88 * c;
                            lblChestContent.Left = pnlBorder.Width - lblChestContent.Width - lblChestContent.Width / 2;

                            lblChestContent.ForeColor = Color.White;
                            lblChestContent.Font = new Font("Arial", 24, FontStyle.Bold);
                            lblChestContent.Text = wonStuff;
                            pnlBorder.Controls.Add(lblChestContent);//ajout des labels au panel principal

                            //

                            Button btnReturn = new Button();
                            btnReturn.Width = pnlBorder.Width / 5;
                            btnReturn.Height = pnlBorder.Height / 10;
                            //
                            btnReturn.Left = pnlBorder.Width - btnReturn.Width;
                            btnReturn.Top = pnlBorder.Height - btnReturn.Height;
                            //
                            btnReturn.ForeColor = Color.White;
                            btnReturn.Font = new Font("Arial", 11, FontStyle.Bold);
                            btnReturn.BackColor = Color.DarkCyan;
                            //
                            btnReturn.Name = "ChestBack";
                            btnReturn.Text = "Retour";
                            //

                            pnlBorder.Controls.Add(btnReturn);
                            btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

                        }

                        ChestNumbers[1, x]--;
                    }
                    else
                    {
                        //mesage d'erreur disant qu'il n'y a aucun coffre disponible au click du panel
                        MessageBox.Show("[ERREUR] Il n'y a aucun coffre disponible dans cette rareté", "Coffre non disponible");
                    }

                }
                //mise à jour de l'argent total dans le compteur en haut de l'écran
                lblGold.Text = totalGold.ToString();
                //mise à jour du tableau au début du programme
                Form1_Load(sender, e);
            }




        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "ChestBack")
            {
                BtnChest_Click(sender, e);
            }
            else if ((sender as Button).Name == "InventoryBack")
            {
                BtnInventory_Click(sender, e);
            }
        }

        //-------------------------------------------------------------------------------Fin coffres|
    }
}
