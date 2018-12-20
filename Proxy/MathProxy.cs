namespace Proxy
{
    class MathProxy : IMath
    {
        Math math = new Math();

        public double Add(double a, double b)
        {
            return math.Add(a, b);
        }

        public double Div(double a, double b)
        {
            return math.Div(a, b);
        }

        public double Mul(double a, double b)
        {
            return math.Mul(a, b);
        }

        public double Sub(double a, double b)
        {
            return math.Sub(a, b);
        }
    }
}
