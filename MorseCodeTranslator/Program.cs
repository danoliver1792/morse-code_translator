using System;
using System.Collections.Generic;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> morseCodeDict = new Dictionary<char, string>
            {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
            {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}
            };

            Console.WriteLine("----------CODIGO MORSE----------");
            Console.WriteLine("Digite uma palavra ou frase para traduzir: ");

            string input = Console.ReadLine().ToUpper();
            string morseCode = TranslateToMorseCode(input, morseCodeDict);

            Console.WriteLine($"Codigo Morse: {morseCode}");
        }

        static string TranslateToMorseCode(string text, Dictionary<char, string> morseCodeDict)
        {
            string morseCode = "";

            foreach (char character in text)
            {
                if (character == ' ')
                {   
                    // adicionando espaco para separar as palavras
                    morseCode += " ";
                }
                else if (morseCodeDict.ContainsKey(character))
                {
                    morseCode += morseCodeDict[character] + " ";
                }
                else
                {   
                    // adicionando "?" em caracteres desconhecidos
                    morseCode += "? ";
                }
            }
            // removendo espacos em branco no inicio e final da frase
            return morseCode.Trim();
        }
    }
}
