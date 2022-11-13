using BLL;

namespace PL
{
    public class DeveloperFunctions : IFunctions
    {
        DeveloperService developerService = new DeveloperService();
        InputService inputService = new InputService();

        public void Add()
        {
            developerService.Add(inputService.InputFirstName(), inputService.InputLastName(), double.Parse(inputService.InputHeight()),
                double.Parse(inputService.InputWeight()), inputService.InputPassport(), double.Parse(inputService.InputSallary()),
                int.Parse(inputService.InputDrunkCoffees()), int.Parse(inputService.InputCodeLines()),
                inputService.InputBehavior());
        }

        public void Remove()
        {
            developerService.Remove(inputService.InputFirstName(), inputService.InputLastName());
        }

        public string Search()
        {
            return developerService.Search(inputService.InputFirstName(), inputService.InputLastName()).ToString();
        }

        public string Show()
        {
            return developerService.Show();
        }

        public string SearchTask()
        {
            return "";
        }
    }
}
