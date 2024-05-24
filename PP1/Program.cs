namespace PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
        var person1 = new
            {
                name = "Audun",
                age = 24,
                hobby1 = "biathlon",
                hobby2 = "Hunting"
            };

            var person2 = new
            {
                name = "Martin",
                age = 27,
                hair = "curly",
                hobby1 = "animation",
                hobby2 = "narratives"
            };


            Console.WriteLine($" Hello, My name is {person1.name}, I am {person1.age} years old \n I am now very interested in {person1.hobby1}, and in fall I like to go {person1.hobby2} \n");



            Console.WriteLine($" Hi, my name is {person2.name}! I'm {person2.age} years old. \n My hair is {person2.hair}. I'm in love with {person2.hobby1} and {person2.hobby2} are my passion.");
        }
    }
}
