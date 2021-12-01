// See https://aka.ms/new-console-template for more information
using InterfaceSegregation_slut;



List<IAnimal> animals = new List<IAnimal>
{
    new Cat("Carina"),
    new Dog("Dan"),
    new Tortoise("Tim"),
    new JellyFish("Jonas"),
};


foreach (IAnimal animal in animals)
{
    Console.WriteLine($"The animal is called {animal.Name}"); 
}



List<ISwimmableAnimal> swimmableAnimals = new List<ISwimmableAnimal>() {
    new Cat("Carina"),
    new Dog("Dan"),
    new JellyFish("Jonas"),
};

foreach (ISwimmableAnimal animal in swimmableAnimals)
{
    animal.Swim();
}




public class MakeSwimmableAnimalsSwim<T> where T : ISwimmableAnimal
{
    public void Swim(List<T> ts)
    {
        foreach (T t in ts)
        {
            t.Swim();
        }
    }
}