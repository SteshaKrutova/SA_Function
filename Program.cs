using System.Data;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
void Infinity (){
    bool bol = false;
    while (bol==false){
        System.Console.Write("Please write someone character: ");
        string str = System.Console.ReadLine();
        if (str=="q"){
            bol=true;
            Console.Write("It's all");
        }
    }
}

Infinity();
Console.WriteLine();

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArrayAndWatch(int size)
{
    int[] array = new int[size];
    for (int i=0;i<size;i++){
        array[i]=new Random().Next(0,10);
    }
    for (int i=0;i<size;i++){
        Console.Write(array[i]);
    }
    return array;
}

int NumberEvenNumbers(int[] array)
{
    int result =0;

    for (int i=0;i<array.Length;i++){
        if (array[i]%2==0){
            result+=1;
        }
    }
    Console.WriteLine();
    return result;

}

Console.WriteLine(NumberEvenNumbers(CreateArrayAndWatch(3)));