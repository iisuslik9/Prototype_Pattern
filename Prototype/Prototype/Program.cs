namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog(1, "Snoopy", 5, 38.6, "Golden Retriever");
            //Console.WriteLine("Original Dog: " + dog1);

            //// Клонирование через базовый метод
            //Animal clonedAnimal1 = dog1.MyClone();
            //Console.WriteLine("Cloned Animal: " + clonedAnimal1);

            //// Клонирование через интерфейс с конкретным типом
            //IMyCloneable<Dog> dogCloneInterface = dog1;
            //Dog clonedDog1 = dogCloneInterface.MyClone();
            //Console.WriteLine("Cloned Dog via interface: " + clonedDog1);

            //// Изменения в клоне не влияют на оригинал
            //clonedDog1.Name = "Max";
            //clonedDog1.Breed = "Labrador";

            //Console.WriteLine("Modified Cloned Dog: " + clonedDog1);
            //Console.WriteLine("Original Dog after clone modification: " + dog1);


            Animal animal = new Animal(1, "Generic Animal", 3);
            Mammal mammal = new Mammal(2, "MammalName", 5, 37.5);
            Fish fish = new Fish(3, "Goldfish", 1, WaterType.Freshwater);
            Dog dog = new Dog(4, "Buddy", 4, 38.6, "Golden Retriever");

            Console.WriteLine("== Originals ==");
            Console.WriteLine(animal);
            Console.WriteLine(mammal);
            Console.WriteLine(fish);
            Console.WriteLine(dog);

            // 1: Клонирование через базовый класс и виртуальный метод
            Animal clonedAnimal = animal.MyClone();
            Animal clonedMammalAsAnimal = mammal.MyClone();
            Animal clonedFishAsAnimal = fish.MyClone();
            Animal clonedDogAsAnimal = dog.MyClone();

            Console.WriteLine("\n== Cloned via Animal base method ==");
            Console.WriteLine(clonedAnimal);
            Console.WriteLine(clonedMammalAsAnimal);
            Console.WriteLine(clonedFishAsAnimal);
            Console.WriteLine(clonedDogAsAnimal);

            // 2: Типобезопасное клонирование через интерфейс с дженериками
            IMyCloneable<Mammal> mammalCloneable = mammal;
            Mammal clonedMammal = mammalCloneable.MyClone();

            IMyCloneable<Fish> fishCloneable = fish;
            Fish clonedFish = fishCloneable.MyClone();

            IMyCloneable<Dog> dogCloneable = dog;
            Dog clonedDog = dogCloneable.MyClone();

            Console.WriteLine("\n== Cloned via interface MyClone() ==");
            Console.WriteLine(clonedMammal);
            Console.WriteLine(clonedFish);
            Console.WriteLine(clonedDog);

            // 3: Модификация клона, проверка, что оригинал не изменился
            clonedDog.Name = "Max";
            clonedDog.Breed = "Labrador";
            clonedDog.BodyTemperature = 39.0;

            Console.WriteLine("\n== After modifying cloned dog ==");
            Console.WriteLine("ClonedDog: " + clonedDog);
            Console.WriteLine("Original Dog: " + dog);

            //  4: Клонирование объектов, работающих в коллекциях базового типа
            Animal[] animalArray = { animal, mammal, fish, dog };
            Animal[] clonedArray = new Animal[animalArray.Length];
            for (int i = 0; i < animalArray.Length; i++)
            {
                clonedArray[i] = animalArray[i].MyClone();
            }

            Console.WriteLine("\n== Cloned array of animals ==");
            foreach (var a in clonedArray)
            {
                Console.WriteLine(a);
            }
        }
    }
}
