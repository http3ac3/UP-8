using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UP_8_GUI
{
    public partial class Form1 : Form
    {
        private string s = "";
        Regex regex;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswerButton_Click(object sender, EventArgs e)
        {
            s = TextBox.Text;
            if (s.Length == 0)
            {
                AnswerBox.Text = "Строка не может быть пустой";
                return;
            }
            regex = new Regex(@"\b[А-Я]+\w*");
            MatchCollection matches = regex.Matches(s);
            AnswerBox.Text += "Слова с заглавной буквы: ";
            foreach (Match m in matches) AnswerBox.Text += m.Value + " ";
        }
    }
}
