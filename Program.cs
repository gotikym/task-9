using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите то, что хотите донести до всех: ");
        string userMessage = Console.ReadLine();
        Console.Write("Сколько раз стоит об этом сообщить? :  ");
        int quantityRepeat = Convert.ToInt32(Console.ReadLine());

        while (quantityRepeat-- > 0)
        {
            Console.WriteLine(userMessage);
        }
    }
}