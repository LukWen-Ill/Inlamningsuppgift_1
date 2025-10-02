namespace App;

class Utils
{
    public static void ClearScreen()
    {
        try { Console.Clear(); } catch { }
    }
    public static void PressEnter()
    {
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue .. ");
        Console.ReadLine();
    }
}