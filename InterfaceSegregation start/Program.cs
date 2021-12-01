// See https://aka.ms/new-console-template for more information
using InterfaceSegregation_start;

Console.WriteLine("Hello, World!");



List<IAnimal> animals = new List<IAnimal>
{
    new Cat("Carina"),
    new Dog("Dan"),
    //new Tortoise("Tim"),
    new JellyFish("Jonas"),
};


foreach (IAnimal animal in animals)
{
    animal.Swim();
    animal.Walk();
    animal.Jump();
}