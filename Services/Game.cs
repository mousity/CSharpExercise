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
        Random seed = new Random();
        int operation = seed.Next(1, 5);
        int num1 = 0;
        int num2 = 0;
        int answer = 0;

        if(operation == 1)
        {
            num1 = seed.Next(1, 100);
            num2 = seed.Next(1, 100);
            answer = num1 + num2;
            Console.WriteLine("Add: " + num1 + " + " + num2);
            int temp = int.Parse(Console.ReadLine());
            if (temp == answer)
            {
                Console.WriteLine("Correct!");
            }
        }
    }


}