using System;

namespace PL
{
    public class FunctionService
    {
        public void ChooseFunction(IFunctions function, string command)
        {
            switch (command)
            {
                case "1":
                    function.Add();
                    break;
                case "2":
                    function.Remove();
                    break;
                case "3":
                    Console.WriteLine(function.Search());
                    break;
                case "4":
                    Console.WriteLine(function.Show());
                    break;
                case "5":
                    Console.WriteLine(function.SearchTask());
                    break;
            }
        }
    }
}
