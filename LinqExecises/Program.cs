namespace LinqExecises
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Dog", "Bosse", 3, 4, true);
            Animal animal2 = new Animal("Cat", "Stina", 6, 4, false);
            Animal animal3 = new Animal("Dog", "Håkan", 9, 3, true);
            Animal animal4 = new Animal("Snake", "Fredrik", 2, 0, true);
            Animal animal5 = new Animal("Sheep", "Lucy", 5, 4, false);
            Animal animal6 = new Animal("Raindeer", "Rudolf", 22, 4, false);
            Animal animal7 = new Animal("Dog", "Skurt", 7, 4, true);
            Animal animal8 = new Animal("Cat", "Fia", 9, 4, true);
            Animal animal9 = new Animal("Lizard", "Doris", 3, 4, false);
            Animal animal10 = new Animal("Dog", "Göran", 1, 4, true);
            Animal animal11 = new Animal("Cow", "Shadow", 10, 4, true);

            List<Animal> listOfAnimals = new List<Animal>() 
            { 
                animal1, 
                animal2, 
                animal3,
                animal4,
                animal5,
                animal6,
                animal7,
                animal8,
                animal9,
                animal10,
                animal11
            };

            Console.WriteLine("A:");
            int numberOfDogs = listOfAnimals
                .Count(a => a.SortOfAnimal == "Dog");
            Console.WriteLine($"Antal hundar är {numberOfDogs}\n");

            Console.WriteLine("B:");
            Animal oldestAnimal = listOfAnimals
                .OrderByDescending(a => a.Age)
                .First();
            Console.WriteLine($"Det äldsta djuret är en {oldestAnimal.SortOfAnimal}, {oldestAnimal.Name}, {oldestAnimal.Age} år gammal.\n");

            Console.WriteLine("C:");
            List<Animal> vaccinatedAnimals = listOfAnimals
                .Where(a => a.IsVaccinated)
                .ToList();

            Console.WriteLine("Vaccinerade djur:");
            foreach (var animal in vaccinatedAnimals)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

            Console.WriteLine("D:");
            List<Animal> fourLeggedOlderThanThree = listOfAnimals
                .Where(a => a.NumberOfLegs == 4 && a.Age > 3)
                .ToList();

            Console.WriteLine("Djur med 4 ben och äldre än 3 år:");
            foreach (var animal in fourLeggedOlderThanThree)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

            Console.WriteLine("E:");
            bool hasShadow = listOfAnimals
                .Any(a => a.Name == "Shadow");

            if (hasShadow)
            {
                Console.WriteLine("Det finns minst ett djur som heter Shadow.\n");
            }
            else
            {
                Console.WriteLine("Det finns inget djur som heter Shadow.\n");
            }
        }
    }
    public class Animal
    {
        public string SortOfAnimal { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public byte NumberOfLegs { get; set; }
        public bool IsVaccinated { get; set; }

        public Animal(string sortOfAnimal, string name, byte age, byte numberOfLegs, bool isVaccinated)
        {
            SortOfAnimal = sortOfAnimal;
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            IsVaccinated = isVaccinated;
        }
    }

}
