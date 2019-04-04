using System;

namespace AbstractFactory
{
    class Wolf : Carnivore
    {
        public void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
