using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите то, что хотите донести до всех: ");
        string userMessage = Console.ReadLine();
        Console.Write("Сколько раз стоит об этом сообщить? :  ");
        int quantityRepeatMessage = Convert.ToInt32(Console.ReadLine());

        for (int i=0; i< quantityRepeatMessage; i++)
        {
            Console.WriteLine(userMessage);
        }
    }
}
