using System;
    //Exercício 1
public class Num1a20
{
    public static void Main(string[] args)
    {
        for (int firstNum = 1; firstNum <= 20; firstNum++)
        {
            if (firstNum % 2 == 0)
            {
                Console.WriteLine(firstNum);
            }
        }
    }
}