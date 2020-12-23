using System;
					
public class Program
{
	public static void Main()
	{
        int a = 12;
        int b = 3 * a;
        int[] mas = { 1, 12, 42, 4, 9, 1, 32 };
        Array.Sort(mas);
        foreach (int i in mas)
        {
            Console.Write(i + " ");
        }
    }
    public void a()
    {
        Console.WriteLine("123");
    }
    public void b()
    {
        Console.WriteLine("321");
    }
}