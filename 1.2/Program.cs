namespace T1_2;

using System;

class Program
{
    static void Main()
    {
        int[] sequence = Input();
        Logic logic = new Logic(sequence);
        Output(logic);
    }

    static int[] Input()
    {
        Console.Write("Введите последовательность ненулевых целых чисел (разделённых пробелом): ");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);
        return numbers;
    }

    static void Output(Logic logic)
    {
        Console.WriteLine($"Количество смен знака: {logic.CountSignChanges()}");
    }
}

public class Logic
{
    private int[] sequence;

    public Logic(int[] sequence)
    {
        this.sequence = sequence;
    }

    public int CountSignChanges()
    {
        int count = 0;
        for (int i = 1; i < sequence.Length; i++)
        {
            if ((sequence[i - 1] > 0 && sequence[i] < 0) || (sequence[i - 1] < 0 && sequence[i] > 0))
            {
                count++;
            }
        }
        return count;
    }
}
