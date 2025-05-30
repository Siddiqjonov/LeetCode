namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _005_FindCommonCharacters
{
    public IList<string> CommonChars(string[] words)
    {
        Array.Sort(words);
        char[] chars = words[0].ToCharArray();
        var latters = new List<string>();

        foreach (char ch in chars)
        {
            if (words.All(word => word.Contains(ch)))
            {
                latters.Add(ch.ToString());
                for (int i = 0; i < words.Length; i++)
                {
                    var index = words[i].IndexOf(ch);
                    words[i] = words[i].Remove(index, 1);
                }
            }
        }
        return latters;
    }
}
