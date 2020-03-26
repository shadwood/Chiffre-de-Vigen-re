using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VigenerCihperWF
{



    public partial class MainForm : Form
    {
        const double IndSovp = 0.553;
        const string EngAlphabet = "abcdefghijklmnopqrstuvwxyz";
        const string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        string Text;
        string KeyWord;

        string OutputText = "";
        int KeyLetterCounter = 0;
        int[] KeyColumnIndex;
        int LetterRowIntex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            KeyWord = (KeyBox.Text).ToLower();
            if (KeyWord != "")
            {
                KeyLetterCounter = 0;
                OutputText = "";
                KeyColumnIndex = new int[KeyWord.Length];
                if (Program.IsLetterOfCurrentLanguage(KeyWord[0]))
                    KeyColumnIndex = Program.VishinerTable.GetKeyColunmIndex(KeyWord);
                else MessageBox.Show("Выбран неверный язык");

                if (OpenTextBox.Text != "")
                {
                    //шифруем откр. текст
                    Text = (OpenTextBox.Text).ToLower();
                    foreach (char letter in Text)
                    {

                        if (Program.IsLetterOfCurrentLanguage(letter))
                        {

                            for (LetterRowIntex = 0; LetterRowIntex < Program.NumberOfAlthabetLetters; LetterRowIntex++)
                            {
                                if (letter == Program.Table[LetterRowIntex, 0]) { break; }
                            }

                            OutputText += Program.Table[LetterRowIntex, KeyColumnIndex[KeyLetterCounter]];
                        }
                        else
                        {
                            OutputText += letter;
                        }

                        if (KeyLetterCounter < KeyWord.Length - 1) { KeyLetterCounter++; }
                        else { KeyLetterCounter = 0; }
                    }
                    CloseTextBox.Text = OutputText;
                    OpenTextBox.Text = "";
                    OpenTextBox.ReadOnly = true;


                }
                else
                {
                    // Расшифрофка закр. текста
                    Text = (CloseTextBox.Text).ToLower();
                    foreach (char letter in Text)
                    {

                        if (Program.IsLetterOfCurrentLanguage(letter))
                        {

                            for (LetterRowIntex = 0; LetterRowIntex < Program.NumberOfAlthabetLetters; LetterRowIntex++)
                            {
                                if (letter == Program.Table[LetterRowIntex, KeyColumnIndex[KeyLetterCounter]]) { break; }
                            }

                            OutputText += Program.Table[LetterRowIntex, 0];
                        }
                        else
                        {
                            OutputText += letter;
                        }

                        if (KeyLetterCounter < KeyWord.Length - 1) { KeyLetterCounter++; }
                        else { KeyLetterCounter = 0; }

                    }

                    OpenTextBox.Text = OutputText;
                    CloseTextBox.Text = "";
                    CloseTextBox.ReadOnly = true;
                }
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            CloseTextBox.Text = "";
            OpenTextBox.Text = "";
        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (Program.Language == "англиский")
            { Program.Language = "русский"; Program.Alphabet = RusAlphabet; Program.NumberOfAlthabetLetters = Program.Alphabet.Length; }
            else
            { Program.Language = "англиский"; Program.Alphabet = EngAlphabet; Program.NumberOfAlthabetLetters = Program.Alphabet.Length; }
            LanguageButton.Text = $"Сменить язык\n Текущий язык {Program.Language}";
            Program.VishinerTable = new ViginereTable(Program.Alphabet);
            Program.Table = Program.VishinerTable;

        }

        private void CloseTextBox_Leave(object sender, EventArgs e)
        {
            if (CloseTextBox.Text != "")
            {
                OpenTextBox.ReadOnly = true;
            }
            else { OpenTextBox.ReadOnly = false; }
        }

        private void OpenTextBox_Leave(object sender, EventArgs e)
        {
            if (OpenTextBox.Text != "")
            {
                CloseTextBox.ReadOnly = true;
            }
            else { CloseTextBox.ReadOnly = false; }
        }

       

        private void таблицаВижинераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VigenerTable form2 = new VigenerTable();
            form2.Show();
        }

        private void взломПоМаскеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaskForm form = new MaskForm();
            form.Show();
        }

        
    }
}
