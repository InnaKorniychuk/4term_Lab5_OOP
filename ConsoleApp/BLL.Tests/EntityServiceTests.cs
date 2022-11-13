using Moq;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BLL.Tests
{
    public class EntityServiceTests
    {
        [Fact]
        public void Add_Success()
        {
            // Arrange
            var student = new Student("Tom", "Ford", 175, 65, "000000001", "KB11111111", 2, new Crying());
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.WriteData(student)).Verifiable();
            var service = new EntityService<Student>(mock.Object);
            // Act
            service.Add(student);
            // Assert
            mock.Verify(x => x.WriteData(student), Times.Once);
        }

        [Fact]
        public void Remove_Success()
        {
            // Arrange
            var student = new Student("Tom", "Ford", 175, 65, "000000001", "KB11111111", 2, new Crying());
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.ReadData()).Returns(GetTestStudents());
            
            var service = new EntityService<Student>(mock.Object);
            // Act
            service.Remove(student);
            // Assert
            Assert.NotEqual(GetTestStudentsString(), service.Show());
        }

        [Fact]
        public void Search_Success()
        {
            // Arrange
            var student = new Student("Tom", "Ford", 175, 65, "000000001", "KB11111111", 2, new Crying());
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.ReadData()).Returns(GetTestStudents());
            var service = new EntityService<Student>(mock.Object);
            // Act
            var result = service.Search(student);
            // Assert
            Assert.IsType<Student>(result);
            Assert.Equal(student, result);
        }

        [Fact]
        public void Show_Success()
        {
            // Arrange
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.ReadData()).Returns(GetTestStudents());
            var service = new EntityService<Student>(mock.Object);
            // Act
            var result = service.Show();
            // Assert
            Assert.IsType<string>(result);
        }

        private List<Student> GetTestStudents()
        {
            var students = new List<Student>
            {
                new Student("Tom", "Ford", 175, 65, "000000001", "KB11111111", 2, new Crying()),
                new Student("Lina", "Kostenko", 165, 55, "000000002", "KB11111110", 1, new Cycle())
            };

            return students;
        }

        private string GetTestStudentsString()
        {
            StringBuilder data = new StringBuilder();
            foreach (var item in GetTestStudents())
                data.Append(item.ToString());
            return data.ToString();
        }
    }
}
