namespace AbstractFactory
{
    class AmericaFactory : ContinentFactory
    {
        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
