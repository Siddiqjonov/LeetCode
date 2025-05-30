namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _006_ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> chars = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                chars.Push('(');
            else if (s[i] == '[')
                chars.Push('[');
            else if (s[i] == '{')
                chars.Push('{');
            else if (chars.Count > 0)
            {
                if (s[i] == ')' && chars.Peek() == '(')
                    chars.Pop();
                else if (s[i] == ']' && chars.Peek() == '[')
                    chars.Pop();
                else if (s[i] == '}' && chars.Peek() == '{')
                    chars.Pop();
                else
                    return false;
            }
            else
                return false;
        }
        if (chars.Count == 0)
            return true;
        else
            return false;
    }
}
