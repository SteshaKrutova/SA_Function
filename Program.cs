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