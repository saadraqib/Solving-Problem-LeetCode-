// The problem (Add Two Numbers_M_S)
// You are given two non-empty linked lists representing two non-negative integers.
// The digits are stored in reverse order, and each of their nodes contains a single digit.
// Add the two numbers and return the sum as a linked list.
//You may assume the two numbers do not contain any leading zero, except the number 0 itself



// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;


Console.WriteLine("Hello, World!");
var reversed = new Solution();
int re=reversed.Reverse(0);
Console.WriteLine("re "+re);


// The question is Solved
public class Solution
{
    public int Reverse(int number)
    {

        if (number == 0) return number;
        int reverse = 0;

        int length = 0;
        int[] array = new int[10];
        while (number != 0)
        {

            //Console.WriteLine(number % 10);
            array[length++] = number % 10;
            //reverse *= digit;

            number /= 10;

        }


        for (int i = 0; i < length; i++)
        {
            if (i + 1 == length) reverse *= 1;
            reverse *= 10;
            reverse += array[i];
        }
        if (array[length - 1] != (reverse % 10)) return 0;
        else return reverse;
    }
}