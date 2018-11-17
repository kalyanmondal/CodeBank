using Newtonsoft.Json;

namespace CodeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee()
            {
                FirstName = "FN",
                LastName = "LN",
                Gender = "M",
                Salary = 10000,
                Id = 1
            };

            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
            };

            string a = JsonConvert.SerializeObject(e, settings);
            string b = JsonConvert.SerializeObject(e);
        }
    }
}
