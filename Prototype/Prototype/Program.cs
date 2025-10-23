namespace Prototype
{
    internal class Program
    {
        static void TestICloneable(ICloneable obj)
        {
            var clone = obj.Clone();
            Console.WriteLine("Original: " + obj);
            Console.WriteLine("Clone: " + clone);
            Console.WriteLine("Same reference? " + (ReferenceEquals(obj, clone) ? "Yes" : "No"));
            Console.WriteLine();
        }
        static void PrintAnimalInfo(Animal animal)
        {
            Console.WriteLine(animal.ToString());
        }
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog(1, "Snoopy", 5, 38.6, "Golden Retriever");
            //Console.WriteLine("Original Dog: " + dog1);

            //// через базовый метод
            //Animal clonedAnimal1 = dog1.MyClone();
            //Console.WriteLine("Cloned Animal: " + clonedAnimal1);

            ////через интерфейс с конкретным типом
            //IMyCloneable<Dog> dogCloneInterface = dog1;
            //Dog clonedDog1 = dogCloneInterface.MyClone();
            //Console.WriteLine("Cloned Dog via interface: " + clonedDog1);

            
            //clonedDog1.Name = "Max";
            //clonedDog1.Breed = "Labrador";

            //Console.WriteLine("Modified Cloned Dog: " + clonedDog1);
            //Console.WriteLine("Original Dog after clone modification: " + dog1);


            Animal animal = new Animal(1, "Generic Animal", 3);
            Mammal mammal = new Mammal(2, "MammalName", 5, 37.5);
            Fish fish = new Fish(3, "Goldfish", 1, WaterType.Fresh);
            Dog dog = new Dog(4, "Buddy", 4, 38.6, "Golden Retriever");

            Console.WriteLine("== Originals ==");
            Console.WriteLine(animal);
            Console.WriteLine(mammal);
            Console.WriteLine(fish);
            Console.WriteLine(dog);

            
            Animal clonedAnimal = animal.MyClone();
            Animal clonedMammalAsAnimal = mammal.MyClone();
            Animal clonedFishAsAnimal = fish.MyClone();
            Animal clonedDogAsAnimal = dog.MyClone();

            Console.WriteLine("\n== Cloned via Animal base method ==");
            Console.WriteLine(clonedAnimal);
            Console.WriteLine(clonedMammalAsAnimal);
            Console.WriteLine(clonedFishAsAnimal);
            Console.WriteLine(clonedDogAsAnimal);

            //
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

            //
            clonedDog.Name = "Max";
            clonedDog.Breed = "Labrador";
            clonedDog.BodyTemperature = 39.0;

            Console.WriteLine("\n== After modifying cloned dog ==");
            Console.WriteLine("ClonedDog: " + clonedDog);
            Console.WriteLine("Original Dog: " + dog);

            


            Dog dog2 = new Dog(1, "Buddy", 4, 38.6, "Golden Retriever");
            Mammal mammal2 = new Mammal(2, "horton", 10, 36.5);
            Fish fish2 = new Fish(3, "nemo", 1, WaterType.Salt);

            Console.WriteLine("test ICloneable :\n");

            TestICloneable((ICloneable)dog);
            TestICloneable((ICloneable)mammal);
            TestICloneable((ICloneable)fish);


            PrintAnimalInfo(animal);
            PrintAnimalInfo(dog);


        }
    }
}
