namespace AbstractFactory
{
    interface ContinentFactory
    {
        Herbivore CreateHerbivore();

        Carnivore CreateCarnivore();
    }
}
