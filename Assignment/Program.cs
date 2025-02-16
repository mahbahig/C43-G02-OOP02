namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[3];
            emps[0] = new Employee(1, "Mahmoud", 25.3f, "28/8/2008", 'M', SecurityLevel.Secretary);
            emps[0] = new Employee(1, "Ahmed", 56.2f, "14/5/2010", 'M', SecurityLevel.Secretary);
            emps[0] = new Employee(1, "Bahig", 48.5f, "3/2/2005", 'M', SecurityLevel.Secretary);

        }
    }
}
