namespace T1_1;

using System;

class Program
{
    static void Main()
    {
        int money = Input();
        Logic logic = new Logic(money);
        Console.WriteLine(logic.Output());
    }

    static int Input()
    {
        Console.Write("Введите сумму в копейках: ");
        return Convert.ToInt32(Console.ReadLine());
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

    public String Output()
    {
        if (GetRub() == 0)
        {
            return ($"{GetKop()} {KopStr()}");
        }
        else if (GetKop() == 0)
        {
            return ($"{GetRub()} {RubStr()}");
        }
        else
        {
            return ($"{GetRub()} {RubStr()} {GetKop()} {KopStr()}");
        }
    }
}

