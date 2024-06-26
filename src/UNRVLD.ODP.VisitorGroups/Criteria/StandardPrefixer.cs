using System.Text.RegularExpressions;


namespace UNRVLD.ODP.VisitorGroups.Criteria
{
    public class StandardPrefixer : IPrefixer
    {
        private static readonly Regex PrefixRegex = new(@"^\[(.+)\] - (.+)$", RegexOptions.Compiled);

        public string Prefix(string value, string prefix)
        {
            return $"[{prefix}] - {value}";
        }

        public (string? prefix, string value) SplitPrefix(string value)
        {
            var match = PrefixRegex.Match(value);

            return match.Success ? (match.Groups[1].Value, match.Groups[2].Value) : (null, value);
        }
    }
}