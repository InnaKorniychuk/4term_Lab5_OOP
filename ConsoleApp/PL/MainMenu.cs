using System;
using BLL;

namespace PL
{
    public class MainMenu
    {
        string[] commands = { "Choose an occupation:\n1 - Student\n2 - Software Developer\n3 - Librarian",
            "Choose an action:\n1 - Add\n2 - Remove\n3 - Search\n4 - Show",
            "Choose an action:\n1 - Add\n2 - Remove\n3 - Search\n4 - Show\n5 - Show task"};
        
        public void Start()
        {
            InputService inputService = new InputService();
            FunctionService functionService = new FunctionService();

            Configuration.configurationService.SetConfiguraion(int.Parse(inputService.InputProviderType()));

            while (true)
            {
                Console.WriteLine(commands[0]);
                string command = Console.ReadLine();
                
                switch(command)
                {
                    case "1":
                        functionService.ChooseFunction(new StudentFunctions(), inputService.InputCommandType(commands[2]));
                        break;
                    case "2":
                        functionService.ChooseFunction(new LibrarianFunctions(), inputService.InputCommandType(commands[1]));
                        break;
                    case "3":
                        functionService.ChooseFunction(new DeveloperFunctions(), inputService.InputCommandType(commands[1]));
                        break;
                }
            }
        }
    }
}
