using System.Reflection.Metadata;

namespace CSharpExercise.Services;

public static class Game
{


    public static void Run()
    {
        bool flag = true;
        List<String> history = new List<string>();
        while (flag == true)
        {
            Console.WriteLine("Welcome to the Math Game! Please continue by choosing an option below:");
            Console.WriteLine("1. Play\n2. History\n3. Quit\n");
            var answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Play();
            }
            else if (answer == 2)
            {
                Console.WriteLine("Your history for this session:");
                foreach(string entry in history)
                {
                    Console.WriteLine(entry);
                }
                break;
            }
            else
            {
                break;
            }
        }
    }
    
    public static void Play()
    {
        
    }


}