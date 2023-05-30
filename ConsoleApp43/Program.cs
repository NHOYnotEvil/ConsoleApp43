namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 5;
            string commandCloseProgram = "exit";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Команда для зыкрытия программы - \"" + commandCloseProgram + "\"");
                Console.Write("Введите команду для закрытия программы:");
                userInput = Console.ReadLine();

                if (commandCloseProgram == userInput)
                {
                    break;
                }
                else if (commandCloseProgram != userInput)
                {
                    tryCount++;
                    Console.WriteLine("Попробуйте снова");
                }
            }
        }
    }
}