//22 напишите програму, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число N");
int x = Convert.ToInt32(Console.ReadLine());


void Kvadrat(int n)
{  if(x<0){
    System.Console.WriteLine("не то число");
    }
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}|{Math.Pow(i,2)}");
    }
}


Kvadrat(x);