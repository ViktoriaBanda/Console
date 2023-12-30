namespace MyConsole;

public static class Extensions
{
    public static string GetSubstringBeforeFirstSpace(this string originalString)
    {
        var spaceIndex = originalString.IndexOf(' ');

        return spaceIndex != -1 ? originalString.Substring(0, spaceIndex) : originalString;
    }

    public static string GetSubstringAfterFirstSpace(this string originalString)
    {
        var spaceIndex = originalString.IndexOf(' ');

        return spaceIndex != -1 ? originalString.Substring(spaceIndex + 1) : null;
    }
}