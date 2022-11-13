using System;

namespace BLL
{
    [Serializable]
    public abstract class Worker : Person
    {
        public double Sallary { get; set; }

        public Worker() { }
        public Worker(string firstName, string lastName, double height, double weight, string passport,
            double sallary, ISpecialBehavior behave) : base(firstName, lastName, height, weight, passport, behave)
        { Sallary = sallary; }
    }
}
