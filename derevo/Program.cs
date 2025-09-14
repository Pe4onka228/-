using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

//beta ЁЛОЧКА!!!!!

do
{
    int num;
    int num2;
    int elkasize;
    int elkalong = 0;
    int trunk;
    int seed;
    int pen;
    int shag1;
    int shag2;
    int starsize = 3;

    string ukrashenie1 = "℗";                            //все переменные которые можно было объявить заранее
    string ukrashenie2 = "©";
    string space = " ";
    string simvol = "^";

    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n \t\t\t\t\t\t ПРОЕКТ ЕЛКА 3.0");    //приветсвие
    Console.WriteLine("\t\t\t\t\t     Режим моддинга ( Y / N )");

    Console.WriteLine();
    Console.WriteLine();


    string y = "Y";                                                  //выбор режима
    string n = "N";
    string mod;
    do
    {
        mod = Console.ReadLine();
    }
    while (mod != y ^ mod == n);
    if (mod == y)                                                        //Настройка елки в режиме моддинга
    {
        Console.WriteLine();
        Console.WriteLine("\t\t\t\t\t      Модификации включены");
        Console.WriteLine();
        Console.WriteLine("\t\t\t\t\t      Выберите украшение 1:");
        ukrashenie1 = Console.ReadLine();
        Console.WriteLine("\t\t\t\t\t      Выберите украшение 2:");
        ukrashenie2 = Console.ReadLine();
        Console.WriteLine("\t\t\t\t\t      Выберите основу елки:");
        simvol = Console.ReadLine();
        Console.WriteLine("\t\t\t\t\t      Выберите размер елки:");
        num = Convert.ToInt32(Console.ReadLine());
        num2 = num;
        elkasize = num;
        Console.WriteLine("\t\t\t\t\t      Выберите размер пня:");
        pen = Convert.ToInt32(Console.ReadLine());
        trunk = pen;
        if (num > pen)
            num2 -= (num - pen);
        else if (num < pen)
            num2 += (pen - num);
    }
    else                                                              //Стандартная елка с заводскими параметрами
    {
        Console.WriteLine("\t\t\t\t\t       Выберите размер елки:");
        num = Convert.ToInt32(Console.ReadLine());
        num2 = num;
        elkasize = num;
        trunk = num;
    }

    Console.WriteLine("\n\n\n\n\n\n\n\n \t\t\t\t\t\t  Генерация елки...");
    Console.WriteLine("\n\n\n\n\n\n\n");

    int trunkdistance = num - (num2 / 5);                                              //значения ствола ёлки
    int trunklong = trunk / 5;
    int midspace = (trunklong * 2) - 1;

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Вот ваша елочка :3");
    Console.WriteLine();
    Console.WriteLine();

    if (elkasize >= 20)                                                         //Звeзда
    {
        while (starsize >= 0)
        {
            int stardistance = num - 3;
            while (stardistance > 0)
            {
                Console.Write(space);
                stardistance--;
            }
            if (starsize == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("   _");
                starsize--;
            }
            else if (starsize == 2)
            {
                Console.Write(@"__/ \__");
                starsize--;
            }
            else if (starsize == 1)
            {
                Console.Write(@"\     /");
                starsize--;
            }
            else if (starsize == 0)
            {
                Console.Write(@"/_/|\_\");
                starsize--;
            }
            Console.WriteLine();
        }
        elkasize--;
        elkalong += 2;
    }
    Console.ResetColor();
    while (elkasize > 0)                                                    //строение кроны   //высота ёлки    
    {
        shag1 = elkasize;
        while (shag1 > 0)                                                 //пробелы слева
        {
            Console.Write(space);
            shag1--;
        }
        shag2 = 0;
        while (shag2 <= elkalong)                                       //сама крона
        {
            if (elkalong == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("*");
                Console.ResetColor();
            }
            else
            {
                Random rnd = new Random();
                seed = rnd.Next(1, 15);
                if (seed == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ukrashenie1);
                    Console.ResetColor();
                }
                else if (seed == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(ukrashenie2);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(simvol);
                    Console.ResetColor();
                }
            }
            shag2++;
        }
        Console.WriteLine();
        elkalong += 2;
        elkasize--;
    }                                                                    //строение ствола
    if (trunklong == 0)                                                 //ствол для маленькой ёлки
    {
        while (trunkdistance > 0)
        {
            Console.Write(space);
            trunkdistance--;
        }
        Console.Write("|");
    }
    else
    {
        while (trunklong > 0)                                      //высота ствола
        {
            shag1 = trunkdistance;
            while (shag1 > 0)                                //расположение ствола пробелами
            {
                Console.Write(space);
                shag1--;
            }
            Console.Write("\x1b[38;5;" + 94 + "m|");
            if (trunklong == 1)                                             //сердцевина ствола - низ ствола
            {
                shag2 = midspace;
                while (shag2 > 0)
                {
                    Console.Write("\x1b[48;5;94m\x1b[38;5;238m_");
                    Console.ResetColor();
                    shag2--;
                }
            }
            else
            {
                shag2 = midspace;
                while (shag2 > 0)
                {
                    Console.Write("\x1b[48;5;94m\x1b[38;5;238m]");
                    Console.ResetColor();
                    shag2--;
                }
            }
            Console.Write("\x1b[38;5;" + 94 + "m|");
            Console.WriteLine();
            trunklong--;
            Console.ResetColor();
        }
    }
    Console.ReadKey();
    Console.WriteLine("Нажмите Enter, чтобы перезапустить или иную клавишу, чтобы завершить");      //окончание программы
}
while (Console.ReadKey().Key == ConsoleKey.Enter);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nПрограмма выполнила свой долг и теперь самоуничтожится\n" +
    $"сохраняйте спокойствие");                                                        //бум бум
Console.ResetColor();   