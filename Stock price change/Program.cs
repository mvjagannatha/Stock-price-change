using System;

public class Stock
{
    // Properties
    public string StockName { get; set; }
    public string StockSymbol { get; set; }
    public double PreviousClosingPrice { get; set; }
    public double CurrentClosingPrice { get; set; }

    // Constructor
    public Stock(string name, string symbol, double previousPrice, double currentPrice)
    {
        StockName = name;
        StockSymbol = symbol;
        PreviousClosingPrice = previousPrice;
        CurrentClosingPrice = currentPrice;
    }

    // Method to calculate percentage change
    public double GetChangePercentage()
    {
        return (CurrentClosingPrice - PreviousClosingPrice) / PreviousClosingPrice * 100;
    }
}

class Program
{
    static void Main()
    {
        var stock = new Stock("WIPRO Technologies", "WIPRO", 480.00, 495.00);
        Console.WriteLine($"The WIPRO stock percentage change from previous day is: {stock.GetChangePercentage()}%");
        Console.ReadKey();
    }
    
}
