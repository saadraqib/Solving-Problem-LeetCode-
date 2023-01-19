// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");


var org = "LVIII";
var test = new Solution();
int number = test.find('M');
Console.WriteLine("n " + number);

int result = test.RomanToInt(org);
Console.WriteLine("result "+result);


// The problem is Solved
public class Solution
{
    public int RomanToInt(string s)
    {
        int i = 0;
        var value = 0;
        while (i < s.Length)
        {
            if (i > 0 && find(s[i]) > find(s[i - 1])) value -= 2*find(s[i - 1]);
            value += find(s[i++]);
            
        }
        return value;
    }
    public int find(char letter)
    {
        var org = "IVXLCDM";
        int i= 0;
        int value = 1;
        while (i != org.Length)
        {
            if (i == 0) value = 1;
            else if (i % 2 != 0)  value*= 5;
            else  value *= 2;

            if (letter == org[i]) break;
            else i++;
            
        }
        return value;
    }
}