/************************************
 * Lieu          : Lausanne         
 * Etablissement : ETML             
 * Classe        : CID2             
 * Auteur        : Damien Loup      
 * Description                               
 *    - Classe   : Ecrit du texte lorsque la librairie est appelée avec : Print.XYZ             
 ************************************/
using System;
using System.Collections.Generic;
using System.Threading;

namespace P_Demomot.util
{
    /// <summary>
    /// 
    /// </summary>
    static class Print
    {
        /// <summary>
        /// Write text and return line
        /// </summary>
        /// <param name="text"></param>
        public static void Line(string text, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Write text
        /// </summary>
        /// <param name="text"></param>
        public static void OneLine(string text, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(text);
        }

        /// <summary>
        /// Write one line but all the letter appears with delay
        /// </summary>
        /// <param name="text"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        public static void LineDelayed(string text, int posX, int posY, int delay)
        {
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }

        /// <summary>
        /// Write text with a loop
        /// </summary>
        /// <param name="text"></param>
        /// <param name="forNumber"></param>
        /// <param name="Line_OnLine"></param>
        public static void LoopList(List<string> text, int forNumber, bool line, int posX, int posY, int offset)
        {
            int counter = 0;
            for(int i = 0; i < forNumber; i++)
            {
                Console.SetCursorPosition(posX, posY + counter);

                if (line == true)
                {
                    Console.WriteLine(text[i]);
                }
                else
                {
                    Console.Write(text[i] + " ");
                }

                counter += (1 + offset);
            }
        }

        /// <summary>
        /// Write text with a loop
        /// </summary>
        /// <param name="text"></param>
        /// <param name="forNumber"></param>
        /// <param name="Line"></param>
        public static void LoopText(string text, int forNumber, bool Line, bool space, int posX, int posY)
        {
            for (int i = 0; i < forNumber; i++)
            {
                

                if (Line == true)
                {
                    Console.SetCursorPosition(posX, posY + i);
                    Console.WriteLine(text);
                }
                else
                {
                    if(space)
                    {
                        Console.Write(text + " ");
                    }
                    else
                    {
                        Console.Write(text);
                    }

                    Console.SetCursorPosition(posX + i, posY);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="forNumber"></param>
        /// <param name="line"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <param name="offset"></param>
        /// <param name="currentChoice"></param>
        public static void MenuButtons(List<string> text, int forNumber, bool line, int posX, int posY, int offset, int currentChoice)
        {
            int counter = 0;
            for (int i = 0; i < forNumber; i++)
            {
                Console.SetCursorPosition(posX, posY + counter);

                if (line == true)
                {
                    if (currentChoice == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(text[i]);
                }
                else
                {
                    if (currentChoice == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(text[i] + " ");
                }

                counter += (1 + offset);
            }
        }



        public static void MenuButtonsTwoAxes(List<string>[] text, int forNumber, bool line, int posX, int posY, int offset, int currentChoiceY, int currentChoiceX)
        {
            int j = 0;
            int counter = 0;
            for (int i = 0; i < forNumber; i++)
            {
                Console.SetCursorPosition(posX, posY + counter);

                if (line == true)
                {
                    if (currentChoiceY == i)
                    {
                        if(currentChoiceY != 0)
                        {
                            Console.Write("> ");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if(i == 0)
                    {
                        Console.WriteLine(text[0][currentChoiceX]);
                    }
                    else
                    {
                        Console.WriteLine(text[1][j]);
                        j++;
                        
                    }
                }
                else
                {
                    if (currentChoiceY == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(text[i] + " ");
                }

                counter += (1 + offset);
            }
        }

    }

    static class Clear
    {
        /// <summary>
        /// Clear wanted list on different lines
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="textLenght"></param>
        public static void ListLine(int positonX, int positionY, List<string> text)
        {
            int counter = 0;

            for (int i = 0; i < text.Count; i++)
            {
                Console.SetCursorPosition(positonX, positionY + counter);
                for (int j = 0; j < text[i].Length; j++)
                {
                    Console.Write(" ");
                }
                counter += 2;
            }
        }

        /// <summary>
        /// Clear wanted list in the same line
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="textLenght"></param>
        public static void ListOneLine(int positonX, int positionY, List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        /// <summary>
        /// Clear wanted text on only one line
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="textLenght"></param>
        public static void OneLine(int positonX, int positionY, int textLenght)
        {
            string clearText = "";

            for (int i = 0; i < textLenght; i++)
            {
                clearText += " ";                
            }

            Console.SetCursorPosition(positonX, positionY);
            Console.Write(clearText);
        }
    }
}
