using System;

namespace BLL
{
    [Serializable]
    public class Librarian : Worker
    {
        public int ReadBooks { get; set; }

        public Librarian() { }
        public Librarian(string firstName, string lastName, double height, double weight, string passport,
            double sallary, int readBooks, ISpecialBehavior behave) :
            base(firstName, lastName, height, weight, passport, sallary, behave)
        { ReadBooks = readBooks; }
        public override string ToString()
        {
            return $"Librarian {FirstName}{LastName}\n" +
                $"firstName: {FirstName}\n" +
                $"lastName: {LastName}\n" +
                $"height: {Height}\n" +
                $"weight: {Weight}\n" +
                $"passport: {Passport}\n" +
                $"sallary: {Sallary}\n" +
                $"readBooks: {ReadBooks}\n";
        }

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
