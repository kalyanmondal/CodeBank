namespace AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore herbiore;
        private Carnivore carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            herbiore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbiore);
        }
    }
}
