namespace Test;
public delegate void RectDelegate(decimal width, decimal height);
public class DelegateTest 
{
    public static void testDelegate()
    {
        var helper = new RectangeHelper();
        RectDelegate rect; 
        rect = helper.GetArea;
        rect += helper.GetPerimter;
        rect(10, 10);
        Console.WriteLine();
    }
}
class RectangeHelper
{
    public void GetArea(decimal width, decimal hight)
    {
        var result = width * hight;
        Console.WriteLine($"Area: {width} * {hight} = {result}");
    }
    public void GetPerimter(decimal width, decimal hight)
    {
        var result = 2 * (width + hight);
        Console.WriteLine($"Perimter: 2 * {width} * {hight} = {result}");
    }
}