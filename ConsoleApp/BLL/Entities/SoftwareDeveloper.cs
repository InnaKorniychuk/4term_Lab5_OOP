using System;

namespace BLL
{
    [Serializable]
    public class SoftwareDeveloper : Worker
    {
        public int DrunkCoffee { get; set; }
        public int CodeLines { get; set; }
        public SoftwareDeveloper(string firstName, string lastName, double height, double weight, string passport,
            double sallary, int drunkCoffee, int codeLines, ISpecialBehavior behave) :
            base(firstName, lastName, height, weight, passport, sallary, behave)
        { DrunkCoffee = drunkCoffee; CodeLines = codeLines; }
        public override string ToString()
        {
            return $"Developer {FirstName}{LastName}\n" +
                $"firstName: {FirstName}\n" +
                $"lastName: {LastName}\n" +
                $"height: {Height}\n" +
                $"weight: {Weight}\n" +
                $"passport: {Passport}\n" +
                $"sallary: {Sallary}\n" +
                $"drunkCoffee: {DrunkCoffee}\n" +
                $"codeLines: {CodeLines}\n";
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
