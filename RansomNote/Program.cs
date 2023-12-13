static bool CanConstruct(string ransomNote, string magazine)
{
    bool contains = true;
    foreach (var c in ransomNote)
    {
        if (!magazine.Contains(c))
        {
            contains = false;
        }
        if (magazine.IndexOf(c) >= 0)
            magazine = magazine.Remove(magazine.IndexOf(c),1);

    }
    return contains;
}
CanConstruct("aa", "aab");