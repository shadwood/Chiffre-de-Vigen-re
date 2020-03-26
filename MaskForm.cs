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
    public partial class MaskForm : Form
    {
        //public TextBox[] _TextBox = new TextBox[Program.NumberOfAlthabetLetters];
        public ComboBox[] _comboBox = new ComboBox[Program.NumberOfAlthabetLetters];
        public CheckBox[] _checkBox = new CheckBox[Program.NumberOfAlthabetLetters];
        public GroupBox[] _groupBox = new GroupBox[Program.NumberOfAlthabetLetters];
        public Label[] _label = new Label[Program.NumberOfAlthabetLetters];

        string CopyText;
        string OriginalTextString;//оригинал шифротекста
        string[] MassivOfTextsLetter;//массив символов текста, где буква заменена на порядковый номер в алфавите
        string[] UnusedLetter = new string[Program.NumberOfAlthabetLetters];//Символы доступные в комбобоксе
        bool OriginalTextEnter = false;

        string[] ChangeMap = new string[Program.NumberOfAlthabetLetters];//"Карта" по которой цифры шифротекста(i) заменяются на буквы открытого текста(value)
        float[] KolichestvoOfLetter = new float[Program.NumberOfAlthabetLetters];

        short Mod = 1;//режимы кнопки отображения текста
        short Button3Mod = 1;

        string Separator = ":";
        string Space = " ";

        public MaskForm()
        {
            InitializeComponent();
        }


        //*********************Обработчики событий элементов формы**********************//
        private void MaskForm_Load(object sender, EventArgs e)
        {
            //обнуляем и задаем некоторые переменные
            for (int j = 0; j < Program.NumberOfAlthabetLetters; j++)
            {
                ChangeMap[j] = null;
            }

            for (int j = 0; j < Program.NumberOfAlthabetLetters; j++)
            {
                KolichestvoOfLetter[j] = 0;
            }

            for (int j = 0; j < Program.NumberOfAlthabetLetters; j++)
            {
                UnusedLetter[j] = "";
                UnusedLetter[j] += Program.Alphabet[j];
            }
            //Создаем элементы правой части экрана по количеству букв алфавита
            for (int i = 0; i < Program.NumberOfAlthabetLetters; i++)
            {



                //
                //ТекстБоксы
                //
                //_TextBox[i] = new TextBox();
                //_TextBox[i].Size = new Size(60, 20);
                //_TextBox[i].Location = new Point(30, 30);
                //
                //ComboBox
                //
                _comboBox[i] = new ComboBox();
                _comboBox[i].Name = $"CB{i}";
                _comboBox[i].Location = new Point(30, 25);
                _comboBox[i].Size = new Size(40, 20);
                _comboBox[i].Items.Add("");
                _comboBox[i].Items.AddRange(UnusedLetter);
                _comboBox[i].SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                //
                //ЧекБоксы
                //
                _checkBox[i] = new CheckBox();
                _checkBox[i].Location = new Point(10, 30);
                _checkBox[i].Size = new Size(15, 15);
                _checkBox[i].Checked = true;
                //
                //Надписи
                //
                _label[i] = new Label();
                _label[i].Location = new Point(70, 30);
                _label[i].Size = new Size(45, 20);
                //
                //ГруппБоксы
                //
                _groupBox[i] = new GroupBox();
                _groupBox[i].Size = new Size(115, 60);
                _groupBox[i].Text = $"{i}";
                //
                //Добавляем элементы в ГруппБоксы
                //
                _groupBox[i].Controls.Add(_checkBox[i]);
                _groupBox[i].Controls.Add(_comboBox[i]);
                _groupBox[i].Controls.Add(_label[i]);

            }
            //Добавляем групп боксы на панель
            panel1.Controls.AddRange(_groupBox);
            SeparatorBox.Text = Separator;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginalTextEnter)
            {
                //узнаем какой комбобокс был использован
                string Name = ((ComboBox)sender).Name;
                string LettersNumber = Name.Substring(2, Name.Length - 2);
                //добавляем в карту новый элемент
                ChangeMap[int.Parse(LettersNumber)] = (string)((ComboBox)sender).SelectedItem;
                //

                ChangeRichBoxText();
            }
        }


        //кнопка режима показа разделителя
        private void button3_Click(object sender, EventArgs e)
        {
            if (OriginalTextEnter)
            {
                if (Button3Mod == 1)
                {
                    Separator = "";
                    ChangeRichBoxText();
                    button3.Text = "Показать разделитель";
                    Button3Mod = 2;
                }
                else
                {
                    Separator = SeparatorBox.Text;
                    ChangeRichBoxText();
                    button3.Text = "Убрать разделитель";
                    Button3Mod = 1;
                }
            }
        }

        //Замена букв закрытого текста на цисла от 0 до количеста букв в алфавите(NumberOfAlthabetLetters)
        private void ProcessButton_Click(object sender, EventArgs e)
        {

            switch (Mod)
            {
                case 1://первичная обработка
                    SaveOriginText();//создание копии первично введенного текста
                    ChangeLetterOriginText();//непосредственно замена символов. Игнорирует не буквы алфавита
                    ChangeLabelText();
                    Mod = 2;
                    ProcessButton.Text = "показать оригинальный текст";
                    break;

                case 2://показа оригинального текста
                    CopyText = richTextBox1.Text;
                    richTextBox1.Text = OriginalTextString;
                    ProcessButton.Text = "показать текущий текст";
                    Mod = 3;
                    break;

                case 3://показ текущего текста
                    richTextBox1.Text = CopyText;
                    Mod = 2;
                    ProcessButton.Text = "показать оригинальный текст";
                    break;


            }
        }

        private void SeparatorBox_TextChanged(object sender, EventArgs e)
        {
            if (OriginalTextEnter)
            {
                Separator = SeparatorBox.Text;
                ChangeRichBoxText();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Space = textBox1.Text;
            ChangeRichBoxText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, (float)numericUpDown1.Value, richTextBox1.Font.Style);
            ChangeRichBoxText();
        }
        //*********************Методы**********************//
        string ChangeRichBoxText()
        {
            string Temp = "";
            for (int i = 0; i < OriginalTextString.Length; i++)
            {
                if (Program.IsLetterOfCurrentLanguage(OriginalTextString[i]))
                {
                    int t = int.Parse(MassivOfTextsLetter[i]);
                    string CurrentChangeMapSumbol = ChangeMap[t];
                    if (CurrentChangeMapSumbol != null && CurrentChangeMapSumbol != "")
                    {
                        Temp += $"{CurrentChangeMapSumbol}{Separator}";

                    }
                    else
                    {
                        Temp += $"{MassivOfTextsLetter[i]}{Separator}";

                    }
                }
                else
                {
                    if (textBox1.Text != "" && OriginalTextString[i] == ' ')
                    {
                        Temp += $"{Space}";
                    }
                    else
                    {
                        Temp += $"{MassivOfTextsLetter[i]}";
                    }
                }
            }
            richTextBox1.Clear();
            richTextBox1.Text = Temp;
            return Temp;
        }

        //создание неизменяемой копии оригинального текста
        void SaveOriginText()
        {
            if (!OriginalTextEnter)
            {
                OriginalTextString = (richTextBox1.Text).ToLower();
                MassivOfTextsLetter = new string[richTextBox1.Text.Length];
                OriginalTextEnter = true;
            }
        }

        //Первая замена символов оригинального текста.
        // Инициализация массива символов. Игнорирует не буквы алфавита
        void ChangeLetterOriginText()
        {

            CopyText = "";
            for (int i = 0; i < OriginalTextString.Length; i++)
            {
                for (int j = 0; j < Program.NumberOfAlthabetLetters; j++)
                {
                    if (Program.IsLetterOfCurrentLanguage(OriginalTextString[i]))
                    {
                        if ((OriginalTextString[i] == Program.Alphabet[j]))
                        {
                            MassivOfTextsLetter[i] += j;//создает массив символов из оригинального текста
                            CopyText += $"{j}{Separator}";
                            KolichestvoOfLetter[j]++;
                            break;
                        }
                    }
                    else
                    {
                        if (textBox1.Text != "" && OriginalTextString[i] == ' ')
                        {
                            CopyText += $"{Space}";
                        }
                        else
                        {
                            CopyText += $"{OriginalTextString[i]}";
                        }
                        MassivOfTextsLetter[i] += $"{OriginalTextString[i]}";//создает массив символов из оригинального текста
                        break;
                    }
                }
            }
            richTextBox1.Text = CopyText;
        }

        void ChangeLabelText()
        {
            float value;
            string temp;
            for (int i = 0; i < Program.NumberOfAlthabetLetters; i++)
            {
                if (KolichestvoOfLetter[i] != 0)
                {
                    temp = "";
                    value = KolichestvoOfLetter[i] / OriginalTextString.Length * 100;
                    temp += value;
                    _label[i].Text += $"{temp.Substring(0, 5)}%";
                }
                else
                { _label[i].Text += $"0%"; }
            }
        }


    }

}
