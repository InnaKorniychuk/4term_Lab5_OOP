using System;

namespace BLL
{
    [Serializable]
    public class Student : Person
    {
        public string StudentID { get; set; }
        public int Course { get; set; }

        public Student() { }
        public Student(string firstName, string lastName, double height, double weight, string passport, 
            string id, int course, ISpecialBehavior behave) : base(firstName, lastName, height, weight, passport, behave)
        { StudentID = id; Course = course; }
        public override string ToString()
        {
            return $"Student {FirstName}{LastName}\n" +
                $"firstName: {FirstName}\n" +
                $"lastName: {LastName}\n" +
                $"height: {Height}\n" +
                $"weight: {Weight}\n" +
                $"passport: {Passport}\n" +
                $"studentID: {StudentID}\n" +
                $"course: {Course}\n" +
                $"idealWeight: {CheckWeight()}\n";
        }
        public bool CheckWeight() => Height - 110 == Weight;

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   FirstName == student.FirstName &&
                   LastName == student.LastName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
