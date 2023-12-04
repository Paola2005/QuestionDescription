using System;

class QuestionDescripcion
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of problems Sam solves daily:");
        int samDaily = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of problems Kelly solves daily:");
        int kellyDaily = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the initial difference of problems Sam has about Kelly:");
        int difference = int.Parse(Console.ReadLine());

        int result = MinNum(samDaily, kellyDaily, difference);
        Console.WriteLine($"The minimum number of days needed for Kelly to surpass Sam is: {result}");


        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int length = FindLongestSubsequence(arr);
        Console.WriteLine($"The length of the longest subsequence is: {length}");
    }

    static int MinNum(int samDaily, int kellyDaily, int difference)
    {
        if (kellyDaily <= samDaily)
        {
            int days = (difference + (kellyDaily - 1)) / (kellyDaily - samDaily);
            return days >= 0 ? days : -1;
        }

        return -1;
    }

    static int FindLongestSubsequence(int[] arr)
    {
        int[] evenSumIndices = new int[arr.Length];
        int totalSum = 0;
        int maxLength = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            totalSum += arr[i];

            if (totalSum % 2 == 0)
                maxLength = i + 1;

            if (Array.IndexOf(evenSumIndices, totalSum % 2) != -1)
                maxLength = Math.Max(maxLength, i - evenSumIndices[Array.IndexOf(evenSumIndices, totalSum % 2)]);

            if (Array.IndexOf(evenSumIndices, totalSum % 2) == -1)
                evenSumIndices[i] = totalSum % 2;
        }

        return maxLength;
    }
}
