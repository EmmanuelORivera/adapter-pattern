// Adaptee: the existing payment system that works with USD
class USDPaymentSystem
{
    public void ProcessPayment(double amountUSD)
    {
        System.Console.WriteLine($"Processing payment of {amountUSD} USD");
    }
}

interface EURPaymentProcessor
{
    void ProcessPayment(double amountEUR);
}

// Adapter: Adapts the EURPaymentProcessor interface to work with the USDPaymentSystem
class EURToUSDAdapter : EURPaymentProcessor
{
    private readonly USDPaymentSystem usdPaymentSystem;
    private const double EURToUSDConversionRate = 1.18; //example of conversion rate

    public EURToUSDAdapter(USDPaymentSystem usdPaymentSystem)
    {
        this.usdPaymentSystem = usdPaymentSystem;

    }
    public void ProcessPayment(double amountEUR)
    {
        //Convert EUR to USD using the converison rate
        double amountUSD = amountEUR * EURToUSDConversionRate;
        usdPaymentSystem.ProcessPayment(amountUSD);
    }
}