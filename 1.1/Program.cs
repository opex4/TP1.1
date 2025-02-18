namespace T1_1;

using System;

class Program
{
    static void Main()
    {
        int money = Input();
        Logic logic = new Logic(money);
        Output(logic);
    }

    static int Input()
    {
        Console.Write("Введите сумму в копейках: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Output(Logic logic)
    {
        if (logic.GetRub() == 0)
        {
            Console.WriteLine($"{logic.GetKop()} {logic.KopStr()}");
        }
        else if (logic.GetKop() == 0)
        {
            Console.WriteLine($"{logic.GetRub()} {logic.RubStr()}");
        }
        else
        {
            Console.WriteLine($"{logic.GetRub()} {logic.RubStr()} {logic.GetKop()} {logic.KopStr()}");
        }
    }
}

public class Logic
{
    private int rub;
    private int kop;

    public Logic(int money)
    {
        this.rub = money / 100;
        this.kop = money % 100;
    }

    public int GetRub()
    {
        return rub;
    }

    public int GetKop()
    {
        return kop;
    }

    public String RubStr()
    {
        if (rub % 100 / 10 == 1)
        {
            return "рублей";
        } else if (rub % 10 == 1)
        {
            return "рубль";
        } else if (rub % 10 is 2 or 3 or 4)
        {
            return "рубля";
        } else
        {
            return "рублей";
        }
    }

    public String KopStr()
    {
        if (kop % 100 / 10 == 1)
        {
            return "копеек";
        }
        else if (kop % 10 == 1)
        {
            return "копейка";
        }
        else if (kop % 10 is 2 or 3 or 4)
        {
            return "копейки";
        }
        else
        {
            return "копеек";
        }
    }
}