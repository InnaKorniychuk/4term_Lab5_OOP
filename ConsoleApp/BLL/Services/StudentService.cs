using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class StudentService 
    {

        EntityService<Student> studentService = new EntityService<Student>
            (Configuration.configurationService.dataProvider.readWriteStudent);

        public void Add(string firstName, string lastName, double height, double weight, string passport,
            string id, int course, int behavior)
        {
            Student student = new Student(firstName, lastName, height, weight, passport, id, course,
                studentService.SetSpecialBehavior(behavior));
            studentService.Add(student);
        }

        public void Remove(string firstName, string lastName)
        {
            Student student = new Student(firstName, lastName, 0, 0, "", "", 0, null);
            studentService.Remove(student);
        }

        public Student Search(string firstName, string lastName)
        {
            return studentService.Search(new Student(firstName, lastName, 0, 0, "", "", 0, null));
        }

        public string Show()
        {
            return studentService.Show();
        }

        public string SearchTask()
        {
            StringBuilder taskData = new StringBuilder();
            List<Student> data = Configuration.configurationService.dataProvider.readWriteStudent.ReadData();
            
            foreach (var item in data)
            {
                if (item.CheckWeight() == true)
                    taskData.Append(item.ToString());
            }
            return taskData.ToString();
        }
    }
}
