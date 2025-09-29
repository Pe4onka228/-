using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

//string[,] GF ={
//    {A1, V1, G1, D1, E1, J1, Z1, I1, K1},
//    {A2, B2, V2, G2, D2, E1, J1, Z1, I1, K1},
//    {A3, B3, V3, G3, D3, E1, J1, Z1, I1, K1},
//    {A4, B4, V4, G4, D4, E1, J1, Z1, I1, K1},
//    {A5, B5, V5, G5, D5, E1, J1, Z1, I1, K1},
//    {A6, B6, V6, G6, D16, E1, J1, Z1, I1, K1},
//    {A7, B7, V7, G7, D1, E1, J1, Z1, I1, K1},
//    {A8, B8, V8, G8, D1, E1, J1, Z1, I1, K1},
//    {A9, B9, V9, G9, D1, E1, J1, Z1, I1, K1},
//    {A10, B10, V10, G10, D1, E1, J1, Z1, I1, K1},
//};
//string [,] GF ={
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//    {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
//void gameboard()
//{
//    Console.WriteLine($"\t\t\t\t\t\t   A B V G D E J Z I K");
//    Console.WriteLine($"\t\t\t\t\t\t 1|{GF[0, 0]}|{GF[0, 1]}|{GF[0, 2]}|{GF[0, 3]}|{GF[0, 4]}|{GF[0, 5]}|{GF[0, 6]}|{GF[0, 7]}|{GF[0, 8]}|{GF[0, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 2|{GF[1, 0]}|{GF[1, 1]}|{GF[1, 2]}|{GF[1, 3]}|{GF[1, 4]}|{GF[1, 5]}|{GF[1, 6]}|{GF[1, 7]}|{GF[1, 8]}|{GF[1, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 3|{GF[2, 0]}|{GF[2, 1]}|{GF[2, 2]}|{GF[2, 3]}|{GF[2, 4]}|{GF[2, 5]}|{GF[2, 6]}|{GF[2, 7]}|{GF[2, 8]}|{GF[2, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 4|{GF[3, 0]}|{GF[3, 1]}|{GF[3, 2]}|{GF[3, 3]}|{GF[3, 4]}|{GF[3, 5]}|{GF[3, 6]}|{GF[3, 7]}|{GF[3, 8]}|{GF[3, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 5|{GF[4, 0]}|{GF[4, 1]}|{GF[4, 2]}|{GF[4, 3]}|{GF[4, 4]}|{GF[4, 5]}|{GF[4, 6]}|{GF[4, 7]}|{GF[4, 8]}|{GF[4, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 6|{GF[5, 0]}|{GF[5, 1]}|{GF[5, 2]}|{GF[5, 3]}|{GF[5, 4]}|{GF[5, 5]}|{GF[5, 6]}|{GF[5, 7]}|{GF[5, 8]}|{GF[5, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 7|{GF[6, 0]}|{GF[6, 1]}|{GF[6, 2]}|{GF[6, 3]}|{GF[6, 4]}|{GF[6, 5]}|{GF[6, 6]}|{GF[6, 7]}|{GF[6, 8]}|{GF[6, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 8|{GF[7, 0]}|{GF[7, 1]}|{GF[7, 2]}|{GF[7, 3]}|{GF[7, 4]}|{GF[7, 5]}|{GF[7, 6]}|{GF[7, 7]}|{GF[7, 8]}|{GF[7, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t 9|{GF[8, 0]}|{GF[8, 1]}|{GF[8, 2]}|{GF[8, 3]}|{GF[8, 4]}|{GF[8, 5]}|{GF[8, 6]}|{GF[8, 7]}|{GF[8, 8]}|{GF[8, 9]}|");
//    Console.WriteLine($"\t\t\t\t\t\t10|{GF[9, 0]}|{GF[9, 1]}|{GF[9, 2]}|{GF[9, 3]}|{GF[9, 4]}|{GF[9, 5]}|{GF[9, 6]}|{GF[9, 7]}|{GF[9, 8]}|{GF[9, 9]}|");
//}
//};

string name1;                                                   //Переменные
string name2;
string space0 = " ";
string ship1 = "O";
string Xship2 = "X";
string miss3 = "•";
string status = "";

bool win = false;

int player = 1;
int turn = 1;
int playerCol;
int playerRow;
int CountNear = 1;
int CountNear2 = 1;

bool error;

bool kater1 = false;
bool esminetz1 = false;
bool kreiser1 = false;
bool avianosetz1 = false;
bool kater2 = false;
bool esminetz2 = false;
bool kreiser2 = false;
bool avianosetz2 = false;

