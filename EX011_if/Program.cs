﻿//даны три положительных числа. могут ли они быть сторонами треугольника
Console.WriteLine ("Введите первое число");
double a = Console.ReadLine();


Console.WriteLine ("Введите второе число");
double b = Console.ReadLine();

Console.WriteLine("Введите третье число ");
double c = Console.ReadLine();

if (a <= 0)
{
Console.WriteLine("Нет, эти три числа не могут быть сторонами треугольника");
}
else{
    if (b<=0){
        Console.WriteLine("Нет, эти три числа не могут быть сторонами треугольника");
    }
    else{
        if (c <=0){
            Console.WriteLine("Нет, эти три числа не могут быть сторонами треугольника");

        }
        else {
            Console.WriteLine("Да, эти три числа могут быть длинами сторон треугольника");
        }
    }
}
