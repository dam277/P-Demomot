using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLE MENU -------------------------------------------------------
            int easterEggMax = 1;
            //nom du coffre
            string nom;
            //nom de la carte
            string cartename = "";
            //argent
            int argent = 0;
            int ArgentC = 0;
            //numéro de carte
            int cartenum = 0;
            //---
            int vie = 0;
            int degats = 0;
            //---

            //personnages communs ----------------------------|
            string commun = "commun";
            int maxCartesCN1 = 20;
            int maxCartesCN2 = 40;
            int prixCN1 = 100;
            int prixCN2 = 200;
                //premier personnage commun ------------|
                string commun1 = "()";
                string nomC1 = "roche1";
                string statusC1 = "verrouillé ";
                //puissance -------------------|
                int vieC1 = 7;
                    int degatC1 = 3;
                    int levelC1 = 0;
                    int cartesC1 = 0;
                //deuxième personnage commun ------------|
                string commun2 = "(o)";
                string nomC2 = "roche2";
                string statusC2 = "verrouillé";
                //puissance -------------------|
                int vieC2 = 8;
                    int degatC2 = 4;
                    int levelC2 = 0;
                    int cartesC2 = 0;
                //troisième personnage commun -----------|
                string commun3 = "(O)";
                string nomC3 = "roche3";
                string statusC3 = "verrouillé";
                //puissance -------------------|
                int vieC3 = 9;
                    int degatC3 = 3;
                    int levelC3 = 0;
                    int cartesC3 = 0;
            //--------------------------------------------------|

            //personnages rares --------------------------------|
            string rare = "rare";
            int maxCartesRN1 = 20;
            int maxCartesRN2 = 40;
            int prixRN1 = 100;
            int prixRN2 = 200;
                //premier personnage rare --------------|
                string rare1 = "{}";
                string nomR1 = "pierre1";
                string statusR1 = "verrouillé";
                //puissance ----------------|
                int vieR1 = 6;
                    int degatR1 = 4;
                    int levelR1 = 0;
                    int cartesR1 = 0;
                //deuxième personnage rare -------------|
                string rare2 = "{o}";
                string nomR2 = "pierre2";
                string statusR2 = "verrouillé";
                //puissance ----------------|
                int vieR2 = 11;
                    int degatR2 = 2;
                    int levelR2 = 0;
                    int cartesR2 = 0;
                //troisième personnage rare ------------|
                string rare3 = "{O}";
                string nomR3 = "pierre3";
                string statusR3 = "verrouillé";
                //puissance ----------------|
                int vieR3 = 12;
                    int degatR3 = 1;
                    int levelR3 = 0;
                    int cartesR3 = 0;
            //-------------------------------------------------|    

            //personnages super rares -------------------------|
            string superrare = "superrare";
            int maxCartesSRN1 = 20;
            int maxCartesSRN2 = 40;
            int prixSRN1 = 100;
            int prixSRN2 = 200;
                //premier personnage super rare -----------|
                string superare1 = "[]";
                string nomSR1 = "rocher";
                string statusSR1 = "verrouillé";
                //puissance ------------|
                int vieSR1 = 8;
                    int degatSR1 = 3;
                    int levelSR1 = 0;
                    int cartesSR1 = 0;
                //deuxième personnage super rare ----------|
                string superare2 = "[o]";
                string nomSR2 = "rocher2";
                string statusSR2 = "verrouillé";
                //puisance -------------|
                    int vieSR2 = 9;
                    int degatSR2 = 3;
                    int levelSR2 = 0;
                    int cartesSR2 = 0;
                //troisième personnage super rare ---------|
                string superare3 = "[O]";
                string nomSR3 = "rocher3";
                string statusSR3 = "verrouillé";
                //puissance -------------|
                int vieSR3 = 10;
                    int degatSR3 = 3;
                    int levelSR3 = 0;
                    int cartesSR3 = 0;
            //--------------------------------------------------|

            //personnages épiques ------------------------------|
            string epique = "épique";
            int maxCartesEN1 = 20;
            int maxCartesEN2 = 40;
            int prixEN1 = 100;
            int prixEN2 = 200;
                //premier personnage épique ------------|
                string epique1 = "//";
                string nomE1 = "tank1";
                string statusE1 = "verrouillé";
                //puissance ------------|
                int vieE1 = 15;
                    int degatE1 = 2;
                    int levelE1 = 0;
                    int cartesE1 = 0;
                //deuxième personnage épique -----------|
                string epique2 = "/o/";
                string nomE2 = "tank2";
                string statusE2 = "verrouillé";
                //puissance ------------|
                int vieE2 = 17;
                    int degatE2 = 1;
                    int levelE2 = 0;
                    int cartesE2 = 0;
                //troisième personnage épique ----------|
                string epique3 = "/O/";
                string nomE3 = "tank3";
                string statusE3 = "verrouillé";
                //puissance ------------|
                int vieE3 = 13;
                    int degatE3 = 2;
                    int levelE3 = 0;
                    int cartesE3 = 0;
            //--------------------------------------------------|

            //personnages légendaires --------------------------|
            string legendaire = "Légendaire";
            int maxCartesLN1 = 20;
            int maxCartesLN2 = 40;
            int prixLN1 = 100;
            int prixLN2 = 200;
                //premier personnage légendaire ----------------|
                string Legendaire1 = "==";
                string nomL1 = "sniper1";
                string statusL1 = "verrouillé";
                //puissance --------------------|
                int vieL1 = 3;
                    int degatL1 = 5;
                    int levelL1 = 0;
                    int cartesL1 = 0;
                //deuxième personnage légendaire ---------------|
                string Legendaire2 = "=o=";
                string nomL2 = "sniper2";
                string statusL2 = "verrouillé";
                //puissance -------------------|
                int vieL2 = 5;
                    int degatL2 = 3;
                    int levelL2 = 0;
                    int cartesL2 = 0;
                //troisième personnage légendaire --------------|
                string Legendaire3 = "=O=";
                string nomL3 = "sniper3";
                string statusL3 = "verrouillé";
                //puissance -------------------|
                int vieL3 = 4;
                    int degatL3 = 4;
                    int levelL3 = 0;
                    int cartesL3 = 0;
            //---------------------------------------------------|


            //personnages mytiques-------------------------------|
            string mythique = "mythique";
            int maxCartesMN1 = 20;
            int maxCartesMN2 = 40;
            int prixMN1 = 100;
            int prixMN2 = 200;
                //premier personnage mytique --------|
                string Mytique1 = "||";
                string nomM1 = "canon1";
                string statusM1 = "verrouillé";
                //puisssance -------------------|
                int vieM1 = 5;
                    int degatM1 = 3;
                    int levelM1 = 0;
                    int cartesM1 = 0;
                //deuxième personnage mytique --------|
                string Mytique2 = "|o|";
                string nomM2 = "canon2";
                string statusM2 = "verrouillé";
                //puissance -------------------|
                int vieM2 = 5;
                    int degatM2 = 5;
                    int levelM2 = 0;
                    int cartesM2 = 0;
                //troisième personnage mytique --------|
                string Mytique3 = "|O|";
                string nomM3 = "canon3";
                string statusM3 = "verrouillé";
                //puissance -------------------|
                int vieM3 = 3;
                    int degatM3 = 6;
                    int levelM3 = 0;
                    int cartesM3 = 0;
            //---------------------------------------------------|

            //personnages mistérieux-----------------------------|
            string misterieuse = "mistèrieuse";
            int maxCartesMSN1 = 20;
            int maxCartesMSN2 = 40;
            int prixMSN1 = 100;
            int prixMSN2 = 200;
                //premier personnage misterieux --------|
                string misterieuse1 = "<>";
                string nomMS1 = "catapulte1";
                string statusMS1 = "verrouillé";
                //puissance -------------------|
                int vieMS1 = 13;
                    int degatMS1 = 3;
                    int levelMS1 = 0;
                    int cartesMS1 = 0;
                //deuxième personnage misterieux --------|
                string misterieuse2 = "<o>";
                string nomMS2 = "catapulte2";
                string statusMS2 = "verrouillé";
                //puissance -------------------| 
                int vieMS2 = 10;
                    int degatMS2 = 4;
                    int levelMS2 = 0;
                    int cartesMS2 = 0;
                //troisième personnage misterieux --------|
                string misterieuse3 = "<O>";
                string nomMS3 = "catapulte3";
                string statusMS3 = "verrouillé";
                //puissance -------------------|
                int vieMS3 = 12;
                    int degatMS3 = 2;
                    int levelMS3 = 0;
                    int cartesMS3 = 0;
            //---------------------------------------------------|
            string[] charactersTable = new string[]
            {
               commun1, commun2, commun3, rare1, rare2, rare3, superare1, superare2, superare3,
               epique1, epique2, epique3, Legendaire1, Legendaire2, Legendaire3, Mytique1, Mytique2,
               Mytique3, misterieuse1, misterieuse2, misterieuse3
            };

            string[] unlockedCharacters = new string[]
            {
                statusC1, statusC2, statusC3, statusR1, statusR2, statusR3, statusSR1, statusSR2, statusSR3, 
                statusE1, statusE2, statusE3
            };






            string unlocked = "verrouillé";
            int chest = 0;

            //loot
            string lootbox = "";
            string cards = "";
            string per = lootbox;
            //level
            int level = 0;
            int cartes = 0;
            //timer
            int timer = 3;
            //boucles
            int menu = 0;
            int boutique = 0;
            int inventaire = 0;
            //choix menu
            int choix = 0;
            string var = "";
            //choix Boutique
            int choixB = 0;
            string varB = "";

            string tuto = "O";

            //VARIABLES JEU ------------------------------------
            int choix1 = 0;


            int vie1 = 0;
            int vie2 = 0;
            int vie3 = 0;
            int vie4 = 0;
            int vie5 = 0;
            int vie6 = 0;
            int viegen1 = 1;
            int viegen2 = 1;


            int degats1 = 0;
            int degats2 = 0;
            int degats3 = 0;
            int degats4 = 0;
            int degats5 = 0;
            int degats6 = 0;

            string personnage1 = "0";
            string personnage2 = "0";
            string personnage3 = "0";
            string personnage4 = "0";
            string personnage5 = "0";
            string personnage6 = "0";

            string personne1 = "";
            string personne2 = "";
            string personne3 = "";
            string personne4 = "";
            string personne5 = "";
            string personne6 = "";

            string perso1 = "";
            string perso2 = "";
            string perso3 = "";
            string perso4 = "";
            string perso5 = "";
            string perso6 = "";

            //JEU

            Console.WriteLine("Voulez-vous faire le tutoriel ? [O/N]");
            tuto = Console.ReadLine();
            while (tuto == "O" || tuto == "o")
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("_______________________________________________________________________________");
                Console.WriteLine("|                                   Menu                                      |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                  Jouer                                      |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                 Boutique                                    |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                Inventaire                                   |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("-------------------------------------------------------------------------------");
                // menu -------------------------------------------------------------------------------------------------------------------------------             
                while (menu == 0)
                {


                    ConsoleKey consoleKey = Console.ReadKey().Key;
                    if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.RightArrow)
                    {

                        if (choix == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                                 ► Jouer ◄                                   |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Boutique                                    |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                Inventaire                                   |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "play";
                        }
                        else if (choix == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                  Jouer                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                                ► Boutique ◄                                 |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                Inventaire                                   |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "shop";
                        }
                        else if (choix == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                  Jouer                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Boutique                                    |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                               ► Inventaire ◄                                |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "inventory";
                        }
                        if (choix > 2)
                        {
                            choix = 0;
                        }

                        choix++;

                    }
                    else if (consoleKey == ConsoleKey.Enter && var == "play" || var == "shop" || var == "inventory")
                    {
                        break;
                    }
                    if (var == "play")
                    {
                        Console.WriteLine("► Jouer au mode de jeu classique");
                    }
                    else if (var == "shop")
                    {
                        Console.WriteLine("► Accèder à la boutique");
                    }
                    else if (var == "inventory")
                    {
                        Console.WriteLine("► Accèder à l'inventaire");
                    }
                }

                Console.Clear();
                if (var == "play")
                {
                    Console.WriteLine("Le mode jouer, n'est pas encore disponible, finissez le tutoriel pour commencer !");
                }
                else if (var == "shop")
                {
                    for (int chargement = 0; chargement < 3; chargement++)
                    {
                        Console.Clear();
                        Console.Write("Chargement de la boutique");
                        Thread.Sleep(100);
                        Console.Write(".");
                        Thread.Sleep(100);
                        Console.Write(".");
                        Thread.Sleep(100);
                        Console.Write(".");
                        Thread.Sleep(100);
                    }
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                    Thread.Sleep(100);
                    Console.WriteLine("│                                                 Vos pières d'or : ...       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│                                                                             │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |  Personnage |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    | Vie : ...   |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                    Thread.Sleep(200);
                    Console.WriteLine("│    | Dégats : ...|  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    | Rareté : ...|  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |    Prix     |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    |   ACHETER   |  |   ACHETER   |  |   ACHETER   |  |   ACHETER   |       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      Instructions :                                                         │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      -Pour utiliser la boutique, vous devrez utiliser le bouton             │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      flèche droite de votre clavier pour séléctionner un achat.             │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      -Lorsque l'achat est séléctionné et appuyez sur *Enter*, un            │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      *onglet* apparaitra. Sur celui-ci, sera marqué, les informations       │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      du personnage,la confirmation d'achat du personnage, le nombre         │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      de carte dont vous disposez déjà, le nombre de cartes à avoir          │");
                    Thread.Sleep(100);
                    Console.WriteLine("│      pour le passer au niveau supérieur. Mettons ça en pratique.            │");
                    Thread.Sleep(100);
                    Console.WriteLine("│                                                               Page 1 / ...  │");
                    Thread.Sleep(100);
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                    Console.ReadLine();

                    for (int easterEgg = 0; easterEgg < easterEggMax; easterEgg++)
                    {

                        Console.Clear();
                        Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                        Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                        Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                        Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                        Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                        Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                        Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                        Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                        Console.WriteLine("│    |   ACHETER   |  |   ACHETER   |  |   ACHETER   |  |   ACHETER   |       │");
                        Console.WriteLine("│    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│                                                                             │");
                        Console.Write("│  ");
                        Console.Write("  Retour  ");
                        Console.WriteLine("                                                                 │");
                        Console.WriteLine("│                                                               Page 1 / ...  │");
                        Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");

                        //Boutique -----------------------|
                        varB = "case0";
                        while (boutique == 0)
                        {
                            ConsoleKey consoleKey = Console.ReadKey().Key;
                            if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.RightArrow)
                            {

                                if (choixB == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                    Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                    Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                                    Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                                    Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                                    Console.Write("│    | ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("► ACHETER ◄ ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|  |   ACHETER   |  |   ACHETER   |  |   ACHETER   |       │");
                                    Console.WriteLine(" │    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.Write("│  ");
                                    Console.Write("  Retour  ");
                                    Console.WriteLine("                                                                 │");
                                    Console.WriteLine("│                                                               Page 1 / ...  │");
                                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                    varB = "case1";
                                }
                                else if (choixB == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                    Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                    Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                                    Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                                    Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                                    Console.Write("│    |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  | ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("► ACHETER ◄ ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|       │");
                                    Console.WriteLine(" │    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.Write("│  ");
                                    Console.Write("  Retour  ");
                                    Console.WriteLine("                                                                 │");
                                    Console.WriteLine("│                                                               Page 1 / ...  │");
                                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                    varB = "case2";
                                }
                                else if (choixB == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                    Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                    Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                                    Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                                    Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                                    Console.Write("│    |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  | ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("► ACHETER ◄ ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|       │");
                                    Console.WriteLine(" │    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.Write("│  ");
                                    Console.Write("  Retour  ");
                                    Console.WriteLine("                                                                 │");
                                    Console.WriteLine("│                                                               Page 1 / ...  │");
                                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                    varB = "case3";
                                }
                                else if (choixB == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                    Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                    Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                                    Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                                    Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                                    Console.Write("│    |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  | ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("► ACHETER ◄ ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|       │");
                                    Console.WriteLine(" │    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.Write("│  ");
                                    Console.Write("  Retour  ");
                                    Console.WriteLine("                                                                 │");
                                    Console.WriteLine("│                                                               Page 1 / ...  │");
                                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                    varB = "case4";
                                }
                                else if (choixB == 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                    Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                    Console.WriteLine("│    |  Perso : " + commun1 + " |  | Personnage  |  |  Personnage |  | Personnage  |       │");
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    | Vie : " + vieC1 + "     |  | Vie : ...   |  | Vie : ...   |  | Vie : ...   |       │");
                                    Console.WriteLine("│    | Dégats : " + degatC1 + "  |  | Dégats : ...|  | Dégats : ...|  | Dégats : ...|       │");
                                    Console.WriteLine("│    | Rareté :    |  | Rareté : ...|  | Rareté : ...|  | Rareté : ...|       │");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("│    | " + commun + "      |  |             |  |             |  |             |       │");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("│    |             |  |             |  |             |  |             |       │");
                                    Console.WriteLine("│    |   Gratuit   |  |    Prix     |  |    Prix     |  |    Prix     |       │");
                                    Console.Write("│    |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  |   ");
                                    Console.Write("ACHETER   ");
                                    Console.Write("|  | ");
                                    Console.Write("  ACHETER   ");
                                    Console.Write("|       │");
                                    Console.WriteLine(" │    └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘       │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.WriteLine("│                                                                             │");
                                    Console.Write("│  ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("► Retour ◄");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("                                                                 │");
                                    Console.WriteLine("│                                                               Page 1 / ...  │");
                                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                    varB = "case5";
                                }
                                if (choixB > 4)
                                {
                                    choixB = 0;
                                }
                                choixB++;
                            }
                            else if (consoleKey == ConsoleKey.Enter && varB == "case1" || varB == "case4" || varB == "case5")
                            {
                                break;
                            }

                        }
                        Console.Clear();
                        if (varB == "case1")
                        {
                            Console.Clear();
                            Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                            Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                            Console.WriteLine("│                                                                             │");
                            Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                            Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │ Voulez-vous vraiment acheter cette carte ?                            │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │ " + commun1 + "                                                                    │  │");
                            Console.WriteLine("│  │ Vie: " + vieC1 + "                                                                │  │");
                            Console.WriteLine("│  │ Dégats: " + degatC1 + "                                                             │  │");
                            Console.WriteLine("│  │ Rareté: " + commun + "                                                        │  │");
                            Console.WriteLine("│  │ Prix: Gratuit                                                         │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  │     CONFIRMER                                         ANNULER         │  │");
                            Console.WriteLine("│  │                                                                       │  │");
                            Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                            Console.WriteLine("│                                                                             │");
                            Console.WriteLine("│                                                                             │");
                            Console.WriteLine("│                                                               Page 1 / ...  │");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            choixB = 0;
                            while (boutique == 0)
                            {
                                ConsoleKey consoleKey = Console.ReadKey().Key;
                                if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.RightArrow || consoleKey == ConsoleKey.Tab)
                                {
                                    if (choixB == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                        Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                        Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │ Voulez-vous vraiment acheter cette carte ?                            │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │ " + commun1 + "                                                                    │  │");
                                        Console.WriteLine("│  │ Vie: " + vieC1 + "                                                                │  │");
                                        Console.WriteLine("│  │ Dégats: " + degatC1 + "                                                             │  │");
                                        Console.WriteLine("│  │ Rareté: " + commun + "                                                        │  │");
                                        Console.WriteLine("│  │ Prix: Gratuit                                                         │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.Write("│  │     ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("► CONFIRMER ◄                                     ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("ANNULER         ");
                                        Console.WriteLine("│  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│                                                               Page 1 / ...  │");
                                        Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                        varB = "case6";
                                    }
                                    if (choixB == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                        Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                        Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │ Voulez-vous vraiment acheter cette carte ?                            │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │ " + commun1 + "                                                                    │  │");
                                        Console.WriteLine("│  │ Vie: " + vieC1 + "                                                                │  │");
                                        Console.WriteLine("│  │ Dégats: " + degatC1 + "                                                             │  │");
                                        Console.WriteLine("│  │ Rareté: " + commun + "                                                        │  │");
                                        Console.WriteLine("│  │ Prix: Gratuit                                                         │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.Write("│  │     ");
                                        Console.Write("CONFIRMER                                         ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("► ANNULER ◄     ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("│  │");
                                        Console.WriteLine("│  │                                                                       │  │");
                                        Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│                                                                             │");
                                        Console.WriteLine("│                                                               Page 1 / ...  │");
                                        Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                        varB = "case7";
                                    }
                                    if (choixB > 1)
                                    {
                                        choixB = 0;
                                    }
                                    choixB++;
                                }
                                else if (consoleKey == ConsoleKey.Enter && varB == "case6" || varB == "case7")
                                {
                                    break;
                                }
                            }
                            if (varB == "case6")
                            {
                                Console.Clear();
                                Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   Desormais, allez voir dans votre inventaire, vous y trouverez       │  │");
                                Console.WriteLine("│  │   La carte que vous venez d'acheter !!                                │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   ACHAT CONFIRME !                                                    │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   Prix : Gratuit                                                      │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│                                                               Page 1 / ...  │");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                levelC1 = 1;
                                cartesC1 = 1;
                                statusC1 = "Dévérouillé";
                            }
                            else if (varB == "case7")
                            {
                                Console.Clear();
                                Console.WriteLine("┌─────────────────────────────────Boutique────────────────────────────────────┐");
                                Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                                Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   Vous avez annulé votre achat, pour le tutoriel, vous serez obligé   │  │");
                                Console.WriteLine("│  │   d'acheter la carte de base pour jouer !!                            │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   ACHAT ANNULE !                                                      │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │   Prix : Gratuit                                                      │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  │                                                                       │  │");
                                Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│                                                                             │");
                                Console.WriteLine("│                                                               Page 1 / ...  │");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            }



                        }
                        else if (varB == "case2")
                        {
                            Console.WriteLine("Erreur");
                        }
                        else if (varB == "case3")
                        {
                            Console.WriteLine("Erreur");
                        }
                        else if (varB == "case4")
                        {
                            Console.WriteLine("Vous ne voulez pas la première carte du jeu ? [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Vous savez que sans elle vous ne commencez pas ? [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("La voulez-vous ? [O/N]");
                            Console.ReadLine();
                            Console.WriteLine("Bon de toute façon quoi que tu fasse tu l'auras");
                            Console.ReadLine();
                            easterEggMax++;
                        }
                        else if (varB == "case5")
                        {
                            break;
                        }
                    }






                }
                // Inventaire --------------------------------------------------------|

                else if (var == "inventory")
                {
                    Console.Clear();
                    Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|   Bienvenue dans l'inventaire. C'est ici que vous allez pouvoir voir        |");
                    Console.WriteLine("|   vos cartes et les améliorer.                                              |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.Write("|          |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|      |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|      |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|          | ");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|   Le fonctionnement reste comme la boutique, mais ici, c'est pour les       |");
                    Console.WriteLine("|   améliorer et pas les acheter.                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                    Console.ReadLine();


                    Console.Clear();
                    Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                    Console.WriteLine("|          |Carte : " + commun1 + "   |      |             |      |             |          |");
                    Console.WriteLine("|          |Vie : " + vieC1 + "      |      |             |      |             |          |");
                    Console.WriteLine("|          |Degats : " + degatC1 + "   |      |             |      |             |          |");
                    Console.WriteLine("|          |Niveau : " + levelC1 + "   |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          |" + statusC1 + "  |      |             |      |             |          |");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.Write("|          |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|      |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|      |");
                    Console.Write(" Voir Carte  ");
                    Console.Write("|          | ");
                    Console.WriteLine("|          |             |      |             |      |             |          |");
                    Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                    Retour                                   |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");


                    while (inventaire == 0)
                    {
                        ConsoleKey consoleKey = Console.ReadKey().Key;
                        if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.RightArrow)
                        {

                            if (choixB == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                                Console.WriteLine("|          |Carte : " + commun1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Vie : " + vieC1 + "      |      |             |      |             |          |");
                                Console.WriteLine("|          |Degats : " + degatC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Niveau : " + levelC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          |" + statusC1 + "  |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.Write("|          |");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("►Voir Carte◄ ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|          | ");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.Write("|                                    ");
                                Console.Write("Retour");
                                Console.WriteLine("                                   |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                varB = "case8";
                            }
                            else if (choixB == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                                Console.WriteLine("|          |Carte : " + commun1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Vie : " + vieC1 + "      |      |             |      |             |          |");
                                Console.WriteLine("|          |Degats : " + degatC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Niveau : " + levelC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          |" + statusC1 + "  |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.Write("|          |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("►Voir Carte◄ ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|          | ");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.Write("|                                    ");
                                Console.Write("Retour");
                                Console.WriteLine("                                   |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                varB = "case9";
                            }
                            else if (choixB == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                                Console.WriteLine("|          |Carte : " + commun1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Vie : " + vieC1 + "      |      |             |      |             |          |");
                                Console.WriteLine("|          |Degats : " + degatC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Niveau : " + levelC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          |" + statusC1 + "  |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.Write("|          |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("►Voir Carte◄ ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("|          | ");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.Write("|                                    ");
                                Console.Write("Retour");
                                Console.WriteLine("                                   |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                varB = "case10";
                            }
                            else if (choixB == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("_________________________________|INVENTAIRE|__________________________________");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|          ┌─────────────┐      ┌─────────────┐      ┌─────────────┐          |");
                                Console.WriteLine("|          |Carte : " + commun1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Vie : " + vieC1 + "      |      |             |      |             |          |");
                                Console.WriteLine("|          |Degats : " + degatC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |Niveau : " + levelC1 + "   |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          |" + statusC1 + "  |      |             |      |             |          |");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.Write("|          |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|      |");
                                Console.Write(" Voir Carte  ");
                                Console.Write("|          | ");
                                Console.WriteLine("|          |             |      |             |      |             |          |");
                                Console.WriteLine("|          └─────────────┘      └─────────────┘      └─────────────┘          |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.Write("|                                  ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("► Retour ◄");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                                 |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("|                                                                             |");
                                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                                varB = "case11";
                            }



                            if (choixB > 3)
                            {
                                choixB = 0;
                            }
                            choixB++;
                        }
                        else if (consoleKey == ConsoleKey.Enter && varB == "case8" || varB == "case11")
                        {
                            break;
                        }
                    }

                    if (varB == "case8")
                    {
                        Console.Clear();
                        Console.WriteLine("┌─────────────────────────────────Inventaire──────────────────────────────────┐");
                        Console.WriteLine("│                                                 Vos pières d'or : " + argent + "         │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│    ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐       │");
                        Console.WriteLine("│  ┌───────────────────────────────────────────────────────────────────────┐  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  │              Informations de carte :                                  │  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  │Personnage : " + commun1 + "                                                        │  │");
                        Console.WriteLine("│  │Vie : " + vieC1 + "                                                               │  │");
                        Console.WriteLine("│  │Degats : " + degatC1 + "                                                             │  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  │Niveau : " + levelC1 + "                                                             │  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  │Cartes accumulées : " + cartesC1 + "/" + maxCartesCN1 + "                                               │  │");
                        Console.WriteLine("│  │Argent nécessaire pour améliorer : " + prixCN1 + " Pierres d'or                    │  │");
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("│  │                             AMELIORER                                 │  │");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("│  │                                                                       │  │");
                        Console.WriteLine("│  └───────────────────────────────────────────────────────────────────────┘  │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("│  Vous ne pouvez pas encore améliorer la carte, donc, c'est partit           │");
                        Console.WriteLine("│                                                                             │");
                        Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                        if (statusC1 == "Dévérouillé")
                        {
                            tuto = "n";
                        }
                    }



                }

                Console.ReadLine();
            }

            //Fin du tutoriel


            levelC1 = 1;
            cartesC1 = 1;
            statusC1 = "Dévérouillé";
            Console.Clear();
            Console.WriteLine("Fin du tutoriel");
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("_______________________________________________________________________________");
                Console.WriteLine("|                                   Menu                                      |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                  Jouer                                      |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                 Boutique                                    |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                Inventaire                                   |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|                                 Coffres                                     |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("-------------------------------------------------------------------------------");

                while (menu == 0)
                {


                    ConsoleKey consoleKey = Console.ReadKey().Key;
                    if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.RightArrow)
                    {

                        if (choix == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                                 ► Jouer ◄                                   |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Boutique                                    |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                Inventaire                                   |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Coffres                                     |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "play";
                        }
                        else if (choix == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                  Jouer                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                                ► Boutique ◄                                 |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                Inventaire                                   |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Coffres                                     |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "shop";
                        }
                        else if (choix == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                  Jouer                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Boutique                                    |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                               ► Inventaire ◄                                |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Coffres                                     |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                        }
                        else if (choix == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("|                                   Menu                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                  Jouer                                      |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Boutique                                    |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                 Inventaire                                  |");
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("|                                                                             |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|                                ► Coffres ◄                                  |");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|                                                                             |");
                            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
                            var = "chest";
                        }
                        if (choix > 3)
                        {
                            choix = 0;
                        }

                        choix++;

                    }
                    else if (consoleKey == ConsoleKey.Enter && var == "play" || var == "shop" || var == "inventory" ||var == "chest")
                    {
                        break;
                    }
                    if (var == "play")
                    {
                        Console.WriteLine("► Jouer au mode de jeu classique");
                    }
                    else if (var == "shop")
                    {
                        Console.WriteLine("► Accèder à la boutique");
                    }
                    else if (var == "inventory")
                    {
                        Console.WriteLine("► Accèder à l'inventaire");
                    }
                    else if (var == "chest")
                    {
                        Console.WriteLine("► Accèder à vos coffres");
                    }
                }
                Console.Clear();
                if (var == "play")
                {
                    unlocked = "verrouillé";
                    /*                                       CHOIX EQUIPE 1                                                                                   */
                    //choix personnage 1 ****************************************************************************************************
                    while (unlocked == "verrouillé")
                    {
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("[1] Equipe 1 : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("[1] Premier personnage : ");

                        for(int i = 0; i < charactersTable.Length;)
                        {
                            for(int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }    
                        personnage1 = Console.ReadLine();
                        if (personnage1 == "1")
                        {
                            personne1 = "roche1";
                            perso1 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage1 == "2")
                        {
                            personne1 = "roche2";
                            perso1 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage1 == "3")
                        {
                            personne1 = "roche3";
                            perso1 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage1 == "4")
                        {
                            personne1 = "pierre1";
                            perso1 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage1 == "5")
                        {
                            personne1 = "pierre2";
                            perso1 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage1 == "6")
                        {
                            personne1 = "pierre3";
                            perso1 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage1 == "7")
                        {
                            personne1 = "rocher1";
                            perso1 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage1 == "8")
                        {
                            personne1 = "rocher2";
                            perso1 = superare2;
                            unlocked = statusSR2;
                        }
                        if (personnage1 == "9")
                        {
                            personne1 = "rocher3";
                            perso1 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage1 == "10")
                        {
                            personne1 = "tank1";
                            perso1 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage1 == "11")
                        {
                            personne1 = "tank2";
                            perso1 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage1 == "12")
                        {
                            personne1 = "tank3";
                            perso1 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage1 == "13")
                        {
                            personne1 = "sniper1";
                            perso1 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage1 == "14")
                        {
                            personne1 = "sniper2";
                            perso1 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage1 == "15")
                        {
                            personne1 = "sniper3";
                            perso1 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage1 == "16")
                        {
                            personne1 = "canon1";
                            perso1 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage1 == "17")
                        {
                            personne1 = "canon2";
                            perso1 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage1 == "18")
                        {
                            personne1 = "canon3";
                            perso1 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage1 == "19")
                        {
                            personne1 = "catapulte1";
                            perso1 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage1 == "20")
                        {
                            personne1 = "catapulte2";
                            perso1 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage1 == "21")
                        {
                            personne1 = "catapulte3";
                            perso1 = misterieuse3;
                            unlocked = statusMS3;
                        }



                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 1
                        switch (personne1)
                        {
                            case "roche1":
                                vie1 = vieC1;
                                degats1 = degatC1;
                                break;

                            case "roche2":
                                vie1 = vieC2;
                                degats1 = degatC2;
                                break;

                            case "roche3":
                                vie1 = vieC3;
                                degats1 = degatC3;
                                break;

                            case "pierre1":
                                vie1 = vieR1;
                                degats1 = degatR1;
                                break;

                            case "pierre2":
                                vie1 = vieR2;
                                degats1 = degatR2;
                                break;

                            case "pierre3":
                                vie1 = vieR3;
                                degats1 = degatR3;
                                break;

                            case "rocher1":
                                vie1 = vieSR1;
                                degats1 = degatSR1;
                                break;

                            case "rocher2":
                                vie1 = vieSR2;
                                degats1 = degatSR2;
                                break;

                            case "rocher3":
                                vie1 = vieSR3;
                                degats1 = degatSR3;
                                break;

                            case "tank1":
                                vie1 = vieE1;
                                degats1 = degatE1;
                                break;

                            case "tank2":
                                vie1 = vieE2;
                                degats1 = degatE2;
                                break;

                            case "tank3":
                                vie1 = vieE3;
                                degats1 = degatE3;
                                break;

                            case "sniper1":
                                vie1 = vieL1;
                                degats1 = degatL1;
                                break;

                            case "sniper2":
                                vie1 = vieL2;
                                degats1 = degatL2;
                                break;

                            case "sniper3":
                                vie1 = vieL3;
                                degats1 = degatL3;
                                break;
                            case "canon1":
                                vie1 = vieM1;
                                degats1 = degatM1;
                                break;

                            case "canon2":
                                vie1 = vieM2;
                                degats1 = degatM2;
                                break;

                            case "canon3":
                                vie1 = vieM3;
                                degats1 = degatM3;
                                break;

                            case "catapulte1":
                                vie1 = vieMS1;
                                degats1 = degatMS1;
                                break;

                            case "catapulte2":
                                vie1 = vieMS2;
                                degats1 = degatMS2;
                                break;

                            case "catapulte3":
                                vie1 = vieMS3;
                                degats1 = degatMS3;
                                break;



                            case "none":
                                vie1 = 0;
                                degats1 = 0;
                                break;
                        }

                        if (unlocked == "Dévérouillé")
                        {
                            Console.Clear();
                            Console.WriteLine("[1] Equipe 1 : ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[1] Premier personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso1 + " \n Nom du personnage : " + personne1 + " \n Vie du personnage : " + vie1 + " \n Dégats du personnage : " + degats1);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    // choix personnage 2 ****************************************************************************************************
                    unlocked = "verrouillé";
                    while (unlocked == "verrouillé")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("[1] Equipe 1 : ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("[2] Second personnage : ");

                        for (int i = 0; i < charactersTable.Length;)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }
                        personnage2 = Console.ReadLine();
                        if (personnage2 == "1")
                        {
                            personne2 = "roche1";
                            perso2 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage2 == "2")
                        {
                            personne2 = "roche2";
                            perso2 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage2 == "3")
                        {
                            personne2 = "roche3";
                            perso2 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage2 == "4")
                        {
                            personne2 = "pierre1";
                            perso2 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage2 == "5")
                        {
                            personne2 = "pierre2";
                            perso2 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage2 == "6")
                        {
                            personne2 = "pierre3";
                            perso2 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage2 == "7")
                        {
                            personne2 = "rocher1";
                            perso2 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage2 == "8")
                        {
                            personne2 = "rocher2";
                            perso2 = superare2;
                            unlocked = statusSR2;
                        }
                        if (personnage2 == "9")
                        {
                            personne2 = "rocher3";
                            perso2 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage2 == "10")
                        {
                            personne2 = "tank1";
                            perso2 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage2 == "11")
                        {
                            personne2 = "tank2";
                            perso2 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage2 == "12")
                        {
                            personne2 = "tank3";
                            perso2 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage2 == "13")
                        {
                            personne2 = "sniper1";
                            perso2 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage2 == "14")
                        {
                            personne2 = "sniper2";
                            perso2 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage2 == "15")
                        {
                            personne2 = "sniper3";
                            perso2 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage2 == "16")
                        {
                            personne2 = "canon1";
                            perso2 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage2 == "17")
                        {
                            personne2 = "canon2";
                            perso2 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage2 == "18")
                        {
                            personne2 = "canon3";
                            perso2 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage2 == "19")
                        {
                            personne2 = "catapulte1";
                            perso2 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage2 == "20")
                        {
                            personne2 = "catapulte2";
                            perso2 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage2 == "21")
                        {
                            personne2 = "catapulte3";
                            perso2 = misterieuse3;
                            unlocked = statusMS3;
                        }

                        if (personne2 == personne1)
                        {
                            if (personne2 == "roche1")
                            {
                                unlocked = statusC1;
                            }
                            else if (personne2 == personne1)
                            {
                                unlocked = "verrouillé";
                            }

                        }
                       

                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 2 ****************************************************************************************************
                        switch (personne2)
                        {
                            case "roche1":
                                vie2 = vieC1;
                                degats2 = degatC1;
                                break;

                            case "roche2":
                                vie2 = vieC2;
                                degats2 = degatC2;
                                break;

                            case "roche3":
                                vie2 = vieC3;
                                degats2 = degatC3;
                                break;

                            case "pierre1":
                                vie2 = vieR1;
                                degats2 = degatR1;
                                break;

                            case "pierre2":
                                vie2 = vieR2;
                                degats2 = degatR2;
                                break;

                            case "pierre3":
                                vie2 = vieR3;
                                degats2 = degatR3;
                                break;

                            case "rocher1":
                                vie2 = vieSR1;
                                degats2 = degatSR1;
                                break;

                            case "rocher2":
                                vie2 = vieSR2;
                                degats2 = degatSR2;
                                break;

                            case "rocher3":
                                vie2 = vieSR3;
                                degats2 = degatSR3;
                                break;

                            case "tank1":
                                vie2 = vieE1;
                                degats2 = degatE1;
                                break;

                            case "tank2":
                                vie2 = vieE2;
                                degats2 = degatE2;
                                break;

                            case "tank3":
                                vie2 = vieE3;
                                degats2 = degatE3;
                                break;

                            case "sniper1":
                                vie2 = vieL1;
                                degats2 = degatL1;
                                break;

                            case "sniper2":
                                vie2 = vieL2;
                                degats2 = degatL2;
                                break;

                            case "sniper3":
                                vie2 = vieL3;
                                degats2 = degatL3;
                                break;
                            case "canon1":
                                vie2 = vieM1;
                                degats2 = degatM1;
                                break;

                            case "canon2":
                                vie2 = vieM2;
                                degats2 = degatM2;
                                break;

                            case "canon3":
                                vie2 = vieM3;
                                degats2 = degatM3;
                                break;

                            case "catapulte1":
                                vie2 = vieMS1;
                                degats2 = degatMS1;
                                break;

                            case "catapulte2":
                                vie2 = vieMS2;
                                degats2 = degatMS2;
                                break;

                            case "catapulte3":
                                vie2 = vieMS3;
                                degats2 = degatMS3;
                                break;



                            case "none":
                                vie2 = 0;
                                degats2 = 0;
                                break;
                        }
                        if (unlocked == "Dévérouillé")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[1] Premier personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso1 + " \n Nom du personnage : " + personne1 + " \n Vie du personnage : " + vie1 + " \n Dégats du personnage : " + degats1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[2] Second personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso2 + " \n Nom du personnage : " + personne2 + " \n Vie du personnage : " + vie2 + " \n Dégats du personnage : " + degats2);

                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    // choix personnage 3 ****************************************************************************************************
                    unlocked = "verrouillé";
                    while (unlocked == "verrouillé")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("[1] Equipe 1 : ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("[3] Troisième personnage : ");

                        for (int i = 0; i < charactersTable.Length;)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }
                        personnage3 = Console.ReadLine();
                        if (personnage3 == "1")
                        {
                            personne3 = "roche1";
                            perso3 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage3 == "2")
                        {
                            personne3 = "roche2";
                            perso3 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage3 == "3")
                        {
                            personne3 = "roche3";
                            perso3 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage3 == "4")
                        {
                            personne3 = "pierre1";
                            perso3 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage3 == "5")
                        {
                            personne3 = "pierre2";
                            perso3 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage3 == "6")
                        {
                            personne3 = "pierre3";
                            perso3 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage3 == "7")
                        {
                            personne3 = "rocher1";
                            perso3 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage3 == "8")
                        {
                            personne3 = "rocher2";
                            perso3 = superare2;
                            unlocked = statusSR2;
                        }
                        else if (personnage3 == "9")
                        {
                            personne3 = "rocher3";
                            perso3 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage3 == "10")
                        {
                            personne3 = "tank1";
                            perso3 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage3 == "11")
                        {
                            personne3 = "tank2";
                            perso3 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage3 == "12")
                        {
                            personne3 = "tank3";
                            perso3 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage3 == "13")
                        {
                            personne3 = "sniper1";
                            perso3 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage3 == "14")
                        {
                            personne3 = "sniper2";
                            perso3 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage3 == "15")
                        {
                            personne3 = "sniper3";
                            perso3 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage3 == "16")
                        {
                            personne3 = "canon1";
                            perso3 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage3 == "17")
                        {
                            personne3 = "canon2";
                            perso3 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage3 == "18")
                        {
                            personne3 = "canon3";
                            perso3 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage3 == "19")
                        {
                            personne3 = "catapulte1";
                            perso3 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage3 == "20")
                        {
                            personne3 = "catapulte2";
                            perso3 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage3 == "21")
                        {
                            personne3 = "catapulte3";
                            perso3 = misterieuse3;
                            unlocked = statusMS3;
                        }

                        if (personne3 == personne1 || personne3 == personne2)
                        {
                            if (personne3 == "roche1")
                            {
                                unlocked = statusC1;
                            }
                            else if (personne3 == personne1 ||personne3 == personne2)
                            {
                                unlocked = "verrouillé";
                            }

                        }


                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 3 ****************************************************************************************************
                        switch (personne3)
                        {
                            case "roche1":
                                vie3 = vieC1;
                                degats3 = degatC1;
                                break;

                            case "roche2":
                                vie3 = vieC2;
                                degats3 = degatC2;
                                break;

                            case "roche3":
                                vie3 = vieC3;
                                degats3 = degatC3;
                                break;

                            case "pierre1":
                                vie3 = vieR1;
                                degats3 = degatR1;
                                break;

                            case "pierre2":
                                vie3 = vieR2;
                                degats3 = degatR2;
                                break;

                            case "pierre3":
                                vie3 = vieR3;
                                degats3 = degatR3;
                                break;

                            case "rocher1":
                                vie3 = vieSR1;
                                degats3 = degatSR1;
                                break;

                            case "rocher2":
                                vie3 = vieSR2;
                                degats3 = degatSR2;
                                break;

                            case "rocher3":
                                vie3 = vieSR3;
                                degats3 = degatSR3;
                                break;

                            case "tank1":
                                vie3 = vieE1;
                                degats3 = degatE1;
                                break;

                            case "tank2":
                                vie3 = vieE2;
                                degats3 = degatE2;
                                break;

                            case "tank3":
                                vie3 = vieE3;
                                degats3 = degatE3;
                                break;

                            case "sniper1":
                                vie3 = vieL1;
                                degats3 = degatL1;
                                break;

                            case "sniper2":
                                vie3 = vieL2;
                                degats3 = degatL2;
                                break;

                            case "sniper3":
                                vie3 = vieL3;
                                degats3 = degatL3;
                                break;
                            case "canon1":
                                vie3 = vieM1;
                                degats3 = degatM1;
                                break;

                            case "canon2":
                                vie3 = vieM2;
                                degats3 = degatM2;
                                break;

                            case "canon3":
                                vie3 = vieM3;
                                degats3 = degatM3;
                                break;

                            case "catapulte1":
                                vie3 = vieMS1;
                                degats3 = degatMS1;
                                break;

                            case "catapulte2":
                                vie3 = vieMS2;
                                degats3 = degatMS2;
                                break;

                            case "catapulte3":
                                vie3 = vieMS3;
                                degats3 = degatMS3;
                                break;



                            case "none":
                                vie3 = 0;
                                degats3 = 0;
                                break;
                        }
                        if (unlocked == "Dévérouillé")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[1] Premier personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso1 + " \n Nom du personnage : " + personne1 + " \n Vie du personnage : " + vie1 + " \n Dégats du personnage : " + degats1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[2] Second personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso2 + " \n Nom du personnage : " + personne2 + " \n Vie du personnage : " + vie2 + " \n Dégats du personnage : " + degats2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[3] Troisième personnage : ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" \n Style du personnage : " + perso3 + " \n Nom du personnage : " + personne3 + " \n Vie du personnage : " + vie3 + " \n Dégats du personnage : " + degats3);

                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                    /*                                       CHOIX EQUIPE 2                                                                                   */
                    //choix personnage 4 ****************************************************************************************************
                    unlocked = "verrouillé";
                    while (unlocked == "verrouillé")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[1] Equipe 2 : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("[1] premier personnage : ");

                        for (int i = 0; i < charactersTable.Length;)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }
                        personnage4 = Console.ReadLine();
                        if (personnage4 == "1")
                        {
                            personne4 = "roche1";
                            perso4 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage4 == "2")
                        {
                            personne4 = "roche2";
                            perso4 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage4 == "3")
                        {
                            personne4 = "roche3";
                            perso4 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage4 == "4")
                        {
                            personne4 = "pierre1";
                            perso4 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage4 == "5")
                        {
                            personne4 = "pierre2";
                            perso4 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage4 == "6")
                        {
                            personne4 = "pierre3";
                            perso4 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage4 == "7")
                        {
                            personne4 = "rocher1";
                            perso4 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage4 == "8")
                        {
                            personne4 = "rocher2";
                            perso4 = superare2;
                            unlocked = statusSR2;
                        }
                        else if (personnage4 == "9")
                        {
                            personne4 = "rocher3";
                            perso4 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage4 == "10")
                        {
                            personne4 = "tank1";
                            perso4 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage4 == "11")
                        {
                            personne4 = "tank2";
                            perso4 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage4 == "12")
                        {
                            personne4 = "tank3";
                            perso4 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage4 == "13")
                        {
                            personne4 = "sniper1";
                            perso4 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage4 == "14")
                        {
                            personne4 = "sniper2";
                            perso4 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage4 == "15")
                        {
                            personne4 = "sniper3";
                            perso4 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage4 == "16")
                        {
                            personne4 = "canon1";
                            perso4 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage4 == "17")
                        {
                            personne4 = "canon2";
                            perso4 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage4 == "18")
                        {
                            personne4 = "canon3";
                            perso4 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage4 == "19")
                        {
                            personne4 = "catapulte1";
                            perso4 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage4 == "20")
                        {
                            personne4 = "catapulte2";
                            perso4 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage4 == "21")
                        {
                            personne4 = "catapulte3";
                            perso4 = misterieuse3;
                            unlocked = statusMS3;
                        }



                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 4 ****************************************************************************************************
                        switch (personne4)
                        {
                            case "roche1":
                                vie4 = vieC1;
                                degats4 = degatC1;
                                break;

                            case "roche2":
                                vie4 = vieC2;
                                degats4 = degatC2;
                                break;

                            case "roche3":
                                vie4 = vieC3;
                                degats4 = degatC3;
                                break;

                            case "pierre1":
                                vie4 = vieR1;
                                degats4 = degatR1;
                                break;

                            case "pierre2":
                                vie4 = vieR2;
                                degats4 = degatR2;
                                break;

                            case "pierre3":
                                vie4 = vieR3;
                                degats4 = degatR3;
                                break;

                            case "rocher1":
                                vie4 = vieSR1;
                                degats4 = degatSR1;
                                break;

                            case "rocher2":
                                vie4 = vieSR2;
                                degats4 = degatSR2;
                                break;

                            case "rocher3":
                                vie4 = vieSR3;
                                degats4 = degatSR3;
                                break;

                            case "tank1":
                                vie4 = vieE1;
                                degats4 = degatE1;
                                break;

                            case "tank2":
                                vie4 = vieE2;
                                degats4 = degatE2;
                                break;

                            case "tank3":
                                vie4 = vieE3;
                                degats4 = degatE3;
                                break;

                            case "sniper1":
                                vie4 = vieL1;
                                degats4 = degatL1;
                                break;

                            case "sniper2":
                                vie4 = vieL2;
                                degats4 = degatL2;
                                break;

                            case "sniper3":
                                vie4 = vieL3;
                                degats4 = degatL3;
                                break;
                            case "canon1":
                                vie4 = vieM1;
                                degats4 = degatM1;
                                break;

                            case "canon2":
                                vie4 = vieM2;
                                degats4 = degatM2;
                                break;

                            case "canon3":
                                vie4 = vieM3;
                                degats4 = degatM3;
                                break;

                            case "catapulte1":
                                vie4 = vieMS1;
                                degats4 = degatMS1;
                                break;

                            case "catapulte2":
                                vie4 = vieMS2;
                                degats4 = degatMS2;
                                break;

                            case "catapulte3":
                                vie4 = vieMS3;
                                degats4 = degatMS3;
                                break;



                            case "none":
                                vie4 = 0;
                                degats4 = 0;
                                break;
                        }
                        if (unlocked == "Dévérouillé")
                        {
                            Console.WriteLine(" \n Style du personnage : " + perso4 + " \n Nom du personnage : " + personne4 + " \n Vie du personnage : " + vie4 + " \n Dégats du personnage : " + degats4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    // choix personnage 5 ****************************************************************************************************
                    unlocked = "verrouillé";
                    while (unlocked == "verrouillé")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[1] Equipe 2 : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("[2] Second personnage : ");

                        for (int i = 0; i < charactersTable.Length;)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }
                        personnage5 = Console.ReadLine();
                        if (personnage5 == "1")
                        {
                            personne5 = "roche1";
                            perso5 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage5 == "2")
                        {
                            personne5 = "roche2";
                            perso5 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage5 == "3")
                        {
                            personne5 = "roche3";
                            perso5 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage5 == "4")
                        {
                            personne5 = "pierre1";
                            perso5 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage5 == "5")
                        {
                            personne5 = "pierre2";
                            perso5 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage5 == "6")
                        {
                            personne5 = "pierre3";
                            perso5 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage5 == "7")
                        {
                            personne5 = "rocher1";
                            perso5 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage5 == "8")
                        {
                            personne5 = "rocher2";
                            perso5 = superare2;
                            unlocked = statusSR2;
                        }
                        else if (personnage5 == "9")
                        {
                            personne5 = "rocher3";
                            perso5 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage5 == "10")
                        {
                            personne5 = "tank1";
                            perso5 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage5 == "11")
                        {
                            personne5 = "tank2";
                            perso5 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage5 == "12")
                        {
                            personne5 = "tank3";
                            perso5 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage5 == "13")
                        {
                            personne5 = "sniper1";
                            perso5 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage5 == "14")
                        {
                            personne5 = "sniper2";
                            perso5 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage5 == "15")
                        {
                            personne5 = "sniper3";
                            perso5 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage5 == "16")
                        {
                            personne5 = "canon1";
                            perso5 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage5 == "17")
                        {
                            personne5 = "canon2";
                            perso5 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage5 == "18")
                        {
                            personne5 = "canon3";
                            perso5 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage5 == "19")
                        {
                            personne5 = "catapulte1";
                            perso5 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage5 == "20")
                        {
                            personne5 = "catapulte2";
                            perso5 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage5 == "21")
                        {
                            personne5 = "catapulte3";
                            perso5 = misterieuse3;
                            unlocked = statusMS3;
                        }



                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 5 ****************************************************************************************************
                        switch (personne5)
                        {
                            case "roche1":
                                vie5 = vieC1;
                                degats5 = degatC1;
                                break;

                            case "roche2":
                                vie5 = vieC2;
                                degats5 = degatC2;
                                break;

                            case "roche3":
                                vie5 = vieC3;
                                degats5 = degatC3;
                                break;

                            case "pierre1":
                                vie5 = vieR1;
                                degats5 = degatR1;
                                break;

                            case "pierre2":
                                vie5 = vieR2;
                                degats5 = degatR2;
                                break;

                            case "pierre3":
                                vie5 = vieR3;
                                degats5 = degatR3;
                                break;

                            case "rocher1":
                                vie5 = vieSR1;
                                degats5 = degatSR1;
                                break;

                            case "rocher2":
                                vie5 = vieSR2;
                                degats5 = degatSR2;
                                break;

                            case "rocher3":
                                vie5 = vieSR3;
                                degats5 = degatSR3;
                                break;

                            case "tank1":
                                vie5 = vieE1;
                                degats5 = degatE1;
                                break;

                            case "tank2":
                                vie5 = vieE2;
                                degats5 = degatE2;
                                break;

                            case "tank3":
                                vie5 = vieE3;
                                degats5 = degatE3;
                                break;

                            case "sniper1":
                                vie5 = vieL1;
                                degats5 = degatL1;
                                break;

                            case "sniper2":
                                vie5 = vieL2;
                                degats5 = degatL2;
                                break;

                            case "sniper3":
                                vie5 = vieL3;
                                degats5 = degatL3;
                                break;
                            case "canon1":
                                vie5 = vieM1;
                                degats5 = degatM1;
                                break;

                            case "canon2":
                                vie5 = vieM2;
                                degats5 = degatM2;
                                break;

                            case "canon3":
                                vie5 = vieM3;
                                degats5 = degatM3;
                                break;

                            case "catapulte1":
                                vie5 = vieMS1;
                                degats5 = degatMS1;
                                break;

                            case "catapulte2":
                                vie5 = vieMS2;
                                degats5 = degatMS2;
                                break;

                            case "catapulte3":
                                vie5 = vieMS3;
                                degats5 = degatMS3;
                                break;



                            case "none":
                                vie5 = 0;
                                degats5 = 0;
                                break;
                        }
                        if (unlocked == "Dévérouillé")
                        {
                            Console.WriteLine("[1] Premier personnage : ");
                            Console.WriteLine(" \n Style du personnage : " + perso4 + " \n Nom du personnage : " + personne4 + " \n Vie du personnage : " + vie4 + " \n Dégats du personnage : " + degats4);
                            Console.WriteLine("[2] Second personnage : ");
                            Console.WriteLine(" \n Style du personnage : " + perso5 + " \n Nom du personnage : " + personne5 + " \n Vie du personnage : " + vie5 + " \n Dégats du personnage : " + degats5);

                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    // choix personnage 6 ****************************************************************************************************
                    unlocked = "verrouillé";
                    while (unlocked == "verrouillé")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[1] Equipe 2 : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Choisir un premier personnage : ");

                        for (int i = 0; i < charactersTable.Length;)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                if (i < 9)
                                {
                                    Console.Write(i + 1 + " ¦ " + charactersTable[i] + " │");
                                }
                                else
                                {
                                    Console.Write(i + 1 + "¦ " + charactersTable[i] + " │");
                                }
                                i++;
                            }
                            Console.WriteLine();
                        }
                        personnage6 = Console.ReadLine();
                        if (personnage6 == "1")
                        {
                            personne6 = "roche1";
                            perso6 = commun1;
                            unlocked = statusC1;
                        }
                        else if (personnage6 == "2")
                        {
                            personne6 = "roche2";
                            perso6 = commun2;
                            unlocked = statusC2;
                        }
                        else if (personnage6 == "3")
                        {
                            personne6 = "roche3";
                            perso6 = commun3;
                            unlocked = statusC3;
                        }
                        else if (personnage6 == "4")
                        {
                            personne6 = "pierre1";
                            perso6 = rare1;
                            unlocked = statusR1;
                        }
                        else if (personnage6 == "5")
                        {
                            personne6 = "pierre2";
                            perso6 = rare2;
                            unlocked = statusR2;
                        }
                        else if (personnage6 == "6")
                        {
                            personne6 = "pierre3";
                            perso6 = rare3;
                            unlocked = statusR3;
                        }
                        else if (personnage6 == "7")
                        {
                            personne6 = "rocher1";
                            perso6 = superare1;
                            unlocked = statusSR1;
                        }
                        else if (personnage6 == "8")
                        {
                            personne6 = "rocher2";
                            perso6 = superare2;
                            unlocked = statusSR2;
                        }
                        else if (personnage6 == "9")
                        {
                            personne6 = "rocher3";
                            perso6 = superare3;
                            unlocked = statusSR3;
                        }
                        else if (personnage6 == "10")
                        {
                            personne6 = "tank1";
                            perso6 = epique1;
                            unlocked = statusE1;
                        }
                        else if (personnage6 == "11")
                        {
                            personne6 = "tank2";
                            perso6 = epique2;
                            unlocked = statusE2;
                        }
                        else if (personnage6 == "12")
                        {
                            personne6 = "tank3";
                            perso6 = epique3;
                            unlocked = statusE3;
                        }
                        else if (personnage6 == "13")
                        {
                            personne6 = "sniper1";
                            perso6 = Legendaire1;
                            unlocked = statusL1;
                        }
                        else if (personnage6 == "14")
                        {
                            personne6 = "sniper2";
                            perso6 = Legendaire2;
                            unlocked = statusL2;
                        }
                        else if (personnage6 == "15")
                        {
                            personne6 = "sniper3";
                            perso6 = Legendaire3;
                            unlocked = statusL3;
                        }
                        else if (personnage6 == "16")
                        {
                            personne6 = "canon1";
                            perso6 = Mytique1;
                            unlocked = statusM1;
                        }
                        else if (personnage6 == "17")
                        {
                            personne6 = "canon2";
                            perso6 = Mytique2;
                            unlocked = statusM2;
                        }
                        else if (personnage6 == "18")
                        {
                            personne6 = "canon3";
                            perso6 = Mytique3;
                            unlocked = statusM3;
                        }
                        else if (personnage6 == "19")
                        {
                            personne6 = "catapulte1";
                            perso6 = misterieuse1;
                            unlocked = statusMS1;
                        }
                        else if (personnage6 == "20")
                        {
                            personne6 = "catapulte2";
                            perso6 = misterieuse2;
                            unlocked = statusMS2;
                        }
                        else if (personnage6 == "21")
                        {
                            personne6 = "catapulte3";
                            perso6 = misterieuse3;
                            unlocked = "Dévérouillée";
                        }



                        else if (unlocked == "verrouillé")
                        {
                            Console.WriteLine("Vous n'avez pas débloqué ce personnage ou n'avez pas saisi un nombre correct. [ENTER]");
                            Console.ReadLine();
                            Console.WriteLine("Veuillez choisir à nouveau votre premier personnage. [ENTER]");
                            Console.ReadLine();
                            unlocked = "verrouillé";
                        }

                        //switch perso 6
                        switch (personne6)
                        {
                            case "roche1":
                                vie6 = vieC1;
                                degats6 = degatC1;
                                break;

                            case "roche2":
                                vie6 = vieC2;
                                degats6 = degatC2;
                                break;

                            case "roche3":
                                vie6 = vieC3;
                                degats6 = degatC3;
                                break;

                            case "pierre1":
                                vie6 = vieR1;
                                degats6 = degatR1;
                                break;

                            case "pierre2":
                                vie6 = vieR2;
                                degats6 = degatR2;
                                break;

                            case "pierre3":
                                vie6 = vieR3;
                                degats6 = degatR3;
                                break;

                            case "rocher1":
                                vie6 = vieSR1;
                                degats6 = degatSR1;
                                break;

                            case "rocher2":
                                vie6 = vieSR2;
                                degats6 = degatSR2;
                                break;

                            case "rocher3":
                                vie6 = vieSR3;
                                degats6 = degatSR3;
                                break;

                            case "tank1":
                                vie6 = vieE1;
                                degats6 = degatE1;
                                break;

                            case "tank2":
                                vie6 = vieE2;
                                degats6 = degatE2;
                                break;

                            case "tank3":
                                vie6 = vieE3;
                                degats6 = degatE3;
                                break;

                            case "sniper1":
                                vie6 = vieL1;
                                degats6 = degatL1;
                                break;

                            case "sniper2":
                                vie6 = vieL2;
                                degats6 = degatL2;
                                break;

                            case "sniper3":
                                vie6 = vieL3;
                                degats6 = degatL3;
                                break;
                            case "canon1":
                                vie6 = vieM1;
                                degats6 = degatM1;
                                break;

                            case "canon2":
                                vie6 = vieM2;
                                degats6 = degatM2;
                                break;

                            case "canon3":
                                vie6 = vieM3;
                                degats6 = degatM3;
                                break;

                            case "catapulte1":
                                vie6 = vieMS1;
                                degats6 = degatMS1;
                                break;

                            case "catapulte2":
                                vie6 = vieMS2;
                                degats6 = degatMS2;
                                break;

                            case "catapulte3":
                                vie6 = vieMS3;
                                degats6 = degatMS3;
                                break;



                            case "none":
                                vie6 = 0;
                                degats6 = 0;
                                break;
                        }
                        if (unlocked == "Dévérouillé")
                        {
                            Console.WriteLine("Premier personnage : ");
                            Console.WriteLine(" \n Style du personnage : " + perso1 + " \n Nom du personnage : " + personne1 + " \n Vie du personnage : " + vie1 + " \n Dégats du personnage : " + degats1);
                            Console.WriteLine("Premier personnage : ");
                            Console.WriteLine(" \n Style du personnage : " + perso2 + " \n Nom du personnage : " + personne2 + " \n Vie du personnage : " + vie2 + " \n Dégats du personnage : " + degats2);
                            Console.WriteLine("Premier personnage : ");
                            Console.WriteLine(" \n Style du personnage : " + perso3 + " \n Nom du personnage : " + personne3 + " \n Vie du personnage : " + vie3 + " \n Dégats du personnage : " + degats3);

                            Console.ReadLine();
                            Console.Clear();
                        }
                    }





                    //combat ----------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    while (viegen1 >= 1)
                    {
                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;

                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        
                            if (vie1 >= 1)
                            {
                                Console.Write(perso1 + " va attaquer, [*joueur1*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                                do
                                {   
                                    int.TryParse(Console.ReadLine(), out choix1);
                                } while (choix1 > 3 || choix1 < 1);

                                if (choix1 == 1)
                                {
                                    vie4 = vie4 - degats1;
                                    if (vie4 <= 0)
                                    {
                                        vie4 = 0;
                                    }
                                }
                                else if (choix1 == 2)
                                {
                                    vie5 = vie5 - degats1;
                                    if (vie5 <= 0)
                                    {
                                        vie5 = 0;
                                    }
                                }
                                else if (choix1 == 3)
                                {
                                    vie6 = vie6 - degats1;
                                    if (vie6 <= 0)
                                    {
                                        vie6 = 0;
                                    }
                                }
                            
                            else if (vie1 <= 0)
                            {
                                vie1 = 0;
                                Console.WriteLine("\nVotre personnage : " + perso1 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                                Console.ReadLine();
                            }
                            if (viegen1 <= 0)
                            {
                                Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                                Console.ReadLine();
                                break;
                            }
                            else if (viegen2 <= 0)
                            {
                                Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                                Console.ReadLine();
                                break;
                            }
                        }

                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;
                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        if (vie4 >= 1)
                        {
                            Console.WriteLine(perso4 + " va attaquer, [*joueur2*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                            do
                            {
                                int.TryParse(Console.ReadLine(), out choix1);
                            } while (choix1 > 3 || choix1 < 1);

                            if (choix1 == 1)
                            {
                                vie1 = vie1 - degats4;
                                if (vie1 <= 0)
                                {
                                    vie1 = 0;
                                }
                            }
                            else if (choix1 == 2)
                            {
                                vie2 = vie2 - degats4;
                                if (vie2 <= 0)
                                {
                                    vie2 = 0;
                                }
                            }
                            else if (choix1 == 3)
                            {
                                vie3 = vie3 - degats4;
                                if (vie3 <= 0)
                                {
                                    vie3 = 0;
                                }
                            }
                        }
                        else if (vie4 <= 0)
                        {
                            Console.WriteLine("Votre personnage : " + perso4 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                            Console.ReadLine();
                        }
                        if (viegen1 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }
                        else if (viegen2 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }

                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;
                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        if (vie2 >= 1)
                        {
                            Console.WriteLine(perso2 + " va attaquer, [*joueur1*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                            do
                            {
                                int.TryParse(Console.ReadLine(), out choix1);
                            } while (choix1 > 3 || choix1 < 1);
                            if (choix1 == 1)
                            {
                                vie4 = vie4 - degats2;
                                if (vie4 <= 0)
                                {
                                    vie4 = 0;
                                }
                            }
                            else if (choix1 == 2)
                            {
                                vie5 = vie5 - degats2;
                                if (vie5 <= 0)
                                {
                                    vie5 = 0;
                                }
                            }
                            else if (choix1 == 3)
                            {
                                vie6 = vie6 - degats2;
                                if (vie6 <= 0)
                                {
                                    vie6 = 0;
                                }
                            }
                        }
                        else if (vie2 <= 0)
                        {
                            Console.WriteLine("Votre personnage : " + perso2 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                            Console.ReadLine();
                        }
                        if (viegen1 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }
                        else if (viegen2 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }

                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;
                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        if (vie5 >= 1)
                        {
                            Console.WriteLine(perso5 + " va attaquer, [*joueur2*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                            do
                            {
                                int.TryParse(Console.ReadLine(), out choix1);
                            } while (choix1 > 3 || choix1 < 1);
                            if (choix1 == 1)
                            {
                                vie1 = vie1 - degats5;
                                if (vie1 <= 0)
                                {
                                    vie1 = 0;
                                }
                            }
                            else if (choix1 == 2)
                            {
                                vie2 = vie2 - degats5;
                                if (vie2 <= 0)
                                {
                                    vie2 = 0;
                                }
                            }
                            else if (choix1 == 3)
                            {
                                vie3 = vie3 - degats5;
                                if (vie3 <= 0)
                                {
                                    vie3 = 0;
                                }
                            }
                        }
                        else if (vie5 <= 0)
                        {
                            Console.WriteLine("Votre personnage : " + perso5 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                            Console.ReadLine();
                        }
                        if (viegen1 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }
                        else if (viegen2 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }

                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;
                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        if (vie3 >= 1)
                        {
                            Console.WriteLine(perso3 + " va attaquer, [*joueur1*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                            do
                            {
                                int.TryParse(Console.ReadLine(), out choix1);
                            } while (choix1 > 3 || choix1 < 1);
                            if (choix1 == 1)
                            {
                                vie4 = vie4 - degats3;
                                if (vie4 <= 0)
                                {
                                    vie4 = 0;
                                }
                            }
                            else if (choix1 == 2)
                            {
                                vie5 = vie5 - degats3;
                                if (vie5 <= 0)
                                {
                                    vie5 = 0;
                                }
                            }
                            else if (choix1 == 3)
                            {
                                vie6 = vie6 - degats3;
                                if (vie6 <= 0)
                                {
                                    vie6 = 0;
                                }
                            }
                        }
                        else if (vie3 <= 0)
                        {
                            Console.WriteLine("Votre personnage : " + perso3 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                            Console.ReadLine();
                        }
                        if (viegen1 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }
                        else if (viegen2 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }

                        viegen1 = vie1 + vie2 + vie3;
                        viegen2 = vie4 + vie5 + vie6;
                        Console.Clear();
                        Console.WriteLine("       EQUIPE 1 :" + viegen1 + "                                                   " + viegen2 + ": EQUIPE 2        ");
                        Console.WriteLine("vie : " + vie1 + "                                                                  " + vie4 + " : vie");
                        Console.WriteLine("dégats : " + degats1 + " " + perso1 + "                                             " + perso4 + " " + degats4 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie2 + "                                                                  " + vie5 + " : vie");
                        Console.WriteLine("dégats : " + degats2 + " " + perso2 + "                                             " + perso5 + " " + degats5 + " : dégats");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("vie : " + vie3 + "                                                                  " + vie6 + " : vie");
                        Console.WriteLine("dégats : " + degats3 + " " + perso3 + "                                             " + perso6 + " " + degats6 + " : dégats");
                        Console.WriteLine("<------------------------------------------------------------------------------>");
                        if (vie5 >= 1)
                        {
                            Console.WriteLine(perso6 + " va attaquer, [*joueur2*] qui voulez vous attaquer dans l'équipe d'en face ? \n[ 1 / 2 / 3 ]");
                            do
                            {
                                int.TryParse(Console.ReadLine(), out choix1);
                            } while (choix1 > 3 || choix1 < 1);
                            if (choix1 == 1)
                            {
                                vie1 = vie1 - degats6;
                                if (vie1 <= 0)
                                {
                                    vie1 = 0;
                                }
                            }
                            else if (choix1 == 2)
                            {
                                vie2 = vie2 - degats6;
                                if (vie2 <= 0)
                                {
                                    vie2 = 0;
                                }
                            }
                            else if (choix1 == 3)
                            {
                                vie3 = vie3 - degats6;
                                if (vie3 <= 0)
                                {
                                    vie3 = 0;
                                }
                            }
                        }
                        else if (vie6 <= 0)
                        {
                            Console.WriteLine("Votre personnage : " + perso6 + " n'a plus de point de vie. vous ne pourrez donc pas attaquer ce tour.");
                            Console.ReadLine();
                        }

                        if (viegen1 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 2, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }
                        else if (viegen2 <= 0)
                        {
                            Console.WriteLine("Victoire de l'équipe 1, BIEN JOUÉ");
                            Console.ReadLine();
                            break;
                        }






                    }//while

                    Console.WriteLine("Bravo, vous avez fini votre première partie. Vous pouvez maintenant jouer comme vous le souhaiter.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Parties à 2 en local [DÉBLOQUÉES]");
                    Thread.Sleep(1000);
                    Console.WriteLine("Boutique [DÉBLOQUÉE]");
                    Thread.Sleep(1000);
                    Console.WriteLine("Argent et améliorations de personnages [DÉBLOQUÉES]");
                    Thread.Sleep(1000);
                    Console.WriteLine("A chaque fin de partie vous recevrez un coffre. Allez le chercher dans l'onglet *coffres* au menu.");
                    Console.ReadLine();
                    chest++;
                }
                else if (var == "shop")
                {
                    Console.WriteLine("Le mode jouer, n'est pas encore disponible, finissez le tutoriel pour commencer !");
                }
                else if (var == "inventory")
                {
                    Console.WriteLine("Le mode jouer, n'est pas encore disponible, finissez le tutoriel pour commencer !");
                }
                else if (var == "chest")
                {

                    Console.WriteLine("Vous avez " + chest + " coffres");
                    Console.ReadLine();
                    if (chest == 0)
                    {

                    }
                    else if (chest > 0)
                    {
                        
                        chest--;
                        Random aleatoire = new Random();
                        int coffre = aleatoire.Next(1, 1001);
                        int carte = aleatoire.Next(1, 1001);

                        int ArgentVC = aleatoire.Next(112, 303);
                        int ArgentCR = aleatoire.Next(268, 541);
                        int ArgentCL = aleatoire.Next(500, 763);
                        int ArgentCR2 = aleatoire.Next(688, 923);
                        int ArgentCD = aleatoire.Next(811, 1001);
                        int loot = aleatoire.Next(0, 999);

                        int nbCartesC = aleatoire.Next(8, 45);
                        int nbCartesR = aleatoire.Next(5, 34);
                        int nbCartesSR = aleatoire.Next(4, 27);
                        int nbCartesE = aleatoire.Next(3, 15);
                        int nbCartesL = aleatoire.Next(2, 7);
                        int nbCartesM = aleatoire.Next(1, 2);
                        int nbCartesMS = aleatoire.Next(1, 1);

                        if (coffre <= 550)
                        {//coffre

                            nom = "Vieux coffret";
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            //carte--------------
                            ArgentC = ArgentVC;
                            if (carte <= 700)
                            {
                                cartename = "commun";
                                cartenum = 1;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = commun1;
                                    cartesC1 = cartesC1 + nbCartesC;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = commun2;
                                    cartesC2 = cartesC2 + nbCartesC;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = commun3;
                                    cartesC2 = cartesC2 + nbCartesC;
                                }
                            }
                            else if (carte <= 950)
                            {
                                cartename = "rare";
                                cartenum = 2;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = rare1;
                                    cartesR1 = cartesR1 + nbCartesR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = rare2;
                                    cartesR2 = cartesR2 + nbCartesR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = rare3;
                                    cartesR3 = cartesR3 + nbCartesR;
                                }
                            }
                            else if (carte <= 1000)
                            {
                                cartename = "super rare";
                                cartenum = 3;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = superare1;
                                    cartesSR1 = cartesSR1 + nbCartesSR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = superare2;
                                    cartesSR2 = cartesSR2 + nbCartesSR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = superare3;
                                    cartesSR3 = cartesSR3 + nbCartesSR;
                                }
                            }
                        }
                        else if (coffre <= 700)
                        {//coffre
                            nom = "Coffre renforcé";
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            //carte

                            ArgentC = ArgentCR;
                            if (carte <= 550)
                            {
                                cartename = "commun";
                                cartenum = 1;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = commun1;
                                    cartesC1 = cartesC1 + nbCartesC;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = commun2;
                                    cartesC2 = cartesC2 + nbCartesC;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = commun2;
                                    cartesC3 = cartesC3 + nbCartesC;
                                }
                            }
                            else if (carte <= 850)
                            {
                                cartename = "rare";
                                cartenum = 2;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = rare1;
                                    cartesR1 = cartesR1 + nbCartesR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = rare2;
                                    cartesR2 = cartesR2 + nbCartesR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = rare3;
                                    cartesR3 = cartesR3 + nbCartesR;
                                }
                            }
                            else if (carte <= 950)
                            {
                                cartename = "super rare";
                                cartenum = 3;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = superare1;
                                    cartesSR1 = cartesSR1 + nbCartesSR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = superare2;
                                    cartesSR2 = cartesSR2 + nbCartesSR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = superare3;
                                    cartesSR3 = cartesSR3 + nbCartesSR;
                                }
                            }
                            else if (carte <= 1000)
                            {
                                cartename = "épique";
                                cartenum = 4;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = epique1;
                                    cartesE1 = cartesE1 + nbCartesE;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = epique2;
                                    cartesE2 = cartesE2 + nbCartesE;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = epique3;
                                    cartesE3 = cartesE3 + nbCartesE;
                                }
                            }
                        }
                        else if (coffre <= 850)
                        {//coffre
                            nom = "Coffre lumineux";
                            Console.ForegroundColor = ConsoleColor.Green;
                            //carte

                            ArgentC = ArgentCL;
                            if (carte <= 400)
                            {
                                cartename = "commun";
                                cartenum = 1;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = commun1;
                                    cartesC1 = cartesC1 + nbCartesC;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = commun2;
                                    cartesC2 = cartesC2 + nbCartesC;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = commun2;
                                    cartesC3 = cartesC3 + nbCartesC;
                                }
                            }
                            else if (carte <= 600)
                            {
                                cartename = "rare";
                                cartenum = 2;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = rare1;
                                    cartesR1 = cartesR1 + nbCartesR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = rare2;
                                    cartesR2 = cartesR2 + nbCartesR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = rare3;
                                    cartesR3 = cartesR3 + nbCartesR;
                                }
                            }
                            else if (carte <= 800)
                            {
                                cartename = "super rare";
                                cartenum = 3;
                                if (loot <= 333)
                                {
                                    lootbox = superare1;
                                    cartesSR1 = cartesSR1 + nbCartesSR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = superare2;
                                    cartesSR2 = cartesSR2 + nbCartesSR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = superare3;
                                    cartesSR3 = cartesSR3 + nbCartesSR;
                                }
                            }
                            else if (carte <= 950)
                            {
                                cartename = "épique";
                                cartenum = 4;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = epique1;
                                    cartesE1 = cartesE1 + nbCartesE;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = epique2;
                                    cartesE2 = cartesE2 + nbCartesE;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = epique3;
                                    cartesE3 = cartesE3 + nbCartesE;
                                }
                            }
                            else if (carte <= 1000)
                            {
                                cartename = "légendaire";
                                cartenum = 5;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = Legendaire1;
                                    cartesL1 = cartesL1 + nbCartesL;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = Legendaire2;
                                    cartesL2 = cartesL2 + nbCartesL;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = Legendaire3;
                                    cartesL3 = cartesL3 + nbCartesL;
                                }
                            }
                        }
                        else if (coffre <= 950)
                        {//coffre
                            nom = "Coffre royal";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            //carte
                            ArgentC = ArgentCR2;
                            if (carte <= 300)
                            {
                                cartename = "rare";
                                cartenum = 2;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = rare1;
                                    cartesR1 = cartesR1 + nbCartesR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = rare2;
                                    cartesR2 = cartesR2 + nbCartesR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = rare3;
                                    cartesR3 = cartesR3 + nbCartesR;
                                }
                            }
                            else if (carte <= 550)
                            {
                                cartename = "super rare";
                                cartenum = 3;
                                if (loot <= 333)
                                {
                                    lootbox = superare1;
                                    cartesSR1 = cartesSR1 + nbCartesSR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = superare2;
                                    cartesSR2 = cartesSR2 + nbCartesSR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = superare3;
                                    cartesSR3 = cartesSR3 + nbCartesSR;
                                }
                            }
                            else if (carte <= 850)
                            {
                                cartename = "épique";
                                cartenum = 4;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = epique1;
                                    cartesE1 = cartesE1 + nbCartesE;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = epique2;
                                    cartesE2 = cartesE2 + nbCartesE;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = epique3;
                                    cartesE3 = cartesE3 + nbCartesE;
                                }
                            }
                            else if (carte <= 989)
                            {
                                cartename = "légendaire";
                                cartenum = 5;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = Legendaire1;
                                    cartesL1 = cartesL1 + nbCartesL;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = Legendaire2;
                                    cartesL2 = cartesL2 + nbCartesL;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = Legendaire3;
                                    cartesL3 = cartesL3 + nbCartesL;
                                }

                            }
                            else if (carte <= 1000)
                            {
                                cartename = "mythique";
                                cartenum = 6;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = Mytique1;
                                    cartesM1 = cartesM1 + nbCartesM;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = Mytique2;
                                    cartesM2 = cartesM2 + nbCartesM;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = Mytique3;
                                    cartesM3 = cartesM3 + nbCartesM;
                                }
                            }
                        }
                        else if (coffre >= 951)
                        {//coffre
                            nom = "Coffre de diamant";
                            Console.ForegroundColor = ConsoleColor.Blue;
                            //carte
                            ArgentC = ArgentCD;
                            if (carte <= 200)
                            {
                                cartename = "super rare";
                                cartenum = 3;
                                if (loot <= 333)
                                {
                                    lootbox = superare1;
                                    cartesSR1 = cartesSR1 + nbCartesSR;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = superare2;
                                    cartesSR2 = cartesSR2 + nbCartesSR;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = superare3;
                                    cartesSR3 = cartesSR3 + nbCartesSR;
                                }
                            }
                            else if (carte <= 400)
                            {
                                cartename = "épique";
                                cartenum = 4;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = epique1;
                                    cartesE1 = cartesE1 + nbCartesE;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = epique2;
                                    cartesE2 = cartesE2 + nbCartesE;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = epique3;
                                    cartesE3 = cartesE3 + nbCartesE;
                                }
                            }
                            else if (carte <= 900)
                            {
                                cartename = "légendaire";
                                cartenum = 5;
                                if (loot <= 333)
                                {
                                    lootbox = Legendaire1;
                                    cartesL1 = cartesL1 + nbCartesL;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = Legendaire2;
                                    cartesL2 = cartesL2 + nbCartesL;
                                }
                                else if (loot <= 999)
                                {
                                    lootbox = Legendaire3;
                                    cartesL3 = cartesL3 + nbCartesL;
                                }
                            }
                            else if (carte <= 989)
                            {
                                cartename = "mythique";
                                cartenum = 6;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = Mytique1;
                                    cartesM1 = cartesM1 + nbCartesM;
                                }
                                else if (loot <= 666)
                                {
                                    lootbox = Mytique2;
                                    cartesM2 = cartesM2 + nbCartesM;

                                }
                                else if (loot <= 999)
                                {
                                    lootbox = Mytique3;
                                    cartesM3 = cartesM3 + nbCartesM;

                                }
                            }
                            else if (carte <= 1000)
                            {
                                cartename = "mistèrieuse";
                                cartenum = 7;
                                //loot----------
                                if (loot <= 333)
                                {
                                    lootbox = misterieuse1;
                                    cartesMS1 = cartesMS1 + nbCartesMS;

                                }
                                else if (loot <= 666)
                                {
                                    lootbox = misterieuse2;
                                    cartesMS2 = cartesMS2 + nbCartesMS;

                                }
                                else if (loot <= 999)
                                {
                                    lootbox = misterieuse3;
                                    cartesMS3 = cartesMS3 + nbCartesMS;

                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine(" OOPS !! petit bug ");
                            nom = "none";
                        }

                        //fermé
                        Console.WriteLine("\n\n\n\n\n\n\n");
                        Console.WriteLine(nom);
                        Console.WriteLine("         ______________________           ");
                        Console.WriteLine("        /_____________________/|          ");
                        Console.WriteLine("       /_____________________/ |          ");
                        Console.WriteLine("      /_____________________/  |          ");
                        Console.WriteLine("     /_____________________/  /|          ");
                        Console.WriteLine("     {////                |  / |          ");
                        Console.WriteLine("     |/////               | /  |          ");
                        Console.WriteLine("     |_________↕↕_________|/   |          ");
                        Console.WriteLine("     |/////////           |    |          ");
                        Console.WriteLine("     |///////             |    |          ");
                        Console.WriteLine("     |////                }    |          ");
                        Console.WriteLine("     |//                  |    |          ");
                        Console.WriteLine("     |//                  |   /           ");
                        Console.WriteLine("     {/                   |  /            ");
                        Console.WriteLine("     |/                   | /             ");
                        Console.WriteLine("     |____________________}/              ");
                        Console.ReadLine();
                        //ouverture
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n");
                        Console.WriteLine(nom);
                        Console.WriteLine("         ______________________           ");
                        Console.WriteLine("        /_____________________/|          ");
                        Console.WriteLine("       /_____________________/ |          ");
                        Console.WriteLine("      /_____________________/  |          ");
                        Console.WriteLine("     /_____________________/  /|          ");
                        Console.WriteLine("     {////                |  / |          ");
                        Console.WriteLine("     |/////               | /  |          ");
                        Console.WriteLine("     |______↕______↕______|/   |          ");
                        Console.WriteLine("     |/////////           |    |          ");
                        Console.WriteLine("     |///////             |    |          ");
                        Console.WriteLine("     |////                }    |          ");
                        Console.WriteLine("     |//                  |    |          ");
                        Console.WriteLine("     |//                  |   /           ");
                        Console.WriteLine("     {/                   |  /            ");
                        Console.WriteLine("     |/                   | /             ");
                        Console.WriteLine("     |____________________}/              ");
                        Console.ReadLine();
                        //ouverture 2
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n");
                        Console.WriteLine("             ______________________       ");
                        Console.WriteLine("            /                     /|      ");
                        Console.WriteLine("           /                     / ]      ");
                        Console.WriteLine("          /                     /  |      ");
                        Console.WriteLine("         /_____________________/   |      ");
                        Console.WriteLine("        /|                    /|  /       ");
                        Console.WriteLine("       / |                   / | /        ");
                        Console.WriteLine("      /  |__________________/  |/         ");
                        Console.WriteLine("     /__/__________________/   |          ");
                        Console.WriteLine("     |/////////           |    |          ");
                        Console.WriteLine("     |///////             |    |          ");
                        Console.WriteLine("     |////                }    |          ");
                        Console.WriteLine("     |//                  |    |          ");
                        Console.WriteLine("     |//                  |   /           ");
                        Console.WriteLine("     {/                   |  /            ");
                        Console.WriteLine("     |/                   | /             ");
                        Console.WriteLine("     |____________________}/              ");
                        timer = 3;
                        for (int i = 0; i < 3; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(timer);
                            timer--;
                            Thread.Sleep(1000);
                        }
                        //objets
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n");
                        argent = argent + ArgentC;

                        if (cartenum == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________/|_____       ");
                            Console.WriteLine("          | /              /      /|      ");
                            Console.WriteLine("          ||             //     / |      ");
                            Console.WriteLine("          /|             |      /  |      ");
                            Console.WriteLine("         /_||__________///_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |        /|      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        else if (cartenum == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________//_____       ");
                            Console.WriteLine("          | /              |      /|      ");
                            Console.WriteLine("          ||              //     / |      ");
                            Console.WriteLine("          /|             /      /  |      ");
                            Console.WriteLine("         /_||__________/|/_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |        /|      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }
                        else if (cartenum == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________|/_____       ");
                            Console.WriteLine("          | /              /      /|      ");
                            Console.WriteLine("          ||              /|     / |      ");
                            Console.WriteLine("          /|             |      /  |      ");
                            Console.WriteLine("         /_||__________///_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |        |/      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        else if (cartenum == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________/|_____       ");
                            Console.WriteLine("          | /              /      /|      ");
                            Console.WriteLine("          ||              /|     / |      ");
                            Console.WriteLine("          /|             /      /  |      ");
                            Console.WriteLine("         /_||__________|//_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |        //      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        else if (cartenum == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________/|_____       ");
                            Console.WriteLine("          | /              |      /|      ");
                            Console.WriteLine("          ||              //     / |      ");
                            Console.WriteLine("          /|             |      /  |      ");
                            Console.WriteLine("         /_||__________/|/_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |        /|      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        else if (cartenum == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("                  " + per + "           ");
                            Console.WriteLine("         |   _______________//_____       ");
                            Console.WriteLine("          | /              |      /|      ");
                            Console.WriteLine("          ||              //     / |      ");
                            Console.WriteLine("          /|             |      /  |      ");
                            Console.WriteLine("         /_||__________///_____/   |      ");
                            Console.WriteLine("        /| ||         /|      /|  /       ");
                            Console.WriteLine("       / |  |        //      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        else if (cartenum == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("           " + ArgentC + " pierres d'or");
                            Console.WriteLine("                 " + cartename + "        ");
                            Console.WriteLine("       ||         " + per + " /         ");
                            Console.WriteLine("         |   _______________/|_____       ");
                            Console.WriteLine("          | ///////        /      /|      ");
                            Console.WriteLine("          ]|/////         //     / ]      ");
                            Console.WriteLine("          /|//           /      /  |      ");
                            Console.WriteLine("         /_||__________/|/_____/   |      ");
                            Console.WriteLine("        /| ||         //      /|  /       ");
                            Console.WriteLine("       / |  |       /|/      / } /        ");
                            Console.WriteLine("      /  |__________________/  |/         ");
                            Console.WriteLine("     /__/__________________/   |          ");
                            Console.WriteLine("     |/////////           |    |          ");
                            Console.WriteLine("     |///////             |    |          ");
                            Console.WriteLine("     |////                }    |          ");
                            Console.WriteLine("     |//                  |    |          ");
                            Console.WriteLine("     |//                  |   /           ");
                            Console.WriteLine("     {/                   |  /            ");
                            Console.WriteLine("     |/                   | /             ");
                            Console.WriteLine("     |____________________}/              ");
                            Console.ReadLine();
                        }

                        switch (lootbox)
                        {
                            case "()":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesC;
                                statusC1 = "Dévérouillé";
                                break;
                            case "(o)":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesC;
                                statusC2 = "Dévérouillé";
                                break;
                            case "(O)":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesC;
                                statusC3 = "Dévérouillé";
                                break;

                            case "{}":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesR;
                                statusR1 = "Dévérouillé";
                                break;
                            case "{o}":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesR;
                                statusR2 = "Dévérouillé";
                                break;
                            case "{O}":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesR;
                                statusR3 = "Dévérouillé";
                                break;

                            case "[]":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesSR;
                                statusSR1 = "Dévérouillé";
                                break;
                            case "[o]":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesSR;
                                statusSR2 = "Dévérouillé";
                                break;
                            case "[O]":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesSR;
                                statusSR3 = "Dévérouillé";
                                break;

                            case "//":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesE;
                                statusE1 = "Dévérouillé";
                                break;
                            case "/o/":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesE;
                                statusE2 = "Dévérouillé";
                                break;
                            case "/O/":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesE;
                                statusE3 = "Dévérouillé";
                                break;

                            case "==":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesL;
                                statusL1 = "Dévérouillé";
                                break;
                            case "=o=":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesL;
                                statusL2 = "Dévérouillé";
                                break;
                            case "=O=":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesL;
                                statusL3 = "Dévérouillé";
                                break;

                            case "||":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesM;
                                statusM1 = "Dévérouillé";
                                break;
                            case "|o|":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesM;
                                statusM2 = "Dévérouillé";
                                break;
                            case "|O|":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesM;
                                statusM3 = "Dévérouillé";
                                break;

                            case "<>":
                                vie = 1;
                                degats = 1;
                                level = 1;
                                cartes = nbCartesMS;
                                statusMS1 = "Dévérouillé";
                                break;
                            case "<o>":
                                vie = 2;
                                degats = 2;
                                level = 2;
                                cartes = nbCartesMS;
                                statusMS2 = "Dévérouillé";
                                break;
                            case "<O>":
                                vie = 3;
                                degats = 3;
                                level = 3;
                                cartes = nbCartesMS;
                                statusMS3 = "Dévérouillé";
                                break;
                        }

                        Console.WriteLine("Pierres d'or : " + argent);
                        Console.WriteLine("Cartes :" + cartes);
                        Console.WriteLine("Personnage :" + lootbox);
                        Console.ReadLine();
                        Console.Clear();

                    }
                }
                Console.ReadLine();
            }
        }
    }
}
