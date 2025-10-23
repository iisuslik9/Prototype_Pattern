namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Buddy", 5, 38.6, "Golden Retriever");
            Console.WriteLine("Original Dog: " + dog1);

            // Клонирование через базовый метод
            Animal clonedAnimal = dog1.MyClone();
            Console.WriteLine("Cloned Animal: " + clonedAnimal);

            // Клонирование через интерфейс с конкретным типом
            IMyCloneable<Dog> dogCloneInterface = dog1;
            Dog clonedDog = dogCloneInterface.MyClone();
            Console.WriteLine("Cloned Dog via interface: " + clonedDog);

            // Изменения в клоне не влияют на оригинал
            clonedDog.Name = "Max";
            clonedDog.Breed = "Labrador";

            Console.WriteLine("Modified Cloned Dog: " + clonedDog);
            Console.WriteLine("Original Dog after clone modification: " + dog1);
        }
    }
}
