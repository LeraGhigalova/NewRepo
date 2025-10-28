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
            {'А', "A"}, {'а', "a"},
            {'Б', "6"}, {'б', "6"},
            {'В', "B"}, {'в', "B"},
            {'Г', "r"}, {'г', "r"},
            {'Д', "D"}, {'д', "D"},
            {'Е', "E"}, {'е', "E"},
            {'Ж', "J"}, {'ж', "J"},
            {'З', "3"}, {'з', "3"},
            {'И', "u"}, {'и', "u"},
            {'Й', "u*"}, {'й', "u*"},
            {'К', "K"}, {'к', "K"},
            {'Л', "J"}, {'л', "J"},
            {'М', "M"}, {'м', "M"},
            {'Н', "H"}, {'н', "H"},
            {'О', "O"}, {'о', "O"},
            {'П', "n"}, {'п', "n"},
            {'Р', "P"}, {'р', "P"},
            {'С', "C"}, {'с', "C"},
            {'Т', "T"}, {'т', "T"},
            {'У', "Y"}, {'у', "Y"},
            {'Ф', "cp"}, {'ф', "cp"},
            {'Х', "X"}, {'х', "X"},
            {'Ц', "L"}, {'ц', "L"},
            {'Ч', "4"}, {'ч', "4"},
            {'Ш', "LLI"}, {'ш', "LLI"},
            {'Щ', "LLL"}, {'щ', "LLL"},
            {'Ъ', "b"}, {'ъ', "b"},
            {'Ы', "bI"}, {'ы', "bI"},
            {'Ь', "b"}, {'ь', "b"},
            {'Э', "-)"}, {'э', "-)"},
            {'Ю', "IO"}, {'ю', "IO"},
            {'Я', "9I"}, {'я', "9I"}
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