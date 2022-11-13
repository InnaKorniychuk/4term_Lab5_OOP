using System;
using BLL;

namespace PL
{
    public class InputService : IInputService
    {
        public string[] inputCommands =  { "Input first name", "Input last name", "Input the height", "Input the weight",
        "Input the passport number (9 digits)", "Input the student ID (2 big letters & 8 digits)", "Input student course (1-6)",
        "Input sallary (100-10000)", "Input read books (10+)", "Input code lines (10+)", "Input drunk coffees (10+)",
        "Input behavior:\n 1 - Cycling\n 2 - Study\n 3 - Find book\n 4 - Crying\n 5 - Dancing with tambourine", 
            "Value is incorrect, please try again", "Input data provider type:\n1 - Binary\n2 - JSON"};

        public string[] inputFormats =  { @"[A-Z]{1}[a-z]+$", @"[1-9]\d{1,2}", @"[1-9]\d{1,2}", @"\d{9}", @"[A-Z]{2}\d{8}",
        @"[1-6]{1}",  @"[1-9]\d{1,4}", @"[1-9]\d+", @"[1-5]{1}", @"[1-5]{1}$", @"[1-2]{1}$"};

        public string Input(string inputCommand, string format)
        {
            Console.WriteLine(inputCommand);
            string data = Console.ReadLine();
            RegexService regexCheck = new RegexService(format);
            while (!regexCheck.Check(data))
            {
                Console.WriteLine(inputCommands[12]);
                data = Console.ReadLine();
            }
            return data;
        }

        public string InputFirstName() => Input(inputCommands[0], inputFormats[0]);
        public string InputLastName() => Input(inputCommands[1], inputFormats[0]);
        public string InputHeight() => Input(inputCommands[2], inputFormats[1]);
        public string InputWeight() => Input(inputCommands[3], inputFormats[2]);
        public string InputPassport() => Input(inputCommands[4], inputFormats[3]);
        public string InputStudentID() => Input(inputCommands[5], inputFormats[4]);
        public string InputStudentCourse() => Input(inputCommands[6], inputFormats[5]);
        public string InputSallary() => Input(inputCommands[7], inputFormats[6]);
        public string InputReadBooks() => Input(inputCommands[8], inputFormats[7]);
        public string InputCodeLines() => Input(inputCommands[9], inputFormats[7]);
        public string InputDrunkCoffees() => Input(inputCommands[10], inputFormats[7]);
        public int InputBehavior() => int.Parse(Input(inputCommands[11], inputFormats[8]));
        public string InputCommandType(string inputCommand) => Input(inputCommand, inputFormats[9]);
        public string InputProviderType() => Input(inputCommands[13], inputFormats[10]);
    }
}
