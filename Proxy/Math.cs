namespace Proxy
{
    class Math : IMath
    {
        public string Add(double a, double b, out double c)
        {
            c = a + b;
            return "You have access!";
        }

        public string Div(double a, double b, out double c)
        {
            c = a / b;
            return "You have access!";
        }

        public string Mul(double a, double b, out double c)
        {
            c = a * b;
            return "You have access!";
        }

        public string Sub(double a, double b, out double c)
        {
            c = a - b;
            return "You have access!";
        }
    }
}
