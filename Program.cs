using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VigenerCihperWF
{
    static class Program
    {
        const double IndSovp = 0.553;
        const string EngAlphabet = "abcdefghijklmnopqrstuvwxyz";
        const string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static char[,] Table = new char[0, 0];
        public static string Language = "русский";
        public static string Alphabet = RusAlphabet;
        public static int NumberOfAlthabetLetters = Alphabet.Length;

        public static ViginereTable VishinerTable = new ViginereTable(Alphabet);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Table = VishinerTable;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool IsLetterOfCurrentLanguage(char letter)
        {
            if (Program.Language == "русский")
            {
                if (((int)letter > 1071 && (int)letter < 1104) || letter == 'ё')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((int)letter < 123 && (int)letter > 96)
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
}
