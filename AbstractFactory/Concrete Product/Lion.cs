using System;

namespace AbstractFactory
{
    class Lion : Carnivore
    {
        public void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
