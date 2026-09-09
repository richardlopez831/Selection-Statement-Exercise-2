namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I was always good with numbers");
                    break;
                case "science":
                    Console.WriteLine("I always like to learn science from Bill Nye");
                    break;
                case "english":
                    Console.WriteLine("I never enjoyed english class");
                    break;
                case "history":
                    Console.WriteLine("I never could remember dates of historic events");
                    break;
                case "pe":
                case "physical education":
                case "p.e.":
                    Console.WriteLine("This was by far my favorite class");
                    break;
                case "wood shop":
                case "shop class":
                    Console.WriteLine("Those power tools can be dangerous");
                    break;
                case "physics":
                    Console.WriteLine("I never took physics but it always intrigued me");
                    break;
                case "art":
                case "ceramics":
                case "art class":
                case "pottery":
                    Console.WriteLine("Being able to creat something with your hands is amazing. I love the arts");
                    break;
                case "astrology":
                    Console.WriteLine("I love astrology. Learning about the stars and planets is so much fun");
                    break;
                default:
                    Console.WriteLine("How cool. Tell me more about that");
                    break;
                    
            }
        }
    }
}