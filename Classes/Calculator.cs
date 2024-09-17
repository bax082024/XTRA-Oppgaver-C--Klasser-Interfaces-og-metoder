public class Calculator : iCalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if(b == 0)
        {
            Console.WriteLine("Invalid Number");
            return 0;
        }
        return a / b;
    }
}