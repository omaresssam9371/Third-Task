using System;
class Program
{
    

    static void Main(string[] args)
    {
        int x = 10; int y = 20;
        swap_with_ref(ref x, ref y);
        Console.WriteLine($"Swap with ref x:{x},y:{y}");
        swap_with_out(out x, out y);
        Console.WriteLine($"Swap with out x:{x},y:{y}");

    }
    public static void swap_with_ref(ref int x, ref int y)
    {
        int x1 = x;
        x = y;
        y = x1;
    }
    public static void swap_with_out(out int x, out int y)
    {
        x = 10;
        int x1 = x;
        y = 20;
        x = y;
        y = x1;
    }
}

