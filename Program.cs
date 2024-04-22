using System.Data;
using System.Reflection.Metadata;
using System.Xml.XPath;

Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("Task_1_Infinity");

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
void Infinity (){
    bool bol = false;
    while (bol==false){
        System.Console.Write("Please write someone character: ");
        string str = System.Console.ReadLine();
        if (str=="q"){
            bol=true;
            Console.WriteLine("It's all");
            Console.WriteLine();
        }
    }
}

Infinity();

Console.WriteLine("Task_2_NumberEvenNumbers");
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
    Console.WriteLine();
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
    return result;

}

Console.WriteLine(NumberEvenNumbers(CreateArrayAndWatch(3)));
Console.WriteLine();

Console.WriteLine("Task_3_Shifter");
// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

void ArrayAndWatch(int[] array)
{
    int size = array.Length;
    for (int i=0;i<size;i++){
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
int[] array = [4,3,2,1];

void Shifter(int[] array)
{
    int size = array.Length;
    for (int i=0;i<size/2;i++)
    {
        int var = array[i];
        array[i]=array[size-i-1];
        array[size-i-1]=var;
    }
    ArrayAndWatch(array);
 }

Console.Write("Write someone number: ");
int a=Convert.ToInt32((Console.ReadLine()));
Shifter(CreateArrayAndWatch(a));
