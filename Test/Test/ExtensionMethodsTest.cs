namespace Test;

public class ExtensionMethodsTest
{
    public static void testExtensionMethods()
    {
        DateTime dt = DateTime.Now;
        DateTimeOffset dtos = DateTimeOffset.Now;
        Console.WriteLine(dt);
        Console.WriteLine(dtos);
    }
    
}