int[,] GF1 ={                                                              //Игровые поля. GF - видно владельцу поля, VGF - видно противнику
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };
int[,] VGF1 ={
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };
int[,] GF2 ={
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };
int[,] VGF2 ={
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

Console.WriteLine("\t\t\t\t\t\tЗДРАВСТВУЙТЕ, ИГРОКИ!");                 //Вывод начального приветствия
Console.WriteLine("\t\t\t\t\tПРИВЕТСТВУЮ В ИГРЕ #MORE KORABLIKI BITVA#!\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tИГРОК НОМЕР 1, ВВЕДИТЕ СВОЁ ИМЯ");
Console.WriteLine("\t\t\t\t(Ник, погоняло, кличку своей собаки, мне вообще по барабану, что вы введёте)");
Console.WriteLine("\t\t\t\t\t (У русских есть секретная техника инвиза!:O)\n\n\n\n\n\n\n\n\n\n\n\n\n\n"); //\x1b[38;5;236m
Console.ResetColor();
name1 = Console.ReadLine();
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tТЕПЕРЬ ИГРОК НОМЕР 2, ВВЕДИТЕ СВОЁ ИМЯ\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
name2 = Console.ReadLine();

void GameField1()              //Вывод поля с расстановкой игрока 1
{
    Console.WriteLine($"\n\n\n\n\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= GF1.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i-1}");
        for (int j = 1; j <= GF1.GetLength(1) - 2; j++)
        {
            if (GF1[i, j] == 0)
            {
                Console.Write($"|{space0}");
                Console.ResetColor();
            }
            if (GF1[i, j] == 1)
            {
                Console.Write($"|{ship1}");
                Console.ResetColor();
            }
            if (GF1[i, j] == 2)
            {
                Console.Write($"|\u001b[38;5;1m{Xship2}");
                Console.ResetColor();
            }
            if (GF1[i, j] == 3)
            {
                Console.Write($"|{miss3}");
                Console.ResetColor();
            }
        }
        Console.WriteLine($"|");
        Console.ResetColor();
    }
    Console.WriteLine($"\n\n\n\n");
}
void GameField2()      //Вывод поля с расстановкой игрока 2
{
    Console.WriteLine($"\n\n\n\n\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= GF2.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i-1}");
        for (int j = 1; j <= GF2.GetLength(1) - 2; j++)
        {
            if (GF2[i, j] == 0)
            {
                Console.Write($"|{space0}");
                Console.ResetColor();
            }
            if (GF2[i, j] == 1)
            {
                Console.Write($"|{ship1}");
                Console.ResetColor();
            }
            if (GF2[i, j] == 2)
            {
                Console.Write($"|\u001b[38;5;1m{Xship2}");
                Console.ResetColor();
            }
            if (GF2[i, j] == 3)
            {
                Console.Write($"|{miss3}");
                Console.ResetColor();
            }
        }
        Console.WriteLine($"|");
        Console.ResetColor();
    }
    Console.WriteLine($"\n\n\n\n");
}
void VisualGameField1()            //Вывод игрового поля игрока 1
{
    Console.WriteLine($"\n\n\n\n\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= VGF1.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i - 1}");
        for (int j = 1; j <= VGF1.GetLength(1) - 2; j++)
        {
            if (VGF1[i, j] == 0)
            {
                Console.Write($"|{space0}");
                Console.ResetColor();
            }
            if (VGF1[i, j] == 1)
            {
                Console.Write($"|{ship1}");
                Console.ResetColor();
            }
            if (VGF1[i, j] == 2)
            {
                Console.Write($"|\u001b[38;5;1m{Xship2}");
                Console.ResetColor();
            }
            if (VGF1[i, j] == 3)
            {
                Console.Write($"|{miss3}");
                Console.ResetColor();
            }
        }
        Console.WriteLine($"|");
        Console.ResetColor();
    }
    Console.WriteLine($"\n\n\n\n");
}
void VisualGameField2()     //Вывод игрового поля игрока 1
{
    Console.WriteLine($"\n\n\n\n\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= VGF2.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i - 1}");
        for (int j = 1; j <= VGF2.GetLength(1) - 2; j++)
        {
            if (VGF2[i, j] == 0)
            {
                Console.Write($"|{space0}");
                Console.ResetColor();
            }
            if (VGF2[i, j] == 1)
            {
                Console.Write($"|{ship1}");
                Console.ResetColor();
            }
            if (VGF2[i, j] == 2)
            {
                Console.Write($"|\u001b[38;5;1m{Xship2}");
                Console.ResetColor();
            }
            if (VGF2[i, j] == 3)
            {
                Console.Write($"|{miss3}");
                Console.ResetColor();
            }
        }
        Console.WriteLine($"|");
        Console.ResetColor();
    }
    Console.WriteLine($"\n\n\n\n");
}
void Error()      //Вывод сообщения об ошибке
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\tОшибочно введено значение, введите его ещё раз");
    Console.ResetColor();
    Console.ReadKey();
    error = true;
}
void CheckCountShip1()  //!Проверка при размещении корабля в клетку, к какому кораблю эта клетка относится. ВРЕМЕННЫЙ ВАРИАНТ
{
    int TempShipCountCol = 0;
    int TempShipCountRow = 0;
    int ShipCountCol = 0;
    int ShipCountRow = 0;

    bool ThisShip = false;
    bool ThisShip2 = false;

    for (int i = 1; i <= 11; i++)
    {
        if (GF1[i,playerCol] == 1)
        {
            TempShipCountCol++;
            if (i == playerRow)
                ThisShip = true;
        }
        else
        {
            if (ThisShip == true)
            {
                ShipCountCol = TempShipCountCol;
                ThisShip = false;
            }
            TempShipCountCol = 0;
        }
        if (GF1[playerRow, i] == 1)
        {
            TempShipCountRow++;
            if (i == playerCol)
                ThisShip2 = true;
        }
        else
        {
            if (ThisShip2 == true)
            {
                ShipCountRow = TempShipCountRow;
                ThisShip2 = false;
            }
            TempShipCountRow = 0;
        }
    }
    int max = Math.Max(ShipCountCol, ShipCountRow);
    switch (max)
    {
        case 1: Console.WriteLine("Ну это единичка");break;
        case 2: Console.WriteLine("Ну это двойка"); break;
        case 3: Console.WriteLine("Ну это тройка"); break;
        case 4: Console.WriteLine("Это АвИаноСиц!"); break;
    }
}
void CheckCountShip2()      //!Проверка при размещении корабля в клетку, к какому кораблю эта клетка относится. ВРЕМЕННЫЙ ВАРИАНТ
{
    int TempShipCountCol = 0;
    int TempShipCountRow = 0;
    int ShipCountCol = 0;
    int ShipCountRow = 0;

    bool ThisShip = false;
    bool ThisShip2 = false;

    for (int i = 1; i <= 11; i++)
    {
        if (GF2[i, playerCol] == 1)
        {
            TempShipCountCol++;
            if (i == playerRow)
                ThisShip = true;
        }
        else
        {
            if (ThisShip == true)
            {
                ShipCountCol = TempShipCountCol;
                ThisShip = false;
            }
            TempShipCountCol = 0;
        }
        if (GF2[playerRow, i] == 1)
        {
            TempShipCountRow++;
            if (i == playerCol)
                ThisShip2 = true;
        }
        else
        {
            if (ThisShip2 == true)
            {
                ShipCountRow = TempShipCountRow;
                ThisShip2 = false;
            }
            TempShipCountRow = 0;
        }
    }
    int max = Math.Max(ShipCountCol, ShipCountRow);
    switch (max)
    {
        case 1: Console.WriteLine("Ну это единичка"); break;
        case 2: Console.WriteLine("Ну это двойка"); break;
        case 3: Console.WriteLine("Ну это тройка"); break;
        case 4: Console.WriteLine("Это АвИаноСиц!"); break;
    }
}
void CheckNear1()       //Проверк а на то, есть ли рядом с размещённой клеткой корабль
{
    if (GF1[playerRow-1, playerCol] == 1  || GF1[playerRow+1, playerCol] == 1 || GF1[playerRow, playerCol-1] == 1 || GF1[playerRow, playerCol + 1] == 1)
    {
        Console.WriteLine("Рядом есть кораблик");
    }
} 
void CheckNear2()      //Проверк а на то, есть ли рядом с размещённой клеткой корабль
{
    if (GF2[playerRow - 1, playerCol] == 1 || GF2[playerRow + 1, playerCol] == 1 || GF2[playerRow, playerCol - 1] == 1 || GF2[playerRow, playerCol + 1] == 1)
    {
        Console.WriteLine("Рядом есть кораблик");
    }
} 
void ShipPlacement()
{
    int shipfragment = 0;
    do
    {
        error = false;
        if (player == 1)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name1}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ СТОЯТЬ ВАШ KORABLIK [в виде (A1)]");
            GameField1();
        }
        else if (player == 2)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name2}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ СТОЯТЬ ВАШ KORABLIK [в виде (A1)]");
            GameField2();
        }
        string plaeyrchoice = Convert.ToString(Console.ReadLine());
        string PLCH = plaeyrchoice.ToUpper();
        if (PLCH.Length != 2)
        {
            Error();
            continue;
        }
        playerRow = (int)char.GetNumericValue(PLCH[1]) + 1;
        switch (PLCH[0])
        {
            case 'A': playerCol = 1; break;
            case 'B': playerCol = 2; break;
            case 'V': playerCol = 3; break;
            case 'G': playerCol = 4; break;
            case 'D': playerCol = 5; break;
            case 'E': playerCol = 6; break;
            case 'J': playerCol = 7; break;
            case 'Z': playerCol = 8; break;
            case 'I': playerCol = 9; break;
            case 'K': playerCol = 10; break;
            default:
                Error();
                continue;
        }
        if (player == 1 && GF1[playerRow, playerCol] == 0)              
        {
            GF1[playerRow, playerCol] = 1;
            shipfragment++;
            CheckCountShip1();
            CheckNear1();
        }
        else if (player == 2 && GF2[playerRow, playerCol] == 0)
        {
            GF2[playerRow, playerCol] = 1;
            shipfragment++;
            CheckNear2();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\tЭта клетка уже занята, введите значение ещё раз");
            Console.ResetColor();
            Console.ReadKey();
            error = true;
        }
        if (shipfragment == 5)
        {
            turn++;
            shipfragment = 0;
            if (player == 1)
                player = 2;
            else if (player == 2)
                player = 1;
        }
    }
    while (error == true || turn <= 2);
}

