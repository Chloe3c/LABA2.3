int a1 = 45, b1 = 13, c1 = -23;
int a2 = -31, b2 = 65, c2 = 12;
int a3 = 52, b3 = -1, c3 = -33;

int min1 = a1;
switch (b1 < min1)
{
    case true:
        min1 = b1;
        break;
}
switch (c1 < min1)
{
    case true:
        min1 = c1;
        break;
}
Console.WriteLine("Наименьшее число из первой группы: " + min1);

int min2 = a2;
switch (b2 < min2)
{
    case true:
        min2 = b2;
        break;
}
switch (c2 < min2)
{
    case true:
        min2 = c2;
        break;
}
Console.WriteLine("Наименьшее число из второй группы: " + min2);

int min3 = a3;
switch (b3 < min3)
{
    case true:
        min3 = b3;
        break;
}
switch (c3 < min3)
{
    case true:
        min3 = c3;
        break;
}
Console.WriteLine("Наименьшее число из третьей группы: " + min3);
