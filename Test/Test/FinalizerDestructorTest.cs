namespace Test;

public class FinalizerDestructorTest
{
    public static void testFinalizerDestructor ()
    {
        Person.MakeSomeGarbage();
        Console.WriteLine($"Memory used Before Collection {GC.GetTotalMemory(false)}:N0");
        GC.Collect(); // GC DID HIS JOB XD
        Console.WriteLine($"Memory used After Collection {GC.GetTotalMemory(true)}:N0");

        /*
        var p = new Person();
        p.name = "Ali";
        */
    } // end of program exe (GC)
}
// when the memo is full (GC)
class Person
{
    public string name { get; set; }

    public Person()
    {
        Console.WriteLine("This is P CTOR");
    }

    ~Person()
    {
        Console.WriteLine("This is P DTOR");
    }

    public static void MakeSomeGarbage()
    {
        Version v;
        for (int i = 0; i < 1000; i++)
        {
            v = new Version();
        }
    }
}