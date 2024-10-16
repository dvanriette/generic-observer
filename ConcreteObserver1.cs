public class ConcreteObserver1() : IObserver
{
    public void update(string value)
    {
        Console.WriteLine($"New Value: {value}"); 
    }
}