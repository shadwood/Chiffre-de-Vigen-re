using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VigenerCihperWF
{
    class ViginereTable
    {
        public delegate void GetLine(string line);
        static GetLine _GetLine;
        static GetLine _GetLetter;

        public static void RegisterLinePrinter(GetLine _line)
        {
            _GetLine += _line;
        }

        public static void RegisterLetterPrinter(GetLine _letter)
        {
            _GetLetter += _letter;
        }

        public char[,] Table { get; set; }
        public int NumberOfAlthabetLetters { get; set; }

        public ViginereTable(string Alphabet)
        {
            NumberOfAlthabetLetters = Alphabet.Length;
            Alphabet += Alphabet;

            Table = new char[NumberOfAlthabetLetters, NumberOfAlthabetLetters];
            for (int k = 0; k < NumberOfAlthabetLetters * 2; k++)
            {
                for (int i = 0; i < NumberOfAlthabetLetters; i++)
                {
                    for (int j = 0; j < NumberOfAlthabetLetters; j++)
                    {
                        if (i + j == k)
                        { Table[i, j] = Alphabet[k]; }
                    }

                }

            }

        }


        public static implicit operator char[,] (ViginereTable viginereTable)
        {
            return viginereTable.Table;
        }


        static public void VisinerTablePrint(char[,] Table)
        {
            _GetLine("");
            _GetLine("--------------------Таблица Вижинера----------------------------");
            _GetLine("");
            _GetLetter("  ");
            for (int j = 0; j < Table.GetLength(1); j++)
            {
                _GetLetter($"{Program.Alphabet[j]} ");
            };
            _GetLine("");
            _GetLine("___________________________________________________________________");
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if (j == 0) { _GetLetter($"{Program.Alphabet[i]}|"); }
                    _GetLetter($"{Table[i, j]} ");
                }
                _GetLine("");
            }
            _GetLine("___________________________________________________________________");
        }

        public int[] GetKeyColunmIndex(string key)
        {
            int CurrentLetterIndex = 0;
            int[] KeyColumnIndex = new int[key.Length];
            while (CurrentLetterIndex < key.Length)
            {
                for (int CurrentIndex = 0; CurrentIndex < NumberOfAlthabetLetters; CurrentIndex++)
                {
                    if (key[CurrentLetterIndex] == Table[0, CurrentIndex])
                    {
                        KeyColumnIndex[CurrentLetterIndex] = CurrentIndex;
                        CurrentLetterIndex++;
                        break;
                    }
                }
            }

            return KeyColumnIndex;
        }
    }
}
