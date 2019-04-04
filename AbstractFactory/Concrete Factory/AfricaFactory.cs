namespace AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public Herbivore CreateHerbivore()
        {
            return new WildBeast();
        }
        public Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
