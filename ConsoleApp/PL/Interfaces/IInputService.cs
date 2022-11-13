namespace PL
{
    public interface IInputService
    {
        string Input(string inputCommand, string format);
        string InputFirstName();
        string InputLastName();
        string InputHeight();
        string InputWeight();
        string InputPassport();
        string InputStudentID();
        string InputStudentCourse();
        string InputSallary();
        string InputReadBooks();
        string InputCodeLines();
        string InputDrunkCoffees();
        int InputBehavior();
        string InputCommandType(string inputCommand);
    }
}
