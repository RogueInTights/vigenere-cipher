using System.Diagnostics;

namespace Vigenere_cipher
{
    class Vigenere
    {
        public static string Alphabet { get; set; }

        private static string shift(char letter)
        {
            int position = Alphabet.IndexOf(letter);
            return Alphabet.Remove(0, position) + Alphabet.Remove(position, 0);
        }

        // Сокращение строки ключа:
        private static string reduceKey(string key)
        {
            for (int i = 1; i < key.Length; i++)
            {
                string reducedKey = key.Remove(i);
                string comparisonString = "";

                while (comparisonString.Length < key.Length)
                {
                    comparisonString += reducedKey;
                }
                if (comparisonString.Length > key.Length)
                    comparisonString = comparisonString.Remove(key.Length);

                if (comparisonString == key) return reducedKey;
            }

            return key;
        }

        // Метод кодирования / декодирования:
        public static string Encode(string input, string key, bool reverse)
        {
            string result = "";

            // Растяжение ключа до длины кодируемой строки:
            while (key.Length < input.Length) key += key;
            if (key.Length > input.Length) key.Remove(input.Length);

            // Добавление символа сдвинутого алфовита к результату:
            for (int i = 0; i < input.Length; i++)
            {
                string shiftedAlphabet = shift(key[i]);

                int position = (!reverse) ? Alphabet.IndexOf(input[i]) : shiftedAlphabet.IndexOf(input[i]);
                result += (!reverse) ? shiftedAlphabet[position] : Alphabet[position];
            }

            return result;
        }

        // Метод поиска ключа:
        public static string FindKey(string input, string output)
        {
            string key = "";

            for (int i = 0; i < input.Length; i++)
            {
                string shiftedAlphabet = shift(input[i]);
                int position = shiftedAlphabet.IndexOf(output[i]);

                key += Alphabet[position];
            }

            return reduceKey(key);
        }
    }
}