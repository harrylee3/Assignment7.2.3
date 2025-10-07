// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

string firstWord = "anagram";
string secondWord = "nagaram";

Console.WriteLine(IsAnagram(firstWord, secondWord));

static bool IsAnagram(string word1, string word2)
{
    if (word1.Length != word2.Length)
    {
        return false;
    }

    var charCount = new Dictionary<char, int>();

    foreach (var chr in word1)
    {
        if (charCount.ContainsKey(chr))
        {
            charCount[chr]++;
        }
        else
        {
            charCount[chr] = 1;
        }
    }
    foreach (var chr in word2)
    {
        if (!charCount.ContainsKey(chr))
        {
            return false;
        }

        charCount[chr]--;

        if (charCount[chr] < 0)
        {
            return false;
        }
    }
    return true;
}
