namespace CSharpExercise.Services;

public static class Game
{

    
    public static void Run()
    {
        bool flag = true;
        while (flag == true)
        {
            Console.WriteLine("Welcome to the Math Game! Please continue by choosing an option below:");
            Console.WriteLine("1. Play\n2. History\n3. Quit\n");
            var answer = int.Parse(Console.ReadLine());
            Console.Write(answer.GetType());
            flag = false;
        }

        
        
    }


}