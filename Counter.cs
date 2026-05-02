class Counter
{
    public int value { get; set; }

    public Counter()
    {
        value = 0;
    }

    public Counter(int startValue)
    {
        value = startValue;
    }

    public void Increase()
    {
        value++;
    }

    public void Decrease()
    {
        value--;
    }

    public void Increase(int increaseBy)
    {
        if (increaseBy >= 0)
        {
            value += increaseBy;
        }
    }

    public void Decrease(int decreaseBy)
    {
        if (decreaseBy >= 0)
        {
            value -= decreaseBy;
        }
    }
}