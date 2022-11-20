//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

Console.Write("Введите координаты точки ХA: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки YA: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки ХB: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки YB: ");
double yb = Convert.ToDouble(Console.ReadLine());


double Lenght (double xa, double ya,double yb, double xb){
    double res = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb));
    return res;
}

double lenght = Lenght(xa,ya,xb,yb);
double lenghtRound= Math.Round(lenght,2, MidpointRounding.ToZero);
Console.WriteLine(lenghtRound);

