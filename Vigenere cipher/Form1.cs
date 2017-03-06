using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        // Сдвиг алфовита:
        private string shift(char letter)
        {
            int pos = alphabet.IndexOf(letter);
            return alphabet.Remove(0, pos) + alphabet.Remove(pos);
        }

        private string encode(string input, string key)
        {
            string result = "";

            while (key.Length < input.Length)
            {
                key += key;
            }
            if (key.Length > input.Length) key.Remove(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                int pos = alphabet.IndexOf(input[i]);
                result += shift(key[i])[pos];
            }

            return result;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            input = input.Replace(" ", String.Empty).ToLower();

            string key = keyTextBox.Text;
            key = key.Replace(" ", String.Empty).ToLower();

            outputTextBox.Text = encode(input, key);
        }
    }
}
