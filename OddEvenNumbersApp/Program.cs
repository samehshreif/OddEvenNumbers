internal class Program
{

    private static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumbers("All Numbers", ints);
        PrintNumbers("Odd Numbers", ints.Where(x=>IsOdd(x)));
        PrintNumbers("Even Numbers", ints.Where(x=>IsEven(x)));
    }
    static void PrintNumbers(string Title,IEnumerable<int> nums) {
        Console.Write($"{Title} : ["); 
        foreach (int i in nums)
        {
            Console.Write(i+",");
        }
        Console.WriteLine("]");
    }
    static bool IsOdd(int n)
    {
        if (n % 2 == 0) {
            return false;
        }
        else
        {
            return true;
        }
    }
    static bool IsEven(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}