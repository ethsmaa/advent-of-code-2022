using System;
string[] lines = File.ReadAllLines("day1.txt");
int[] sumArray = new int[500];
int sum = 0;
int count = -1;
for (int i = 0; i < lines.Length; i++)
{
    if (lines[i] != "")
        sum += Convert.ToInt32(lines[i]);

    if (lines[i] == "")
    {
        count++;
        sumArray[count] = sum;
        sum = 0;
    }
}
Array.Sort(sumArray);
Array.Reverse(sumArray);
Console.WriteLine(sumArray[0]); // the elf with the most calories
Console.WriteLine(sumArray[0] + sumArray[1] + sumArray[2]); // sum of the calories