class PaymentTerminal
{
    private double money{get;set;}
    private int lunchesSold{get;set;}
    private int coffeesSold{get;set;}

    private const double lunchPrice = 10.0;
    private const double coffeePrice = 5.0;

    public PaymentTerminal()
    {
        money = 1000.0;
        lunchesSold = 0;
        coffeesSold = 0;
    }
    public double EatLunch(double cash)
    {
        if (cash >= lunchPrice)
        {
            money += lunchPrice;
            lunchesSold++;
            return cash - lunchPrice;
        }

        return cash;
    }
    public double DrinkCoffee(double cash)
    {
        if (cash >= coffeePrice)
        {
            money += coffeePrice;
            coffeesSold++;
            return cash - coffeePrice;
        }

        return cash;
    }
    public bool EatLunch(PaymentCard card)
    {
        if (card.TakeMoney(lunchPrice))
        {
            lunchesSold++;
            return true;
        }

        return false;
    }
    public bool DrinkCoffee(PaymentCard card)
    {
        if (card.TakeMoney(coffeePrice))
        {
            coffeesSold++;
            return true;
        }

        return false;
    }
    public void AddMoneyToCard(PaymentCard card, double amount)
    {
        if (amount > 0)
        {
            card.AddMoney(amount);
            money += amount;
        }
    }
}