
using ITHS_CC_Lektion6;

List<Animal> animals = new List<Animal>
{
    new Animal("Anna"),
    new Cat("Carina"),
    new Dog("Dan")
};


foreach(Animal animal in animals)
{
    animal.Speak();
}