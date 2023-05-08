namespace TaskRefOut01._05._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 18;
            person.Name = "Hikmet";
            Modify(ref person);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

        static void Modify(ref Person person)
        {
            person.Age += 1;
            person.Name = "HikmetBabayev";
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}