using System.Text.RegularExpressions;

namespace Tool
{
    public static class ToolString
    {
        public static string GetNextID(string input)
        {
            Match match = Regex.Match(input, @"\d+");
            if (!match.Success) return input;

            int number = int.Parse(match.Value) + 1;
            string incrementedNumber = number.ToString().PadLeft(match.Length, '0');
            return input.Substring(0, match.Index) + incrementedNumber + input.Substring(match.Index + match.Length);
        }
    }
}
