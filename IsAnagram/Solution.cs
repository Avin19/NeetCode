// See https://aka.ms/new-console-template for more information
public class Solution
{
    int n = 0;
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] store = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            store[s[i] - 'a']++;
            store[t[i] - 'a']--;
            // Console.WriteLine(" ");
            // Console.WriteLine("Store is getting print");
            // foreach (int n in store)
            // {
            //     Console.Write(n);
            // }

        }
        foreach (int n in store) if (n != 0) return false;

        return true;




    }
}