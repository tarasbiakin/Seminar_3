//18. Напишите програму, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти(Х и У)

Console.WriteLine("Укажите номер четверти");
int qarter = Convert.ToInt32(Console.ReadLine());

string Range(int quarter1){
    if(quarter1 ==1) return "x > 0 и y > 0";
    if(quarter1 ==2) return "x < 0 и y > 0";
    if(quarter1 ==3) return "x > 0 и y < 0";
    if(quarter1 ==4) return "x < 0 и y < 0";
    return"Указан неверный номер четверти";
}
string range = Range(qarter);

Console.WriteLine(range);
