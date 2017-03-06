using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vigenere.Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        }

        // Подготовка строки к кодированию:
        private string prepare(string str)
        {
            string pattern = @"\W";
            Regex rgx = new Regex(pattern);

            return rgx.Replace(str, String.Empty).ToLower();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string input = prepare(inputTextBox.Text);
            string key = prepare(keyTextBox.Text);

            outputTextBox.Text = Vigenere.Encode(input, key, false);
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string output = prepare(outputTextBox.Text);
            string key = prepare(keyTextBox.Text);

            inputTextBox.Text = Vigenere.Encode(output, key, true);
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            string input = prepare(inputTextBox.Text);
            string output = prepare(outputTextBox.Text);

            keyTextBox.Text = Vigenere.FindKey(input, output);
        }
    }
}
