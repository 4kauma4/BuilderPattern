namespace BuilderPattren
{
    public class Program
    {
        public static void Main()
        {
            Dog dog = new Dog.DogBuilder()
                .SetName("Вулкан")
                .SetBreed("Дворняжка")
                .SetAge(5)
                .AddToy("Косточка")
                .AddToy("Мячик")
                .Build();

            Console.WriteLine("Коичка: " + dog.GetName());
            Console.WriteLine("Попода: " + dog.GetBreed());
            Console.WriteLine("Возраст: " + dog.GetAge());
            Console.WriteLine("Игрушки: " + string.Join(", ", dog.GetToys()));
        }
    }
}
