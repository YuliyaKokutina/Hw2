/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

System.Console.WriteLine("Введите число, обозначающее день недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0 && num<8)
{
    if(num==6 || num ==7){System.Console.WriteLine("Выходной день");}
    else {System.Console.WriteLine("Будний день");}
}
else {System.Console.WriteLine("Ввели некорректное число");}