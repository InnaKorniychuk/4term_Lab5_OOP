using BLL;

namespace PL
{
    public class LibrarianFunctions : IFunctions
    {
        LibrarianService librarianService = new LibrarianService();
        InputService inputService = new InputService();

        public void Add()
        {
            librarianService.Add(inputService.InputFirstName(), inputService.InputLastName(), double.Parse(inputService.InputHeight()),
                double.Parse(inputService.InputWeight()), inputService.InputPassport(), double.Parse(inputService.InputSallary()),
                int.Parse(inputService.InputReadBooks()), inputService.InputBehavior());
        }

        public void Remove()
        {
            librarianService.Remove(inputService.InputFirstName(), inputService.InputLastName());
        }

        public string Search()
        {
            return librarianService.Search(inputService.InputFirstName(), inputService.InputLastName()).ToString();
        }

        public string Show()
        {
            return librarianService.Show();
        }

        public string SearchTask()
        {
            return "";
        }
    }
}
