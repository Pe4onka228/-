using System;

//Версия проверки на выбор постановки кораблей
NavalBattle player0;
NavalBattle player1;
string name1;
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
bool ErrorNear = false;

bool kater1 = false;
bool esminetz1 = false;
bool podlodka1 = false;
bool avianosetz1 = false;
bool kater2 = false;
bool esminetz2 = false;
bool podlodka2 = false;
bool avianosetz2 = false;


int[,] GF1 ={
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

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tЗДРАВСТВУЙТЕ, ИГРОКИ!");                 //Вывод начального приветствия
Console.WriteLine("\t\t\t\t\tПРИВЕТСТВУЮ В ИГРЕ #MORE KORABLIKI BITVA#!\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
Console.ReadKey();
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tИГРОК НОМЕР 1, ВВЕДИТЕ СВОЁ ИМЯ");
Console.WriteLine("\t\t\t\t(Ник, погоняло, кличку своей собаки, мне по барабану, что вы введёте)");
Console.WriteLine("\t\t\t\t\t(У русских есть секретная техника инвиза!-_-)\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
Console.ResetColor();
name1 = Console.ReadLine();
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tТЕПЕРЬ ИГРОК НОМЕР 2, ВВЕДИТЕ СВОЁ ИМЯ\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
name2 = Console.ReadLine();

// Создание игроков
player0 = new NavalBattle(name1);
player1 = new NavalBattle(name2);

void GameField1()              //Вывод поля с расстановкой игрока 1
{
    Console.WriteLine($"\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= GF1.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i - 1}");
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
    Console.WriteLine($"\n\n");
}

void GameField2()      //Вывод поля с расстановкой игрока 2
{
    Console.WriteLine($"\n\n\t\t\t\t\t\t  A B V G D E J Z I K");
    for (int i = 1; i <= GF2.GetLength(0) - 2; i++)
    {
        Console.ResetColor();
        Console.Write($"\t\t\t\t\t\t{i - 1}");
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

void shipZopa()
{
    if (player == 1)
        player1.shipZopa();
    else
        player0.shipZopa();
}

void ShipPlacement1()
{
    while (!player0.AllShipsPlaced())
    {
        int shipRotate = 1;
        error = false;
        ConsoleKey keyInput;

        do
        {
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\t\t{name1}, расставляйте корабли! Осталось {player0.ShipsToPlace.Length - player0.CurrentShipIndex} кораблей");
            Console.WriteLine($"\t\tТекущий корабль: {player0.GetCurrentShipSize()}-палубный\n");
            Console.WriteLine($"\t\tВЫ МОЖЕТЕ ВЫБРАТЬ РАЗВЕРНУТЬ КОРАБЛЬ ИСПОЛЬЗУЯ СТРЕЛОК. НАЖМИТЕ (ENTER), ЧТОБЫ ПОДТВЕРДИТЬ ПОЛОЖЕНИЕ\n");

            switch (shipRotate)
            {
                case 1:
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m\n\n\n");
                    break;
                case 2:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m000\n\n\n");
                    break;
                case 3:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    break;
                case 4:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t     000\u001b[31m0\u001b[0m\n\n\n");
                    break;
            }
            GameField1();
            keyInput = Console.ReadKey().Key;
            switch (keyInput)
            {
                case ConsoleKey.UpArrow: shipRotate = 1; break;
                case ConsoleKey.RightArrow: shipRotate = 2; break;
                case ConsoleKey.DownArrow: shipRotate = 3; break;
                case ConsoleKey.LeftArrow: shipRotate = 4; break;
            }
        }
        while (keyInput != ConsoleKey.Enter);

        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name1}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ СТОЯТЬ ВАШ KORABLIK [в виде (A1)]");
        GameField1();
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

        // Проверяем можно ли разместить корабль
        if (player0.CanPlaceShip(GF1, playerRow, playerCol, player0.GetCurrentShipSize(), shipRotate))
        {
            // Размещаем корабль
            player0.PlaceShip(GF1, playerRow, playerCol, player0.GetCurrentShipSize(), shipRotate);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Невозможно разместить корабль здесь! Нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey();
            error = true;
        }
    }
}

void ShipPlacement2()
{
    while (!player1.AllShipsPlaced())
    {
        int shipRotate = 1;
        error = false;
        ConsoleKey keyInput;

        do
        {
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\t\t{name2}, расставляйте корабли! Осталось {player1.ShipsToPlace.Length - player1.CurrentShipIndex} кораблей");
            Console.WriteLine($"\t\tТекущий корабль: {player1.GetCurrentShipSize()}-палубный\n");
            Console.WriteLine($"\t\tВЫ МОЖЕТЕ ВЫБРАТЬ РАЗВЕРНУТЬ КОРАБЛЬ ИСПОЛЬЗУЯ СТРЕЛОК. НАЖМИТЕ (ENTER), ЧТОБЫ ПОДТВЕРДИТЬ ПОЛОЖЕНИЕ\n");

            switch (shipRotate)
            {
                case 1:
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m\n\n\n");
                    break;
                case 2:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m000\n\n\n");
                    break;
                case 3:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\u001b[31m0\u001b[0m");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    Console.WriteLine("\t\t\t\t\t\t\t\t0");
                    break;
                case 4:
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t     000\u001b[31m0\u001b[0m\n\n\n");
                    break;
            }
            GameField2();
            keyInput = Console.ReadKey().Key;
            switch (keyInput)
            {
                case ConsoleKey.UpArrow: shipRotate = 1; break;
                case ConsoleKey.RightArrow: shipRotate = 2; break;
                case ConsoleKey.DownArrow: shipRotate = 3; break;
                case ConsoleKey.LeftArrow: shipRotate = 4; break;
            }
        }
        while (keyInput != ConsoleKey.Enter);

        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name2}, ВЫБЕРИТЕ КЛЕТКУ НА КОТОРОЙ БУДЕТ СТОЯТЬ ВАШ KORABLIK [в виде (A1)]");
        GameField2();
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

        // Проверяем можно ли разместить корабль
        if (player1.CanPlaceShip(GF2, playerRow, playerCol, player1.GetCurrentShipSize(), shipRotate))
        {
            // Размещаем корабль
            player1.PlaceShip(GF2, playerRow, playerCol, player1.GetCurrentShipSize(), shipRotate);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Невозможно разместить корабль здесь! Нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey();
            error = true;
        }
    }
}

void game1()                         //Сам процесс игры
{
    bool hit;
    do
    {
        error = false;
        hit = false;    //Попадание
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name1}, ВЫБЕРИТЕ КЛЕТКУ В КОТОРУЮ ХОТИТЕ БАХНУТЬ");
        VisualGameField1();
        string plaeyrchoice = Convert.ToString(Console.ReadLine());                 //Ввод координаты корабликов
        string PLCH = plaeyrchoice.ToUpper();
        if (PLCH.Length != 2)                                           //Проверка на правильный ввод
        {
            Error();
            continue;
        }
        playerRow = (int)char.GetNumericValue(PLCH[1]) + 1;
        switch (PLCH[0])                                        //Присваивание коордиратам значений
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
        if (VGF1[playerRow, playerCol] == 0)             //Проверка на попадание
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
                    shipZopa();
                    if (player0.ShipsOstalos == 18)       // снести это хрень в будущем#
                    {
                        continue;
                    } 
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
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t{status}");        //Ввод "Попал" или "Промазал"
        VisualGameField1();
        Console.ReadKey();
    }
    while (error == true || hit == true);
}

void game2()                         //Сам процесс игры
{
    bool hit;
    do
    {
        error = false;
        hit = false;
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t{name2}, ВЫБЕРИТЕ КЛЕТКУ В КОТОРУЮ ХОТИТЕ БАХНУТЬ");
        VisualGameField2();
        string plaeyrchoice = Convert.ToString(Console.ReadLine());                 //Ввод координаты корабликов
        string PLCH = plaeyrchoice.ToUpper();
        if (PLCH.Length != 2)                                           //Проверка на правильный ввод
        {
            Error();
            continue;
        }
        playerRow = (int)char.GetNumericValue(PLCH[1]) + 1;
        switch (PLCH[0])                                        //Присваивание коордиратам значений
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
        if (VGF2[playerRow, playerCol] == 0)           //Проверка на попадание
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
                    shipZopa();
                    if (player1.ShipsOstalos == 18)       // снести это хрень в будущем gj;fkeqcnf vyt gkj[f лабу дабу даб даб! оно ещё и не работает#
                    {
                        continue;
                    }
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
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t{status}");              //Ввод "Попал" или "Промазал"
        VisualGameField2();
        Console.ReadKey();
    }
    while (error == true || hit == true);
}

//GameField1();
ShipPlacement1();
ShipPlacement2();
while (player0.da == false & player1.da == false)        //Основной цикл процесса игры
{
    game1();
    game2();
    if (player == 1 & player0.da == false & player1.da == false)
    {
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t{name1} ПЕРЕДАЙТЕ УСТРОЙСТВО ИГРОКУ {name2}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.ReadKey();
        player = 2;
    }
    else if (player == 2 & player0.da == false & player1.da == false)
    {
        Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t{name2} ПЕРЕДАЙТЕ УСТРОЙСТВО ИГРОКУ {name1}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.ReadKey();
        player = 1;
    }
    turn++;
}
if (player0.da == true)
{
    Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t ПОЗДРАВЛЯЮ {name1} ЖЁСТКО ДАЛ В РОТ ИГРОКУ {name2}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.ReadKey();
}
if (player1.da == true)
{
    Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t ПОЗДРАВЛЯЮ {name2} ЖЁСТКО ДАЛ В РОТ ИГРОКУ {name1}\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    Console.ReadKey();
}
class NavalBattle
{
    public string PlayerName { get; private set; }
    public int ShipsOstalos { get; private set; }
    public bool da = false;

    // Добавляем отслеживания расставленных кораблей
    public bool[,] ShipPositions { get; private set; }
    public int[] ShipsToPlace { get; private set; }
    public int CurrentShipIndex { get; private set; }

    public NavalBattle(string name)
    {
        PlayerName = name;
        ShipsOstalos = 20; //10 кораблей всего(наверное)?, а бля их 20
        ShipPositions = new bool[12, 12]; // поле 12x12 с границами
        ShipsToPlace = new int[] { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 }; // Ну там короче корабли все 1x4, 2x3, 3x2, 4x1
        CurrentShipIndex = 0;
    }

    public void shipZopa()
    {
        if (ShipsOstalos > 0)
            ShipsOstalos--;
        if (ShipsOstalos == 18)
            da = true;
    }

    public void schetLodok()
    {
        Console.WriteLine($"Игрок: {PlayerName} | Кораблей осталось: {ShipsOstalos}");
    }

    // Функция для проверки возможности размещения корабля
    public bool CanPlaceShip(int[,] field, int startRow, int startCol, int size, int direction)
    {
        if (direction == 1 || direction == 3) // Вертикально
        {
            if (startRow + size - 1 > 10) return false;

            for (int i = 0; i < size; i++)
            {
                if (field[startRow + i, startCol] != 0) return false;
                // Проверяем соседние клетки
                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = startRow + i + dr;
                        int nc = startCol + dc;
                        if (nr >= 1 && nr <= 10 && nc >= 1 && nc <= 10 && field[nr, nc] != 0)
                            return false;
                    }
                }
            }
        }
        else // Горизонтально
        {
            if (startCol + size - 1 > 10) return false;

            for (int i = 0; i < size; i++)
            {
                if (field[startRow, startCol + i] != 0) return false;
                // Проверяем соседние клетки
                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = startRow + dr;
                        int nc = startCol + i + dc;
                        if (nr >= 1 && nr <= 10 && nc >= 1 && nc <= 10 && field[nr, nc] != 0)
                            return false;
                    }
                }
            }
        }
        return true;
    }

    // Функция для размещения корабля на поле
    public void PlaceShip(int[,] field, int startRow, int startCol, int size, int direction)
    {
        if (direction == 1 || direction == 3) // Вертикально
        {
            for (int i = 0; i < size; i++)
            {
                field[startRow + i, startCol] = 1;
                ShipPositions[startRow + i, startCol] = true;
            }
        }
        else // Горизонтально
        {
            for (int i = 0; i < size; i++)
            {
                field[startRow, startCol + i] = 1;
                ShipPositions[startRow, startCol + i] = true;
            }
        }
        CurrentShipIndex++;
    }

    // Проверка, все ли корабли расставлены
    public bool AllShipsPlaced()
    {
        return CurrentShipIndex >= ShipsToPlace.Length;
    }

    // Получение текущего размера корабля для расстановки
    public int GetCurrentShipSize()
    {
        if (CurrentShipIndex < ShipsToPlace.Length)
            return ShipsToPlace[CurrentShipIndex];
        return 0;
    }
}