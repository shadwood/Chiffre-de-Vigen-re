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
    public partial class VigenerTable : Form
    {
        string temp = "";

        public VigenerTable()
        {
            InitializeComponent();
        }

        private void VigenerTable_Load(object sender, EventArgs e)
        {
            ViginereTable.RegisterLinePrinter(new ViginereTable.GetLine(PrintLine));
            ViginereTable.RegisterLetterPrinter(new ViginereTable.GetLine(PrintSumbol));
            ViginereTable.VisinerTablePrint(Program.Table);
            textBox1.Text = temp;
        }

        void PrintSumbol(string sum)
        {
            temp += $"{sum}";
        }

        void PrintLine(string str)
        {
            temp += $"{str}\n";
        }
    }
}
