using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;

//   A B V
// 1| | | |
// 2| | | |
// 2| | | |
//

Console.ResetColor();
string name1;
string name2;
string X = "X";
string O = "O";

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n \t\t\t\t\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n" +
    "\t\t\t\t\t█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\r\n" +
    "\t\t\t\t\t█░██░██░██░██░██░██░██░██░██░░░░░░░░░░█\r\n" +
    "\t\t\t\t\t█░██░██░██░██░██░██░██░██░██░░░░░░░░░░█\r\n" +
    "\t\t\t\t\t█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█\r\n" +
    "\t\t\t\t\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n" +
    "\t\t\t\t\t░░█░░░░█▀▀▀█░█▀▀█░█▀▀▄░▀█▀░█▄░░█░█▀▀█░░\r\n" +
    "\t\t\t\t\t░░█░░░░█░░░█░█▄▄█░█░░█░░█░░█░█░█░█░▄▄░░\r\n" +
    "\t\t\t\t\t░░█▄▄█░█▄▄▄█░█░░█░█▄▄▀░▄█▄░█░░▀█░█▄▄█░░\r\n" +
    "\t\t\t\t\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.ReadKey();
Console.WriteLine("\t\t\t\t\t\tЗДРАВСТВУЙТЕ, ИГРОКИ!");
Console.WriteLine("\t\t\t\t\tПРИВЕТСТВУЮ В ИГРЕ #KRESTIKI NOLIKI#!\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
string mod = Console.ReadLine();
mod = mod.ToLower();
if (mod == "c==3")
{
    X = Console.ReadLine();
    O = Console.ReadLine();
}
if (mod == "sex")
{
    Console.WriteLine("\t\t\t\t \x1b[48;5;7m\x1b[38;5;233m.\r\n\t\t\t\t\t\t███▓█▓█████████████████████████████▓████\r\n\t\t\t\t\t\t▓█▓█▓██████▓▒▒▒▒▒▒░░░▒▒▓██████████████▓█\r\n\t\t\t\t\t\t█▓█▓███▓█▓▓▒▒▒▓▒▒▒▒▒░───░░▒▓█████▓███▓█▓\r\n\t\t\t\t\t\t▓█▓███▓█▓▓▓█▓▓▒▒▒▓▓████▓▒▒───▓████▓█▓█▓█\r\n\t\t\t\t\t\t█▓████▓▒▓▓▓▒░░▒▒▒░▒░▒▒▓██▓▓▒░─▒██████▓█▓\r\n\t\t\t\t\t\t████▓▒▒▓█▓▒▓▓▓▒▒░░─────░▒▒▒▓▒▒─░████▓███\r\n\t\t\t\t\t\t███▓▒░▓██▓██▓▒▓▒▓▒▒▒▒░░─░▒▒▒▒▒▒─▓██▓█▓██\r\n\t\t\t\t\t\t██▓▒▒▒▒▓▓█▓▓▓▓▓▓▓▓▒▒░▒▒░░▒▒▓▒▓▒░░█████▓█\r\n\t\t\t\t\t\t██▓▒▒░██▓▒▒░▒▒▒▒▒░░─░░░░░▒▓▒▓▒▓░─▒███▓█▓\r\n\t\t\t\t\t\t██░▒▒███▓▓░░░░░░░░░░░░─░─░▒▓░▒░▒─▒██▓█▓█\r\n\t\t\t\t\t\t█▓▒░▓██▓▓▒▒░░░░░░─░─░───░─▒▓▒░▒─▒─███▓█▓\r\n\t\t\t\t\t\t██▒▒▓█▓█▓▓▒░░░░░░░░░░░───░░▒▒░▒░─░▒███▓█\r\n\t\t\t\t\t\t██▒▒▓▓█▓▓▓▒░░─░─░───░░─────░▓░░▒──░████▓\r\n\t\t\t\t\t\t██▒▒▓██▓▓▓▒▒───░░────▒░░░░░░▒▒▒▒▒──▓████\r\n\t\t\t\t\t\t█▓░▒▓████████▒▒░▒▒████████▓░▒░▓▒░░──███▓\r\n\t\t\t\t\t\t█▓─▓▓█████▓▓███▓─▒▓███▓▓▓░──░░░░─░░─░███\r\n\t\t\t\t\t\t█▒─▒█▓▓▓▓▓▓▒▒██▒────░░░─▒───░─░░─░░░─░██\r\n\t\t\t\t\t\t█░─░██▓▒▒░░░▒██▒────────░▒──░██▒──░░░─▒█\r\n\t\t\t\t\t\t█──░███▓▓░░░███▒──░──────░░─▒██▒░─▒░▒▒─▓\r\n\t\t\t\t\t\t█──▒█████▓▒▓██▓░──░▒░░─░░░──▓█▓▒─░░▓░▓▒░\r\n\t\t\t\t\t\t█─░▒█████▓██████▒───────░──░██▓▒░░▒▒▒░▓▒\r\n\t\t\t\t\t\t█─░▓██████▓▓▓█▓▒░░─░░░─────███▒▒░▒░▒▒▒▒▓\r\n\t\t\t\t\t\t█─░▓███████▒███▓▓▓▓▒▒▒░───▓██▓▒▒░▒▒▒▒▒▒▒\r\n\t\t\t\t\t\t▓░─█▓███████▒▓▓▓▓▓▒░────░▓████▒▒░▓▒░▒▓▒▓\r\n\t\t\t\t\t\t▒░▒█▓████████▓▒░──────░▒▓████▓▒░░▓█▒░░▒▒\r\n\t\t\t\t\t\t▒░▒█▓▓████████▓▓▒░─░░▒▓█▓███▓▓░▒░▓██▒▒▒▒\r\n\t\t\t\t\t\t▒─▓▓▓▓█▓█████▓███▓▓▒▓██▓▓████▒─▒▒▒██▓▓▓▓\r\n\t\t\t\t\t\t░▒█▓▒▓▓▓████▓▓▓▓▓▓▓███▓██████▒─▒░▓▓███▓█\r\n\t\t\t\t\t\t▓██▒░▒▓▓█████▓▓▒▓████▓███████░─▒▒▓███░▓▓\r\n\t\t\t\t\t\t███▒░▒░▓██████▓▒▓███▓███████▓░░▒▒███▒▒█▓\r\n\t\t\t\t\t\t██▓░─░░▒███████▒███▓████████▓░░░▓███▒▓█▓\r\n\t\t\t\t\t\t██▓░─░░▓███████▓▓█▓█████████▒░▒▒████▓███\r\n\t\t\t\t\t\t██▓─░─░▒█▓█████▓████████████▒▒▒▓████▒▓██\r\n\t\t\t\t\t\t██▒░░░░▓▓███████▓▓▓█████████▒▓▓████▓▒█▓█\r\n\t\t\t\t\t\t██▓░▒▒▒▒█▓███████▓█████████▓▓▒█████▒█▓█▒\r\n\t\t\t\t\t\t██▓▒▒▒▒▓████████▓███████████▓▓████▓████▓\r\n\t\t\t\t\t\t███▒▓▓▓▒█████████▓█████████▓█▓██▓▒▓█████\r\n\t\t\t\t\t\t▓██▓▓█▓▓████████▓███████████████▒▓████▓█\r\n\t\t\t\t\t\t█▓███▓███▓█▓█▓█▓█▓█▓█▓█▓█▓█▓█████████▓█▓\r\n\t\t\t\t\t\t────────────────────────────────────────\r\n\t\t\t\t\t\t▀█▀▒█▒█▒█▀▒▒█▒▒▒█▒▒▀▒▀█▀▒█▀▒█▒█▒█▀▒█▀▀█▒\r\n\t\t\t\t\t\t▒█▒▒█▀█▒█▀▒▒█▒█▒█▒▀█▀▒█▒▒█░▒█▀█▒█▀▒█▄▄▀▒\r\n\t\t\t\t\t\t▒█▒▒▀▒▀▒▀▀▒▒█▄▀▄█▒▀▀▀▒▀▒▒▀▀▒▀▒▀▒▀▀▒▀▒▀▀▒");
    Console.ReadKey();
    Console.ResetColor();
}
if (mod == "duck")
{
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░\r\n░░░░░░░░░░░░░░░░░░░▄█████▄░░\r\n░░░░░░░░░░░░░░░░░░░████████▄\r\n░░░░░░░░░░░░░░░░░░░███░░░░░░\r\n░░░░░░░░░░░░░░░░░░░███░░░░░░\r\n░░░░░░░░░░░░░░░░░░░███░░░░░░\r\n░░░░░░░░░░░░░░░░░░░███░░░░░░\r\n░░░░░░░░░░░░░░░░░░░███░░░░░░\r\n░░░░░░░░░░░░░▄▄▄▄▄████░░░░░░\r\n░░░░░░░░▄▄████████████▄░░░░░\r\n░░░░▄▄██████████████████░░░░\r\n▄▄██████████████████████░░░░\r\n░▀▀████████████████████▀░░░░\r\n░░░░▀█████████████████▀░░░░░\r\n░░░░░░▀▀███████████▀▀░░░░░░░\r\n░░░░░░░░░▀███▀▀██▀░░░░░░░░░░\r\n░░░░░░░░░░█░░░░██░░░░░░░░░░░\r\n░░░░░░░░░░█░░░░█░░░░░░░░░░░░\r\n░░░▄▄▄▄███████▄███████▄▄▄▄░░");
    Console.WriteLine("\t\tКря");
    Console.ReadKey();
}
if (mod == "uwuf")
{
    Console.WriteLine("\u001b[48;5;7m\u001b[38;5;233m▓█████▓███████▓█▓███▓███▓█▓█████▓███████\r\n\t\t\t\t\t\t████▓▒▓██▓█████▓█▓███▓█████████▓█▓▓▓████\r\n\t\t\t\t\t\t███▓▒▒▒▒▓███▓███████████████▓██▓▒▓▒▓▓███\r\n\t\t\t\t\t\t██▓░▒▒▒▒▓▓███▒▒▒▓▓█▓▓▓██▓▓▓▓█▓▓▓▓▒▓░░▓██\r\n\t\t\t\t\t\t█▓░─░▓▓▓░──▓██▓▒▓▒▒▒▒▒▒▓▒▓▓▓░─░▒▒▓▒──▒██\r\n\t\t\t\t\t\t█▓──░▓█▒────▒▓██████▓▓█████░───░▓█▒──▒██\r\n\t\t\t\t\t\t█▓───▒▒▒───▒▓███████▓███████░───▒▓░──▒▓█\r\n\t\t\t\t\t\t█▒──░░▒▓▒▒▓▓█▓▓▓█▓█████▓▓▓▓▓▓░░▓█▓░░─░▓█\r\n\t\t\t\t\t\t▓▒───▒▒▓▓▓▓▓▓▓▒▓▓█▓███▓▓▓▓▒▓▓▓▓█▓░░───▒█\r\n\t\t\t\t\t\t▓▒▒▒▓▓▓▓▒▒▒▒▓▒▓▓▓▓█▓█▓▓▓▓▓▓▒▓▒▓▓▓▒▓░░░▒▓\r\n\t\t\t\t\t\t▓█▓█▓▓▒░░░░▒▒▒▒▓▒▓▓▓▓▓▓▓▒▒▒▒▒▒░▒▒▓▓▓▓▓▒▓\r\n\t\t\t\t\t\t▓▓▓▓▓▒▒░▒▒▒▒▒▒▓▒▓▓▓▓▓▓▓▒▒░▒▒▒▒▒▒▒▒▓▓█▓▓▓\r\n\t\t\t\t\t\t▒▓▓▒▒▒▒▒▓▓▒▓▒░▒▓▒▓▓▓▓▓▒░░▓▒▓▓▓▓▓▒▒▒▓▓█▒▒\r\n\t\t\t\t\t\t█▓▒▒▒▒▓▒▓▒░────░▒▒▓▒▓▒▒░─░░░▓▓▓▓▓▒▒▒▒▓▓░\r\n\t\t\t\t\t\t▓▓▒▒▒▒▒▒▒▒▓▓▒░──▒▓▒▒▒▒──▒█▒▓▒▓▓▓▒▒▒▒▒▒▓▒\r\n\t\t\t\t\t\t▓▒▒▒▒▒▓▓▒─████░─▒▒▒▒▒░─▒████░─▓▓▓▒▓▒▒▒▓▓\r\n\t\t\t\t\t\t▓▒▒▒▓▓▓▒───▒▓██──▒▒▒░░─██▓░───░▓▓▓▓▓▓▓▓▓\r\n\t\t\t\t\t\t▓▒▓▓▓▒▒───────░──░▓▒▒░─░─────░░─▒▓▓▓▓▓▓▒\r\n\t\t\t\t\t\t▒▓▒▓▒░░░─░───────░▒▒░░─░░░░░░░──░▒▒▒▒▓░─\r\n\t\t\t\t\t\t▒▒▓▒░───────░────░▒▒▒───░░░░░───░─░░▒▒▒─\r\n\t\t\t\t\t\t▒▓▒▒────────────░▒▒▒▒░───░────────░░░▒▒░\r\n\t\t\t\t\t\t░▒▒▒▒░──────────▒░░░░░░───────────░░▒░░─\r\n\t\t\t\t\t\t─▒▒▓▓▒──────────▒▓▓▓▒░───────░─░░▒▒▓▒▒░─\r\n\t\t\t\t\t\t▒▓▓▓█▒░░░──░───███████▓───░▓░─░░░░▓▒▓▓▓░\r\n\t\t\t\t\t\t▓▓▓▓▒▒░───░█▒─░███████▓───██─────░░▒▒▓▓▓\r\n\t\t\t\t\t\t▓▒▒▒▒▒▒░───░▓──▓██████───░█──────░░▒▒▒▒▒\r\n\t\t\t\t\t\t▒▒▒▒▒▒▒▒────────▓████▒───░───────░░▒░▒░▒\r\n\t\t\t\t\t\t▓▒▓▒▒▒▒▒▒────░░▒▓█████▓───────░░░░░░▒▒▓▓\r\n\t\t\t\t\t\t▓▓▒▒░░░▒▒░───░───░────░──░░──░─░░▒▒▓▒▓▓█\r\n\t\t\t\t\t\t▓▒▓▒▒▒▓▒▒░▒░░───░───▒░▒░▒░░─░▒▓░▒▒▓▓▓▓▓▓\r\n\t\t\t\t\t\t▓▓▓▓▓▓▓▒▒▒▒▒░░░▓░░░▒▒▓▒▓▒▒░░░▒▓█▒▓▓▓▓▓▓█\r\n\t\t\t\t\t\t▓▓█▓███▓▓▓▓▒▓▒▓▓▒▒▓▓▓▓▓▓▓▒▒▒▒▒▓▓█▓█▓████\r\n\t\t\t\t\t\t████▓█████▓▓▓▓▓█▒▓▓█▓▓▓▓▒▓▓█▓▓▓█▓███████\r\n\t\t\t\t\t\t███████████▓█████▓███████████████████▓█▓\r\n\t\t\t\t\t\t████████████████████████████████████▓███\r\n\t\t\t\t\t\t█▓█▓█▓███▓███████▓███▓█▓█████▓█▓████████");
    Console.ResetColor();
    Console.WriteLine("\r\n\t\t\t\t\t\t\t  ЖопаСъелаТрусы");
    Console.WriteLine("\t\t\t\t\t\t\t\tАуф");
    Console.ReadKey();
}
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tИГРОК НОМЕР 1, ВВЕДИТЕ СВОЁ ИМЯ");
Console.WriteLine("\t\t\t\t(Ник, погоняло, кличку своей собаки, мне по барабану что вы введёте)");
Console.WriteLine("\t\t\t\t\t \x1b[38;5;236m(У русских есть секретная техника инвиза!:O)\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
Console.ResetColor();
name1 = Console.ReadLine();
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tТЕПЕРЬ ИГРОК НОМЕР 2, ВВЕДИТЕ СВОЁ ИМЯ\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
name2 = Console.ReadLine();
do
{
    string A1 = " ";
    string A2 = " ";
    string A3 = " ";
    string B1 = " ";
    string B2 = " ";
    string B3 = " ";
    string V1 = " ";
    string V2 = " ";
    string V3 = " ";

    bool win = false;

    int player = 1;
    int turn = 0;
    int playerCol;
    int playerRow;

    string[,] GF =
    {
    {A1, B1, V1},
    {A2, B2, V2},
    {A3, B3, V3}
    };

    void gameboard()   //Просто вывод игрового поля
    {
        Console.WriteLine($"\t\t\t\t\t\t\t  A B V ");
        Console.WriteLine($"\t\t\t\t\t\t\t1|{GF[0, 0]}|{GF[0, 1]}|{GF[0, 2]}|");
        Console.WriteLine($"\t\t\t\t\t\t\t2|{GF[1, 0]}|{GF[1, 1]}|{GF[1, 2]}|");
        Console.WriteLine($"\t\t\t\t\t\t\t3|{GF[2, 0]}|{GF[2, 1]}|{GF[2, 2]}|\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    }
    void check()     //САМОЕ МОЁ ГЕНИАЛЬНОЕ ТВОРЕНИЕ В ЭТОМ КОДЕ!!! Проверка на три в ряд на одном цикле (ну цикл в цикле это за один считайте, так как цикл по массиву идёт)
    {
        int CountRow = 0;
        int CountCol = 0;
        int CountDia1 = 0;
        int CountDia2 = 0;
        int strcount = GF.GetLength(0) - 1;
        for (int i = 0; i <= GF.GetLength(0) - 1; i++)
        {
            for (int j = 0; j <= GF.GetLength(1) - 1; j++)
            {
                if (GF[i, j] == GF[i, 0] && GF[i, j] != " ")                //Чек три в ряд
                {
                    CountRow++;
                    if (CountRow == 3)
                    {
                        win = true;
                        return;
                    }
                }
                if (GF[j, i] == GF[0, i] && GF[j, i] != " ")            //Чек три в столбик
                {
                    CountCol++;
                    if (CountCol == 3)
                    {
                        win = true;
                        return;
                    }
                }
            }
            if (GF[i, i] == GF[0, 0] && GF[i, i] != " ")                //Чек три на диагональ \
            {
                CountDia1++;
                if (CountDia1 == 3)
                {
                    win = true;
                    return;
                }
            }
            if (GF[strcount, i] == GF[GF.GetLength(0) - 1, 0] && GF[strcount, i] != " ")             //Чек три на вторую диагональ /
            {
                CountDia2++;
                if (CountDia2 == 3)
                {
                    win = true;
                    return;
                }
            }
            strcount--;
            CountRow = 0;
            CountCol = 0;
        }
    }
    void game()                         //Ну тут и так всё думаю просто. Процесс игры
    {
        bool error;
        do
        {
            error = false;
            if (player == 1)
                Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name1}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ ВАШ {X} [в виде (A1)]\n\n");
            else if (player == 2)
                Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name2}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ ВАШ {O} [в виде (A1)]\n\n");
            gameboard();
            string plaeyrchoice = Convert.ToString(Console.ReadLine());
            string PLCH = plaeyrchoice.ToUpper();
            playerRow = (int)char.GetNumericValue(PLCH[1]) - 1;            //Перевод индекса чара строки в интовую переменную
            if (PLCH[0] == 'A')
            {
                playerCol = 0;
            }
            else if (PLCH[0] == 'B')
            {
                playerCol = 1;
            }
            else if (PLCH[0] == 'V')
            {
                playerCol = 2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tОшибочно введено значение, введите его ещё раз");
                Console.ResetColor();
                Console.ReadKey();
                error = true;
                continue;
            }
            if (player == 1 && GF[playerRow, playerCol] != X && GF[playerRow, playerCol] != O)           //размещение крестиков и ноликов по координатам
            {
                GF[playerRow, playerCol] = X;
            }
            else if (player == 2 && GF[playerRow, playerCol] != X && GF[playerRow, playerCol] != O)
            {
                GF[playerRow, playerCol] = O;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tЭта клетка уже занята, введите значение ещё раз");
                Console.ResetColor();
                Console.ReadKey();
                error = true;
            }
        }
        while (error == true);
        check();
    }
    while (turn < 9 && win == false)                    //Цикл процесса игры
    {
        game();
        if (player == 1)
            player = 2;
        else if (player == 2)
            player = 1;
        turn++;
    }
    if (win == true)
    {
        if (player == 2)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t ПОЗДРАВЛЯЮ С ПОБЕДОЙ {name1}!");
            Console.WriteLine($"\t\t\t\t\t\t    ВЫИГРАЛИ KRESTIKI");
            Console.WriteLine($"\n\n\n\n\t\t\t\t\t Если хотите перезапустить игру, то нажмите ENTER\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"\n\n\t\t\t \x1b[38;5;238mв противном случае боевая ракета b4 будет выпущена по вашим координатам :3");
            Console.ResetColor();
        }
        else if (player == 1)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t ПОЗДРАВЛЯЮ С ПОБЕДОЙ {name2}!");
            Console.WriteLine($"\t\t\t\t\t\t     ВЫИГРАЛИ NOLIKI");
            Console.WriteLine($"\n\n\n\n\t\t\t\t\t Если хотите перезапустить игру, то нажмите ENTER\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"\n\n\t\t\t \x1b[38;5;236mв противном случае боевая ракета b4 будет выпущена по вашим координатам :3");
            Console.ResetColor();
        }
    }
    else
    {
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t ЧТО Ж, ПОБЕДИЛА НИЧЬЯ");
        Console.WriteLine($"\n\n\n\n\t\t\t\t\t Если хотите перезапустить игру, то нажмите ENTER\n\n\n\n\n\n\n\n\n\n\n");
        Console.WriteLine($"\n\n\t\t\t \x1b[38;5;236mв противном случае боевая ракета b46 будет выпущена по вашим координатам :3");
        Console.ResetColor();
    }
}
while (Console.ReadKey().Key == ConsoleKey.Enter);
Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t ПРИЯТНОГО ДНЯ");
Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t \x1b[38;5;236m    ожидайте посылку :> ");
Console.ResetColor();