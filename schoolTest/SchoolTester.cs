using SchoolClassLibrary;

namespace schoolTest
{
    public class SchoolTester
    {
        private Student _student;
        private Teacher _teacher;

        public SchoolTester()
        {
            _student = new Student("ali", "veli", 1);
            _teacher = new Teacher("lale", "yagmur", 1);
        }

        [Fact]
        public void StudentReferenceTest()
        {
            // 3A: Arrange - Act - Assert
            // Arrange - Act
            Student student2 = _student;
            student2.FirstName = "okan";
            student2.LastName = "tepe";
            student2.StudentId = 2;

            // Assert
            Assert.Equal("okan", _student.FirstName);
            Assert.Equal("tepe", _student.LastName);
            Assert.Equal("okan tepe", _student.FullName);
            Assert.Equal(2, _student.StudentId);

            Assert.Equal("okan", student2.FirstName);
            Assert.Equal("tepe", student2.LastName);
            Assert.Equal("okan tepe", student2.FullName);
            Assert.Equal(2, student2.StudentId);
        }

        [Fact]
        public void TeacherDataTest()
        {
            // 3A: Arrange - Act - Assert
            // Arrange - Act
            Teacher teacher2 = _teacher;
            teacher2.FirstName = "okan";
            teacher2.LastName = "tepe";
            teacher2.TeacherId = 2;

            // Assert
            Assert.Equal("lale", _teacher.FirstName);
            Assert.Equal("yagmur", _teacher.LastName);
            Assert.Equal("lale yagmur", _teacher.FullName);
            Assert.Equal(1, _teacher.TeacherId);

            Assert.Equal("okan", teacher2.FirstName);
            Assert.Equal("tepe", teacher2.LastName);
            Assert.Equal("okan tepe", teacher2.FullName);
            Assert.Equal(2, teacher2.TeacherId);
        }
    }
}