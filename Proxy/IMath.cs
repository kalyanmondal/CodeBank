namespace Proxy
{
    interface IMath
    {
        string Add(double a, double b, out double c);

        string Sub(double a, double b, out double c);

        string Mul(double a, double b, out double c);

        string Div(double a, double b, out double c);
    }
}
