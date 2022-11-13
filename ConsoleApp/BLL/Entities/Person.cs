using System;

namespace BLL
{
    [Serializable]
    public abstract class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Passport { get; set; }
        [NonSerialized]
        protected ISpecialBehavior behavior;

        public Person() { }
        public Person(string firstName, string lastName, double height, double weight, string passport, 
            ISpecialBehavior behave)
        { FirstName = firstName; LastName = lastName; Height = height; Weight = weight; Passport = passport; behavior = behave; }
    }
}
