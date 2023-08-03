namespace Test;

public class EventsAndDelegateTest
{
    public static void testDelegate()
    {
        var stock = new Stock("Amazon");
        stock.Price = 100;
        stock.onPriceChanged += Stock.Stock_OnPriceChanged;
        stock.ChangesStockPriceBy(0.05m);
        stock.ChangesStockPriceBy(-0.1m);
        stock.ChangesStockPriceBy(0.00m);
        Console.WriteLine();
    }
}

class Stock
{
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    
    private string name; // Amazon
    private decimal price; // 100
    public event StockPriceChangeHandler onPriceChanged; // event with delegate (need more explination)

    public string Name => this.name; // 
    public decimal Price
    {
        get => this.price;
        set => this.price = value;
    }

    public Stock(string stockname) // constructor
    {
        this.name = stockname;
    }

    public void ChangesStockPriceBy(decimal percent) 
    {
        decimal oldPrice = this.price; // to store the old price
        this.price += Math.Round(this.price * percent, 2);
        if (onPriceChanged != null)
        {
            onPriceChanged(this, oldPrice);
        }
    }
    public static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
    {
        string result = "";
        if (stock.Price > oldPrice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            result = "up";
        } 
        else if (oldPrice > stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            result = "down";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            result = "stable";
        }
        Console.WriteLine($"{stock.Name}: ${stock.Price} - {result}");
    }
}