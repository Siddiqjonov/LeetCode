using System.Text;

namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _007_ReverseVowelsOfAtring
{
    public string ReverseVowels(string s)
    {
        string vowels = string.Empty;
        var latters = new StringBuilder(s);

        foreach (char l in s)
        {
            if (char.IsLetter(l))
            {
                switch (l)
                {
                    case 'a': case 'e': case 'i': case 'o': case 'u':
                    case 'A': case 'E': case 'I': case 'U': case 'O':
                    {
                        vowels += l;
                        break;
                    }
                }
            }
        }

        vowels = new string(vowels.Reverse().ToArray());

        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'a': case 'e': case 'i': case 'o': case 'u':
                case 'A': case 'E': case 'I': case 'O': case 'U':
                {
                    latters[i] = vowels[index];
                    index++;
                    break;
                }
            }
        }

        return latters.ToString();
    }
}
