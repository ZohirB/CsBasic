namespace Test;

public class GenericDelegateTypeTest
{
    public delegate bool Filter<in T>(T n);
    
    //Action_ Func_ Predicate
    public static void testGenericDelegateType()
    {
        IEnumerable<int> list = new[] { 1, 2, 3, 4 ,3,1,2,4,5,6,67,7,};
        var x = 5;
        Console.Write($"Numbers Less than {x}: ");
        PrintNumbers(list,e => e < 6);
        
        Console.Write($"Numbers dividable by 2 : ");
        PrintNumbers(list,e => e % 2 == 0);
    }

    static void PrintNumbers<T>(IEnumerable<T> numbers,Filter<T> filter)
    {
        foreach (var n in numbers)
        {
            if (filter(n))
            {
                Console.Write(n);
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}