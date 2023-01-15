// Дано натуральное число. Определить ск раз встречается минимальная цифра

/*
static int Number(int count, int num, int min)
{
    //count = 1032012012; int min=10; int countnum = 0;
   // min = 10; count = 1231432;
    while (count > 0)
    {
        num = count % 10;
    if (num < min)
    {
        min = num;
    }
    count /= 10;
}
    return min;
}
int AsNumber = Number(322443, 0, 10) ;

Console.WriteLine($"Мин число {AsNumber}");
*/


int count = 3151721;
int num = 0;
int min = 10;

static int Minchislo(int count, int num, int min)
{
    while (count > 0)
    {
        num = count % 10;
        if (num < min)
        {
            min = num;
        }
        count /= 10;
    }
    return min;
}

//int a = Minchislo(count, num, min);
static int Countchislo(int count, int num, int min)
{
    int a = Minchislo(count, num, min);
    int countnum = 0;
    while (count > 0)
    {
        num = count % 10;
        if (num == a)
        {
            countnum++;
        }
        count /= 10;
    }
    return countnum;
}


Console.WriteLine(Minchislo(count, num, min));
Console.WriteLine(Countchislo(count, num, min));