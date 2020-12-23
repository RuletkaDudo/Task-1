using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("new World TEXT");
        int[] mas = { 1, 12, 42, 4, 9, 1, 32 };
        Array.Sort(mas);
        foreach (int i in mas)
        {
            Console.Write(i + " ");
        }
    }

    public void b()
    {
        Console.WriteLine('321');
    }
}