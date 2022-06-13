using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.utils
{
    public static class Out
    {
        /// <summary>
        /// Write text and return line
        /// </summary>
        /// <param name="text"></param>
        public static void WriteLine(string text, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Write text
        /// </summary>
        /// <param name="text"></param>
        public static void WriteOneLine(string text, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(text);
        }

        /// <summary>
        /// Write text with a loop
        /// </summary>
        /// <param name="text"></param>
        /// <param name="forNumber"></param>
        /// <param name="Line"></param>
        public static void WriteLoopText(string text, int forNumber, bool Line, bool space, int posX, int posY)
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
                    if (space)
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

        public static void WriteMenuButtonsTwoAxes(List<string>[] text, int forNumber, bool line, int posX, int posY, int offset, int currentChoiceY, int currentChoiceX)
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
                        if (currentChoiceY != 0)
                        {
                            Console.Write("> ");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (i == 0)
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

        /// <summary>
        /// Clear wanted list on different lines
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="textLenght"></param>
        public static void ClearListLine(int positonX, int positionY, List<string> text)
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
        /// Clear wanted text on only one line
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="textLenght"></param>
        public static void ClearOneLine(int positonX, int positionY, int textLenght)
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
