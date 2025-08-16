public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfTwo(16)); // output true
        Console.WriteLine(IsPowerOfTwo(17)); // output false
        Console.WriteLine(IsPowerOfTwo(1)); // output true
        Console.WriteLine(IsPowerOfTwo(10)); // output false
    }
    public static bool IsPowerOfTwo(int n)
    {
        if(n==0)
        {
            return false;
        }
        while(n!=1)
        {
            if(n%2!=0)
            {
                return false;
            }
            else
            {
                n = n / 2;
            }
        }
        return true;
    }
}
