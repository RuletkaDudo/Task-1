using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Hello World");
        int[] mas = { 1, 5, 2, 4, 9, 0, 3 };
        Array.Sort(mas);
        foreach (int i in mas)
        {
            Console.Write(i + " ");
        }
    }
}