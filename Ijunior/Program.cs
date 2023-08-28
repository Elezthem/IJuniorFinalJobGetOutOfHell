int doors = 1;
int three = 3;
int four = 4;
int five = 5;
int six = 6;
int seven = 7;
int eight = 8;
int exit = 2;
int health = 66;
int buttle = 10;
int buttle1 = 20;
int buttle2 = 30;
int buttle3 = 40;
int buttle4 = 50;
int next0 = 100;
int boss = 200;
int theend = 300;
bool isDoor = true;
int playerInput;

int playerHealth = 100;
int playerDamage = 4;
int enemyHealth = 40;
int enemyDamage = 2;

Console.WriteLine("Game: Практическая работа - Выберись из ада");
Console.WriteLine();

Console.WriteLine("Game: Ты попал в ад, если ты имеешь желание выбраться и жить дальше, то тыкай `1`");
Console.WriteLine("Game: Если тебе тут нравиться, то тыкай `2`");

Console.WriteLine();

while (isDoor == true)
{
    playerInput = Convert.ToInt32(Console.ReadLine());

    if (playerInput == exit)
    {
        Console.WriteLine("\nBoss: АХАХХАХ, иди ко мне." +
            "\n\nYou: Oh no");
    }

    else if (playerInput == doors)
    {
        Console.WriteLine("Boss: Ок, какую дверь выберешь? ( 3 | 4 )");
    }

    else if (playerInput == three)
    {
        Console.WriteLine("Game: Тебе повезло! Противника нету!" +
            "\n\nBoss: Вот черт... Проходи дальше, жми `100`");
    }

    else if (playerInput == four)
    {
        Console.WriteLine("Game: Ужас! Тут противник! Сражайста!!!" +
            "\n\nBoss: Хм, нажми `10` или мой телохранитель...");
    }

    else if (playerInput == buttle)
    {

        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " игрок.");
            Console.WriteLine(enemyHealth + " враг.");
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока. Для продолжения нажмите `100`");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага.");
        }

    }

    else if (playerInput == next0)
    {
        Console.WriteLine("Game: Ты молодец! Но это только начало... Какую дверь выберешь? ( 5 | 6 | 7 )" +
            "\n\nBoss: ХА! Я снова тут! Я так понял ты хочешь дальше? Так ли? Тогда жми `5` чтобы попасть в команту без босса.");
    }

    else if (playerInput == five)
    {
        Console.WriteLine("Game: Зачем ты его послушал?!" +
            "\n\nBoss: ХА! Да да, я тебя обманул, сразись с моим телохранителем `30`");
    }

    else if (playerInput == buttle1)
    {

        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " игрок.");
            Console.WriteLine(enemyHealth + " враг.");
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока. Для продолжения нажмите `66`");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага.");
        }

    }

    else if (playerInput == buttle2)
    {

        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " игрок.");
            Console.WriteLine(enemyHealth + " враг.");
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока. Для продолжения нажмите `66`");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага.");
        }

    }

    else if (playerInput == six)
    {
        Console.WriteLine("Game: Противников нету! Для продолжения нажмите `66`" +
            "\n\nBoss: Хм");
    }

    else if (playerInput == seven)
    {
        Console.WriteLine("Game: Противников нету! Для продолжения нажмите `66`" +
            "\n\nBoss: Хм, AAAA");
    }

    else if (playerInput == health)
    {
        Console.WriteLine("Game: Вижу ты сильно устал, вот тебе 100XP" +
            "\n\nЖена: Как! ты где?" +
            "\n\nYou: Я скоро вернусь! ( Надеюсь... )" +
            "\n\nGame: Вижу ты отдохнул, но тебя ждет новый противник, Вот тебе номер двери `8`");
    }

    else if (playerInput == eight)
    {
        Console.WriteLine("Game: О ты тут, сражайся! Чтобы сражаться нажмите `40`");
    }

    else if (playerInput == buttle3)
    {

        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " игрок.");
            Console.WriteLine(enemyHealth + " враг.");
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока. Для продолжения нажмите `200`");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага.");
        }
    }

    else if (playerInput == boss)
    {
        Console.WriteLine("Boss: Ну привет еще раз, ты думал это всё? НЕТ!" +
            "\n\nBoss: Это время я готовился, подумать не мог что ты доберешься к этому этапу! Ну а мы начинаем бой." +
            "\n\nGame: Чтобы начать бой, нажмите `50`");
    }

    else if (playerInput == buttle4)
    {

        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " игрок.");
            Console.WriteLine(enemyHealth + " враг.");
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока. Для продолжения нажмите `300`");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага.");
        }
    }

    else if (playerInput == theend)
    {
        Console.WriteLine("Boss: ЧТО!? WHAT!? NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!" +
            "\n\nGame: Босс умер..." +
            "\n\nGame: Поздравляем! Вы прошли от начала и до конца! Вот ваш приз ( 100000000$ )" +
            "\n\nGame: Врота открылись" +
            "\n\nGame: Game Over");
    }
}