using System.Collections.Generic;
using Xunit;
using Moq;
using DAL;

namespace BLL.Tests
{
    public class ReadWriteServiceTests
    {
        [Fact]
        public void Read_Success()
        {
            // Arrange
            var mock = new Mock<IDataContext<Student>>();
            mock.Setup(x => x.GetData()).Returns(GetTestStudents());
            var service = new ReadWriteService<Student>(null, null);
            service._dataContext = mock.Object;
            // Act
            var result = service.ReadData();
            // Assert
            Assert.IsType<List<Student>>(result);
            Assert.Equal(GetTestStudents(), result);
        }

        [Fact]
        public void Write_Success()
        {
            // Arrange
            var student = new Student("Tom", "Ford", 175, 65, "000000001", "KB11111111", 2, new Crying());
            var mock = new Mock<IDataContext<Student>>();
            mock.Setup(x => x.SetData(student)).Verifiable();
            var service = new ReadWriteService<Student>(null, null);
            service._dataContext = mock.Object;
            // Act
            service.WriteData(student);
            // Assert
            mock.Verify(x => x.SetData(student), Times.Once);
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
    }
}
