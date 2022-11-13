namespace BLL
{
    public interface ISpecialBehavior
    {
        void Do();
    }
    
    public class Cycle : ISpecialBehavior
    {
        public void Do() { }
    }
    public class Study : ISpecialBehavior
    {
        public void Do() { }
    }
    public class FindBook : ISpecialBehavior
    {
        public void Do() { }
    }
    public class DancingWithTambourine : ISpecialBehavior
    {
        public void Do() { }
    }
    public class Crying : ISpecialBehavior
    {
        public void Do() { }
    }
}
