using BLL;

namespace PL
{
    public class StudentFunctions : IFunctions
    {
        StudentService studentService = new StudentService();
        InputService inputService = new InputService();

        public void Add()
        {
            studentService.Add(inputService.InputFirstName(), inputService.InputLastName(), double.Parse(inputService.InputHeight()), 
                double.Parse(inputService.InputWeight()), inputService.InputPassport(), inputService.InputStudentID(),
                int.Parse(inputService.InputStudentCourse()), inputService.InputBehavior());
        }

        public void Remove()
        {
            studentService.Remove(inputService.InputFirstName(), inputService.InputLastName());
        }

        public string Search()
        {
            return studentService.Search(inputService.InputFirstName(), inputService.InputLastName()).ToString();
        }

        public string Show()
        {
            return studentService.Show();
        }

        public string SearchTask()
        {
            return studentService.SearchTask();
        }
    }
}
