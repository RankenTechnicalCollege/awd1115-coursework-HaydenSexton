using System.Runtime.InteropServices;

int[] testScores = [100, 90, 30, 88, 75, 93];

// get max ming avg sum

int min = 0;
int max = 100;
int sum = 0;

foreach (int i in testScores)
{
    min = int.Max(min, i);
    max = int.Min(max, i);
    sum += i;
}

Console.WriteLine($"Best: {min}\nWorst: {max}\nSum: {sum}\nAverage: {sum / 6}");
