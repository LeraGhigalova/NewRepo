using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст на русском языке:");
        string input = Console.ReadLine();

        string result = ConvertToCsAlphabet(input);

        Console.WriteLine("\nПеревод на алфавит CS:");
        Console.WriteLine(result);
    }

    static string ConvertToCsAlphabet(string russianText)
    {
        if (string.IsNullOrEmpty(russianText))
            return string.Empty;

        var translationTable = new Dictionary<char, string>
        {
            {'А', "A"},
            {'Б', "6"},
            {'В', "B"},
            {'Г', "r"},
            {'Д', "D"},
            {'Е', "E"}, 
            {'Ж', "J"}, 
            {'З', "3"}, 
            {'И', "u"}, 
            {'Й', "u*"}, 
            {'К', "K"}, 
            {'Л', "J"}, 
            {'М', "M"}, 
            {'Н', "H"},
            {'О', "O"}, 
            {'П', "n"},
            {'Р', "P"},
            {'С', "C"},
            {'Т', "T"},
            {'У', "Y"},
            {'Ф', "cp"}, 
            {'Х', "X"}, 
            {'Ц', "L"}, 
            {'Ч', "4"}, 
            {'Ш', "LLI"},
            {'Щ', "LLL"}, 
            {'Ъ', "b"}, 
            {'Ы', "bI"}, 
            {'Ь', "b"}, 
            {'Э', "-)"}, 
            {'Ю', "IO"}, 
            {'Я', "9I"}
        };

        StringBuilder result = new StringBuilder();

        foreach (char c in russianText)
        {
            if (translationTable.ContainsKey(c))
            {
                result.Append(translationTable[c]);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
