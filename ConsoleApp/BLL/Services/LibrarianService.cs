namespace BLL
{
    public class LibrarianService
    {

        EntityService<Librarian> librarianService = new EntityService<Librarian>
            (Configuration.configurationService.dataProvider.readWriteLibrarian);

        public void Add(string firstName, string lastName, double height, double weight, string passport,
            double sallary, int readBooks, int behavior)
        {
            Librarian librarian = new Librarian(firstName, lastName, height, weight, passport, sallary, readBooks,
                librarianService.SetSpecialBehavior(behavior));
            librarianService.Add(librarian);
        }

        public void Remove(string firstName, string lastName)
        {
            Librarian librarian = new Librarian(firstName, lastName, 0, 0, "", 0, 0, null);
            librarianService.Remove(librarian);
        }

        public Librarian Search(string firstName, string lastName)
        {
            return librarianService.Search(new Librarian(firstName, lastName, 0, 0, "", 0, 0, null));
        }

        public string Show()
        {
            return librarianService.Show();
        }
    }
}
