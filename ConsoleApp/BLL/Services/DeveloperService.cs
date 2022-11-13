namespace BLL
{
    public class DeveloperService
    {

        EntityService<SoftwareDeveloper> developerService = new EntityService<SoftwareDeveloper>
            (Configuration.configurationService.dataProvider.readWriteDeveloper);

        public void Add(string firstName, string lastName, double height, double weight,
            string passport, double sallary, int drunkCoffee, int codeLines, int behavior)
        {
            SoftwareDeveloper developer = new SoftwareDeveloper(firstName, lastName, height, weight, passport, sallary, drunkCoffee,
                codeLines, developerService.SetSpecialBehavior(behavior));
            developerService.Add(developer);
        }

        public void Remove(string firstName, string lastName)
        {
            SoftwareDeveloper developer = new SoftwareDeveloper(firstName, lastName, 0, 0, "", 0, 0, 0, null);
            developerService.Remove(developer);
        }

        public SoftwareDeveloper Search(string firstName, string lastName)
        {
            return developerService.Search(new SoftwareDeveloper(firstName, lastName, 0, 0, "", 0, 0, 0, null));
        }

        public string Show()
        {
            return developerService.Show();
        }
    }
}
