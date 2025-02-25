namespace _1_3;
using System;

class Program
{
    static void Main()
    {
        string sentence = Input();
        Logic logic = new Logic(sentence);
        Output(logic);
    }

    static string Input()
    {
        Console.Write("Введите предложение: ");
        return Console.ReadLine();
    }

    static void Output(Logic logic)
    {
        Console.WriteLine($"Доля букв в предложении: {logic.LetterPercentage():F2}%");
    }
}

public class Logic
{
    private string sentence;

    public Logic(string sentence)
    {
        this.sentence = sentence;
    }

    public double LetterPercentage()
    {
        int letterCount = 0;
        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                letterCount++;
            }
        }
        return sentence.Length > 0 ? (letterCount / (double)sentence.Length) * 100 : 0;
    }
}
