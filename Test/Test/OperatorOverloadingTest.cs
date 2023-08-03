namespace Test;

public class OperatorOverloadingTest
{
    public static void testOperatorOverloading()
    {
        Money m1 = new Money(10);
        Money m2 = new Money(20);
        Console.WriteLine($"Monye m1: ${m1.Amount}, Monye m2: ${m2.Amount} ");

        Money m3 = m1 + m2;
        Console.WriteLine($"The answer of (m1+m2): ${m3.Amount}");
        
        Money m4 = m1 - m2;
        Console.WriteLine($"The answer of (m1-m2): ${m4.Amount}");

    } 
}

class Money
{
    private decimal _amount;
    public decimal Amount => _amount;

    public Money(decimal value)
    {
        this._amount = Math.Round(value, 2);
    }

    public static Money operator +(Money money1, Money money2)
    {
        var value = money1._amount + money2._amount;
        return new Money(value);
    }
    
    public static Money operator -(Money money1, Money money2)
    {
        var value = money1._amount - money2._amount;
        return new Money(value);
    }
}