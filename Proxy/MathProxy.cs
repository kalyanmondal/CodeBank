namespace Proxy
{
    class MathProxy : IMath
    {
        private string accessLevel { get; set; }

        public MathProxy()
        {
            this.accessLevel = "Not Full";
        }

        public MathProxy(string accessLevel)
        {
            this.accessLevel = accessLevel;
        }

        Math math = new Math();

        public string Add(double a, double b, out double c)
        {
            c = new double();
            if (this.accessLevel.Equals("Full", System.StringComparison.OrdinalIgnoreCase))
            {
                return math.Add(a, b, out c);
            }
            else
            {
                return "You dont have access!";
            }
        }

        public string Div(double a, double b, out double c)
        {
            c = new double();
            if (this.accessLevel.Equals("Full", System.StringComparison.OrdinalIgnoreCase))
            {
                return math.Div(a, b, out c);
            }
            else
            {
                return "You dont have access!";
            }
        }

        public string Mul(double a, double b, out double c)
        {
            c = new double();
            if (this.accessLevel.Equals("Full", System.StringComparison.OrdinalIgnoreCase))
            {
                return math.Mul(a, b, out c);
            }
            else
            {
                return "You dont have access!";
            }
        }

        public string Sub(double a, double b, out double c)
        {
            c = new double();
            if (this.accessLevel.Equals("Full", System.StringComparison.OrdinalIgnoreCase))
            {
                return math.Sub(a, b, out c);
            }
            else
            {
                return "You dont have access!";
            }
        }
    }
}
