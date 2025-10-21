using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Person person = new Person()
            {
                Name = "Peter",
                Age = 20
            };

            Person person1 = new Person();
            person1.Name = "George";
            person1.Age = 18;

            Person person2 = new Person("Jose", 43);

        }
    }
}
