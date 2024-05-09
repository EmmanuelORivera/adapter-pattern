// Structural design pattern that allows objects with incompatible interfaces
// to collaborate.
Adaptee adaptee1 = new Adaptee();
ITarget target = new Adapter(adaptee1);

System.Console.WriteLine("****************EXAMPLE 1******************");
System.Console.WriteLine("Adaptee interface is incompatible with the client.");
System.Console.WriteLine("But with adapter client can call it's method.");

System.Console.WriteLine(target.GetRequest());

System.Console.WriteLine("****************EXAMPLE 2******************");
var usdPaymentSystem = new USDPaymentSystem();
var adapter = new EURToUSDAdapter(usdPaymentSystem);

double amountEUR = 100.00;
adapter.ProcessPayment(amountEUR);

public interface ITarget
{
    string GetRequest();
}

class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request";
    }
}

class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is {this._adaptee.GetSpecificRequest()}";
    }
}

