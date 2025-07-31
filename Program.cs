/*
Write a function that reverses a string. The input string is given as an array of characters s.
You must do this by modifying the input array in-place. (Problem 344 in leetcode)

Example 1:
    Input: s = ["h","e","l","l","o"]
    Output: ["o","l","l","e","h"]

Example 2:
    Input: s = ["H","a","n","n","a","h"]
    Output: ["h","a","n","n","a","H"]
*/

namespace ChallengeLab_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = "hello".ToCharArray();
            ReverseArray(s);

            Console.WriteLine(); // next test
            s = "Hannah".ToCharArray();
            ReverseArray(s);

            Console.WriteLine(); // next test
            s = "12345".ToCharArray();
            ReverseArray(s);
        }

        static void ReverseArray(char[] input)
        {
            // Print array
            Console.WriteLine($" Input: [\"{String.Join("\",\"", input)}\"]");

            // Reverse array
            for (int i = 0; i < input.Length / 2; i++)
            {
                char temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            //// Testing and slightly improving on another student's solution
            //int firstIndex = 0;
            //for (int i = input.Length - 1; i > input.Length / 2; i--)
            //{
            //    (input[firstIndex], input[i]) = (input[i], input[firstIndex++]);
            //}

            // Print array again, now reversed
            Console.WriteLine($"Output: [\"{String.Join("\",\"", input)}\"]");
        }
    }
}
