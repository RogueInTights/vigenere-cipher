using System;
using System.Text.RegularExpressions;
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
            return new Regex(@"[\W\d]").Replace(str, String.Empty).ToLower();
        }

        // Исходное форматирование текста:
        private string originalFormat(string original, string encoded)
        {
            string lowerCase = original.ToLower();

            for (int i = 0; i < original.Length; i++)
            {
                if (Vigenere.Alphabet.IndexOf(lowerCase[i]) != -1)
                {
                    string newLetter = (lowerCase[i] == original[i]) ? 
                        encoded[0].ToString() : 
                        encoded[0].ToString().ToUpper();

                    original = original.Remove(i, 1).Insert(i, newLetter);
                    encoded = encoded.Remove(0, 1);
                }
            }

            return original;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string input = prepare(inputTextBox.Text);
            string key = prepare(keyTextBox.Text);

            outputTextBox.Text = originalFormat(
                inputTextBox.Text, 
                Vigenere.Encode(input, key, false)
            );
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string output = prepare(outputTextBox.Text);
            string key = prepare(keyTextBox.Text);

            inputTextBox.Text = originalFormat(
                outputTextBox.Text, 
                Vigenere.Encode(output, key, true)
            );
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            string input = prepare(inputTextBox.Text);
            string output = prepare(outputTextBox.Text);

            keyTextBox.Text = Vigenere.FindKey(input, output);
        }
    }
}
