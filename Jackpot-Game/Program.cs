using System.Drawing;

bool control = false;
bool flag = false;

Random rnd = new Random();

int f = 0;   //first number
int s = 0;   //second number
int t = 0;   //third number

int fRgb = 0;
int sRgb = 0;   //colors
int tRgb = 0;

int point = 0;  //point
int bonus = 0;  //bonus point
int sum = 0;
int result = 0;

string choice;

do
{   //random
    f = rnd.Next(1, 7);
    s = rnd.Next(1, 7);
    t = rnd.Next(1, 7);

    fRgb = rnd.Next(1, 4);
    sRgb = rnd.Next(1, 4);
    tRgb = rnd.Next(1, 4);

    //jackpot
    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("("); Console.ResetColor();

    if (fRgb == 1) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(f); Console.ResetColor(); }
    else if (fRgb == 2) { Console.ForegroundColor = ConsoleColor.Blue; Console.Write(f); Console.ResetColor(); }
    else { Console.ForegroundColor = ConsoleColor.Green; Console.Write(f); Console.ResetColor(); }

    Console.Write(" ");

    if (sRgb == 1) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(s); Console.ResetColor(); }
    else if (sRgb == 2) { Console.ForegroundColor = ConsoleColor.Blue; Console.Write(s); Console.ResetColor(); }
    else { Console.ForegroundColor = ConsoleColor.Green; Console.Write(s); Console.ResetColor(); }

    Console.Write(" ");

    if (tRgb == 1) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(t); Console.ResetColor(); }
    else if (tRgb == 2) { Console.ForegroundColor = ConsoleColor.Blue; Console.Write(t); Console.ResetColor(); }
    else { Console.ForegroundColor = ConsoleColor.Green; Console.Write(t); Console.ResetColor(); }

    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(")"); Console.ResetColor();

    sum = Math.Abs(f - s) + Math.Abs(s - t) + Math.Abs(f - t);  //for consecutive numbers

    //point calculation
    if (f == s && s == t)
    {
        if (fRgb == sRgb && sRgb == tRgb)
        {
            point = 30;
        }
        else if (fRgb != sRgb && sRgb != tRgb && fRgb != tRgb)
        {
            point = 28;
        }
        else point = 26;
    }

    else if (f != s && s != t && f != t && sum == 4)
    {
        if (fRgb == sRgb && sRgb == tRgb)
        {
            point = 20;
        }
        else if (fRgb != sRgb && sRgb != tRgb && fRgb != tRgb)
        {
            point = 18;
        }
        else point = 16;
    }

    else if (f != s && s != t && f != t)
    {
        if (fRgb == sRgb && sRgb == tRgb)
        {
            point = 10;
        }
        else if (fRgb != sRgb && sRgb != tRgb && fRgb != tRgb)
        {
            point = 8;
        }
    }

    else if (f == s && s != t || s == t && f != t || f == t && f != s)
    {
        if (fRgb == sRgb && sRgb == tRgb)
        {
            point = 6;
        }
    }

    if (point > 0)
    {
        if ((f % 2 == 0) && (s % 2 == 0) && (t % 2 == 0)) bonus = 3;
        if ((f % 2 == 1) && (s % 2 == 1) && (t % 2 == 1)) bonus = 3;
    }

    result += point + bonus;

    //bonus control
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (point > 0)
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine("You win " + point + "$.");
        if (bonus > 0) Console.WriteLine("You win " + bonus + "$ bonus.");
    }
    else Console.WriteLine("You lost :(");
    Console.ResetColor();
    point = 0;
    bonus = 0;
    flag = false;

    Console.ForegroundColor = ConsoleColor.White;
    do
    {
        Console.WriteLine("\vDo you want to play again? (Y or N)");
        choice = Console.ReadLine();
        if (choice == "Y") flag = true;
        if (choice == "N") flag = true;
    } while (flag == false);
    Console.ResetColor();
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    if (choice == "N")
    {
        Console.WriteLine("The game is finished!");
        Console.WriteLine("Total score obtained is " + result + "$");
        control = true;
    }

    Console.ResetColor();

}
while (control == false);   //main while loop

Console.ReadLine();