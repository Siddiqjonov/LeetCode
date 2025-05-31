namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _004_LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        var shortestWord = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            if (shortestWord.Length > strs[i].Length)
            {
                shortestWord = strs[i];
            }
        }

        var toReturn = "";
        for (int i = 0; i < shortestWord.Length; i++)
        {
            if (strs.All(w => w[i] == shortestWord[i]))
                toReturn += shortestWord[i];
            else
                return toReturn;
        }
        return toReturn;
    }
}
