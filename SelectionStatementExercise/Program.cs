namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int favnum = 100;
                Console.WriteLine("try to guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your favorite school subject");
            var favsubject = (Console.ReadLine());
                if (userinput < favnum)
            {
                Console.WriteLine("too low");

            }
                 else if (userinput > favnum)
            {
                Console.WriteLine("too high");
            }
                  else
            {
                Console.WriteLine("nevermind");
            
            
            }
            switch (favsubject)
            {
                case "science":
                    Console.WriteLine($"{favsubject} my favorite subject"); break;

                case "math":
                    Console.WriteLine($"{favsubject} not my favorite subject"); break;
                case "history":
                    Console.WriteLine($"{favsubject}boring subject"); break;
                case "P.E":
                    Console.WriteLine($"{favsubject} my second favorite subject"); break;
                case "theatre":
                    Console.WriteLine($"{favsubject}my third favorite subject"); break;
                default:
                    Console.WriteLine($"{favsubject} good decsion"); break;
            
            }
        }
        
        
    }
}