void game()                 //Сам процесс игры
{
    bool hit;
    do
    {
        error = false;
        hit = false;
        if (player == 1)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name1}, ВЫБЕРИТЕ КЛЕТКУ В КОТОРУЮ ХОТИТЕ БАХНУТЬ");
            VisualGameField1();
        }
        else if (player == 2)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name2}, ВЫБЕРИТЕ КЛЕТКУ В КОТОРУЮ ХОТИТЕ БАХНУТЬ");
            VisualGameField2();
        }
        string plaeyrchoice = Convert.ToString(Console.ReadLine());
        string PLCH = plaeyrchoice.ToUpper();
        if (PLCH.Length != 2)
        {
            Error();
            continue;
        }
        playerRow = (int)char.GetNumericValue(PLCH[1]) + 1;
        switch (PLCH[0])
        {
            case 'A': playerCol = 1; break;
            case 'B': playerCol = 2; break;
            case 'V': playerCol = 3; break;
            case 'G': playerCol = 4; break;
            case 'D': playerCol = 5; break;
            case 'E': playerCol = 6; break;
            case 'J': playerCol = 7; break;
            case 'Z': playerCol = 8; break;
            case 'I': playerCol = 9; break;
            case 'K': playerCol = 10; break;
            default:
                Error();
                continue;
        }
        if (player == 1 && VGF1[playerRow, playerCol] == 0)
        {
            switch (GF2[playerRow, playerCol])
            {
                case 0: 
                    VGF1[playerRow, playerCol] = 3;
                    status = "Мимо";
                    break;
                case 1: 
                    VGF1[playerRow, playerCol] = 2;
                    status = "Попадание!";
                    hit = true;
                    break;
            }
        }
        else if (player == 2 && VGF2[playerRow, playerCol] == 0)
        {
            switch (GF1[playerRow, playerCol])
            {
                case 0: 
                    VGF2[playerRow, playerCol] = 3;
                    status = "  Мимо";
                    break;
                case 1:
                    VGF2[playerRow, playerCol] = 2;
                    status = "Попадание!";
                    hit = true;
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\tЭта клетка уже занята, введите значение ещё раз");
            Console.ResetColor();
            Console.ReadKey();
            error = true;
            continue;
        }
        if (player == 1)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t{status}");
            VisualGameField1();
            Console.ReadKey();
        }
        else if (player == 2)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t{status}");
            VisualGameField2();
            Console.ReadKey();
        }
    }
    while (error == true || hit == true);
}

//GameField1();
ShipPlacement();
while (win == false)
{
    game();
    if (player == 1)
    {
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t{name1} ПЕРЕДАЙТЕ УСТРОЙСТВО ИГРОКУ {name2}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.ReadKey();
        player = 2;
    }
    else if (player == 2)
    {
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t{name2} ПЕРЕДАЙТЕ УСТРОЙСТВО ИГРОКУ {name1}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.ReadKey();
        player = 1;
    }
    turn++;
}