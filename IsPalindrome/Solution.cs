// See https://aka.ms/new-console-template for more information
public class Solution
{
    public bool IsPalindrome(string a)
    {
        int l = a.Length - 1, count = 0;

        for (int i = 0; i <= l/2; i++)
        {
            if (a[i] == a[l - i])
            {
                count++;
            }
        }
        if (count == l) return true;
        else return false;
    }
}
