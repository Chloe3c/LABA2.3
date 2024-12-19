try
{
    //const double a = 45;
    //const double b = 13;
    //const double c = -23;

    //const double a = -31;
    //const double b = 65;
    //const double c = 12;

    const double a = 52;
    const double b = -1;
    const double c = -33;
    if ((a < b)&&(a < c)) Console.WriteLine($"{a} (a - наименьшее)");
    else if ((b < c)&&(b<a)) Console.WriteLine($"{b} (b - наименьшее)");
    else if ((c<a)&&(c<b)) Console.WriteLine($"{c} (c - наименьшее)");
    else Console.WriteLine("Какая то ошибка");
    
         
    




}
catch
{
    Console.WriteLine("Введите верно!");
}
